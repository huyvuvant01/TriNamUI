// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramShapeDefaultsEditableSettingsToolButton`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DiagramShapeDefaultsEditableSettingsToolButton<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public IDictionary<string, object> HtmlAttributes { get; set; }

    public ClientHandlerDescriptor Click { get; set; }

    public bool? Enable { get; set; }

    public string Group { get; set; }

    public string Icon { get; set; }

    public string Id { get; set; }

    public string ImageUrl { get; set; }

    public bool? Selected { get; set; }

    public string ShowIcon { get; set; }

    public string ShowText { get; set; }

    public string SpriteCssClass { get; set; }

    public ClientHandlerDescriptor Toggle { get; set; }

    public bool? Togglable { get; set; }

    public string Text { get; set; }

    public string Url { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IDictionary<string, object> htmlAttributes = this.HtmlAttributes;
      if ((htmlAttributes != null ? (htmlAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary["attributes"] = (object) this.HtmlAttributes;
      ClientHandlerDescriptor click = this.Click;
      if ((click != null ? (click.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) this.Click;
      bool? nullable = this.Enable;
      if (nullable.HasValue)
        dictionary["enable"] = (object) this.Enable;
      string group = this.Group;
      if ((group != null ? (group.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["group"] = (object) this.Group;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["icon"] = (object) this.Icon;
      string id = this.Id;
      if ((id != null ? (id.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["id"] = (object) this.Id;
      string imageUrl = this.ImageUrl;
      if ((imageUrl != null ? (imageUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageUrl"] = (object) this.ImageUrl;
      nullable = this.Selected;
      if (nullable.HasValue)
        dictionary["selected"] = (object) this.Selected;
      string showIcon = this.ShowIcon;
      if ((showIcon != null ? (showIcon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["showIcon"] = (object) this.ShowIcon;
      string showText = this.ShowText;
      if ((showText != null ? (showText.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["showText"] = (object) this.ShowText;
      string spriteCssClass = this.SpriteCssClass;
      if ((spriteCssClass != null ? (spriteCssClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["spriteCssClass"] = (object) this.SpriteCssClass;
      ClientHandlerDescriptor toggle = this.Toggle;
      if ((toggle != null ? (toggle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["toggle"] = (object) this.Toggle;
      nullable = this.Togglable;
      if (nullable.HasValue)
        dictionary["togglable"] = (object) this.Togglable;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      string url = this.Url;
      if ((url != null ? (url.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["url"] = (object) this.Url;
      return dictionary;
    }
  }
}
