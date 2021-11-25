// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ValidatorTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("form", Attributes = "kendo-validator")]
  [HtmlTargetElement("div", Attributes = "kendo-validator")]
  public class ValidatorTagHelper : TagHelperBase
  {
    [HtmlAttributeName("kendo-validator")]
    public bool? IsEnabled { get; set; }

    [HtmlAttributeName("kendo-validateOnBlur")]
    public bool? ValidateOnBlur { get; set; }

    [HtmlAttributeName("kendo-errorTemplate")]
    public 
    #nullable disable
    string ErrorTemplate { get; set; }

    [HtmlAttributeName("kendo-messages")]
    public IDictionary<string, string> Messages { get; set; }

    [HtmlAttributeName("kendo-rules")]
    public IDictionary<string, string> Rules { get; set; }

    public ValidatorTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ValidatorTagHelper validatorTagHelper = this;
      if (validatorTagHelper.IsEnabled.HasValue && !validatorTagHelper.IsEnabled.Value)
        return;
      context.Items[(object) validatorTagHelper.GetType()] = (object) validatorTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await validatorTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Validator", (IDictionary<string, object>) this.SerializeSettings());

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.ValidateOnBlur.HasValue)
        dictionary["validateOnBlur"] = (object) this.ValidateOnBlur;
      if (this.ErrorTemplate.HasValue())
        dictionary["errorTemplate"] = (object) this.ErrorTemplate;
      if (this.Messages != null && typeof (IDictionary<string, string>).IsAssignableFrom(this.Messages.GetType()))
        dictionary["messages"] = (object) this.SerializeMessagesSettings();
      if (this.Rules != null && typeof (IDictionary<string, string>).IsAssignableFrom(this.Rules.GetType()))
        dictionary["rules"] = (object) this.ToDictionaryHandler(this.Rules);
      return dictionary;
    }

    protected Dictionary<string, object> SerializeMessagesSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      foreach (string key in (IEnumerable<string>) this.Messages.Keys)
        dictionary[key] = (object) this.Messages[key];
      return dictionary;
    }

    [HtmlAttributeName("on-kendo-validate")]
    public string OnValidate { get; set; }

    [HtmlAttributeName("on-kendo-validateInput")]
    public string OnValidateInput { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onValidate = this.OnValidate;
      if ((onValidate != null ? (onValidate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["validate"] = (object) this.CreateHandler(this.OnValidate);
      string onValidateInput = this.OnValidateInput;
      if ((onValidateInput != null ? (onValidateInput.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["validateInput"] = (object) this.CreateHandler(this.OnValidateInput);
      return dictionary;
    }
  }
}
