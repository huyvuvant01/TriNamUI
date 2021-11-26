// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridToolBarSaveCommand
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;

namespace Kendo.Mvc.UI
{
  public class GridToolBarSaveCommand : GridActionCommandBase
  {
    public GridToolBarSaveCommand()
    {
      this.CancelText = Messages.Grid_CancelChanges;
      this.SaveText = Messages.Grid_SaveChanges;
    }

    public override string Name => "save";

    public override string Text
    {
      get => this.SaveText;
      set => this.SaveText = value;
    }

    public string SaveText { get; set; }

    public string CancelText { get; set; }
  }
}
