// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TaskBoardToolbarSettingsItemFactory`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TaskBoardToolbarSettingsItemFactory<TCard, TColumn>
    where TCard : class
    where TColumn : class
  {
    public TaskBoardToolbarSettingsItemFactory(
      List<TaskBoardToolbarSettingsItem<TCard, TColumn>> container)
    {
      this.Container = container;
    }

    protected List<TaskBoardToolbarSettingsItem<TCard, TColumn>> Container { get; private set; }

    public Kendo.Mvc.UI.TaskBoard<TCard, TColumn> TaskBoard { get; set; }

    public virtual TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Add()
    {
      TaskBoardToolbarSettingsItem<TCard, TColumn> container = new TaskBoardToolbarSettingsItem<TCard, TColumn>();
      container.TaskBoard = this.TaskBoard;
      this.Container.Add(container);
      return new TaskBoardToolbarSettingsItemBuilder<TCard, TColumn>(container);
    }
  }
}
