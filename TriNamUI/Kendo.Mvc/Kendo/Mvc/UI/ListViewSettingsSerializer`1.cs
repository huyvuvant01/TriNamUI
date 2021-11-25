// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ListViewSettingsSerializer`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ListViewSettingsSerializer<T> where T : class
  {
    private readonly ListView<T> listView;

    public ListViewSettingsSerializer(ListView<T> listView) => this.listView = listView;

    public void Serialize(IDictionary<string, object> options)
    {
      if (this.listView.DataSourceId.HasValue())
        options["dataSourceId"] = (object) this.listView.DataSourceId;
      else
        options["dataSource"] = (object) this.listView.DataSource.ToJson();
      DataSourceType? type = this.listView.DataSource.Type;
      DataSourceType dataSourceType = DataSourceType.Server;
      bool flag = !(type.GetValueOrDefault() == dataSourceType & type.HasValue) && this.listView.AutoBind.GetValueOrDefault(true);
      if (!flag)
      {
        options["autoBind"] = (object) flag;
        this.listView.Pageable.AutoBind = flag;
      }
      this.SerializeClientTemplate(options);
      this.SerializePaging(options);
      this.SerializeSelection(options);
      this.SerializeScrollable(options);
      this.SerializeEditTemplate(options);
    }

    private void SerializePaging(IDictionary<string, object> options)
    {
      if (!this.listView.Pageable.Enabled)
        return;
      ListView<T> listView = this.listView;
      DataSourceType? type = this.listView.DataSource.Type;
      DataSourceType dataSourceType = DataSourceType.Server;
      bool? autoBind;
      int num1;
      if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
      {
        autoBind = this.listView.AutoBind;
        num1 = autoBind.GetValueOrDefault(true) ? 1 : 0;
      }
      else
        num1 = 0;
      bool? nullable = new bool?(num1 != 0);
      listView.AutoBind = nullable;
      PageableSettings pageable = this.listView.Pageable;
      autoBind = this.listView.AutoBind;
      int num2 = autoBind.Value ? 1 : 0;
      pageable.AutoBind = num2 != 0;
      IDictionary<string, object> json = this.listView.Pageable.ToJson();
      json.Add("pagerId", (object) (this.listView.Id + "_pager"));
      options["pageable"] = (object) json;
    }

    private void SerializeEditTemplate(IDictionary<string, object> options)
    {
      if (!this.listView.Editable.Enabled || string.IsNullOrEmpty(this.listView.EditorHtml))
        return;
      string str = this.listView.EditorHtml.Trim().EscapeHtmlEntities().Replace("\r\n", string.Empty).Replace("#", "\\#").Replace("jQuery(\"#", "jQuery(\"\\#");
      options["editTemplate"] = (object) str;
    }

    private void SerializeClientTemplate(IDictionary<string, object> options)
    {
      string str = "#";
      if (this.listView.IsInClientTemplate)
        str = "\\" + str;
      if (!string.IsNullOrEmpty(this.listView.ClientTemplateId))
        options["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.listView.ClientTemplateId)
        };
      if (string.IsNullOrEmpty(this.listView.ClientAltTemplateId))
        return;
      options["altTemplate"] = (object) new ClientHandlerDescriptor()
      {
        HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.listView.ClientAltTemplateId)
      };
    }

    private void SerializeSelection(IDictionary<string, object> options)
    {
      bool? enabled = this.listView.Selectable.Enabled;
      bool flag = true;
      if (!(enabled.GetValueOrDefault() == flag & enabled.HasValue))
        return;
      string str = "single";
      ListViewSelectionMode? mode = this.listView.Selectable.Mode;
      if (mode.HasValue)
      {
        mode = this.listView.Selectable.Mode;
        str = mode.Value.Serialize();
      }
      options["selectable"] = (object) str;
    }

    private void SerializeScrollable(IDictionary<string, object> options)
    {
      if (this.listView.Scrollable.Enabled)
      {
        options["scrollable"] = (object) true;
      }
      else
      {
        if (string.IsNullOrEmpty(this.listView.Scrollable.Mode.ToString()))
          return;
        options["scrollable"] = (object) this.listView.Scrollable.Mode.ToString().ToLower();
      }
    }
  }
}
