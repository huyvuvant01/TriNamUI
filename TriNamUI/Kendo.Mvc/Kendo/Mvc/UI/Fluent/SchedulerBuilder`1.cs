// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerBuilder<T> : WidgetBuilderBase<Scheduler<T>, SchedulerBuilder<T>>
    where T : class, ISchedulerEvent
  {
    public SchedulerBuilder(Scheduler<T> component)
      : base(component)
    {
    }

    public SchedulerBuilder<T> StartTime(int hours, int minutes, int seconds)
    {
      DateTime today = DateTime.Today;
      this.Container.StartTime = new DateTime?(new DateTime(today.Year, today.Month, today.Day, hours, minutes, seconds));
      return this;
    }

    public SchedulerBuilder<T> EndTime(int hours, int minutes, int seconds)
    {
      DateTime today = DateTime.Today;
      this.Container.EndTime = new DateTime?(new DateTime(today.Year, today.Month, today.Day, hours, minutes, seconds));
      return this;
    }

    public SchedulerBuilder<T> WorkDayStart(int hours, int minutes, int seconds)
    {
      DateTime today = DateTime.Today;
      this.Component.WorkDayStart = new DateTime?(new DateTime(today.Year, today.Month, today.Day, hours, minutes, seconds));
      return this;
    }

    public SchedulerBuilder<T> WorkDays(int[] workDays)
    {
      this.Component.WorkDays = workDays;
      return this;
    }

    public SchedulerBuilder<T> WorkDayEnd(int hours, int minutes, int seconds)
    {
      DateTime today = DateTime.Today;
      this.Component.WorkDayEnd = new DateTime?(new DateTime(today.Year, today.Month, today.Day, hours, minutes, seconds));
      return this;
    }

    public SchedulerBuilder<T> BindTo(IEnumerable<T> dataSource)
    {
      this.Component.DataSource.Data = (IEnumerable) dataSource;
      return this;
    }

    public SchedulerBuilder<T> DataSource(
      Action<SchedulerAjaxDataSourceBuilder<T>> configurator)
    {
      configurator(new SchedulerAjaxDataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public SchedulerBuilder<T> Toolbar(
      Action<SchedulerToolbarFactory<T>> addToolbarAction)
    {
      SchedulerToolbarFactory<T> schedulerToolbarFactory = new SchedulerToolbarFactory<T>(this.Component);
      addToolbarAction(schedulerToolbarFactory);
      return this;
    }

    public SchedulerBuilder<T> Mobile()
    {
      this.Container.Mobile = new MobileMode?(MobileMode.Auto);
      return this;
    }

    public SchedulerBuilder<T> Editable(
      Action<SchedulerEditableSettingsBuilder<T>> configurator)
    {
      configurator(new SchedulerEditableSettingsBuilder<T>(this.Component.Editable));
      return this;
    }

    public SchedulerBuilder<T> Editable(bool isEditable)
    {
      this.Component.Editable.Enabled = isEditable;
      return this;
    }

    public SchedulerBuilder<T> Group(Action<SchedulerGroupBuilder> configuration)
    {
      SchedulerGroupBuilder schedulerGroupBuilder = new SchedulerGroupBuilder(this.Component.Group);
      configuration(schedulerGroupBuilder);
      return this;
    }

    public SchedulerBuilder<T> Resources(
      Action<SchedulerResourceFactory<T>> addResourceAction)
    {
      SchedulerResourceFactory<T> schedulerResourceFactory = new SchedulerResourceFactory<T>(this.Component);
      addResourceAction(schedulerResourceFactory);
      return this;
    }

    public SchedulerBuilder<T> Views(Action<SchedulerViewFactory<T>> addViewAction)
    {
      SchedulerViewFactory<T> schedulerViewFactory = new SchedulerViewFactory<T>(this.Component);
      addViewAction(schedulerViewFactory);
      return this;
    }

    public SchedulerBuilder<T> AllDayEventTemplate(string value)
    {
      this.Container.AllDayEventTemplate = value;
      return this;
    }

    public SchedulerBuilder<T> AllDayEventTemplateId(string templateId)
    {
      this.Container.AllDayEventTemplateId = templateId;
      return this;
    }

    public SchedulerBuilder<T> AllDaySlot(bool value)
    {
      this.Container.AllDaySlot = new bool?(value);
      return this;
    }

    public SchedulerBuilder<T> AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public SchedulerBuilder<T> CurrentTimeMarker(
      Action<SchedulerCurrentTimeMarkerSettingsBuilder<T>> configurator)
    {
      this.Container.CurrentTimeMarker.Enabled = new bool?(true);
      this.Container.CurrentTimeMarker.Scheduler = this.Container;
      configurator(new SchedulerCurrentTimeMarkerSettingsBuilder<T>(this.Container.CurrentTimeMarker));
      return this;
    }

    public SchedulerBuilder<T> CurrentTimeMarker(bool enabled)
    {
      this.Container.CurrentTimeMarker.Enabled = new bool?(enabled);
      return this;
    }

    public SchedulerBuilder<T> Date(DateTime value)
    {
      this.Container.Date = new DateTime?(value);
      return this;
    }

    public SchedulerBuilder<T> DateHeaderTemplate(string value)
    {
      this.Container.DateHeaderTemplate = value;
      return this;
    }

    public SchedulerBuilder<T> DateHeaderTemplateId(string templateId)
    {
      this.Container.DateHeaderTemplateId = templateId;
      return this;
    }

    public SchedulerBuilder<T> EndTime(DateTime value)
    {
      this.Container.EndTime = new DateTime?(value);
      return this;
    }

    public SchedulerBuilder<T> EventTemplate(string value)
    {
      this.Container.EventTemplate = value;
      return this;
    }

    public SchedulerBuilder<T> EventTemplateId(string templateId)
    {
      this.Container.EventTemplateId = templateId;
      return this;
    }

    public SchedulerBuilder<T> Footer(
      Action<SchedulerFooterSettingsBuilder<T>> configurator)
    {
      this.Container.Footer.Enabled = new bool?(true);
      this.Container.Footer.Scheduler = this.Container;
      configurator(new SchedulerFooterSettingsBuilder<T>(this.Container.Footer));
      return this;
    }

    public SchedulerBuilder<T> Footer(bool enabled)
    {
      this.Container.Footer.Enabled = new bool?(enabled);
      return this;
    }

    public SchedulerBuilder<T> GroupHeaderTemplate(string value)
    {
      this.Container.GroupHeaderTemplate = value;
      return this;
    }

    public SchedulerBuilder<T> GroupHeaderTemplateId(string templateId)
    {
      this.Container.GroupHeaderTemplateId = templateId;
      return this;
    }

    public SchedulerBuilder<T> Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public SchedulerBuilder<T> MajorTick(int value)
    {
      this.Container.MajorTick = new int?(value);
      return this;
    }

    public SchedulerBuilder<T> MajorTimeHeaderTemplate(string value)
    {
      this.Container.MajorTimeHeaderTemplate = value;
      return this;
    }

    public SchedulerBuilder<T> MajorTimeHeaderTemplateId(string templateId)
    {
      this.Container.MajorTimeHeaderTemplateId = templateId;
      return this;
    }

    public SchedulerBuilder<T> Max(DateTime value)
    {
      this.Container.Max = new DateTime?(value);
      return this;
    }

    public SchedulerBuilder<T> Messages(
      Action<SchedulerMessagesSettingsBuilder<T>> configurator)
    {
      this.Container.Messages.Scheduler = this.Container;
      configurator(new SchedulerMessagesSettingsBuilder<T>(this.Container.Messages));
      return this;
    }

    public SchedulerBuilder<T> Min(DateTime value)
    {
      this.Container.Min = new DateTime?(value);
      return this;
    }

    public SchedulerBuilder<T> MinorTickCount(int value)
    {
      this.Container.MinorTickCount = new int?(value);
      return this;
    }

    public SchedulerBuilder<T> MinorTimeHeaderTemplate(string value)
    {
      this.Container.MinorTimeHeaderTemplate = value;
      return this;
    }

    public SchedulerBuilder<T> MinorTimeHeaderTemplateId(string templateId)
    {
      this.Container.MinorTimeHeaderTemplateId = templateId;
      return this;
    }

    public SchedulerBuilder<T> Pdf(
      Action<SchedulerPdfSettingsBuilder<T>> configurator)
    {
      this.Container.Pdf.Scheduler = this.Container;
      configurator(new SchedulerPdfSettingsBuilder<T>(this.Container.Pdf));
      return this;
    }

    public SchedulerBuilder<T> Selectable(bool value)
    {
      this.Container.Selectable = new bool?(value);
      return this;
    }

    public SchedulerBuilder<T> Selectable()
    {
      this.Container.Selectable = new bool?(true);
      return this;
    }

    public SchedulerBuilder<T> ShowWorkHours(bool value)
    {
      this.Container.ShowWorkHours = new bool?(value);
      return this;
    }

    public SchedulerBuilder<T> ShowWorkHours()
    {
      this.Container.ShowWorkHours = new bool?(true);
      return this;
    }

    public SchedulerBuilder<T> Snap(bool value)
    {
      this.Container.Snap = new bool?(value);
      return this;
    }

    public SchedulerBuilder<T> StartTime(DateTime value)
    {
      this.Container.StartTime = new DateTime?(value);
      return this;
    }

    public SchedulerBuilder<T> Timezone(string value)
    {
      this.Container.Timezone = value;
      return this;
    }

    public SchedulerBuilder<T> Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public SchedulerBuilder<T> WorkDayStart(DateTime value)
    {
      this.Container.WorkDayStart = new DateTime?(value);
      return this;
    }

    public SchedulerBuilder<T> WorkDayEnd(DateTime value)
    {
      this.Container.WorkDayEnd = new DateTime?(value);
      return this;
    }

    public SchedulerBuilder<T> WorkWeekStart(int value)
    {
      this.Container.WorkWeekStart = new int?(value);
      return this;
    }

    public SchedulerBuilder<T> WorkWeekEnd(int value)
    {
      this.Container.WorkWeekEnd = new int?(value);
      return this;
    }

    public SchedulerBuilder<T> Mobile(MobileMode value)
    {
      this.Container.Mobile = new MobileMode?(value);
      return this;
    }

    public SchedulerBuilder<T> Events(Action<SchedulerEventBuilder> configurator)
    {
      configurator(new SchedulerEventBuilder(this.Container.Events));
      return this;
    }
  }
}
