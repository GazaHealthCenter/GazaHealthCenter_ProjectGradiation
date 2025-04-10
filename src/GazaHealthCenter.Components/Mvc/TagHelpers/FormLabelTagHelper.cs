using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace GazaHealthCenter.Components.Mvc;

[HtmlTargetElement("label", Attributes = "asp-for")]
public class FormLabelTagHelper : TagHelper
{
    public Boolean? Required { get; set; }

    [HtmlAttributeName("asp-for")]
    public ModelExpression? For { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder require = new("span");
        require.Attributes["class"] = "require";

        if (Required == true)
            require.InnerHtml.Append("*");

        if (Required == null && For?.Metadata.IsRequired == true && For?.Metadata.ModelType != typeof(Boolean))
            require.InnerHtml.Append("*");

        output.Content.AppendHtml(require);
    }
}
