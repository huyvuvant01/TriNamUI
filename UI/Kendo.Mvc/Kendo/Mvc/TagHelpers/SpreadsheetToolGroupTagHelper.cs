// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetToolGroupTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("group", ParentTag = "home", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("group", ParentTag = "insert", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("group", ParentTag = "data", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("tool", new string[] {})]
  public class SpreadsheetToolGroupTagHelper : SpreadsheetToolTagHelper
  {
    public SpreadsheetToolGroupTagHelper() => this.Tools = (IList<SpreadsheetGroupedToolTagHelper>) new List<SpreadsheetGroupedToolTagHelper>();

    [HtmlAttributeNotBound]
    public IList<SpreadsheetGroupedToolTagHelper> Tools { get; set; }

    public override Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Tools != null && this.Tools.Count > 0)
        dictionary["tool"] = (object) this.Tools.Select<SpreadsheetGroupedToolTagHelper, string>((Func<SpreadsheetGroupedToolTagHelper, string>) (tool => tool.Name));
      return dictionary;
    }
  }
}
