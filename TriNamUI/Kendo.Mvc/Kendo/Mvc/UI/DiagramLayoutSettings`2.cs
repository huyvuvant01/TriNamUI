// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramLayoutSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DiagramLayoutSettings<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? EndRadialAngle { get; set; }

    public DiagramLayoutGridSettings<TShapeModel, TConnectionModel> Grid { get; } = new DiagramLayoutGridSettings<TShapeModel, TConnectionModel>();

    public double? HorizontalSeparation { get; set; }

    public double? Iterations { get; set; }

    public double? LayerSeparation { get; set; }

    public double? NodeDistance { get; set; }

    public double? RadialFirstLevelSeparation { get; set; }

    public double? RadialSeparation { get; set; }

    public double? StartRadialAngle { get; set; }

    public double? TipOverTreeStartLevel { get; set; }

    public double? UnderneathHorizontalOffset { get; set; }

    public double? UnderneathVerticalSeparation { get; set; }

    public double? UnderneathVerticalTopOffset { get; set; }

    public double? VerticalSeparation { get; set; }

    public DiagramLayoutType? Type { get; set; }

    public DiagramLayoutSubtype? Subtype { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.EndRadialAngle.HasValue)
        dictionary1["endRadialAngle"] = (object) this.EndRadialAngle;
      Dictionary<string, object> source = this.Grid.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["grid"] = (object) source;
      if (this.HorizontalSeparation.HasValue)
        dictionary1["horizontalSeparation"] = (object) this.HorizontalSeparation;
      if (this.Iterations.HasValue)
        dictionary1["iterations"] = (object) this.Iterations;
      if (this.LayerSeparation.HasValue)
        dictionary1["layerSeparation"] = (object) this.LayerSeparation;
      if (this.NodeDistance.HasValue)
        dictionary1["nodeDistance"] = (object) this.NodeDistance;
      if (this.RadialFirstLevelSeparation.HasValue)
        dictionary1["radialFirstLevelSeparation"] = (object) this.RadialFirstLevelSeparation;
      if (this.RadialSeparation.HasValue)
        dictionary1["radialSeparation"] = (object) this.RadialSeparation;
      if (this.StartRadialAngle.HasValue)
        dictionary1["startRadialAngle"] = (object) this.StartRadialAngle;
      if (this.TipOverTreeStartLevel.HasValue)
        dictionary1["tipOverTreeStartLevel"] = (object) this.TipOverTreeStartLevel;
      if (this.UnderneathHorizontalOffset.HasValue)
        dictionary1["underneathHorizontalOffset"] = (object) this.UnderneathHorizontalOffset;
      if (this.UnderneathVerticalSeparation.HasValue)
        dictionary1["underneathVerticalSeparation"] = (object) this.UnderneathVerticalSeparation;
      if (this.UnderneathVerticalTopOffset.HasValue)
        dictionary1["underneathVerticalTopOffset"] = (object) this.UnderneathVerticalTopOffset;
      if (this.VerticalSeparation.HasValue)
        dictionary1["verticalSeparation"] = (object) this.VerticalSeparation;
      if (this.Type.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        DiagramLayoutType? type = this.Type;
        ref DiagramLayoutType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["type"] = (object) str;
      }
      if (this.Subtype.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        DiagramLayoutSubtype? subtype = this.Subtype;
        ref DiagramLayoutSubtype? local = ref subtype;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["subtype"] = (object) str;
      }
      return dictionary1;
    }
  }
}
