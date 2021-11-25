// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartAxisDefaultsLabelsSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartAxisDefaultsLabelsSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Font { get; set; }

    public string Format { get; set; }

    public ChartAxisDefaultsLabelsMarginSettings<T> Margin { get; } = new ChartAxisDefaultsLabelsMarginSettings<T>();

    public bool? Mirror { get; set; }

    public ChartAxisDefaultsLabelsPaddingSettings<T> Padding { get; } = new ChartAxisDefaultsLabelsPaddingSettings<T>();

    public ChartAxisDefaultsLabelsRotationSettings<T> Rotation { get; } = new ChartAxisDefaultsLabelsRotationSettings<T>();

    public double? Skip { get; set; }

    public double? Step { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    public ClientHandlerDescriptor Visual { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string font = this.Font;
      if ((font != null ? (font.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["font"] = (object) this.Font;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["format"] = (object) this.Format;
      Dictionary<string, object> source1 = this.Margin.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["margin"] = (object) source1;
      bool? nullable1 = this.Mirror;
      if (nullable1.HasValue)
        dictionary["mirror"] = (object) this.Mirror;
      Dictionary<string, object> source2 = this.Padding.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["padding"] = (object) source2;
      Dictionary<string, object> source3 = this.Rotation.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["rotation"] = (object) source3;
      double? nullable2 = this.Skip;
      if (nullable2.HasValue)
        dictionary["skip"] = (object) this.Skip;
      nullable2 = this.Step;
      if (nullable2.HasValue)
        dictionary["step"] = (object) this.Step;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Chart.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      nullable1 = this.Visible;
      if (nullable1.HasValue)
        dictionary["visible"] = (object) this.Visible;
      ClientHandlerDescriptor visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.Visual;
      return dictionary;
    }
  }
}
