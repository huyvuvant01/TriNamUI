// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramConnectionDefaultsContentSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class DiagramConnectionDefaultsContentSettings<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Color { get; set; }

    public string FontFamily { get; set; }

    public double? FontSize { get; set; }

    public string FontStyle { get; set; }

    public string FontWeight { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Text { get; set; }

    public ClientHandlerDescriptor Visual { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      string fontFamily = this.FontFamily;
      if ((fontFamily != null ? (fontFamily.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fontFamily"] = (object) this.FontFamily;
      if (this.FontSize.HasValue)
        dictionary["fontSize"] = (object) this.FontSize;
      string fontStyle = this.FontStyle;
      if ((fontStyle != null ? (fontStyle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fontStyle"] = (object) this.FontStyle;
      string fontWeight = this.FontWeight;
      if ((fontWeight != null ? (fontWeight.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fontWeight"] = (object) this.FontWeight;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Diagram.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      ClientHandlerDescriptor visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.Visual;
      return dictionary;
    }
  }
}
