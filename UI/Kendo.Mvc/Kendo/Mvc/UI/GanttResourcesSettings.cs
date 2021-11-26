// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GanttResourcesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GanttResourcesSettings
  {
    public string DataFormatField { get; set; }

    public string DataColorField { get; set; }

    public string DataTextField { get; set; }

    public string Field { get; set; }

    public DataSource DataSource { get; set; }

    public GanttResourcesSettings(IModelMetadataProvider modelMetaDataProvider) => this.DataSource = new DataSource(modelMetaDataProvider);

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string dataFormatField = this.DataFormatField;
      if ((dataFormatField != null ? (dataFormatField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataFormatField"] = (object) this.DataFormatField;
      string dataColorField = this.DataColorField;
      if ((dataColorField != null ? (dataColorField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataColorField"] = (object) this.DataColorField;
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTextField"] = (object) this.DataTextField;
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
      if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url) && string.IsNullOrEmpty(this.DataSource.Transport.FunctionRead.HandlerName) && this.DataSource.Transport.CustomRead == null)
      {
        DataSourceType? type = this.DataSource.Type;
        DataSourceType dataSourceType = DataSourceType.Custom;
        if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
        {
          if (this.DataSource.Data != null)
          {
            dictionary["dataSource"] = (object) this.DataSource.Data;
            goto label_13;
          }
          else
            goto label_13;
        }
      }
      dictionary["dataSource"] = (object) this.DataSource.ToJson();
label_13:
      return dictionary;
    }
  }
}
