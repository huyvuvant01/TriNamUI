// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TaskBoardPreviewPaneSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TaskBoardPreviewPaneSettingsBuilder<TCard, TColumn>
    where TCard : class
    where TColumn : class
  {
    public TaskBoardPreviewPaneSettingsBuilder(
      TaskBoardPreviewPaneSettings<TCard, TColumn> container)
    {
      this.Container = container;
    }

    protected TaskBoardPreviewPaneSettings<TCard, TColumn> Container { get; private set; }

    public TaskBoardPreviewPaneSettingsBuilder<TCard, TColumn> Buttons(
      Action<TaskBoardPreviewPaneSettingsButtonFactory<TCard, TColumn>> configurator)
    {
      configurator(new TaskBoardPreviewPaneSettingsButtonFactory<TCard, TColumn>(this.Container.Buttons)
      {
        TaskBoard = this.Container.TaskBoard
      });
      return this;
    }

    public TaskBoardPreviewPaneSettingsBuilder<TCard, TColumn> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public TaskBoardPreviewPaneSettingsBuilder<TCard, TColumn> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public TaskBoardPreviewPaneSettingsBuilder<TCard, TColumn> HeaderTemplate(
      string value)
    {
      this.Container.HeaderTemplate = value;
      return this;
    }

    public TaskBoardPreviewPaneSettingsBuilder<TCard, TColumn> HeaderTemplateId(
      string templateId)
    {
      this.Container.HeaderTemplateId = templateId;
      return this;
    }
  }
}
