﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridToolBarSaveCommandBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class GridToolBarSaveCommandBuilder : 
    GridToolBarCommandBuilderBase<GridToolBarSaveCommand, GridToolBarSaveCommandBuilder>
  {
    public GridToolBarSaveCommandBuilder(GridToolBarSaveCommand command)
      : base(command)
    {
    }

    public GridToolBarSaveCommandBuilder SaveText(string text)
    {
      this.Command.SaveText = text;
      return this;
    }

    public GridToolBarSaveCommandBuilder CancelText(string text)
    {
      this.Command.CancelText = text;
      return this;
    }
  }
}
