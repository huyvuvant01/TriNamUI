// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerBaseViewBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerBaseViewBuilder<TView, TViewBuilder>
    where TView : class, ISchedulerView
    where TViewBuilder : SchedulerBaseViewBuilder<TView, TViewBuilder>
  {
    protected readonly TView view;

    public SchedulerBaseViewBuilder(TView view) => this.view = view;

    public TViewBuilder Title(string title)
    {
      this.view.Title = title;
      return (TViewBuilder) this;
    }

    public TViewBuilder Editable(
      Action<SchedulerViewEditableSettingsBuilder> configurator)
    {
      this.view.Editable = new SchedulerViewEditableSettings();
      configurator(new SchedulerViewEditableSettingsBuilder(this.view.Editable));
      return (TViewBuilder) this;
    }

    public TViewBuilder Editable(bool isEditable)
    {
      this.view.Editable = new SchedulerViewEditableSettings();
      this.view.Editable.Enabled = isEditable;
      return (TViewBuilder) this;
    }

    public TViewBuilder EventTemplate(string eventTemplate)
    {
      this.view.EventTemplate = eventTemplate;
      return (TViewBuilder) this;
    }

    public TViewBuilder EventTemplateId(string eventTemplateId)
    {
      this.view.EventTemplateId = eventTemplateId;
      return (TViewBuilder) this;
    }

    public TViewBuilder SelectedDateFormat(string selectedDateFormat)
    {
      this.view.SelectedDateFormat = selectedDateFormat;
      return (TViewBuilder) this;
    }

    public TViewBuilder SelectedShortDateFormat(string selectedShortDateFormat)
    {
      this.view.SelectedShortDateFormat = selectedShortDateFormat;
      return (TViewBuilder) this;
    }

    public TViewBuilder Selected(bool isSelected)
    {
      this.view.Selected = isSelected;
      return (TViewBuilder) this;
    }

    public TViewBuilder Groups(SchedulerGroupOrientation orientation)
    {
      this.view.Group.Orientation = orientation;
      return (TViewBuilder) this;
    }

    public TViewBuilder Groups(bool date)
    {
      this.view.Group.Date = date;
      return (TViewBuilder) this;
    }

    public TViewBuilder Groups(Action<SchedulerGroupBuilder> configuration)
    {
      SchedulerGroupBuilder schedulerGroupBuilder = new SchedulerGroupBuilder(this.view.Group);
      configuration(schedulerGroupBuilder);
      return (TViewBuilder) this;
    }
  }
}
