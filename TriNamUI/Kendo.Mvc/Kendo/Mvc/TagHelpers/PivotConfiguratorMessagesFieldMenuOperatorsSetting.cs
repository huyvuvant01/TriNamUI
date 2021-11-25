// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotConfiguratorMessagesFieldMenuOperatorsSettingsTagHelper
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
  [HtmlTargetElement("operators", ParentTag = "pivotconfigurator-messages-field-menu", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class PivotConfiguratorMessagesFieldMenuOperatorsSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PivotConfiguratorMessagesFieldMenuSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PivotConfiguratorMessagesFieldMenuSettingsTagHelper).Operators = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Contains { get; set; }

    public string Doesnotcontain { get; set; }

    public string Startswith { get; set; }

    public string Endswith { get; set; }

    public string Eq { get; set; }

    public string Neq { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string contains = this.Contains;
      if ((contains != null ? (contains.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contains"] = (object) this.Contains;
      string doesnotcontain = this.Doesnotcontain;
      if ((doesnotcontain != null ? (doesnotcontain.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["doesnotcontain"] = (object) this.Doesnotcontain;
      string startswith = this.Startswith;
      if ((startswith != null ? (startswith.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["startswith"] = (object) this.Startswith;
      string endswith = this.Endswith;
      if ((endswith != null ? (endswith.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["endswith"] = (object) this.Endswith;
      string eq = this.Eq;
      if ((eq != null ? (eq.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["eq"] = (object) this.Eq;
      string neq = this.Neq;
      if ((neq != null ? (neq.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["neq"] = (object) this.Neq;
      return dictionary;
    }
  }
}
