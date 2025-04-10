using Microsoft.AspNetCore.Mvc;
using GazaHealthCenter.Components.Security;
using GazaHealthCenter.Objects;
using GazaHealthCenter.Services;
using GazaHealthCenter.Validators;

namespace GazaHealthCenter.Controllers.Administration;

[Area(nameof(Area.Administration))]
public class Roles : ValidatedController<RoleValidator, RoleService>
{
    public Roles(RoleValidator validator, RoleService service)
        : base(validator, service)
    {
    }

    [HttpGet]
    public ViewResult Index()
    {
        return View(Service.GetViews());
    }

    [HttpGet]
    public ViewResult Create()
    {
        return View(Service.Seed(new RoleView()));
    }

    [HttpPost]
    public ActionResult Create(RoleView role)
    {
        if (!Validator.CanCreate(role))
            return View(Service.Seed(role));

        Service.Create(role);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    [AuthorizeAs(nameof(Index))]
    public ActionResult Details(Int64 id)
    {
        return NotEmptyView(Service.GetView(id));
    }

    [HttpGet]
    public ActionResult Edit(Int64 id)
    {
        return NotEmptyView(Service.GetView(id));
    }

    [HttpPost]
    public ActionResult Edit(RoleView role)
    {
        if (!Validator.CanEdit(role))
            return View(Service.Seed(role));

        Service.Edit(role);

        Authorization.Refresh(HttpContext.RequestServices);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public ActionResult Delete(Int64 id)
    {
        return NotEmptyView(Service.GetView(id));
    }

    [HttpPost]
    [ActionName("Delete")]
    public RedirectToActionResult DeleteConfirmed(Int64 id)
    {
        Service.Delete(id);

        Authorization.Refresh(HttpContext.RequestServices);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    [ActionName("AddPermission")]
    public ActionResult AddPermission()
    {
        return View();
    }

    [HttpPost]
    [ActionName("AddPermission")]
    public ActionResult AddPermission(Permission permission)
    {
        Service.CreateP(permission);
        return RedirectToAction("Index");
    }
}
