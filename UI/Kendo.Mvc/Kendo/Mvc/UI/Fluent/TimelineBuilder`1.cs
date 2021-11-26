// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TimelineBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TimelineBuilder<T> : WidgetBuilderBase<Timeline<T>, TimelineBuilder<T>>
    where T : class
  {
    public TimelineBuilder(Timeline<T> component)
      : base(component)
    {
    }

    public TimelineBuilder<T> EventTemplate(string value)
    {
      this.Container.EventTemplate = value;
      return this;
    }

    public TimelineBuilder<T> EventTemplateId(string templateId)
    {
      this.Container.EventTemplateId = templateId;
      return this;
    }

    public TimelineBuilder<T> DataSource(
      Action<TimelineReadOnlyDataSourceBuilder> configurator)
    {
      configurator(new TimelineReadOnlyDataSourceBuilder(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public TimelineBuilder<T> DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public TimelineBuilder<T> AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public TimelineBuilder<T> AlternatingMode(bool value)
    {
      this.Container.AlternatingMode = new bool?(value);
      return this;
    }

    public TimelineBuilder<T> AlternatingMode()
    {
      this.Container.AlternatingMode = new bool?(true);
      return this;
    }

    public TimelineBuilder<T> CollapsibleEvents(bool value)
    {
      this.Container.CollapsibleEvents = new bool?(value);
      return this;
    }

    public TimelineBuilder<T> CollapsibleEvents()
    {
      this.Container.CollapsibleEvents = new bool?(true);
      return this;
    }

    public TimelineBuilder<T> DataActionsField(string value)
    {
      this.Container.DataActionsField = value;
      return this;
    }

    public TimelineBuilder<T> DataDescriptionField(string value)
    {
      this.Container.DataDescriptionField = value;
      return this;
    }

    public TimelineBuilder<T> DataDateField(string value)
    {
      this.Container.DataDateField = value;
      return this;
    }

    public TimelineBuilder<T> DataImagesAltField(string value)
    {
      this.Container.DataImagesAltField = value;
      return this;
    }

    public TimelineBuilder<T> DataImagesField(string value)
    {
      this.Container.DataImagesField = value;
      return this;
    }

    public TimelineBuilder<T> DataSubtitleField(string value)
    {
      this.Container.DataSubtitleField = value;
      return this;
    }

    public TimelineBuilder<T> DataTitleField(string value)
    {
      this.Container.DataTitleField = value;
      return this;
    }

    public TimelineBuilder<T> DateFormat(string value)
    {
      this.Container.DateFormat = value;
      return this;
    }

    public TimelineBuilder<T> EventHeight(double value)
    {
      this.Container.EventHeight = new double?(value);
      return this;
    }

    public TimelineBuilder<T> EventWidth(double value)
    {
      this.Container.EventWidth = new double?(value);
      return this;
    }

    public TimelineBuilder<T> Navigatable(bool value)
    {
      this.Container.Navigatable = new bool?(value);
      return this;
    }

    public TimelineBuilder<T> Navigatable()
    {
      this.Container.Navigatable = new bool?(true);
      return this;
    }

    public TimelineBuilder<T> ShowDateLabels(bool value)
    {
      this.Container.ShowDateLabels = new bool?(value);
      return this;
    }

    public TimelineBuilder<T> Orientation(TimelineOrientation value)
    {
      this.Container.Orientation = new TimelineOrientation?(value);
      return this;
    }

    public TimelineBuilder<T> Events(Action<TimelineEventBuilder> configurator)
    {
      configurator(new TimelineEventBuilder(this.Container.Events));
      return this;
    }
  }
}
