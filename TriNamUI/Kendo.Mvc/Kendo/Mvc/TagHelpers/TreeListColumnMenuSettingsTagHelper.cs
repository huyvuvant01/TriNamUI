// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeListColumnMenuSettingsTagHelper
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
  [HtmlTargetElement("column-menu", ParentTag = "kendo-treelist", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("treelist-column-menu-messages", new string[] {})]
  [SuppressTagRendering]
  public class TreeListColumnMenuSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (TreeListTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as TreeListTagHelper).ColumnMenu = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    public bool? Columns { get; set; }

    public bool? Filterable { get; set; }

    public bool? Sortable { get; set; }

    [HtmlAttributeNotBound]
    public TreeListColumnMenuMessagesSettingsTagHelper Messages { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Columns.HasValue)
        dictionary["columns"] = (object) this.Columns;
      if (this.Filterable.HasValue)
        dictionary["filterable"] = (object) this.Filterable;
      if (this.Sortable.HasValue)
        dictionary["sortable"] = (object) this.Sortable;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      return dictionary;
    }
  }
}
