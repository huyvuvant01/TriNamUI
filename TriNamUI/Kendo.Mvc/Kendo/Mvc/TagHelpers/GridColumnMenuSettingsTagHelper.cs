// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridColumnMenuSettingsTagHelper
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
  [HtmlTargetElement("column-menu", ParentTag = "kendo-grid", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("messages", new string[] {"column-menu-columns"})]
  [SuppressTagRendering]
  public class GridColumnMenuSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridTagHelper).ColumnMenu = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    [HtmlAttributeNotBound]
    public GridColumnMenuColumnsSettingsTagHelper Columns { get; set; }

    public bool? Filterable { get; set; }

    public string ComponentType { get; set; }

    public bool? Sortable { get; set; }

    [HtmlAttributeNotBound]
    public GridColumnMenuMessagesSettingsTagHelper Messages { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      bool? nullable;
      if (this.Columns != null)
      {
        Dictionary<string, object> source = this.Columns.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable = this.Columns.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.Columns.Enabled;
            if (!nullable.Value)
              goto label_5;
          }
          dictionary["columns"] = (object) source;
          goto label_8;
        }
label_5:
        nullable = this.Columns.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Columns.Enabled;
          if (!nullable.Value)
            dictionary["columns"] = (object) this.Columns.Enabled;
        }
      }
label_8:
      nullable = this.Filterable;
      if (nullable.HasValue)
        dictionary["filterable"] = (object) this.Filterable;
      string componentType = this.ComponentType;
      if ((componentType != null ? (componentType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["componentType"] = (object) this.ComponentType;
      nullable = this.Sortable;
      if (nullable.HasValue)
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
