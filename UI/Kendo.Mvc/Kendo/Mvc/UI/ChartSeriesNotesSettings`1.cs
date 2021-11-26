// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeriesNotesSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartSeriesNotesSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public ChartSeriesNotesIconSettings<T> Icon { get; } = new ChartSeriesNotesIconSettings<T>();

    public ChartSeriesNotesLabelSettings<T> Label { get; } = new ChartSeriesNotesLabelSettings<T>();

    public ChartSeriesNotesLineSettings<T> Line { get; } = new ChartSeriesNotesLineSettings<T>();

    public ClientHandlerDescriptor Visual { get; set; }

    public ChartNotePosition? Position { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Icon.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["icon"] = (object) source1;
      Dictionary<string, object> source2 = this.Label.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["label"] = (object) source2;
      Dictionary<string, object> source3 = this.Line.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["line"] = (object) source3;
      ClientHandlerDescriptor visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["visual"] = (object) this.Visual;
      if (this.Position.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ChartNotePosition? position = this.Position;
        ref ChartNotePosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["position"] = (object) str;
      }
      return dictionary1;
    }
  }
}
