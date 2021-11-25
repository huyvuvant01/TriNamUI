// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridBoundColumnFilterableSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class GridBoundColumnFilterableSettings : GridFilterableSettings
  {
    public GridBoundColumnFilterableSettings(IModelMetadataProvider modelMetadataProvider)
    {
      this.Enabled = true;
      this.FilterUIHandler = new ClientHandlerDescriptor();
      this.ItemTemplate = new ClientHandlerDescriptor();
      this.CellSettings = new GridColumnFilterableCellSettings(modelMetadataProvider);
      this.DataSource = new DataSource(modelMetadataProvider);
      this.DataSource.Transport.SerializeEmptyPrefix = false;
      this.DataSource.Schema.Data = "";
      this.DataSource.Schema.Total = "";
      this.DataSource.Schema.Errors = "";
    }

    public GridFilterUIRole FilterUIRole { get; set; }

    public ClientHandlerDescriptor FilterUIHandler { get; set; }

    public bool Multi { get; set; }

    public ClientHandlerDescriptor ItemTemplate { get; set; }

    public bool CheckAll { get; set; }

    public bool Search { get; set; }

    public bool? IgnoreCase { get; set; }

    public GridColumnFilterableCellSettings CellSettings { get; }

    public DataSource DataSource { get; set; }

    public string DataSourceId { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      if (this.FilterUIHandler.HasValue())
        json["ui"] = (object) this.FilterUIHandler;
      else if (this.FilterUIRole != GridFilterUIRole.Default)
        json["ui"] = (object) Enum.GetName(typeof (GridFilterUIRole), (object) this.FilterUIRole).ToLowerInvariant();
      IDictionary<string, object> json1 = this.CellSettings.ToJson();
      if (json1.Any<KeyValuePair<string, object>>())
        json["cell"] = (object) json1;
      if (!string.IsNullOrEmpty(this.DataSourceId))
      {
        json["dataSourceId"] = (object) this.DataSourceId;
      }
      else
      {
        if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
        {
          DataSourceType? type = this.DataSource.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue) || this.DataSource.CustomTransport == null)
          {
            if (this.DataSource.Data != null)
            {
              json["dataSource"] = (object) this.DataSource.Data;
              goto label_13;
            }
            else
              goto label_13;
          }
        }
        json["dataSource"] = (object) this.DataSource.ToJson();
      }
label_13:
      if (this.Multi)
        json["multi"] = (object) this.Multi;
      if (this.IgnoreCase.HasValue)
        json["ignoreCase"] = (object) this.IgnoreCase;
      if (this.ItemTemplate.HasValue())
        json["itemTemplate"] = (object) this.ItemTemplate;
      if (!this.CheckAll)
        json["checkAll"] = (object) this.CheckAll;
      if (!this.Search)
        return;
      json["search"] = (object) this.Search;
    }
  }
}
