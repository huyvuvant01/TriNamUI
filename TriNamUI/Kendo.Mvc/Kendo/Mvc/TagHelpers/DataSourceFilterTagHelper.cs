// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceFilterTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("datasource-filter", ParentTag = "filters", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("filters", new string[] {})]
  [SuppressTagRendering]
  public class DataSourceFilterTagHelper : TagHelperCollectionItemBase
  {
    public 
    #nullable disable
    string Field { get; set; }

    public string Logic { get; set; }

    public string Operator { get; set; }

    public object Value { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceFiltersTagHelper Filter { get; set; }

    public string OperatorHandler { get; set; }

    private DataSourceFilterTagHelper PreviousInstance { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DataSourceFilterTagHelper sourceFilterTagHelper = this;
      Type type = sourceFilterTagHelper.GetType();
      if (context.Items.ContainsKey((object) type))
        sourceFilterTagHelper.PreviousInstance = context.Items[(object) type] as DataSourceFilterTagHelper;
      context.Items[(object) type] = (object) sourceFilterTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      sourceFilterTagHelper.AddSelfToParent(context);
      context.Items[(object) type] = (object) sourceFilterTagHelper.PreviousInstance;
      type = (Type) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type1 = typeof (DataSourceNestedFiltersTagHelper);
      if (context.Items.ContainsKey((object) type1))
      {
        (context.Items[(object) type1] as DataSourceNestedFiltersTagHelper).Add(this);
      }
      else
      {
        Type type2 = typeof (DataSourceFiltersTagHelper);
        (context.Items[(object) type2] as DataSourceFiltersTagHelper).Add(this);
      }
    }

    internal Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
      string logic = this.Logic;
      if ((logic != null ? (logic.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["logic"] = (object) this.Logic;
      if (this.Value != null)
        dictionary["value"] = this.Value;
      string operatorHandler = this.OperatorHandler;
      if ((operatorHandler != null ? (operatorHandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["operator"] = (object) this.CreateHandler(this.OperatorHandler);
      string str = this.Operator;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["operator"] = (object) this.Operator;
      if (this.Filter != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Filter.Select<DataSourceFilterTagHelper, Dictionary<string, object>>((Func<DataSourceFilterTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["filters"] = (object) source;
      }
      return dictionary;
    }
  }
}
