// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PivotGridMessages
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class PivotGridMessages : JsonObject
  {
    private const string DefaultMeasureFields = "Drop Data Fields Here";
    private const string DefaultColumnFields = "Drop Column Fields Here";
    private const string DefaultRowFields = "Drop Rows Fields Here";

    public PivotGridMessages()
    {
      this.MeasureFields = Messages.PivotConfigurator_Measures;
      this.ColumnFields = Messages.PivotConfigurator_Columns;
      this.RowFields = Messages.PivotConfigurator_Rows;
      this.FieldMenu = new PivotFieldMenuMessages();
    }

    public string MeasureFields { get; set; }

    public string ColumnFields { get; set; }

    public string RowFields { get; set; }

    public PivotFieldMenuMessages FieldMenu { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.MeasureFields != "Drop Data Fields Here")
        json["measureFields"] = (object) this.MeasureFields;
      if (this.ColumnFields != "Drop Column Fields Here")
        json["columnFields"] = (object) this.ColumnFields;
      if (this.RowFields != "Drop Rows Fields Here")
        json["rowFields"] = (object) this.RowFields;
      IDictionary<string, object> json1 = this.FieldMenu.ToJson();
      if (json1.Count <= 0)
        return;
      json["fieldMenu"] = (object) json1;
    }
  }
}
