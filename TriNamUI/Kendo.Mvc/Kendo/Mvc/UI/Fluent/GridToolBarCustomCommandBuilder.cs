// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridToolBarCustomCommandBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridToolBarCustomCommandBuilder : 
    GridToolBarCommandBuilderBase<GridToolBarCustomCommand, GridToolBarCustomCommandBuilder>
  {
    public GridToolBarCustomCommandBuilder(GridToolBarCustomCommand command)
      : base(command)
    {
    }

    public GridToolBarCustomCommandBuilder Name(string name)
    {
      this.Command.Name = name;
      if (!this.Command.Text.HasValue())
        this.Command.Text = name;
      return this;
    }

    private void SetTextIfEmpty(string value)
    {
      if (!string.IsNullOrEmpty(this.Command.Text))
        return;
      this.Command.Text = value;
    }
  }
}
