// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridActionCommandFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridActionCommandFactory<T> : IHideObjectMembers where T : class
  {
    public GridActionCommandFactory(GridActionColumn<T> column) => this.Column = column;

    private GridActionColumn<T> Column { get; set; }

    public GridEditActionCommandBuilder Edit()
    {
      GridEditActionCommand command = new GridEditActionCommand();
      this.Column.Commands.Add((IGridActionCommand) command);
      this.Column.Grid.Editable.Enabled = true;
      return new GridEditActionCommandBuilder(command);
    }

    public GridDestroyActionCommandBuilder Destroy()
    {
      GridDestroyActionCommand command = new GridDestroyActionCommand();
      this.Column.Commands.Add((IGridActionCommand) command);
      this.Column.Grid.Editable.Enabled = true;
      return new GridDestroyActionCommandBuilder(command);
    }

    public GridCustomActionCommandBuilder<T> Custom(string name)
    {
      GridCustomActionCommand command = new GridCustomActionCommand();
      command.Name = name;
      command.Text = name;
      this.Column.Commands.Add((IGridActionCommand) command);
      return new GridCustomActionCommandBuilder<T>(command);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
