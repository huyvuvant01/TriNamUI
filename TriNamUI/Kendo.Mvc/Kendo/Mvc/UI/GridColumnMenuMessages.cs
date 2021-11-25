// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridColumnMenuMessages
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GridColumnMenuMessages
  {
    private const string DefaultSetColumnPosition = "Set Column Position";
    private const string DefaultSortAscending = "Sort Ascending";
    private const string DefaultSortDescending = "Sort Descending";
    private const string DefaultFilter = "Filter";
    private const string DefaultColumns = "Columns";
    private const string DefaultColumnSettings = "Column Settings";
    private const string DefaultLock = "Lock Column";
    private const string DefaultUnlock = "Unlock Column";
    private const string DefaultStick = "Stick Column";
    private const string DefaultUnstick = "Unstick Column";
    private const string DefaultApply = "Apply";
    private const string DefaultReset = "Reset";
    private const string DefaultButtonTitle = "{0} edit column settings";

    public GridColumnMenuMessages()
    {
      this.Filter = Messages.Filter_Filter;
      this.Columns = Messages.Grid_Columns;
      this.SetColumnPosition = Messages.Grid_SetColumnPosition;
      this.SortAscending = Messages.Grid_SortAscending;
      this.SortDescending = Messages.Grid_SortDescending;
      this.ColumnSettings = Messages.Grid_ColumnSettings;
      this.Lock = Messages.Grid_Lock;
      this.Unlock = Messages.Grid_Unlock;
      this.Stick = Messages.Grid_Stick;
      this.Unstick = Messages.Grid_Unstick;
      this.Apply = Messages.Grid_Apply;
      this.Reset = Messages.Grid_Reset;
      this.ButtonTitle = Messages.Filter_ButtonTitle;
    }

    public string SetColumnPosition { get; set; }

    public string SortAscending { get; set; }

    public string SortDescending { get; set; }

    public string Filter { get; set; }

    public string Columns { get; set; }

    public string ColumnSettings { get; set; }

    public string Lock { get; set; }

    public string Unlock { get; set; }

    public string Stick { get; set; }

    public string Unstick { get; set; }

    public string Apply { get; set; }

    public string Reset { get; set; }

    public string ButtonTitle { get; set; }

    public IDictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Filter != "Filter")
        dictionary["filter"] = (object) this.Filter;
      if (this.Columns != "Columns")
        dictionary["columns"] = (object) this.Columns;
      if (this.SetColumnPosition != "Set Column Position")
        dictionary["setColumnPosition"] = (object) this.SetColumnPosition;
      if (this.SortAscending != "Sort Ascending")
        dictionary["sortAscending"] = (object) this.SortAscending;
      if (this.SortDescending != "Sort Descending")
        dictionary["sortDescending"] = (object) this.SortDescending;
      if (this.ColumnSettings != "Column Settings")
        dictionary["settings"] = (object) this.ColumnSettings;
      if (this.Lock != "Lock Column")
        dictionary["lock"] = (object) this.Lock;
      if (this.Unlock != "Unlock Column")
        dictionary["unlock"] = (object) this.Unlock;
      if (this.Stick != "Stick Column")
        dictionary["stick"] = (object) this.Stick;
      if (this.Unstick != "Unstick Column")
        dictionary["unstick"] = (object) this.Unstick;
      if (this.Apply != "Apply")
        dictionary["apply"] = (object) this.Apply;
      if (this.Reset != "Reset")
        dictionary["reset"] = (object) this.Reset;
      if (this.ButtonTitle != "{0} edit column settings")
        dictionary["buttonTitle"] = (object) this.ButtonTitle;
      return (IDictionary<string, object>) dictionary;
    }
  }
}
