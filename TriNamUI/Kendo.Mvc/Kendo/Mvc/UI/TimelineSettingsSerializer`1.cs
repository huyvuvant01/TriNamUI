// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TimelineSettingsSerializer`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class TimelineSettingsSerializer<T> where T : class
  {
    private readonly Timeline<T> timeline;

    public TimelineSettingsSerializer(Timeline<T> timeline) => this.timeline = timeline;

    public void Serialize(IDictionary<string, object> options)
    {
      DataSourceType? type;
      if (!string.IsNullOrEmpty(this.timeline.DataSourceId))
      {
        options["dataSourceId"] = (object) this.timeline.DataSourceId;
      }
      else
      {
        if (string.IsNullOrEmpty(this.timeline.DataSource.Transport.Read.Url))
        {
          type = this.timeline.DataSource.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
          {
            if (this.timeline.DataSource.Data != null)
            {
              options["dataSource"] = (object) this.timeline.DataSource.Data;
              goto label_7;
            }
            else
              goto label_7;
          }
        }
        options["dataSource"] = (object) this.timeline.DataSource.ToJson();
      }
label_7:
      type = this.timeline.DataSource.Type;
      DataSourceType dataSourceType1 = DataSourceType.Server;
      bool flag = !(type.GetValueOrDefault() == dataSourceType1 & type.HasValue) && this.timeline.AutoBind.GetValueOrDefault(true);
      if (!flag)
        options["autoBind"] = (object) flag;
      this.SerializeClientTemplate(options);
    }

    private void SerializeClientTemplate(IDictionary<string, object> options)
    {
      string str = "#";
      if (!string.IsNullOrEmpty(this.timeline.EventTemplateId))
      {
        options["eventTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.timeline.EventTemplateId)
        };
      }
      else
      {
        if (string.IsNullOrEmpty(this.timeline.EventTemplate))
          return;
        options["eventTemplate"] = (object) this.timeline.EventTemplate;
      }
    }
  }
}
