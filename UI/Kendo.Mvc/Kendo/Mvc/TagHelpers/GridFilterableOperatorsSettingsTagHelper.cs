// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridFilterableOperatorsSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("operators", ParentTag = "filterable", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("string", new string[] {"number", "date", "enums"})]
  [SuppressTagRendering]
  public class GridFilterableOperatorsSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type1 = typeof (GridFilterableSettingsTagHelper);
      Type type2 = typeof (GridColumnFilterableSettingsTagHelper);
      if (context.Items.ContainsKey((object) type1))
        (context.Items[(object) type1] as GridFilterableSettingsTagHelper).Operators = this;
      if (!context.Items.ContainsKey((object) type2))
        return;
      (context.Items[(object) type2] as GridColumnFilterableSettingsTagHelper).Operators = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public GridFilterableOperatorsStringSettingsTagHelper String { get; set; }

    public GridFilterableOperatorsNumberSettingsTagHelper Number { get; set; }

    public GridFilterableOperatorsDateSettingsTagHelper Date { get; set; }

    public GridFilterableOperatorsEnumsSettingsTagHelper Enums { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.String != null)
      {
        Dictionary<string, object> source = this.String.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["string"] = (object) source;
      }
      if (this.Number != null)
      {
        Dictionary<string, object> source = this.Number.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["number"] = (object) source;
      }
      if (this.Date != null)
      {
        Dictionary<string, object> source = this.Date.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["date"] = (object) source;
      }
      if (this.Enums != null)
      {
        Dictionary<string, object> source = this.Enums.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["enums"] = (object) source;
      }
      return dictionary;
    }
  }
}
