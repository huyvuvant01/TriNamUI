// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TaskBoardColumnSettingsSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TaskBoardColumnSettingsSettingsBuilder<TCard, TColumn>
    where TCard : class
    where TColumn : class
  {
    public TaskBoardColumnSettingsSettingsBuilder(
      TaskBoardColumnSettingsSettings<TCard, TColumn> container)
    {
      this.Container = container;
    }

    protected TaskBoardColumnSettingsSettings<TCard, TColumn> Container { get; private set; }

    public TaskBoardColumnSettingsSettingsBuilder<TCard, TColumn> Buttons(
      Action<TaskBoardColumnSettingsSettingsButtonFactory<TCard, TColumn>> configurator)
    {
      configurator(new TaskBoardColumnSettingsSettingsButtonFactory<TCard, TColumn>(this.Container.Buttons)
      {
        TaskBoard = this.Container.TaskBoard
      });
      return this;
    }

    public TaskBoardColumnSettingsSettingsBuilder<TCard, TColumn> DataStatusField(
      string value)
    {
      this.Container.DataStatusField = value;
      return this;
    }

    public TaskBoardColumnSettingsSettingsBuilder<TCard, TColumn> DataTextField(
      string value)
    {
      this.Container.DataTextField = value;
      return this;
    }

    public TaskBoardColumnSettingsSettingsBuilder<TCard, TColumn> DataOrderField(
      string value)
    {
      this.Container.DataOrderField = value;
      return this;
    }

    public TaskBoardColumnSettingsSettingsBuilder<TCard, TColumn> Width(
      string value)
    {
      this.Container.Width = value;
      return this;
    }

    public TaskBoardColumnSettingsSettingsBuilder<TCard, TColumn> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public TaskBoardColumnSettingsSettingsBuilder<TCard, TColumn> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }
  }
}
