// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.BottomNavigationItem
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class BottomNavigationItem
  {
    public object Attributes { get; set; }

    public object Data { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Data != null)
        dictionary["data"] = (object) this.Data.ToDictionary();
      if (this.Attributes != null)
        dictionary["attributes"] = (object) this.Attributes.ToDictionary();
      return dictionary;
    }

    public string Url { get; set; }

    public string Icon { get; set; }

    public string Text { get; set; }

    public bool? Encoded { get; set; }

    public string IconClass { get; set; }

    public string CssClass { get; set; }

    public bool? Enabled { get; set; }

    public bool? Selected { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public BottomNavigation BottomNavigation { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string url = this.Url;
      if ((url != null ? (url.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["url"] = (object) this.Url;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["icon"] = (object) this.Icon;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      bool? nullable = this.Encoded;
      if (nullable.HasValue)
        dictionary["encoded"] = (object) this.Encoded;
      string iconClass = this.IconClass;
      if ((iconClass != null ? (iconClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["iconClass"] = (object) this.IconClass;
      string cssClass = this.CssClass;
      if ((cssClass != null ? (cssClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cssClass"] = (object) this.CssClass;
      nullable = this.Enabled;
      if (nullable.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      nullable = this.Selected;
      if (nullable.HasValue)
        dictionary["selected"] = (object) this.Selected;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.BottomNavigation.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      return dictionary;
    }
  }
}
