// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-datasource")]
  [HtmlTargetElement("datasource", ParentTag = "kendo-grid")]
  [HtmlTargetElement("datasource", ParentTag = "kendo-chart")]
  [HtmlTargetElement("datasource", ParentTag = "kendo-combobox")]
  [HtmlTargetElement("datasource", ParentTag = "combobox-editor")]
  [HtmlTargetElement("datasource", ParentTag = "kendo-multicolumncombobox")]
  [HtmlTargetElement("datasource", ParentTag = "multicolumncombobox-editor")]
  [HtmlTargetElement("datasource", ParentTag = "kendo-autocomplete")]
  [HtmlTargetElement("datasource", ParentTag = "autocomplete-editor")]
  [HtmlTargetElement("datasource", ParentTag = "kendo-dropdownlist")]
  [HtmlTargetElement("datasource", ParentTag = "dropdownlist-editor")]
  [HtmlTargetElement("datasource", ParentTag = "kendo-multiselect")]
  [HtmlTargetElement("datasource", ParentTag = "multiselect-editor")]
  [HtmlTargetElement("datasource", ParentTag = "kendo-listbox")]
  [HtmlTargetElement("datasource", ParentTag = "sheet")]
  [HtmlTargetElement("datasource", ParentTag = "layer")]
  [HtmlTargetElement("datasource", ParentTag = "resource")]
  [HtmlTargetElement("datasource", ParentTag = "resources")]
  [HtmlTargetElement("datasource", ParentTag = "assignments")]
  [HtmlTargetElement("datasource", ParentTag = "kendo-scrollview")]
  [HtmlTargetElement("datasource", ParentTag = "kendo-timeline")]
  [HtmlTargetElement("datasource", ParentTag = "kendo-taskboard")]
  [HtmlTargetElement("datasource", ParentTag = "taskboard-columns")]
  [HtmlTargetElement("datasource", ParentTag = "foreign-key-column")]
  [RestrictChildren("aggregates", new string[] {"filters", "groups", "schema", "sorts", "transport"})]
  public class DataSourceTagHelper : TagHelperBase
  {
    public 
    #nullable disable
    string CustomType { get; set; }

    public DataSourceTagHelperType? Type { get; set; }

    public bool? ServerOperation { get; set; }

    protected bool IsNested { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceAggregatesTagHelper Aggregate { get; set; }

    public bool? AutoSync { get; set; }

    public bool? Batch { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceFiltersTagHelper Filter { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceGroupsTagHelper Group { get; set; }

    public bool? InPlaceSort { get; set; }

    public bool? GroupPaging { get; set; }

    public string OfflineStorage { get; set; }

    public double? Page { get; set; }

    public double? PageSize { get; set; }

    public string AccentFoldingFiltering { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceSchemaSettingsTagHelper Schema { get; set; }

    public bool? ServerAggregates { get; set; }

    public bool? ServerFiltering { get; set; }

    public bool? ServerGrouping { get; set; }

    public bool? ServerPaging { get; set; }

    public bool? ServerSorting { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceSortsTagHelper Sort { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceTransportSettingsTagHelper Transport { get; set; }

    public DataSourceTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    protected virtual void SetDataSource(object item)
    {
      if (!(item is IDataBoundWidget<DataSourceTagHelper>) || (item as IDataBoundWidget<DataSourceTagHelper>).Datasource != null)
        return;
      (item as IDataBoundWidget<DataSourceTagHelper>).Datasource = this;
      this.IsNested = true;
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DataSourceTagHelper dataSourceTagHelper = this;
      foreach (KeyValuePair<object, object> keyValuePair in context.Items.Reverse<KeyValuePair<object, object>>())
      {
        dataSourceTagHelper.SetDataSource(keyValuePair.Value);
        if (dataSourceTagHelper.IsNested)
          break;
      }
      dataSourceTagHelper.AddSelfToContext(context);
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      dataSourceTagHelper.SetDefaults();
      if (dataSourceTagHelper.IsNested)
      {
        output.SuppressOutput();
      }
      else
      {
        if (!dataSourceTagHelper.Name.HasValue() && !dataSourceTagHelper.Id.HasValue())
          return;
        // ISSUE: reference to a compiler-generated method
        await dataSourceTagHelper.\u003C\u003En__0(context, output);
      }
    }

    protected virtual void AddSelfToContext(TagHelperContext context) => context.Items[(object) this.GetType()] = (object) this;

    protected override void WriteHtml(TagHelperOutput output) => output.SuppressOutput();

    protected void SetDefaults()
    {
      DataSourceTagHelperType? type1 = this.Type;
      DataSourceTagHelperType sourceTagHelperType1 = DataSourceTagHelperType.Ajax;
      if (!(type1.GetValueOrDefault() == sourceTagHelperType1 & type1.HasValue))
      {
        DataSourceTagHelperType? type2 = this.Type;
        DataSourceTagHelperType sourceTagHelperType2 = DataSourceTagHelperType.WebApi;
        if (!(type2.GetValueOrDefault() == sourceTagHelperType2 & type2.HasValue))
          goto label_22;
      }
      if (this.Schema == null)
        this.Schema = new DataSourceSchemaSettingsTagHelper();
      if (this.ServerOperation.HasValue)
      {
        bool? serverOperation = this.ServerOperation;
        bool flag = true;
        if (!(serverOperation.GetValueOrDefault() == flag & serverOperation.HasValue))
          goto label_16;
      }
      if (!this.ServerAggregates.HasValue)
        this.ServerAggregates = new bool?(true);
      if (!this.ServerFiltering.HasValue)
        this.ServerFiltering = new bool?(true);
      if (!this.ServerGrouping.HasValue)
        this.ServerGrouping = new bool?(true);
      if (!this.ServerSorting.HasValue)
        this.ServerSorting = new bool?(true);
      if (!this.ServerPaging.HasValue)
        this.ServerPaging = new bool?(true);
label_16:
      this.Schema.Data = this.Schema.Data.HasValue() ? this.Schema.Data : "Data";
      this.Schema.Errors = this.Schema.Errors.HasValue() ? this.Schema.Errors : "Errors";
      this.Schema.Total = this.Schema.Total.HasValue() ? this.Schema.Total : "Total";
      double? nullable = this.Page;
      if (!nullable.HasValue)
      {
        bool? serverPaging = this.ServerPaging;
        bool flag = true;
        if (serverPaging.GetValueOrDefault() == flag & serverPaging.HasValue)
          this.Page = new double?(1.0);
      }
      nullable = this.PageSize;
      if (!nullable.HasValue)
      {
        bool? serverPaging = this.ServerPaging;
        bool flag = true;
        if (serverPaging.GetValueOrDefault() == flag & serverPaging.HasValue)
          this.PageSize = new double?(20.0);
      }
label_22:
      DataSourceTagHelperType? type3 = this.Type;
      DataSourceTagHelperType sourceTagHelperType3 = DataSourceTagHelperType.WebApi;
      if (!(type3.GetValueOrDefault() == sourceTagHelperType3 & type3.HasValue) || this.Schema.Model == null || this.Schema.Model.Id == null)
        return;
      this.Transport.IdField = this.Schema.Model.Id;
    }

    protected override string GetInitializationScript() => this.Name + " = new kendo.data.DataSource(" + this.Initializer.Serialize((IDictionary<string, object>) this.Serialize()) + ");";

    internal virtual Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Aggregate != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Aggregate.Select<DataSourceAggregateTagHelper, Dictionary<string, object>>((Func<DataSourceAggregateTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["aggregate"] = (object) source;
      }
      if (this.AutoSync.HasValue)
        dictionary["autoSync"] = (object) this.AutoSync;
      if (this.Batch.HasValue)
        dictionary["batch"] = (object) this.Batch;
      if (this.Filter != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Filter.Select<DataSourceFilterTagHelper, Dictionary<string, object>>((Func<DataSourceFilterTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["filter"] = (object) source;
      }
      if (this.Group != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Group.Select<DataSourceGroupTagHelper, Dictionary<string, object>>((Func<DataSourceGroupTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["group"] = (object) source;
      }
      if (this.GroupPaging.HasValue)
        dictionary["groupPaging"] = (object) this.GroupPaging;
      if (this.InPlaceSort.HasValue)
        dictionary["inPlaceSort"] = (object) this.InPlaceSort;
      string offlineStorage = this.OfflineStorage;
      if ((offlineStorage != null ? (offlineStorage.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["offlineStorage"] = (object) this.OfflineStorage;
      if (!string.IsNullOrEmpty(this.AccentFoldingFiltering))
        dictionary["accentFoldingFiltering"] = (object) this.AccentFoldingFiltering;
      if (this.Page.HasValue)
        dictionary["page"] = (object) this.Page;
      if (this.PageSize.HasValue)
        dictionary["pageSize"] = (object) this.PageSize;
      if (this.Schema != null)
      {
        Dictionary<string, object> source = this.Schema.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["schema"] = (object) source;
      }
      if (this.ServerAggregates.HasValue)
        dictionary["serverAggregates"] = (object) this.ServerAggregates;
      if (this.ServerFiltering.HasValue)
        dictionary["serverFiltering"] = (object) this.ServerFiltering;
      if (this.ServerGrouping.HasValue)
        dictionary["serverGrouping"] = (object) this.ServerGrouping;
      if (this.ServerPaging.HasValue)
        dictionary["serverPaging"] = (object) this.ServerPaging;
      if (this.ServerSorting.HasValue)
        dictionary["serverSorting"] = (object) this.ServerSorting;
      if (this.Sort != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Sort.Select<DataSourceSortTagHelper, Dictionary<string, object>>((Func<DataSourceSortTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["sort"] = (object) source;
      }
      if (this.Transport != null)
      {
        Dictionary<string, object> source = this.Transport.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["transport"] = (object) source;
      }
      if (this.Type.HasValue)
      {
        DataSourceTagHelperType? type = this.Type;
        DataSourceTagHelperType sourceTagHelperType1 = DataSourceTagHelperType.Ajax;
        if (type.GetValueOrDefault() == sourceTagHelperType1 & type.HasValue)
        {
          dictionary["type"] = (object) new ClientHandlerDescriptor()
          {
            HandlerName = this.GenerateTypeFunction(true)
          };
        }
        else
        {
          type = this.Type;
          DataSourceTagHelperType sourceTagHelperType2 = DataSourceTagHelperType.Custom;
          if (type.GetValueOrDefault() == sourceTagHelperType2 & type.HasValue)
          {
            if (!string.IsNullOrEmpty(this.CustomType))
              dictionary["type"] = (object) this.CustomType;
          }
          else
            dictionary["type"] = (object) new ClientHandlerDescriptor()
            {
              HandlerName = this.GenerateTypeFunction(false)
            };
        }
      }
      else if (!string.IsNullOrEmpty(this.CustomType))
        dictionary["type"] = (object) this.CustomType;
      return dictionary;
    }

    private string GenerateTypeFunction(bool isAspNetMvc)
    {
      string format = "(function(){{if(kendo.data.transports['{0}{1}']){{return '{0}{1}';}} else{{throw new Error('The kendo.aspnetmvc.min.js script is not included.');}}}})()";
      return isAspNetMvc ? string.Format(format, (object) "aspnetmvc-", (object) this.Type.ToString().ToLower()) : string.Format(format, (object) "", (object) this.Type.ToString().ToLower());
    }

    public string OnChange { get; set; }

    public string OnError { get; set; }

    public string OnPush { get; set; }

    public string OnRequestEnd { get; set; }

    public string OnRequestStart { get; set; }

    public string OnSync { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onError = this.OnError;
      if ((onError != null ? (onError.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.CreateHandler(this.OnError);
      string onPush = this.OnPush;
      if ((onPush != null ? (onPush.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["push"] = (object) this.CreateHandler(this.OnPush);
      string onRequestEnd = this.OnRequestEnd;
      if ((onRequestEnd != null ? (onRequestEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["requestEnd"] = (object) this.CreateHandler(this.OnRequestEnd);
      string onRequestStart = this.OnRequestStart;
      if ((onRequestStart != null ? (onRequestStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["requestStart"] = (object) this.CreateHandler(this.OnRequestStart);
      string onSync = this.OnSync;
      if ((onSync != null ? (onSync.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["sync"] = (object) this.CreateHandler(this.OnSync);
      return dictionary;
    }
  }
}
