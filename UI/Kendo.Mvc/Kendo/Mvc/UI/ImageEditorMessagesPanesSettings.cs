// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ImageEditorMessagesPanesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ImageEditorMessagesPanesSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public ImageEditorMessagesPanesCropSettings Crop { get; } = new ImageEditorMessagesPanesCropSettings();

    public ImageEditorMessagesPanesResizeSettings Resize { get; } = new ImageEditorMessagesPanesResizeSettings();

    public ImageEditor ImageEditor { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Crop.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["crop"] = (object) source1;
      Dictionary<string, object> source2 = this.Resize.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["resize"] = (object) source2;
      return dictionary;
    }
  }
}
