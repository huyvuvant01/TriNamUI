// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PivotConfiguratorMessages
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class PivotConfiguratorMessages : JsonObject
  {
    private const string DefaultMeasures = "Drop Data Fields Here";
    private const string DefaultColumns = "Drop Column Fields Here";
    private const string DefaultRows = "Drop Rows Fields Here";
    private const string DefaultMeasuresLabel = "Measures";
    private const string DefaultColumnsLabel = "Columns";
    private const string DefaultRowsLabel = "Rows";
    private const string DefaultFieldsLabel = "Fields";

    public PivotConfiguratorMessages()
    {
      this.Measures = Messages.PivotConfigurator_Measures;
      this.Columns = Messages.PivotConfigurator_Columns;
      this.Rows = Messages.PivotConfigurator_Rows;
      this.MeasuresLabel = Messages.PivotConfigurator_MeasuresLabel;
      this.ColumnsLabel = Messages.PivotConfigurator_ColumnsLabel;
      this.RowsLabel = Messages.PivotConfigurator_RowsLabel;
      this.FieldsLabel = Messages.PivotConfigurator_FieldsLabel;
      this.FieldMenu = new PivotFieldMenuMessages();
    }

    public string Measures { get; set; }

    public string Columns { get; set; }

    public string Rows { get; set; }

    public string MeasuresLabel { get; set; }

    public string ColumnsLabel { get; set; }

    public string RowsLabel { get; set; }

    public string FieldsLabel { get; set; }

    public PivotFieldMenuMessages FieldMenu { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Measures != "Drop Data Fields Here")
        json["measures"] = (object) this.Measures;
      if (this.Columns != "Drop Column Fields Here")
        json["columns"] = (object) this.Columns;
      if (this.Rows != "Drop Rows Fields Here")
        json["rows"] = (object) this.Rows;
      if (this.MeasuresLabel != "Measures")
        json["measuresLabel"] = (object) this.MeasuresLabel;
      if (this.ColumnsLabel != "Columns")
        json["columnsLabel"] = (object) this.ColumnsLabel;
      if (this.RowsLabel != "Rows")
        json["rowsLabel"] = (object) this.RowsLabel;
      if (this.FieldsLabel != "Fields")
        json["fieldsLabel"] = (object) this.FieldsLabel;
      IDictionary<string, object> json1 = this.FieldMenu.ToJson();
      if (json1.Count <= 0)
        return;
      json["fieldMenu"] = (object) json1;
    }
  }
}
