// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramShapeDefaultsSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DiagramShapeDefaultsSettings<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public List<DiagramShapeDefaultsSettingsConnector<TShapeModel, TConnectionModel>> Connectors { get; set; } = new List<DiagramShapeDefaultsSettingsConnector<TShapeModel, TConnectionModel>>();

    public DiagramShapeDefaultsConnectorDefaultsSettings<TShapeModel, TConnectionModel> ConnectorDefaults { get; } = new DiagramShapeDefaultsConnectorDefaultsSettings<TShapeModel, TConnectionModel>();

    public DiagramShapeDefaultsContentSettings<TShapeModel, TConnectionModel> Content { get; } = new DiagramShapeDefaultsContentSettings<TShapeModel, TConnectionModel>();

    public DiagramShapeDefaultsEditableSettings<TShapeModel, TConnectionModel> Editable { get; } = new DiagramShapeDefaultsEditableSettings<TShapeModel, TConnectionModel>();

    public DiagramShapeDefaultsFillSettings<TShapeModel, TConnectionModel> Fill { get; } = new DiagramShapeDefaultsFillSettings<TShapeModel, TConnectionModel>();

    public double? Height { get; set; }

    public DiagramShapeDefaultsHoverSettings<TShapeModel, TConnectionModel> Hover { get; } = new DiagramShapeDefaultsHoverSettings<TShapeModel, TConnectionModel>();

    public double? MinHeight { get; set; }

    public double? MinWidth { get; set; }

    public string Path { get; set; }

    public DiagramShapeDefaultsRotationSettings<TShapeModel, TConnectionModel> Rotation { get; } = new DiagramShapeDefaultsRotationSettings<TShapeModel, TConnectionModel>();

    public bool? Selectable { get; set; }

    public string Source { get; set; }

    public DiagramShapeDefaultsStrokeSettings<TShapeModel, TConnectionModel> Stroke { get; } = new DiagramShapeDefaultsStrokeSettings<TShapeModel, TConnectionModel>();

    public string Type { get; set; }

    public ClientHandlerDescriptor Visual { get; set; }

    public double? Width { get; set; }

    public double? X { get; set; }

    public double? Y { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IEnumerable<Dictionary<string, object>> source1 = this.Connectors.Select<DiagramShapeDefaultsSettingsConnector<TShapeModel, TConnectionModel>, Dictionary<string, object>>((Func<DiagramShapeDefaultsSettingsConnector<TShapeModel, TConnectionModel>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source1.Any<Dictionary<string, object>>())
        dictionary["connectors"] = (object) source1;
      Dictionary<string, object> source2 = this.ConnectorDefaults.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["connectorDefaults"] = (object) source2;
      Dictionary<string, object> source3 = this.Content.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["content"] = (object) source3;
      Dictionary<string, object> source4 = this.Editable.Serialize();
      bool? nullable1;
      if (source4.Any<KeyValuePair<string, object>>())
      {
        dictionary["editable"] = (object) source4;
      }
      else
      {
        nullable1 = this.Editable.Enabled;
        if (nullable1.HasValue)
          dictionary["editable"] = (object) this.Editable.Enabled;
      }
      Dictionary<string, object> source5 = this.Fill.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary["fill"] = (object) source5;
      double? nullable2 = this.Height;
      if (nullable2.HasValue)
        dictionary["height"] = (object) this.Height;
      Dictionary<string, object> source6 = this.Hover.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary["hover"] = (object) source6;
      nullable2 = this.MinHeight;
      if (nullable2.HasValue)
        dictionary["minHeight"] = (object) this.MinHeight;
      nullable2 = this.MinWidth;
      if (nullable2.HasValue)
        dictionary["minWidth"] = (object) this.MinWidth;
      string path = this.Path;
      if ((path != null ? (path.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["path"] = (object) this.Path;
      Dictionary<string, object> source7 = this.Rotation.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary["rotation"] = (object) source7;
      nullable1 = this.Selectable;
      if (nullable1.HasValue)
        dictionary["selectable"] = (object) this.Selectable;
      string source8 = this.Source;
      if ((source8 != null ? (source8.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["source"] = (object) this.Source;
      Dictionary<string, object> source9 = this.Stroke.Serialize();
      if (source9.Any<KeyValuePair<string, object>>())
        dictionary["stroke"] = (object) source9;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      ClientHandlerDescriptor visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.Visual;
      nullable2 = this.Width;
      if (nullable2.HasValue)
        dictionary["width"] = (object) this.Width;
      nullable2 = this.X;
      if (nullable2.HasValue)
        dictionary["x"] = (object) this.X;
      nullable2 = this.Y;
      if (nullable2.HasValue)
        dictionary["y"] = (object) this.Y;
      return dictionary;
    }
  }
}
