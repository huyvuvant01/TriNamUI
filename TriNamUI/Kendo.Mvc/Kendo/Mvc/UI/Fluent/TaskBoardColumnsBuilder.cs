// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TaskBoardColumnsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TaskBoardColumnsBuilder
  {
    private DataSource Columns { get; set; }

    private List<TaskBoardColumnItemSettings> items { get; set; } = new List<TaskBoardColumnItemSettings>();

    public TaskBoardColumnsBuilder(DataSource columns)
    {
      this.Columns = columns;
      this.Columns.Data = (IEnumerable) this.items;
    }

    public TaskBoardColumnItemBuilder Add()
    {
      TaskBoardColumnItemSettings column = new TaskBoardColumnItemSettings();
      this.items.Add(column);
      return new TaskBoardColumnItemBuilder(column);
    }
  }
}
