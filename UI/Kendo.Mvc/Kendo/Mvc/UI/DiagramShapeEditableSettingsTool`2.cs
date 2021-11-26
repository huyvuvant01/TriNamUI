// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramShapeEditableSettingsTool`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DiagramShapeEditableSettingsTool<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Name { get; set; }

    public double? Step { get; set; }

    public IDictionary<string, object> HtmlAttributes { get; set; }

    public List<DiagramShapeEditableSettingsToolButton<TShapeModel, TConnectionModel>> Buttons { get; set; } = new List<DiagramShapeEditableSettingsToolButton<TShapeModel, TConnectionModel>>();

    public ClientHandlerDescriptor Click { get; set; }

    public bool? Enable { get; set; }

    public string Group { get; set; }

    public string Icon { get; set; }

    public string Id { get; set; }

    public string ImageUrl { get; set; }

    public List<DiagramShapeEditableSettingsToolMenuButton<TShapeModel, TConnectionModel>> MenuButtons { get; set; } = new List<DiagramShapeEditableSettingsToolMenuButton<TShapeModel, TConnectionModel>>();

    public string Overflow { get; set; }

    public string OverflowTemplate { get; set; }

    public string OverflowTemplateId { get; set; }

    public bool? Primary { get; set; }

    public bool? Selected { get; set; }

    public string ShowIcon { get; set; }

    public string ShowText { get; set; }

    public string SpriteCssClass { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Text { get; set; }

    public bool? Togglable { get; set; }

    public ClientHandlerDescriptor Toggle { get; set; }

    public string Type { get; set; }

    public string Url { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      if (this.Step.HasValue)
        dictionary["step"] = (object) this.Step;
      IDictionary<string, object> htmlAttributes = this.HtmlAttributes;
      if ((htmlAttributes != null ? (htmlAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary["attributes"] = (object) this.HtmlAttributes;
      IEnumerable<Dictionary<string, object>> source1 = this.Buttons.Select<DiagramShapeEditableSettingsToolButton<TShapeModel, TConnectionModel>, Dictionary<string, object>>((Func<DiagramShapeEditableSettingsToolButton<TShapeModel, TConnectionModel>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source1.Any<Dictionary<string, object>>())
        dictionary["buttons"] = (object) source1;
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
      IEnumerable<Dictionary<string, object>> source2 = this.MenuButtons.Select<DiagramShapeEditableSettingsToolMenuButton<TShapeModel, TConnectionModel>, Dictionary<string, object>>((Func<DiagramShapeEditableSettingsToolMenuButton<TShapeModel, TConnectionModel>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source2.Any<Dictionary<string, object>>())
        dictionary["menuButtons"] = (object) source2;
      string overflow = this.Overflow;
      if ((overflow != null ? (overflow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["overflow"] = (object) this.Overflow;
      if (this.OverflowTemplateId.HasValue())
        dictionary["overflowTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Diagram.IdPrefix, (object) this.OverflowTemplateId)
        };
      else if (this.OverflowTemplate.HasValue())
        dictionary["overflowTemplate"] = (object) this.OverflowTemplate;
      nullable = this.Primary;
      if (nullable.HasValue)
        dictionary["primary"] = (object) this.Primary;
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
      nullable = this.Togglable;
      if (nullable.HasValue)
        dictionary["togglable"] = (object) this.Togglable;
      ClientHandlerDescriptor toggle = this.Toggle;
      if ((toggle != null ? (toggle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["toggle"] = (object) this.Toggle;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      string url = this.Url;
      if ((url != null ? (url.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["url"] = (object) this.Url;
      return dictionary;
    }
  }
}
