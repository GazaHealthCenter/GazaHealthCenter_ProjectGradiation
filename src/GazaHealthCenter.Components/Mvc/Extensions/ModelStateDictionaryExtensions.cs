using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GazaHealthCenter.Components.Mvc;

public static class ModelStateDictionaryExtensions
{
    public static Dictionary<String, String?> Errors(this ModelStateDictionary modelState)
    {
        return modelState
            .Where(state => state.Value!.Errors.Count > 0)
            .ToDictionary(
                pair => pair.Key,
                pair => pair.Value!.Errors
                    .Select(model => model.ErrorMessage)
                    .FirstOrDefault(error => error.Length > 0));
    }
}
