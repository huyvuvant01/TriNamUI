// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeListSortableSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("sortable", ParentTag = "kendo-treelist", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class TreeListSortableSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (TreeListTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as TreeListTagHelper).Sortable = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    public bool? AllowUnsort { get; set; }

    public TreeListSortMode? Mode { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.AllowUnsort.HasValue)
        dictionary1["allowUnsort"] = (object) this.AllowUnsort;
      if (this.Mode.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        TreeListSortMode? mode = this.Mode;
        ref TreeListSortMode? local = ref mode;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["mode"] = (object) str;
      }
      return dictionary1;
    }
  }
}
