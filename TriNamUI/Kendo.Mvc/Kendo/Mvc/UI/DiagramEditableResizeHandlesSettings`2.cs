// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramEditableResizeHandlesSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DiagramEditableResizeHandlesSettings<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public DiagramEditableResizeHandlesFillSettings<TShapeModel, TConnectionModel> Fill { get; } = new DiagramEditableResizeHandlesFillSettings<TShapeModel, TConnectionModel>();

    public double? Height { get; set; }

    public DiagramEditableResizeHandlesHoverSettings<TShapeModel, TConnectionModel> Hover { get; } = new DiagramEditableResizeHandlesHoverSettings<TShapeModel, TConnectionModel>();

    public DiagramEditableResizeHandlesStrokeSettings<TShapeModel, TConnectionModel> Stroke { get; } = new DiagramEditableResizeHandlesStrokeSettings<TShapeModel, TConnectionModel>();

    public double? Width { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Fill.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["fill"] = (object) source1;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      Dictionary<string, object> source2 = this.Hover.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["hover"] = (object) source2;
      Dictionary<string, object> source3 = this.Stroke.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["stroke"] = (object) source3;
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      return dictionary;
    }
  }
}
