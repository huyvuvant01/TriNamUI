// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PagerTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-pager")]
  [RestrictChildren("messages", new string[] {})]
  public class PagerTagHelper : TagHelperBase
  {
    public PagerTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PagerTagHelper pagerTagHelper = this;
      context.Items[(object) pagerTagHelper.GetType()] = (object) pagerTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await pagerTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.DatasourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DatasourceId;
      return this.Initializer.Initialize(this.Selector, "Pager", (IDictionary<string, object>) dictionary);
    }

    public string DatasourceId { get; set; }

    public string OnChange { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      return dictionary;
    }

    public string ARIATemplate { get; set; }

    public string ARIATemplateId { get; set; }

    public bool? AutoBind { get; set; }

    public double? ButtonCount { get; set; }

    public string SelectTemplate { get; set; }

    public string SelectTemplateId { get; set; }

    public string LinkTemplate { get; set; }

    public string LinkTemplateId { get; set; }

    public bool? Info { get; set; }

    public bool? Input { get; set; }

    public bool? Numeric { get; set; }

    public bool? PageSizes { get; set; }

    public bool? PreviousNext { get; set; }

    public bool? Refresh { get; set; }

    public bool? Responsive { get; set; }

    [HtmlAttributeNotBound]
    public PagerMessagesSettingsTagHelper Messages { get; set; }

    public bool? Navigatable { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.ARIATemplateId.HasValue())
        dictionary["ARIATemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.ARIATemplateId)
        };
      else if (this.ARIATemplate.HasValue())
        dictionary["ARIATemplate"] = (object) this.ARIATemplate;
      bool? nullable = this.AutoBind;
      if (nullable.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      if (this.ButtonCount.HasValue)
        dictionary["buttonCount"] = (object) this.ButtonCount;
      if (this.SelectTemplateId.HasValue())
        dictionary["selectTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.SelectTemplateId)
        };
      else if (this.SelectTemplate.HasValue())
        dictionary["selectTemplate"] = (object) this.SelectTemplate;
      if (this.LinkTemplateId.HasValue())
        dictionary["linkTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.LinkTemplateId)
        };
      else if (this.LinkTemplate.HasValue())
        dictionary["linkTemplate"] = (object) this.LinkTemplate;
      nullable = this.Info;
      if (nullable.HasValue)
        dictionary["info"] = (object) this.Info;
      nullable = this.Input;
      if (nullable.HasValue)
        dictionary["input"] = (object) this.Input;
      nullable = this.Numeric;
      if (nullable.HasValue)
        dictionary["numeric"] = (object) this.Numeric;
      nullable = this.PageSizes;
      if (nullable.HasValue)
        dictionary["pageSizes"] = (object) this.PageSizes;
      nullable = this.PreviousNext;
      if (nullable.HasValue)
        dictionary["previousNext"] = (object) this.PreviousNext;
      nullable = this.Refresh;
      if (nullable.HasValue)
        dictionary["refresh"] = (object) this.Refresh;
      nullable = this.Responsive;
      if (nullable.HasValue)
        dictionary["responsive"] = (object) this.Responsive;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      nullable = this.Navigatable;
      if (nullable.HasValue)
        dictionary["navigatable"] = (object) this.Navigatable;
      return dictionary;
    }
  }
}
