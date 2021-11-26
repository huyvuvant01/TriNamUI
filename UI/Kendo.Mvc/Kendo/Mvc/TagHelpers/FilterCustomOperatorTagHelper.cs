// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FilterCustomOperatorTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("filter-custom-operator", ParentTag = "filter-operators-boolean", TagStructure = TagStructure.WithoutEndTag)]
  [HtmlTargetElement("filter-custom-operator", ParentTag = "filter-operators-date", TagStructure = TagStructure.WithoutEndTag)]
  [HtmlTargetElement("filter-custom-operator", ParentTag = "filter-operators-number", TagStructure = TagStructure.WithoutEndTag)]
  [HtmlTargetElement("filter-custom-operator", ParentTag = "filter-operators-string", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class FilterCustomOperatorTagHelper : TagHelperChildBase
  {
    public string Name { get; set; }

    public string Text { get; set; }

    public string Handler { get; set; }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type1 = typeof (FilterOperatorsBooleanSettingsTagHelper);
      Type type2 = typeof (FilterOperatorsDateSettingsTagHelper);
      Type type3 = typeof (FilterOperatorsNumberSettingsTagHelper);
      Type type4 = typeof (FilterOperatorsStringSettingsTagHelper);
      if (context.Items.ContainsKey((object) type1))
        (context.Items[(object) type1] as FilterOperatorsBooleanSettingsTagHelper).CustomOperator = this;
      else if (context.Items.ContainsKey((object) type2))
        (context.Items[(object) type2] as FilterOperatorsDateSettingsTagHelper).CustomOperator = this;
      else if (context.Items.ContainsKey((object) type3))
      {
        (context.Items[(object) type3] as FilterOperatorsNumberSettingsTagHelper).CustomOperator = this;
      }
      else
      {
        if (!context.Items.ContainsKey((object) type4))
          return;
        (context.Items[(object) type4] as FilterOperatorsStringSettingsTagHelper).CustomOperator = this;
      }
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      string handler = this.Handler;
      if ((handler != null ? (handler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["handler"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = this.Handler
        };
      return dictionary;
    }
  }
}
