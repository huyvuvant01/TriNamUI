// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramShapeConnector`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DiagramShapeConnector<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Description { get; set; }

    public string Name { get; set; }

    public ClientHandlerDescriptor Position { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public DiagramShapeConnectorHoverSettings<TShapeModel, TConnectionModel> Hover { get; } = new DiagramShapeConnectorHoverSettings<TShapeModel, TConnectionModel>();

    public DiagramShapeConnectorFillSettings<TShapeModel, TConnectionModel> Fill { get; } = new DiagramShapeConnectorFillSettings<TShapeModel, TConnectionModel>();

    public DiagramShapeConnectorStrokeSettings<TShapeModel, TConnectionModel> Stroke { get; } = new DiagramShapeConnectorStrokeSettings<TShapeModel, TConnectionModel>();

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string description = this.Description;
      if ((description != null ? (description.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["description"] = (object) this.Description;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      ClientHandlerDescriptor position = this.Position;
      if ((position != null ? (position.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["position"] = (object) this.Position;
      double? nullable = this.Width;
      if (nullable.HasValue)
        dictionary["width"] = (object) this.Width;
      nullable = this.Height;
      if (nullable.HasValue)
        dictionary["height"] = (object) this.Height;
      Dictionary<string, object> source1 = this.Hover.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["hover"] = (object) source1;
      Dictionary<string, object> source2 = this.Fill.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["fill"] = (object) source2;
      Dictionary<string, object> source3 = this.Stroke.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["stroke"] = (object) source3;
      return dictionary;
    }
  }
}
