// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridColumnFilterableCellSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("cell", ParentTag = "filterable", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class GridColumnFilterableCellSettings : TagHelperChildBase
  {
    public GridColumnFilterableCellSettings()
    {
      this.Enabled = true;
      this.ShowOperators = true;
      this.Delay = 200.0;
      this.MinLength = 1;
      this.SuggestionOperator = FilterType.StartsWith;
      this.Operator = "eq";
    }

    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type1 = typeof (GridColumnFilterableSettingsTagHelper);
      if (context.Items.ContainsKey((object) type1))
      {
        (context.Items[(object) type1] as GridColumnFilterableSettingsTagHelper).CellSettings = this;
      }
      else
      {
        Type type2 = typeof (TreeListColumnFilterableSettingsTagHelper);
        if (!context.Items.ContainsKey((object) type2))
          return;
        (context.Items[(object) type2] as TreeListColumnFilterableSettingsTagHelper).CellSettings = this;
      }
    }

    public string Operator { get; set; }

    public double Delay { get; set; }

    public int MinLength { get; set; }

    public FilterType SuggestionOperator { get; set; }

    public int? InputWidth { get; set; }

    public bool Enabled { get; set; }

    public bool ShowOperators { get; set; }

    public string Template { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (!this.Enabled)
        dictionary["enabled"] = (object) this.Enabled;
      string template = this.Template;
      if ((template != null ? (template.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = this.Template
        };
      if (!this.ShowOperators)
        dictionary["showOperators"] = (object) this.ShowOperators;
      if (this.Delay != 200.0)
        dictionary["delay"] = (object) this.Delay;
      if (this.InputWidth.HasValue)
        dictionary["inputWidth"] = (object) this.InputWidth;
      if (this.SuggestionOperator != FilterType.StartsWith)
        dictionary["suggestionOperator"] = (object) this.SuggestionOperator;
      if (this.MinLength != 1)
        dictionary["minLength"] = (object) this.MinLength;
      if (this.Operator != "eq")
        dictionary["operator"] = (object) this.Operator;
      return dictionary;
    }
  }
}
