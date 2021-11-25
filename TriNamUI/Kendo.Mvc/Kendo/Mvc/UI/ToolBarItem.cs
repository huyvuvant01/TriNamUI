﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ToolBarItem
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ToolBarItem
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public IDictionary<string, object> HtmlAttributes { get; set; }

    public List<ToolBarItemButton> Buttons { get; set; } = new List<ToolBarItemButton>();

    public ClientHandlerDescriptor Click { get; set; }

    public bool? Enable { get; set; }

    public string Group { get; set; }

    public bool? Hidden { get; set; }

    public string Icon { get; set; }

    public string Id { get; set; }

    public string ImageUrl { get; set; }

    public List<ToolBarItemMenuButton> MenuButtons { get; set; } = new List<ToolBarItemMenuButton>();

    public string OverflowTemplate { get; set; }

    public string OverflowTemplateId { get; set; }

    public bool? Primary { get; set; }

    public bool? Selected { get; set; }

    public string SpriteCssClass { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Text { get; set; }

    public bool? Togglable { get; set; }

    public ClientHandlerDescriptor Toggle { get; set; }

    public string Url { get; set; }

    public CommandType? Type { get; set; }

    public ShowIn? ShowText { get; set; }

    public ShowIn? ShowIcon { get; set; }

    public ShowInOverflowPopup? Overflow { get; set; }

    public ToolBar ToolBar { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      IDictionary<string, object> htmlAttributes = this.HtmlAttributes;
      if ((htmlAttributes != null ? (htmlAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary1["attributes"] = (object) this.HtmlAttributes;
      IEnumerable<Dictionary<string, object>> source1 = this.Buttons.Select<ToolBarItemButton, Dictionary<string, object>>((Func<ToolBarItemButton, Dictionary<string, object>>) (i => i.Serialize()));
      if (source1.Any<Dictionary<string, object>>())
        dictionary1["buttons"] = (object) source1;
      ClientHandlerDescriptor click = this.Click;
      if ((click != null ? (click.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["click"] = (object) this.Click;
      bool? nullable1 = this.Enable;
      if (nullable1.HasValue)
        dictionary1["enable"] = (object) this.Enable;
      string group = this.Group;
      if ((group != null ? (group.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["group"] = (object) this.Group;
      nullable1 = this.Hidden;
      if (nullable1.HasValue)
        dictionary1["hidden"] = (object) this.Hidden;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["icon"] = (object) this.Icon;
      string id = this.Id;
      if ((id != null ? (id.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["id"] = (object) this.Id;
      string imageUrl = this.ImageUrl;
      if ((imageUrl != null ? (imageUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["imageUrl"] = (object) this.ImageUrl;
      IEnumerable<Dictionary<string, object>> source2 = this.MenuButtons.Select<ToolBarItemMenuButton, Dictionary<string, object>>((Func<ToolBarItemMenuButton, Dictionary<string, object>>) (i => i.Serialize()));
      if (source2.Any<Dictionary<string, object>>())
        dictionary1["menuButtons"] = (object) source2;
      if (this.OverflowTemplateId.HasValue())
        dictionary1["overflowTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.ToolBar.IdPrefix, (object) this.OverflowTemplateId)
        };
      else if (this.OverflowTemplate.HasValue())
        dictionary1["overflowTemplate"] = (object) this.OverflowTemplate;
      nullable1 = this.Primary;
      if (nullable1.HasValue)
        dictionary1["primary"] = (object) this.Primary;
      nullable1 = this.Selected;
      if (nullable1.HasValue)
        dictionary1["selected"] = (object) this.Selected;
      string spriteCssClass = this.SpriteCssClass;
      if ((spriteCssClass != null ? (spriteCssClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["spriteCssClass"] = (object) this.SpriteCssClass;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.ToolBar.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["text"] = (object) this.Text;
      nullable1 = this.Togglable;
      if (nullable1.HasValue)
        dictionary1["togglable"] = (object) this.Togglable;
      ClientHandlerDescriptor toggle = this.Toggle;
      if ((toggle != null ? (toggle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["toggle"] = (object) this.Toggle;
      string url = this.Url;
      if ((url != null ? (url.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["url"] = (object) this.Url;
      CommandType? type = this.Type;
      if (type.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        type = this.Type;
        ref CommandType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["type"] = (object) str;
      }
      ShowIn? nullable2 = this.ShowText;
      if (nullable2.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        nullable2 = this.ShowText;
        ref ShowIn? local = ref nullable2;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["showText"] = (object) str;
      }
      nullable2 = this.ShowIcon;
      if (nullable2.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        nullable2 = this.ShowIcon;
        ref ShowIn? local = ref nullable2;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["showIcon"] = (object) str;
      }
      ShowInOverflowPopup? overflow = this.Overflow;
      if (overflow.HasValue)
      {
        Dictionary<string, object> dictionary5 = dictionary1;
        overflow = this.Overflow;
        ref ShowInOverflowPopup? local = ref overflow;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary5["overflow"] = (object) str;
      }
      return dictionary1;
    }
  }
}
