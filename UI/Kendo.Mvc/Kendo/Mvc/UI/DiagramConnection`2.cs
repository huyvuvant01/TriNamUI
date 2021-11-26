// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramConnection`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DiagramConnection<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public DiagramConnectionContentSettings<TShapeModel, TConnectionModel> Content { get; } = new DiagramConnectionContentSettings<TShapeModel, TConnectionModel>();

    public DiagramConnectionEditableSettings<TShapeModel, TConnectionModel> Editable { get; } = new DiagramConnectionEditableSettings<TShapeModel, TConnectionModel>();

    public DiagramConnectionEndCapSettings<TShapeModel, TConnectionModel> EndCap { get; } = new DiagramConnectionEndCapSettings<TShapeModel, TConnectionModel>();

    public DiagramConnectionFromSettings<TShapeModel, TConnectionModel> From { get; } = new DiagramConnectionFromSettings<TShapeModel, TConnectionModel>();

    public string FromConnector { get; set; }

    public DiagramConnectionHoverSettings<TShapeModel, TConnectionModel> Hover { get; } = new DiagramConnectionHoverSettings<TShapeModel, TConnectionModel>();

    public List<DiagramConnectionPoint<TShapeModel, TConnectionModel>> Points { get; set; } = new List<DiagramConnectionPoint<TShapeModel, TConnectionModel>>();

    public DiagramConnectionSelectionSettings<TShapeModel, TConnectionModel> Selection { get; } = new DiagramConnectionSelectionSettings<TShapeModel, TConnectionModel>();

    public DiagramConnectionStartCapSettings<TShapeModel, TConnectionModel> StartCap { get; } = new DiagramConnectionStartCapSettings<TShapeModel, TConnectionModel>();

    public DiagramConnectionStrokeSettings<TShapeModel, TConnectionModel> Stroke { get; } = new DiagramConnectionStrokeSettings<TShapeModel, TConnectionModel>();

    public DiagramConnectionToSettings<TShapeModel, TConnectionModel> To { get; } = new DiagramConnectionToSettings<TShapeModel, TConnectionModel>();

    public string ToConnector { get; set; }

    public DiagramConnectionType? Type { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Content.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["content"] = (object) source1;
      Dictionary<string, object> source2 = this.Editable.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["editable"] = (object) source2;
      else if (this.Editable.Enabled.HasValue)
        dictionary1["editable"] = (object) this.Editable.Enabled;
      Dictionary<string, object> source3 = this.EndCap.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["endCap"] = (object) source3;
      Dictionary<string, object> source4 = this.From.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary1["from"] = (object) source4;
      string fromConnector = this.FromConnector;
      if ((fromConnector != null ? (fromConnector.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["fromConnector"] = (object) this.FromConnector;
      Dictionary<string, object> source5 = this.Hover.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary1["hover"] = (object) source5;
      IEnumerable<Dictionary<string, object>> source6 = this.Points.Select<DiagramConnectionPoint<TShapeModel, TConnectionModel>, Dictionary<string, object>>((Func<DiagramConnectionPoint<TShapeModel, TConnectionModel>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source6.Any<Dictionary<string, object>>())
        dictionary1["points"] = (object) source6;
      Dictionary<string, object> source7 = this.Selection.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary1["selection"] = (object) source7;
      Dictionary<string, object> source8 = this.StartCap.Serialize();
      if (source8.Any<KeyValuePair<string, object>>())
        dictionary1["startCap"] = (object) source8;
      Dictionary<string, object> source9 = this.Stroke.Serialize();
      if (source9.Any<KeyValuePair<string, object>>())
        dictionary1["stroke"] = (object) source9;
      Dictionary<string, object> source10 = this.To.Serialize();
      if (source10.Any<KeyValuePair<string, object>>())
        dictionary1["to"] = (object) source10;
      string toConnector = this.ToConnector;
      if ((toConnector != null ? (toConnector.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["toConnector"] = (object) this.ToConnector;
      if (this.Type.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        DiagramConnectionType? type = this.Type;
        ref DiagramConnectionType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["type"] = (object) str;
      }
      return dictionary1;
    }
  }
}
