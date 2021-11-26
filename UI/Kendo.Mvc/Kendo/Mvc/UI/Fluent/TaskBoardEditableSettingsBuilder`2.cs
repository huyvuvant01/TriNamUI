// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TaskBoardEditableSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TaskBoardEditableSettingsBuilder<TCard, TColumn>
    where TCard : class
    where TColumn : class
  {
    public TaskBoardEditableSettingsBuilder(
      TaskBoardEditableSettings<TCard, TColumn> container)
    {
      this.Container = container;
    }

    protected TaskBoardEditableSettings<TCard, TColumn> Container { get; private set; }

    public TaskBoardEditableSettingsBuilder<TCard, TColumn> Form(
      Action<FormBuilder<TCard>> configurator)
    {
      this.Container.Form = new Kendo.Mvc.UI.Form<TCard>(this.Container.TaskBoard.ViewContext);
      configurator(new FormBuilder<TCard>(this.Container.Form));
      return this;
    }

    public TaskBoardEditableSettingsBuilder<TCard, TColumn> Buttons(
      Action<TaskBoardEditableSettingsButtonFactory<TCard, TColumn>> configurator)
    {
      configurator(new TaskBoardEditableSettingsButtonFactory<TCard, TColumn>(this.Container.Buttons)
      {
        TaskBoard = this.Container.TaskBoard
      });
      return this;
    }

    public TaskBoardEditableSettingsBuilder<TCard, TColumn> HeaderTemplate(
      string value)
    {
      this.Container.HeaderTemplate = value;
      return this;
    }

    public TaskBoardEditableSettingsBuilder<TCard, TColumn> HeaderTemplateId(
      string templateId)
    {
      this.Container.HeaderTemplateId = templateId;
      return this;
    }
  }
}
