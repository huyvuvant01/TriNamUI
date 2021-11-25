// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.StockChart`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class StockChart<T> : Chart<T> where T : class
  {
    public StockChart(ViewContext viewContext)
      : base(viewContext)
    {
      this.Navigator = new StockChartNavigatorSettings<T>(this, viewContext);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      this.SerializeCustomSettings((IDictionary<string, object>) dictionary);
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (StockChart<T>), (IDictionary<string, object>) dictionary));
    }

    protected override void SerializeCustomSettings(IDictionary<string, object> settings) => base.SerializeCustomSettings(settings);

    public string DateField { get; set; }

    public StockChartNavigatorSettings<T> Navigator { get; } = new StockChartNavigatorSettings<T>();

    public new bool? PersistSeriesVisibility { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      string dateField = this.DateField;
      if ((dateField != null ? (dateField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dateField"] = (object) this.DateField;
      Dictionary<string, object> source = this.Navigator.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["navigator"] = (object) source;
      if (this.PersistSeriesVisibility.HasValue)
        dictionary["persistSeriesVisibility"] = (object) this.PersistSeriesVisibility;
      return dictionary;
    }
  }
}
