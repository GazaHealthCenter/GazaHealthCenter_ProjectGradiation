using Microsoft.AspNetCore.Mvc;
using GazaHealthCenter.Components.Lookups;
using GazaHealthCenter.Components.Security;
using GazaHealthCenter.Data;
using GazaHealthCenter.Objects;
using NonFactors.Mvc.Lookup;

namespace GazaHealthCenter.Controllers;

[AllowUnauthorized]
public class Lookup : AController
{
    private IUnitOfWork UnitOfWork { get; }

    public Lookup(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }

    [HttpGet]
    public JsonResult Role(LookupFilter filter)
    {
        return Json(new MvcLookup<Role, RoleView>(UnitOfWork) { Filter = filter }.GetData());
    }

    protected override void Dispose(Boolean disposing)
    {
        UnitOfWork.Dispose();

        base.Dispose(disposing);
    }
}
