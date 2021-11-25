// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridFilterableOperatorsDateSettingsTagHelper
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
  [HtmlTargetElement("date", ParentTag = "operators", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class GridFilterableOperatorsDateSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridFilterableOperatorsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridFilterableOperatorsSettingsTagHelper).Date = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Eq { get; set; }

    public string Neq { get; set; }

    public string Isnull { get; set; }

    public string Isnotnull { get; set; }

    public string Gte { get; set; }

    public string Gt { get; set; }

    public string Lte { get; set; }

    public string Lt { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string eq = this.Eq;
      if ((eq != null ? (eq.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["eq"] = (object) this.Eq;
      string neq = this.Neq;
      if ((neq != null ? (neq.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["neq"] = (object) this.Neq;
      string isnull = this.Isnull;
      if ((isnull != null ? (isnull.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["isnull"] = (object) this.Isnull;
      string isnotnull = this.Isnotnull;
      if ((isnotnull != null ? (isnotnull.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["isnotnull"] = (object) this.Isnotnull;
      string gte = this.Gte;
      if ((gte != null ? (gte.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["gte"] = (object) this.Gte;
      string gt = this.Gt;
      if ((gt != null ? (gt.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["gt"] = (object) this.Gt;
      string lte = this.Lte;
      if ((lte != null ? (lte.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["lte"] = (object) this.Lte;
      string lt = this.Lt;
      if ((lt != null ? (lt.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["lt"] = (object) this.Lt;
      return dictionary;
    }
  }
}
