// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeListColumnFilterableSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("filterable", ParentTag = "treelist-column", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("cell", new string[] {})]
  [SuppressTagRendering]
  public class TreeListColumnFilterableSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    GridColumnFilterableCellSettings CellSettings { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (TreeListColumnTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as TreeListColumnTagHelper).Filterable = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      Dictionary<string, object> source = this.CellSettings?.SerializeSettings();
      if (source != null && source.Any<KeyValuePair<string, object>>())
        dictionary["cell"] = (object) source;
      return dictionary;
    }

    public bool? Enabled { get; set; }

    public string Ui { get; set; }

    public string UiHandler { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string uiHandler = this.UiHandler;
      if ((uiHandler != null ? (uiHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["ui"] = (object) this.CreateHandler(this.UiHandler);
      }
      else
      {
        string ui = this.Ui;
        if ((ui != null ? (ui.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["ui"] = (object) this.Ui;
      }
      return dictionary;
    }
  }
}
