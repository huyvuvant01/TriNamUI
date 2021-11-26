// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SpreadsheetSheet
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class SpreadsheetSheet
  {
    public DataSource DataSource { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.DataSource != null)
        dictionary["dataSource"] = (object) this.DataSource.ToJson();
      return dictionary;
    }

    public string ActiveCell { get; set; }

    public string Name { get; set; }

    public List<SpreadsheetSheetColumn> Columns { get; set; } = new List<SpreadsheetSheetColumn>();

    public List<SpreadsheetSheetDrawing> Drawings { get; set; } = new List<SpreadsheetSheetDrawing>();

    public SpreadsheetSheetFilterSettings Filter { get; } = new SpreadsheetSheetFilterSettings();

    public int? FrozenColumns { get; set; }

    public int? FrozenRows { get; set; }

    public string[] MergedCells { get; set; }

    public List<SpreadsheetSheetRow> Rows { get; set; } = new List<SpreadsheetSheetRow>();

    public string Selection { get; set; }

    public bool? ShowGridLines { get; set; }

    public SpreadsheetSheetSortSettings Sort { get; } = new SpreadsheetSheetSortSettings();

    public Spreadsheet Spreadsheet { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string activeCell = this.ActiveCell;
      if ((activeCell != null ? (activeCell.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["activeCell"] = (object) this.ActiveCell;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      IEnumerable<Dictionary<string, object>> source1 = this.Columns.Select<SpreadsheetSheetColumn, Dictionary<string, object>>((Func<SpreadsheetSheetColumn, Dictionary<string, object>>) (i => i.Serialize()));
      if (source1.Any<Dictionary<string, object>>())
        dictionary["columns"] = (object) source1;
      IEnumerable<Dictionary<string, object>> source2 = this.Drawings.Select<SpreadsheetSheetDrawing, Dictionary<string, object>>((Func<SpreadsheetSheetDrawing, Dictionary<string, object>>) (i => i.Serialize()));
      if (source2.Any<Dictionary<string, object>>())
        dictionary["drawings"] = (object) source2;
      Dictionary<string, object> source3 = this.Filter.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["filter"] = (object) source3;
      int? nullable = this.FrozenColumns;
      if (nullable.HasValue)
        dictionary["frozenColumns"] = (object) this.FrozenColumns;
      nullable = this.FrozenRows;
      if (nullable.HasValue)
        dictionary["frozenRows"] = (object) this.FrozenRows;
      string[] mergedCells = this.MergedCells;
      if ((mergedCells != null ? (((IEnumerable<string>) mergedCells).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary["mergedCells"] = (object) this.MergedCells;
      IEnumerable<Dictionary<string, object>> source4 = this.Rows.Select<SpreadsheetSheetRow, Dictionary<string, object>>((Func<SpreadsheetSheetRow, Dictionary<string, object>>) (i => i.Serialize()));
      if (source4.Any<Dictionary<string, object>>())
        dictionary["rows"] = (object) source4;
      string selection = this.Selection;
      if ((selection != null ? (selection.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["selection"] = (object) this.Selection;
      if (this.ShowGridLines.HasValue)
        dictionary["showGridLines"] = (object) this.ShowGridLines;
      Dictionary<string, object> source5 = this.Sort.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary["sort"] = (object) source5;
      return dictionary;
    }
  }
}
