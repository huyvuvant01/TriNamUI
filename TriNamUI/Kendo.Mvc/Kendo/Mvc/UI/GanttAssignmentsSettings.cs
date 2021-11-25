// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GanttAssignmentsSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GanttAssignmentsSettings
  {
    public IModelMetadataProvider ModelMetaDataProvider;

    public string DataResourceIdField { get; set; }

    public string DataTaskIdField { get; set; }

    public string DataValueField { get; set; }

    public DataSource DataSource { get; set; }

    public GanttAssignmentsSettings(IModelMetadataProvider modelMetaDataProvider)
    {
      this.ModelMetaDataProvider = modelMetaDataProvider;
      this.DataSource = new DataSource(modelMetaDataProvider);
      this.DataSource.Type = new DataSourceType?(DataSourceType.Ajax);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string dataResourceIdField = this.DataResourceIdField;
      if ((dataResourceIdField != null ? (dataResourceIdField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataResourceIdField"] = (object) this.DataResourceIdField;
      string dataTaskIdField = this.DataTaskIdField;
      if ((dataTaskIdField != null ? (dataTaskIdField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTaskIdField"] = (object) this.DataTaskIdField;
      string dataValueField = this.DataValueField;
      if ((dataValueField != null ? (dataValueField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataValueField"] = (object) this.DataValueField;
      if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url) && string.IsNullOrEmpty(this.DataSource.Transport.FunctionRead.HandlerName) && this.DataSource.Transport.CustomRead == null)
      {
        DataSourceType? type = this.DataSource.Type;
        DataSourceType dataSourceType = DataSourceType.Custom;
        if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
        {
          if (this.DataSource.Data != null)
          {
            dictionary["dataSource"] = (object) this.DataSource.Data;
            goto label_11;
          }
          else
            goto label_11;
        }
      }
      dictionary["dataSource"] = (object) this.DataSource.ToJson();
label_11:
      return dictionary;
    }
  }
}
