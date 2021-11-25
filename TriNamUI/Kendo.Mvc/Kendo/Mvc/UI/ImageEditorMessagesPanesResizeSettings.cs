// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ImageEditorMessagesPanesResizeSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ImageEditorMessagesPanesResizeSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Title { get; set; }

    public string Pixels { get; set; }

    public string Percents { get; set; }

    public ImageEditor ImageEditor { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      string pixels = this.Pixels;
      if ((pixels != null ? (pixels.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pixels"] = (object) this.Pixels;
      string percents = this.Percents;
      if ((percents != null ? (percents.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["percents"] = (object) this.Percents;
      return dictionary;
    }
  }
}
