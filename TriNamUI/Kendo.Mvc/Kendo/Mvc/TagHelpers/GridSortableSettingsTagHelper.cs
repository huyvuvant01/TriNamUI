// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridSortableSettingsTagHelper
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
  [HtmlTargetElement("sortable", ParentTag = "kendo-grid", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class GridSortableSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridTagHelper).Sortable = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    public bool? AllowUnsort { get; set; }

    public bool? ShowIndexes { get; set; }

    public string InitialDirection { get; set; }

    public string Mode { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.AllowUnsort.HasValue)
        dictionary["allowUnsort"] = (object) this.AllowUnsort;
      if (this.ShowIndexes.HasValue)
        dictionary["showIndexes"] = (object) this.ShowIndexes;
      string initialDirection = this.InitialDirection;
      if ((initialDirection != null ? (initialDirection.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["initialDirection"] = (object) this.InitialDirection;
      string mode = this.Mode;
      if ((mode != null ? (mode.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["mode"] = (object) this.Mode;
      return dictionary;
    }
  }
}
