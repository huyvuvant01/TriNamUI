// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramLayoutGridSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class DiagramLayoutGridSettings<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? ComponentSpacingX { get; set; }

    public double? ComponentSpacingY { get; set; }

    public double? OffsetX { get; set; }

    public double? OffsetY { get; set; }

    public double? Width { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.ComponentSpacingX.HasValue)
        dictionary["componentSpacingX"] = (object) this.ComponentSpacingX;
      if (this.ComponentSpacingY.HasValue)
        dictionary["componentSpacingY"] = (object) this.ComponentSpacingY;
      if (this.OffsetX.HasValue)
        dictionary["offsetX"] = (object) this.OffsetX;
      if (this.OffsetY.HasValue)
        dictionary["offsetY"] = (object) this.OffsetY;
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      return dictionary;
    }
  }
}
