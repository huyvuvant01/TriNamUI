// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetToolTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("tool", ParentTag = "home", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("tool", ParentTag = "insert", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("tool", ParentTag = "data", TagStructure = TagStructure.NormalOrSelfClosing)]
  public class SpreadsheetToolTagHelper : SpreadsheetGroupedToolTagHelper
  {
    protected override void AddSelfToParent(TagHelperContext context)
    {
      foreach (Type type in new List<Type>()
      {
        typeof (SpreadsheetHomeToolTabTagHelper),
        typeof (SpreadsheetInsertToolTabTagHelper),
        typeof (SpreadsheetDataToolTabTagHelper)
      })
      {
        if (context.Items.ContainsKey((object) type))
        {
          (context.Items[(object) type] as SpreadsheetToolTabTagHelper).Add(this);
          break;
        }
      }
    }
  }
}
