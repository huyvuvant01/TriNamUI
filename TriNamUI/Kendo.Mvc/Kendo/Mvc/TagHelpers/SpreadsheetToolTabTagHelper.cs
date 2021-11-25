// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetToolTabTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [RestrictChildren("tool", new string[] {"group"})]
  [SuppressTagRendering]
  public abstract class SpreadsheetToolTabTagHelper : 
    TagHelperCollectionBase<
    #nullable disable
    SpreadsheetToolTagHelper>
  {
    public SpreadsheetToolTabTagHelper()
      : base((IList<SpreadsheetToolTagHelper>) new List<SpreadsheetToolTagHelper>())
    {
      this.Enabled = true;
    }

    [HtmlAttributeNotBound]
    public IList<SpreadsheetToolTagHelper> Tools => this.InternalRef;

    public bool Enabled { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);
  }
}
