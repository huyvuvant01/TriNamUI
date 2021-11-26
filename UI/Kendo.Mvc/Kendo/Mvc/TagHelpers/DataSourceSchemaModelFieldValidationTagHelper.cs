// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceSchemaModelFieldValidationTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("validation", ParentTag = "field", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class DataSourceSchemaModelFieldValidationTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string Required { get; set; }

    public int? Min { get; set; }

    public int? Max { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DataSourceSchemaModelFieldTaghelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DataSourceSchemaModelFieldTaghelper).Validation = this;
    }

    internal Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string required = this.Required;
      if ((required != null ? (required.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["required"] = (object) this.Required;
      int? nullable = this.Min;
      if (nullable.HasValue)
        dictionary["min"] = (object) this.Min;
      nullable = this.Max;
      if (nullable.HasValue)
        dictionary["max"] = (object) this.Max;
      return dictionary;
    }
  }
}
