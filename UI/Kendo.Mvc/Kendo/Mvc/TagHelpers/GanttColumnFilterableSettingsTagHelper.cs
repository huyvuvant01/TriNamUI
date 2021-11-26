// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GanttColumnFilterableSettingsTagHelper
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
  [HtmlTargetElement("filterable", ParentTag = "gantt-column", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class GanttColumnFilterableSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GanttColumnTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GanttColumnTagHelper).Filterable = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

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
