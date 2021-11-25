// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PivotDataSourceSchemaCube
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class PivotDataSourceSchemaCube : JsonObject
  {
    public PivotDataSourceSchemaCube()
    {
      this.Measures = (IList<PivotDataSourceSchemaMeasureDescriptor>) new List<PivotDataSourceSchemaMeasureDescriptor>();
      this.Dimensions = (IList<PivotDataSourceSchemaDimensionDescriptor>) new List<PivotDataSourceSchemaDimensionDescriptor>();
    }

    public IList<PivotDataSourceSchemaMeasureDescriptor> Measures { get; set; }

    public IList<PivotDataSourceSchemaDimensionDescriptor> Dimensions { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Measures.Count > 0)
      {
        Dictionary<string, object> measures = new Dictionary<string, object>();
        json["measures"] = (object) measures;
        this.Measures.Each<PivotDataSourceSchemaMeasureDescriptor>((Action<PivotDataSourceSchemaMeasureDescriptor>) (prop =>
        {
          Dictionary<string, object> dictionary = new Dictionary<string, object>();
          measures[prop.Measure] = (object) dictionary;
          if (!string.IsNullOrEmpty(prop.Caption))
            dictionary["caption"] = (object) prop.Caption;
          if (!string.IsNullOrEmpty(prop.Field))
            dictionary["field"] = (object) prop.Field;
          if (prop.AggregateName.HasValue())
            dictionary["aggregate"] = (object) prop.AggregateName;
          else if (prop.Aggregate.HasValue())
            dictionary["aggregate"] = (object) prop.Aggregate;
          if (prop.Result.HasValue())
            dictionary["result"] = (object) prop.Result;
          if (string.IsNullOrEmpty(prop.Format))
            return;
          dictionary["format"] = (object) prop.Format;
        }));
      }
      if (this.Dimensions.Count <= 0)
        return;
      Dictionary<string, object> dimensions = new Dictionary<string, object>();
      json["dimensions"] = (object) dimensions;
      this.Dimensions.Each<PivotDataSourceSchemaDimensionDescriptor>((Action<PivotDataSourceSchemaDimensionDescriptor>) (prop =>
      {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        dimensions[prop.Member] = (object) dictionary;
        if (string.IsNullOrEmpty(prop.Caption))
          return;
        dictionary["caption"] = (object) prop.Caption;
      }));
    }
  }
}
