using Microsoft.AspNetCore.Mvc.ModelBinding;
using GazaHealthCenter.Components.Notifications;

namespace GazaHealthCenter.Validators;

public interface IValidator : IDisposable
{
    Alerts Alerts { get; set; }
    ModelStateDictionary ModelState { get; set; }
}
