// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotConfiguratorMessagesSettingsTagHelper
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
  [HtmlTargetElement("messages", ParentTag = "kendo-pivotconfigurator", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("pivotconfigurator-messages-field-menu", new string[] {})]
  [SuppressTagRendering]
  public class PivotConfiguratorMessagesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PivotConfiguratorTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PivotConfiguratorTagHelper).Messages = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Measures { get; set; }

    public string Columns { get; set; }

    public string Rows { get; set; }

    public string MeasuresLabel { get; set; }

    public string RowsLabel { get; set; }

    public string ColumnsLabel { get; set; }

    public string FieldsLabel { get; set; }

    [HtmlAttributeNotBound]
    public PivotConfiguratorMessagesFieldMenuSettingsTagHelper FieldMenu { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string measures = this.Measures;
      if ((measures != null ? (measures.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["measures"] = (object) this.Measures;
      string columns = this.Columns;
      if ((columns != null ? (columns.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columns"] = (object) this.Columns;
      string rows = this.Rows;
      if ((rows != null ? (rows.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rows"] = (object) this.Rows;
      string measuresLabel = this.MeasuresLabel;
      if ((measuresLabel != null ? (measuresLabel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["measuresLabel"] = (object) this.MeasuresLabel;
      string rowsLabel = this.RowsLabel;
      if ((rowsLabel != null ? (rowsLabel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rowsLabel"] = (object) this.RowsLabel;
      string columnsLabel = this.ColumnsLabel;
      if ((columnsLabel != null ? (columnsLabel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnsLabel"] = (object) this.ColumnsLabel;
      string fieldsLabel = this.FieldsLabel;
      if ((fieldsLabel != null ? (fieldsLabel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fieldsLabel"] = (object) this.FieldsLabel;
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
