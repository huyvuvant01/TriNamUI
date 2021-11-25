// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DataSource
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


#nullable enable
namespace Kendo.Mvc.UI
{
  public class DataSource : JsonObject
  {
    public DataSource(
    #nullable disable
    IModelMetadataProvider modelMetaDataProvider)
      : this()
    {
      this.ModelMetaDataProvider = modelMetaDataProvider;
    }

    protected DataSource()
    {
      this.Transport = new Transport();
      this.Filters = (IList<IFilterDescriptor>) new List<IFilterDescriptor>();
      this.OrderBy = (IList<SortDescriptor>) new List<SortDescriptor>();
      this.Groups = (IList<GroupDescriptor>) new List<GroupDescriptor>();
      this.Aggregates = (IList<AggregateDescriptor>) new List<AggregateDescriptor>();
      this.Events = (IDictionary<string, object>) new Dictionary<string, object>();
      this.Schema = new DataSourceSchema();
      this.OfflineStorage = (IDictionary<string, object>) new Dictionary<string, object>();
    }

    public int TotalPages { get; set; }

    public int Page { get; set; }

    public bool GroupPaging { get; set; }

    public string AccentFoldingFiltering { get; set; }

    public string Culture { get; set; }

    public int Total { get; set; }

    public string OfflineStorageKey { get; set; }

    public IDictionary<string, object> OfflineStorage { get; }

    public DataSourceSchema Schema { get; }

    public IDictionary<string, object> Events { get; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      int num1 = this.Transport.Read.Url == null ? 1 : 0;
      DataSourceType? type1 = this.Type;
      DataSourceType dataSourceType1 = DataSourceType.Custom;
      int num2 = !(type1.GetValueOrDefault() == dataSourceType1 & type1.HasValue) ? 1 : 0;
      if ((num1 & num2) != 0)
        this.Transport.Read.Url = "";
      DataSourceType? type2 = this.Type;
      if (type2.HasValue)
      {
        type2 = this.Type;
        DataSourceType dataSourceType2 = DataSourceType.Ajax;
        if (!(type2.GetValueOrDefault() == dataSourceType2 & type2.HasValue))
        {
          type2 = this.Type;
          DataSourceType dataSourceType3 = DataSourceType.Server;
          if (!(type2.GetValueOrDefault() == dataSourceType3 & type2.HasValue))
          {
            type2 = this.Type;
            DataSourceType dataSourceType4 = DataSourceType.Custom;
            if (type2.GetValueOrDefault() == dataSourceType4 & type2.HasValue)
            {
              if (!string.IsNullOrEmpty(this.CustomType))
              {
                json["type"] = (object) this.CustomType;
                goto label_14;
              }
              else
                goto label_14;
            }
            else
            {
              json["type"] = (object) new ClientHandlerDescriptor()
              {
                HandlerName = this.GenerateTypeFunction(false)
              };
              type2 = this.Type;
              DataSourceType dataSourceType5 = DataSourceType.WebApi;
              if (type2.GetValueOrDefault() == dataSourceType5 & type2.HasValue)
              {
                if (this.Schema.Model.Id != null)
                  this.Transport.IdField = this.Schema.Model.Id.Name;
                if (!string.IsNullOrEmpty(this.Culture) && this.Transport != null)
                {
                  this.Transport.Culture = this.Culture;
                  goto label_14;
                }
                else
                  goto label_14;
              }
              else
                goto label_14;
            }
          }
        }
        json["type"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = this.GenerateTypeFunction(true)
        };
      }
label_14:
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
      if (!string.IsNullOrEmpty(this.OfflineStorageKey))
        json["offlineStorage"] = (object) this.OfflineStorageKey;
      if (this.OfflineStorage.Any<KeyValuePair<string, object>>())
        json["offlineStorage"] = (object) this.OfflineStorage;
      if (!string.IsNullOrEmpty(this.AccentFoldingFiltering))
        json["accentFoldingFiltering"] = (object) this.AccentFoldingFiltering;
      if (this.PageSize > 0)
      {
        json["pageSize"] = (object) this.PageSize;
        json["page"] = (object) this.Page;
        json["groupPaging"] = (object) this.GroupPaging;
        json["total"] = (object) this.Total;
      }
      if (this.ServerPaging)
        json["serverPaging"] = (object) this.ServerPaging;
      if (this.ServerSorting)
        json["serverSorting"] = (object) this.ServerSorting;
      if (this.ServerFiltering)
        json["serverFiltering"] = (object) this.ServerFiltering;
      if (this.ServerGrouping)
        json["serverGrouping"] = (object) this.ServerGrouping;
      if (this.ServerAggregates)
        json["serverAggregates"] = (object) this.ServerAggregates;
      if (this.OrderBy.Any<SortDescriptor>())
        json["sort"] = (object) ((IEnumerable<JsonObject>) this.OrderBy).ToJson();
      if (this.Groups.Any<GroupDescriptor>())
      {
        if (this.Aggregates.Any<AggregateDescriptor>())
          this.Groups.Where<GroupDescriptor>((Func<GroupDescriptor, bool>) (g => g.AggregateFunctions.Count == 0)).Each<GroupDescriptor>((Action<GroupDescriptor>) (g => g.AggregateFunctions.AddRange<AggregateFunction>(this.Aggregates.SelectMany<AggregateDescriptor, AggregateFunction>((Func<AggregateDescriptor, IEnumerable<AggregateFunction>>) (a => (IEnumerable<AggregateFunction>) a.Aggregates)))));
        json["group"] = (object) ((IEnumerable<JsonObject>) this.Groups).ToJson();
      }
      if (this.Aggregates.Any<AggregateDescriptor>())
        json["aggregate"] = (object) this.Aggregates.SelectMany<AggregateDescriptor, IDictionary<string, object>>((Func<AggregateDescriptor, IEnumerable<IDictionary<string, object>>>) (agg => ((IEnumerable<JsonObject>) agg.Aggregates).ToJson()));
      if (this.Filters.Any<IFilterDescriptor>() || this.ServerFiltering)
        json["filter"] = (object) ((IEnumerable<JsonObject>) this.Filters.OfType<FilterDescriptorBase>()).ToJson();
      if (this.Events.Keys.Any<string>())
        DictionaryExtensions.Merge(json, this.Events);
      IDictionary<string, object> json2 = this.Schema.ToJson();
      if (json2.Keys.Any<string>())
        json["schema"] = (object) json2;
      if (this.Batch)
        json["batch"] = (object) this.Batch;
      if (this.AutoSync)
        json["autoSync"] = (object) this.AutoSync;
      if (this.IsClientOperationMode)
      {
        type2 = this.Type;
        DataSourceType dataSourceType6 = DataSourceType.Custom;
        if (type2.GetValueOrDefault() == dataSourceType6 & type2.HasValue && this.CustomType != "aspnetmvc-ajax")
          this.RawData = this.Data;
      }
      if (this.IsClientOperationMode && this.RawData != null)
      {
        this.SerializeData(json, this.RawData);
      }
      else
      {
        if (!this.IsClientBinding || this.IsClientOperationMode || this.Data == null)
          return;
        this.SerializeData(json, this.Data);
      }
    }

    private string GenerateTypeFunction(bool isAspNetMvc)
    {
      string format = "(function(){{if(kendo.data.transports['{0}{1}']){{return '{0}{1}';}} else{{throw new Error('The kendo.aspnetmvc.min.js script is not included.');}}}})()";
      return isAspNetMvc ? string.Format(format, (object) "aspnetmvc-", (object) this.Type.ToString().ToLower()) : string.Format(format, (object) "", (object) this.Type.ToString().ToLower());
    }

    private void SerializeData(IDictionary<string, object> json, IEnumerable data)
    {
      if (string.IsNullOrEmpty(this.Schema.Data))
        json[nameof (data)] = this.SerializeDataSource(data);
      else
        json[nameof (data)] = (object) new Dictionary<string, object>()
        {
          {
            this.Schema.Data,
            this.SerializeDataSource(data)
          },
          {
            this.Schema.Total,
            (object) this.Total
          }
        };
    }

    private object SerializeDataSource(IEnumerable data) => data is IEnumerable<AggregateFunctionsGroup> && !this.ServerGrouping ? (object) data.Cast<IGroup>().Leaves() : (object) data;

    public bool IsClientOperationMode
    {
      get
      {
        if (!this.IsClientBinding)
          return false;
        return !this.ServerPaging || !this.ServerSorting || !this.ServerGrouping || !this.ServerFiltering || !this.ServerAggregates;
      }
    }

    public bool IsClientBinding
    {
      get
      {
        DataSourceType? type1 = this.Type;
        DataSourceType dataSourceType1 = DataSourceType.Ajax;
        if (!(type1.GetValueOrDefault() == dataSourceType1 & type1.HasValue))
        {
          DataSourceType? type2 = this.Type;
          DataSourceType dataSourceType2 = DataSourceType.WebApi;
          if (!(type2.GetValueOrDefault() == dataSourceType2 & type2.HasValue))
          {
            DataSourceType? type3 = this.Type;
            DataSourceType dataSourceType3 = DataSourceType.Custom;
            return type3.GetValueOrDefault() == dataSourceType3 & type3.HasValue;
          }
        }
        return true;
      }
    }

    public void ModelType(System.Type modelType) => this.Schema.Model = new ModelDescriptor(modelType, this.ModelMetaDataProvider);

    public IModelMetadataProvider ModelMetaDataProvider { get; protected set; }

    public bool Batch { get; set; }

    public DataSourceType? Type { get; set; }

    public string CustomType { get; set; }

    public IList<IFilterDescriptor> Filters { get; }

    public IList<SortDescriptor> OrderBy { get; }

    public IList<GroupDescriptor> Groups { get; }

    public IList<AggregateDescriptor> Aggregates { get; }

    public int PageSize { get; set; }

    public bool ServerPaging { get; set; }

    public bool ServerSorting { get; set; }

    public bool ServerFiltering { get; set; }

    public bool ServerGrouping { get; set; }

    public bool ServerAggregates { get; set; }

    public Transport Transport { get; }

    public IDictionary<string, object> CustomTransport { get; set; }

    public IEnumerable Data { get; set; }

    public bool AutoSync { get; set; }

    public IEnumerable RawData { get; set; }

    public IEnumerable<AggregateResult> AggregateResults { get; set; }

    public void Process(DataSourceRequest request, bool processData)
    {
      this.RawData = this.Data;
      if (request.Sorts == null)
        request.Sorts = this.OrderBy;
      else if (request.Sorts.Any<SortDescriptor>())
      {
        this.OrderBy.Clear();
        this.OrderBy.AddRange<SortDescriptor>((IEnumerable<SortDescriptor>) request.Sorts);
      }
      else
        this.OrderBy.Clear();
      if (request.PageSize == 0)
        request.PageSize = this.PageSize;
      this.PageSize = request.PageSize;
      if (request.Groups == null)
        request.Groups = this.Groups;
      else if (request.Groups.Any<GroupDescriptor>())
      {
        this.Groups.Clear();
        this.Groups.AddRange<GroupDescriptor>((IEnumerable<GroupDescriptor>) request.Groups);
      }
      else
        this.Groups.Clear();
      if (request.Filters == null)
        request.Filters = this.Filters;
      else if (request.Filters.Any<IFilterDescriptor>())
      {
        this.Filters.Clear();
        this.Filters.AddRange<IFilterDescriptor>((IEnumerable<IFilterDescriptor>) request.Filters);
      }
      else
        this.Filters.Clear();
      if (!request.Aggregates.Any<AggregateDescriptor>())
        request.Aggregates = this.Aggregates;
      else if (request.Aggregates.Any<AggregateDescriptor>())
      {
        this.MergeAggregateTypes(request);
        this.Aggregates.Clear();
        this.Aggregates.AddRange<AggregateDescriptor>((IEnumerable<AggregateDescriptor>) request.Aggregates);
      }
      else
        this.Aggregates.Clear();
      if (this.Groups.Any<GroupDescriptor>() && this.Aggregates.Any<AggregateDescriptor>() && this.Data == null)
        this.Groups.Each<GroupDescriptor>((Action<GroupDescriptor>) (g => g.AggregateFunctions.AddRange<AggregateFunction>(this.Aggregates.SelectMany<AggregateDescriptor, AggregateFunction>((Func<AggregateDescriptor, IEnumerable<AggregateFunction>>) (a => (IEnumerable<AggregateFunction>) a.Aggregates)))));
      if (this.Data != null)
      {
        if (processData)
        {
          DataSourceResult dataSourceResult = QueryableExtensions.ToDataSourceResult(this.Data.AsQueryable(), request);
          this.Data = dataSourceResult.Data;
          this.Total = dataSourceResult.Total;
          this.AggregateResults = dataSourceResult.AggregateResults;
        }
        else if (this.Data is IGridCustomGroupingWrapper data3)
          this.RawData = this.Data = data3.GroupedEnumerable.AsGenericEnumerable();
      }
      this.Page = request.Page;
      if (this.Total == 0 || this.PageSize == 0)
        this.TotalPages = 1;
      else
        this.TotalPages = (this.Total + this.PageSize - 1) / this.PageSize;
    }

    private void MergeAggregateTypes(DataSourceRequest request)
    {
      if (!this.Aggregates.Any<AggregateDescriptor>())
        return;
      foreach (AggregateDescriptor aggregate in (IEnumerable<AggregateDescriptor>) request.Aggregates)
      {
        AggregateDescriptor requestAggregate = aggregate;
        AggregateDescriptor match = this.Aggregates.SingleOrDefault<AggregateDescriptor>((Func<AggregateDescriptor, bool>) (agg => agg.Member.Equals(requestAggregate.Member, StringComparison.OrdinalIgnoreCase)));
        if (match != null)
          requestAggregate.Aggregates.Each<AggregateFunction>((Action<AggregateFunction>) (function =>
          {
            AggregateFunction aggregateFunction = match.Aggregates.SingleOrDefault<AggregateFunction>((Func<AggregateFunction, bool>) (matchFunction => matchFunction.AggregateMethodName == function.AggregateMethodName));
            if (aggregateFunction == null || !(aggregateFunction.MemberType != (System.Type) null))
              return;
            function.MemberType = aggregateFunction.MemberType;
          }));
      }
    }
  }
}
