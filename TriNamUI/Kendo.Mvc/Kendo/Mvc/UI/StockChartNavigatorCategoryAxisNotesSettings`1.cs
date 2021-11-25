// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.StockChartNavigatorCategoryAxisNotesSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class StockChartNavigatorCategoryAxisNotesSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Position { get; set; }

    public StockChartNavigatorCategoryAxisNotesIconSettings<T> Icon { get; } = new StockChartNavigatorCategoryAxisNotesIconSettings<T>();

    public StockChartNavigatorCategoryAxisNotesLabelSettings<T> Label { get; } = new StockChartNavigatorCategoryAxisNotesLabelSettings<T>();

    public StockChartNavigatorCategoryAxisNotesLineSettings<T> Line { get; } = new StockChartNavigatorCategoryAxisNotesLineSettings<T>();

    public Kendo.Mvc.UI.StockChart<T> StockChart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string position = this.Position;
      if ((position != null ? (position.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["position"] = (object) this.Position;
      Dictionary<string, object> source1 = this.Icon.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["icon"] = (object) source1;
      Dictionary<string, object> source2 = this.Label.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["label"] = (object) source2;
      Dictionary<string, object> source3 = this.Line.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["line"] = (object) source3;
      return dictionary;
    }
  }
}
