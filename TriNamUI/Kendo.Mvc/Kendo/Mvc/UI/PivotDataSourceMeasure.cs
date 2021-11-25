// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PivotDataSourceMeasure
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PivotDataSourceMeasure : JsonObject
  {
    public PivotDataSourceMeasure() => this.Axis = PivotDataSourceMeasureAxis.Columns;

    public IEnumerable<PivotDataSourceMeasureDescriptor> Values { get; set; }

    public PivotDataSourceMeasureAxis Axis { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Values != null && this.Values.Any<PivotDataSourceMeasureDescriptor>())
        json["values"] = (object) ((IEnumerable<JsonObject>) this.Values).ToJson();
      if (this.Axis == PivotDataSourceMeasureAxis.Columns)
        return;
      json["axis"] = (object) this.Axis.ToString();
    }
  }
}
