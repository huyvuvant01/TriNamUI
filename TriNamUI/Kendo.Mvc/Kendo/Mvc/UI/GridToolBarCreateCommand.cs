﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridToolBarCreateCommand
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;

namespace Kendo.Mvc.UI
{
  public class GridToolBarCreateCommand : GridActionCommandBase
  {
    public GridToolBarCreateCommand() => this.Text = Messages.Grid_Create;

    public override string Name => "create";
  }
}
