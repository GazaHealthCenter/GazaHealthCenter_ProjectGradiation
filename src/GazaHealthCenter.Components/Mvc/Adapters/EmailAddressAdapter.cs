using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using GazaHealthCenter.Resources;

namespace GazaHealthCenter.Components.Mvc;

public class EmailAddressAdapter : AttributeAdapterBase<EmailAddressAttribute>
{
    public EmailAddressAdapter(EmailAddressAttribute attribute)
        : base(attribute, null)
    {
    }

    public override void AddValidation(ClientModelValidationContext context)
    {
        context.Attributes["data-val-email"] = GetErrorMessage(context);
    }
    public override String GetErrorMessage(ModelValidationContextBase validationContext)
    {
        return Validation.For("EmailAddress", validationContext.ModelMetadata.GetDisplayName());
    }
}
