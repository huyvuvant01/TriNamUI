// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerEditableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerEditableSettingsBuilder<T> where T : class
  {
    private readonly SchedulerEditableSettings<T> container;

    public SchedulerEditableSettingsBuilder(SchedulerEditableSettings<T> container) => this.container = container;

    public SchedulerEditableSettingsBuilder<T> Create(bool create)
    {
      this.container.Create = create;
      return this;
    }

    public SchedulerEditableSettingsBuilder<T> Destroy(bool destroy)
    {
      this.container.Destroy = destroy;
      return this;
    }

    public SchedulerEditableSettingsBuilder<T> Update(bool update)
    {
      this.container.Update = update;
      return this;
    }

    public SchedulerEditableSettingsBuilder<T> Template(
      string template)
    {
      this.container.Template = template;
      return this;
    }

    public SchedulerEditableSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.container.TemplateId = templateId;
      return this;
    }

    public SchedulerEditableSettingsBuilder<T> TemplateName(
      string name)
    {
      this.container.TemplateName = name;
      return this;
    }

    public SchedulerEditableSettingsBuilder<T> Confirmation(
      string message)
    {
      this.container.Confirmation = message;
      return this;
    }

    public SchedulerEditableSettingsBuilder<T> Resize(bool enable)
    {
      this.container.Resize = enable;
      return this;
    }

    public SchedulerEditableSettingsBuilder<T> Move(bool enable)
    {
      this.container.Move = enable;
      return this;
    }

    public SchedulerEditableSettingsBuilder<T> Confirmation(
      bool enable)
    {
      this.container.DisplayDeleteConfirmation = enable;
      return this;
    }

    public SchedulerEditableSettingsBuilder<T> EditRecurringMode(
      SchedulerEditRecurringMode editRecurringMode)
    {
      this.container.EditRecurringMode = editRecurringMode;
      return this;
    }

    public SchedulerEditableSettingsBuilder<T> Window(
      Action<WindowBuilder> configurator)
    {
      configurator(new WindowBuilder(this.container.PopUp));
      return this;
    }

    public SchedulerEditableSettingsBuilder<T> AdditionalViewData(
      object additionalViewData)
    {
      this.container.AdditionalViewData = additionalViewData;
      return this;
    }
  }
}
