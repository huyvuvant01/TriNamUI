// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridCustomActionCommandBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridCustomActionCommandBuilder<T> : 
    GridActionCommandBuilderBase<GridCustomActionCommand, GridCustomActionCommandBuilder<T>>
    where T : class
  {
    public GridCustomActionCommandBuilder(GridCustomActionCommand command)
      : base(command)
    {
    }

    public GridCustomActionCommandBuilder<T> Click(
      Func<object, object> handler)
    {
      this.Command.Click.TemplateDelegate = handler;
      return this;
    }

    public GridCustomActionCommandBuilder<T> Click(string handler)
    {
      this.Command.Click.HandlerName = handler;
      return this;
    }
  }
}
