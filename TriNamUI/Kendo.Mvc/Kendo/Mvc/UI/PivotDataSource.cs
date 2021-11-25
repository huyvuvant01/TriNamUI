// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PivotDataSource
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PivotDataSource : JsonObject
  {
    public PivotDataSource(IModelMetadataProvider modelMetaDataProvider)
    {
      this.Transport = new PivotTransport();
      this.Rows = (IList<PivotDataSourceRow>) new List<PivotDataSourceRow>();
      this.Columns = (IList<PivotDataSourceColumn>) new List<PivotDataSourceColumn>();
      this.Measure = new PivotDataSourceMeasure();
      this.Schema = new PivotDataSourceSchema();
      this.Events = (IDictionary<string, object>) new Dictionary<string, object>();
      this.OrderBy = (IList<SortDescriptor>) new List<SortDescriptor>();
      this.ModelMetaDataProvider = modelMetaDataProvider;
    }

    public IList<PivotDataSourceRow> Rows { get; set; }

    public IList<PivotDataSourceColumn> Columns { get; set; }

    public PivotDataSourceMeasure Measure { get; set; }

    public PivotDataSourceSchema Schema { get; private set; }

    public IList<SortDescriptor> OrderBy { get; }

    public PivotTransport Transport { get; protected set; }

    public string CustomType { get; set; }

    public PivotDataSourceType? Type { get; set; }

    public IEnumerable Data { get; set; }

    public IDictionary<string, object> CustomTransport { get; set; }

    public IDictionary<string, object> Events { get; private set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Type.HasValue)
      {
        PivotDataSourceType? type = this.Type;
        PivotDataSourceType pivotDataSourceType1 = PivotDataSourceType.Xmla;
        if (type.GetValueOrDefault() == pivotDataSourceType1 & type.HasValue)
        {
          IDictionary<string, object> dictionary = json;
          type = this.Type;
          string lower = type.ToString().ToLower();
          dictionary["type"] = (object) lower;
        }
        else
        {
          type = this.Type;
          PivotDataSourceType pivotDataSourceType2 = PivotDataSourceType.Ajax;
          if (type.GetValueOrDefault() == pivotDataSourceType2 & type.HasValue)
            json["type"] = (object) new ClientHandlerDescriptor()
            {
              HandlerName = this.GenerateTypeFunction(true)
            };
          else if (!string.IsNullOrEmpty(this.CustomType))
            json["type"] = (object) this.CustomType;
        }
      }
      if (this.CustomTransport != null)
      {
        json["transport"] = (object) this.CustomTransport;
      }
      else
      {
        IDictionary<string, object> json1 = this.Transport.ToJson();
        if (json1.Keys.Any<string>())
          json["transport"] = (object) json1;
      }
      if (this.Events.Keys.Any<string>())
        DictionaryExtensions.Merge(json, this.Events);
      if (this.Rows.Any<PivotDataSourceRow>())
        json["rows"] = (object) ((IEnumerable<JsonObject>) this.Rows).ToJson();
      if (this.Columns.Any<PivotDataSourceColumn>())
        json["columns"] = (object) ((IEnumerable<JsonObject>) this.Columns).ToJson();
      IDictionary<string, object> json2 = this.Measure.ToJson();
      if (json2.Keys.Any<string>())
        json["measures"] = (object) json2;
      IDictionary<string, object> json3 = this.Schema.ToJson();
      if (json3.Keys.Any<string>())
        json["schema"] = (object) json3;
      if (this.OrderBy.Any<SortDescriptor>())
        json["sort"] = (object) ((IEnumerable<JsonObject>) this.OrderBy).ToJson();
      if (this.Data == null)
        return;
      this.SerializeData(json, this.Data);
    }

    private void SerializeData(IDictionary<string, object> json, IEnumerable data)
    {
      if (string.IsNullOrEmpty(this.Schema.Data))
        json[nameof (data)] = (object) this.Data;
      else
        json[nameof (data)] = (object) new Dictionary<string, object>()
        {
          {
            this.Schema.Data,
            (object) this.Data
          },
          {
            this.Schema.Total,
            (object) this.Data.AsQueryable().Count()
          }
        };
    }

    public void ModelType(System.Type modelType) => this.Schema.Model = new ModelDescriptor(modelType, this.ModelMetaDataProvider);

    public IModelMetadataProvider ModelMetaDataProvider { get; }

    private string GenerateTypeFunction(bool isAspNetMvc) => string.Format("(function(){{if(kendo.data.transports['{0}{1}']){{return '{0}{1}';}} else{{throw new Error('The kendo.aspnetmvc.min.js script is not included.');}}}})()", (object) "aspnetmvc-", (object) this.Type.ToString().ToLower());
  }
}
