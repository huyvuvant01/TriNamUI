// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DataSourceSchema
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class DataSourceSchema : JsonObject
  {
    public string Data { get; set; }

    public ClientHandlerDescriptor FunctionData { get; }

    public string Total { get; set; }

    public ClientHandlerDescriptor FunctionTotal { get; }

    public string Errors { get; set; }

    public ClientHandlerDescriptor FunctionErrors { get; }

    public string Aggregates { get; set; }

    public ClientHandlerDescriptor FunctionAggregates { get; }

    public string Groups { get; set; }

    public ClientHandlerDescriptor FunctionGroups { get; }

    public string Type { get; set; }

    public ClientHandlerDescriptor Parse { get; }

    public object FunctionModel { get; set; }

    public ModelDescriptor Model { get; set; }

    public DataSourceSchema()
    {
      this.Data = nameof (Data);
      this.Total = nameof (Total);
      this.Errors = nameof (Errors);
      this.FunctionData = new ClientHandlerDescriptor();
      this.FunctionTotal = new ClientHandlerDescriptor();
      this.FunctionErrors = new ClientHandlerDescriptor();
      this.FunctionAggregates = new ClientHandlerDescriptor();
      this.FunctionGroups = new ClientHandlerDescriptor();
      this.Parse = new ClientHandlerDescriptor();
    }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.FunctionData.HasValue())
        json.Add("data", (object) this.FunctionData);
      else
        json.Add<string>("data", this.Data, string.Empty);
      if (this.FunctionTotal.HasValue())
        json.Add("total", (object) this.FunctionTotal);
      else
        json.Add<string>("total", this.Total, string.Empty);
      if (this.FunctionErrors.HasValue())
        json.Add("errors", (object) this.FunctionErrors);
      else
        json.Add<string>("errors", this.Errors, string.Empty);
      if (this.FunctionAggregates.HasValue())
        json.Add("aggregates", (object) this.FunctionAggregates);
      else
        json.Add<string>("aggregates", this.Aggregates, string.Empty);
      if (this.FunctionGroups.HasValue())
        json.Add("groups", (object) this.FunctionGroups);
      else
        json.Add<string>("groups", this.Groups, string.Empty);
      if (this.FunctionModel != null)
        json.Add("model", this.FunctionModel);
      else if (this.Model != null)
        json.Add("model", (object) this.Model.ToJson());
      if (!string.IsNullOrEmpty(this.Type))
        json.Add("type", (object) this.Type);
      if (!this.Parse.HasValue())
        return;
      json.Add("parse", (object) this.Parse);
    }
  }
}
