// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridActionColumn`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class GridActionColumn<T> : GridColumnBase<T>, IGridActionColumn, IGridColumn
    where T : class
  {
    public GridActionColumn(Grid<T> grid)
      : base(grid)
    {
      this.Commands = (IList<IGridActionCommand>) new List<IGridActionCommand>();
    }

    public IList<IGridActionCommand> Commands { get; private set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      List<IDictionary<string, object>> commands = new List<IDictionary<string, object>>();
      this.Commands.Each<IGridActionCommand>((Action<IGridActionCommand>) (command => commands.Add(command.Serialize())));
      if (!commands.Any<IDictionary<string, object>>())
        return;
      json["command"] = (object) commands;
    }
  }
}
