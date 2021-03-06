// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetHomeToolTabTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("home", ParentTag = "toolbar", TagStructure = TagStructure.NormalOrSelfClosing)]
  public class SpreadsheetHomeToolTabTagHelper : SpreadsheetToolTabTagHelper
  {
    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SpreadsheetToolbarTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SpreadsheetToolbarTagHelper).Home = this;
    }
  }
}
