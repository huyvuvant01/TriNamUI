// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MapControlsSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class MapControlsSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public MapControlsAttributionSettings Attribution { get; } = new MapControlsAttributionSettings();

    public MapControlsNavigatorSettings Navigator { get; } = new MapControlsNavigatorSettings();

    public MapControlsZoomSettings Zoom { get; } = new MapControlsZoomSettings();

    public Map Map { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Attribution.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["attribution"] = (object) source1;
      else if (this.Attribution.Enabled.HasValue)
        dictionary["attribution"] = (object) this.Attribution.Enabled;
      Dictionary<string, object> source2 = this.Navigator.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["navigator"] = (object) source2;
      else if (this.Navigator.Enabled.HasValue)
        dictionary["navigator"] = (object) this.Navigator.Enabled;
      Dictionary<string, object> source3 = this.Zoom.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["zoom"] = (object) source3;
      else if (this.Zoom.Enabled.HasValue)
        dictionary["zoom"] = (object) this.Zoom.Enabled;
      return dictionary;
    }
  }
}
