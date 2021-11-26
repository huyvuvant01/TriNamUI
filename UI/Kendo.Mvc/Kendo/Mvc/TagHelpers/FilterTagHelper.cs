// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FilterTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-filter")]
  [RestrictChildren("fields", new string[] {"messages", "operators"})]
  public class FilterTagHelper : TagHelperBase
  {
    public 
    #nullable disable
    string DatasourceId { get; set; }

    public FilterTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      FilterTagHelper filterTagHelper = this;
      context.Items[(object) filterTagHelper.GetType()] = (object) filterTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await filterTagHelper.\u003C\u003En__0(context, output);
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
      if (this.Expression != null)
        dictionary["expression"] = (object) this.Expression.ToJson();
      if (this.DatasourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DatasourceId;
      dictionary["mainLogic"] = (object) this.MainLogic.ToString().ToLowerInvariant();
      return this.Initializer.Initialize(this.Selector, "Filter", (IDictionary<string, object>) dictionary);
    }

    public string OnChange { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      return dictionary;
    }

    public bool? ApplyButton { get; set; }

    public CompositeFilterDescriptor Expression { get; set; }

    public bool? ExpressionPreview { get; set; }

    [HtmlAttributeNotBound]
    public FilterFieldsTagHelper Fields { get; set; }

    public FilterCompositionLogicalOperator MainLogic { get; set; }

    [HtmlAttributeNotBound]
    public FilterMessagesSettingsTagHelper Messages { get; set; }

    [HtmlAttributeNotBound]
    public FilterOperatorsSettingsTagHelper Operators { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.ApplyButton.HasValue)
        dictionary["applyButton"] = (object) this.ApplyButton;
      if (this.ExpressionPreview.HasValue)
        dictionary["expressionPreview"] = (object) this.ExpressionPreview;
      if (this.Fields != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Fields.Select<FilterFieldTagHelper, Dictionary<string, object>>((Func<FilterFieldTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["fields"] = (object) source;
      }
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      if (this.Operators != null)
      {
        Dictionary<string, object> source = this.Operators.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["operators"] = (object) source;
      }
      return dictionary;
    }
  }
}
