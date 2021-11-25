// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramPdfMarginSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class DiagramPdfMarginSettings<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? Bottom { get; set; }

    public double? Left { get; set; }

    public double? Right { get; set; }

    public double? Top { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Bottom.HasValue)
        dictionary["bottom"] = (object) this.Bottom;
      if (this.Left.HasValue)
        dictionary["left"] = (object) this.Left;
      if (this.Right.HasValue)
        dictionary["right"] = (object) this.Right;
      if (this.Top.HasValue)
        dictionary["top"] = (object) this.Top;
      return dictionary;
    }
  }
}
