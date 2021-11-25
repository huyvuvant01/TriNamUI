﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SpreadsheetSheetFilterSettingsColumn
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class SpreadsheetSheetFilterSettingsColumn
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public List<SpreadsheetSheetFilterSettingsColumnCriteria> Criteria { get; set; } = new List<SpreadsheetSheetFilterSettingsColumnCriteria>();

    public string Filter { get; set; }

    public double? Index { get; set; }

    public string Logic { get; set; }

    public string Type { get; set; }

    public double? Value { get; set; }

    public object[] Values { get; set; }

    public Spreadsheet Spreadsheet { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IEnumerable<Dictionary<string, object>> source = this.Criteria.Select<SpreadsheetSheetFilterSettingsColumnCriteria, Dictionary<string, object>>((Func<SpreadsheetSheetFilterSettingsColumnCriteria, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["criteria"] = (object) source;
      string filter = this.Filter;
      if ((filter != null ? (filter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filter"] = (object) this.Filter;
      double? index = this.Index;
      if (index.HasValue)
        dictionary["index"] = (object) this.Index;
      string logic = this.Logic;
      if ((logic != null ? (logic.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["logic"] = (object) this.Logic;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      index = this.Value;
      if (index.HasValue)
        dictionary["value"] = (object) this.Value;
      object[] values = this.Values;
      if ((values != null ? (((IEnumerable<object>) values).Any<object>() ? 1 : 0) : 0) != 0)
        dictionary["values"] = (object) this.Values;
      return dictionary;
    }
  }
}
