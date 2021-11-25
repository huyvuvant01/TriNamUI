// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotGridMessagesSettingsTagHelper
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
  [HtmlTargetElement("messages", ParentTag = "kendo-pivotgrid", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("pivotgrid-messages-field-menu", new string[] {})]
  [SuppressTagRendering]
  public class PivotGridMessagesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PivotGridTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PivotGridTagHelper).Messages = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string MeasureFields { get; set; }

    public string ColumnFields { get; set; }

    public string RowFields { get; set; }

    [HtmlAttributeNotBound]
    public PivotGridMessagesFieldMenuSettingsTagHelper FieldMenu { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string measureFields = this.MeasureFields;
      if ((measureFields != null ? (measureFields.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["measureFields"] = (object) this.MeasureFields;
      string columnFields = this.ColumnFields;
      if ((columnFields != null ? (columnFields.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnFields"] = (object) this.ColumnFields;
      string rowFields = this.RowFields;
      if ((rowFields != null ? (rowFields.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rowFields"] = (object) this.RowFields;
      if (this.FieldMenu != null)
      {
        Dictionary<string, object> source = this.FieldMenu.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["fieldMenu"] = (object) source;
      }
      return dictionary;
    }
  }
}
