// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ListBoxSettingsSerializer
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ListBoxSettingsSerializer
  {
    private readonly ListBox listBox;

    public ListBoxSettingsSerializer(ListBox listBox) => this.listBox = listBox;

    public void Serialize(IDictionary<string, object> options)
    {
      DataSourceType? type;
      if (!string.IsNullOrEmpty(this.listBox.DataSourceId))
      {
        options["dataSourceId"] = (object) this.listBox.DataSourceId;
      }
      else
      {
        if (string.IsNullOrEmpty(this.listBox.DataSource.Transport.Read.Url))
        {
          type = this.listBox.DataSource.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
          {
            if (this.listBox.DataSource.Data != null)
            {
              options["dataSource"] = (object) this.listBox.DataSource.Data;
              goto label_7;
            }
            else
              goto label_7;
          }
        }
        options["dataSource"] = (object) this.listBox.DataSource.ToJson();
      }
label_7:
      type = this.listBox.DataSource.Type;
      DataSourceType dataSourceType1 = DataSourceType.Server;
      bool flag = !(type.GetValueOrDefault() == dataSourceType1 & type.HasValue) && this.listBox.AutoBind.GetValueOrDefault(true);
      if (flag)
        return;
      options["autoBind"] = (object) flag;
    }
  }
}
