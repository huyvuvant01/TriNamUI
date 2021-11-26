// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TaskBoardColumnSettingsSettingsButtonFactory`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TaskBoardColumnSettingsSettingsButtonFactory<TCard, TColumn>
    where TCard : class
    where TColumn : class
  {
    public TaskBoardColumnSettingsSettingsButtonFactory(
      List<TaskBoardColumnSettingsSettingsButton<TCard, TColumn>> container)
    {
      this.Container = container;
    }

    protected List<TaskBoardColumnSettingsSettingsButton<TCard, TColumn>> Container { get; private set; }

    public Kendo.Mvc.UI.TaskBoard<TCard, TColumn> TaskBoard { get; set; }

    public virtual TaskBoardColumnSettingsSettingsButtonBuilder<TCard, TColumn> Add()
    {
      TaskBoardColumnSettingsSettingsButton<TCard, TColumn> container = new TaskBoardColumnSettingsSettingsButton<TCard, TColumn>();
      container.TaskBoard = this.TaskBoard;
      this.Container.Add(container);
      return new TaskBoardColumnSettingsSettingsButtonBuilder<TCard, TColumn>(container);
    }
  }
}
