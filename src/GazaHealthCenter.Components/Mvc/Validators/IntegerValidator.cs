using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using GazaHealthCenter.Resources;

namespace GazaHealthCenter.Components.Mvc;

public class IntegerValidator : IClientModelValidator
{
    public void AddValidation(ClientModelValidationContext context)
    {
        if (!context.Attributes.ContainsKey("data-val-integer"))
            context.Attributes["data-val-integer"] = Validation.For("Integer", context.ModelMetadata.GetDisplayName());
    }
}
