// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Transport
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Transport : JsonObject
  {
    public Transport()
    {
      this.Read = new CrudOperation();
      this.Update = new CrudOperation();
      this.Destroy = new CrudOperation();
      this.Create = new CrudOperation();
      this.FunctionRead = new ClientHandlerDescriptor();
      this.FunctionUpdate = new ClientHandlerDescriptor();
      this.FunctionDestroy = new ClientHandlerDescriptor();
      this.FunctionCreate = new ClientHandlerDescriptor();
      this.FunctionSubmit = new ClientHandlerDescriptor();
      this.ParameterMap = new ClientHandlerDescriptor();
      this.SerializeEmptyPrefix = true;
      this.SignalR = new TransportSignalR();
    }

    public bool? Cache { get; set; }

    public string Prefix { get; set; }

    public bool StringifyDates { get; set; }

    public string Culture { get; set; }

    public string IdField { get; set; }

    public ClientHandlerDescriptor ParameterMap { get; set; }

    public bool SerializeEmptyPrefix { get; set; }

    public TransportSignalR SignalR { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.CustomRead != null)
        json["read"] = (object) this.CustomRead;
      else if (this.FunctionRead.HasValue())
      {
        json["read"] = (object) this.FunctionRead;
      }
      else
      {
        IDictionary<string, object> json1 = this.Read.ToJson();
        if (json1.Keys.Any<string>())
          json["read"] = (object) json1;
      }
      if (this.SerializeEmptyPrefix)
        json["prefix"] = this.Prefix.HasValue() ? (object) this.Prefix : (object) string.Empty;
      else if (this.Prefix.HasValue())
        json["prefix"] = (object) this.Prefix;
      if (this.CustomUpdate != null)
        json["update"] = (object) this.CustomUpdate;
      else if (this.FunctionUpdate.HasValue())
      {
        json["update"] = (object) this.FunctionUpdate;
      }
      else
      {
        IDictionary<string, object> json2 = this.Update.ToJson();
        if (json2.Keys.Any<string>())
          json["update"] = (object) json2;
      }
      if (this.CustomCreate != null)
        json["create"] = (object) this.CustomCreate;
      else if (this.FunctionCreate.HasValue())
      {
        json["create"] = (object) this.FunctionCreate;
      }
      else
      {
        IDictionary<string, object> json3 = this.Create.ToJson();
        if (json3.Keys.Any<string>())
          json["create"] = (object) json3;
      }
      if (this.CustomDestroy != null)
        json["destroy"] = (object) this.CustomDestroy;
      else if (this.FunctionDestroy.HasValue())
      {
        json["destroy"] = (object) this.FunctionDestroy;
      }
      else
      {
        IDictionary<string, object> json4 = this.Destroy.ToJson();
        if (json4.Keys.Any<string>())
          json["destroy"] = (object) json4;
      }
      if (this.CustomBatch != null)
        json["batch"] = (object) this.CustomBatch;
      if (this.FunctionSubmit.HasValue())
        json["submit"] = (object) this.FunctionSubmit;
      if (this.StringifyDates)
        json["stringifyDates"] = (object) this.StringifyDates;
      if (!string.IsNullOrEmpty(this.IdField))
        json["idField"] = (object) this.IdField;
      if (this.ParameterMap.HasValue())
        json["parameterMap"] = (object) this.ParameterMap;
      IDictionary<string, object> json5 = this.SignalR.ToJson();
      if (json5.Keys.Any<string>())
        json["signalr"] = (object) json5;
      if (this.Cache.HasValue)
        json["cache"] = (object) this.Cache;
      if (string.IsNullOrEmpty(this.Culture))
        return;
      json["culture"] = (object) this.Culture;
    }

    public CrudOperation Read { get; }

    public CrudOperation Update { get; }

    public CrudOperation Create { get; }

    public CrudOperation Destroy { get; }

    public IDictionary<string, object> CustomRead { get; set; }

    public IDictionary<string, object> CustomUpdate { get; set; }

    public IDictionary<string, object> CustomCreate { get; set; }

    public IDictionary<string, object> CustomDestroy { get; set; }

    public IDictionary<string, object> CustomBatch { get; set; }

    public ClientHandlerDescriptor FunctionRead { get; set; }

    public ClientHandlerDescriptor FunctionUpdate { get; set; }

    public ClientHandlerDescriptor FunctionCreate { get; set; }

    public ClientHandlerDescriptor FunctionDestroy { get; set; }

    public ClientHandlerDescriptor FunctionSubmit { get; set; }
  }
}
