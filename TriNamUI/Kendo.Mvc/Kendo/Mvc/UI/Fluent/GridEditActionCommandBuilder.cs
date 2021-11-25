// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridEditActionCommandBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class GridEditActionCommandBuilder : 
    GridActionCommandBuilderBase<GridEditActionCommand, GridEditActionCommandBuilder>
  {
    public GridEditActionCommandBuilder(GridEditActionCommand command)
      : base(command)
    {
    }

    public GridEditActionCommandBuilder UpdateText(string text)
    {
      this.Command.UpdateText = text;
      return this;
    }

    public GridEditActionCommandBuilder CancelText(string text)
    {
      this.Command.CancelText = text;
      return this;
    }

    public GridEditActionCommandBuilder UpdateIconClass(string iconClass)
    {
      this.Command.UpdateIconClass = iconClass;
      return this;
    }

    public GridEditActionCommandBuilder CancelIconClass(string iconClass)
    {
      this.Command.CancelIconClass = iconClass;
      return this;
    }
  }
}
