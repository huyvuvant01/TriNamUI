// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.OrgChartBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class OrgChartBuilder<T> : WidgetBuilderBase<OrgChart<T>, OrgChartBuilder<T>>
    where T : class
  {
    public OrgChartBuilder(OrgChart<T> component)
      : base(component)
    {
    }

    public OrgChartBuilder<T> CardsColors(string[] value)
    {
      this.Container.CardsColors = value;
      return this;
    }

    public OrgChartBuilder<T> DataSource(
      Action<OrgChartAjaxDataSourceBuilder<T>> configurator)
    {
      configurator(new OrgChartAjaxDataSourceBuilder<T>(this.Container.DataSource, this.Container.ViewContext, this.Container.UrlGenerator));
      return this;
    }

    public OrgChartBuilder<T> DataSource(string dataSourceId)
    {
      this.Container.DataSourceId = dataSourceId;
      return this;
    }

    public OrgChartBuilder<T> BindTo(IEnumerable data)
    {
      this.Container.DataSource.Data = data;
      return this;
    }

    public OrgChartBuilder<T> BindTo(IEnumerable<T> data)
    {
      this.Container.DataSource.Data = (IEnumerable) data;
      return this;
    }

    public OrgChartBuilder<T> Editable(
      Action<OrgChartEditableSettingsBuilder<T>> configurator)
    {
      this.Container.Editable.Enabled = new bool?(true);
      this.Container.Editable.OrgChart = this.Container;
      configurator(new OrgChartEditableSettingsBuilder<T>(this.Container.Editable));
      return this;
    }

    public OrgChartBuilder<T> Editable(bool enabled)
    {
      this.Container.Editable.Enabled = new bool?(enabled);
      return this;
    }

    public OrgChartBuilder<T> GroupField(string value)
    {
      this.Container.GroupField = value;
      return this;
    }

    public OrgChartBuilder<T> GroupHeaderTemplate(string value)
    {
      this.Container.GroupHeaderTemplate = value;
      return this;
    }

    public OrgChartBuilder<T> GroupHeaderTemplateId(string templateId)
    {
      this.Container.GroupHeaderTemplateId = templateId;
      return this;
    }

    public OrgChartBuilder<T> Messages(
      Action<OrgChartMessagesSettingsBuilder<T>> configurator)
    {
      this.Container.Messages.OrgChart = this.Container;
      configurator(new OrgChartMessagesSettingsBuilder<T>(this.Container.Messages));
      return this;
    }

    public OrgChartBuilder<T> Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public OrgChartBuilder<T> TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public OrgChartBuilder<T> Events(Action<OrgChartEventBuilder> configurator)
    {
      configurator(new OrgChartEventBuilder(this.Container.Events));
      return this;
    }
  }
}
