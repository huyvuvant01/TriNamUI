// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ActionSheetItem
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ActionSheetItem
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public ClientHandlerDescriptor Click { get; set; }

    public string Description { get; set; }

    public bool? Disabled { get; set; }

    public string Group { get; set; }

    public string IconClass { get; set; }

    public string IconColor { get; set; }

    public double? IconSize { get; set; }

    public string Text { get; set; }

    public ActionSheet ActionSheet { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      ClientHandlerDescriptor click = this.Click;
      if ((click != null ? (click.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) this.Click;
      string description = this.Description;
      if ((description != null ? (description.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["description"] = (object) this.Description;
      if (this.Disabled.HasValue)
        dictionary["disabled"] = (object) this.Disabled;
      string group = this.Group;
      if ((group != null ? (group.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["group"] = (object) this.Group;
      string iconClass = this.IconClass;
      if ((iconClass != null ? (iconClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["iconClass"] = (object) this.IconClass;
      string iconColor = this.IconColor;
      if ((iconColor != null ? (iconColor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["iconColor"] = (object) this.IconColor;
      if (this.IconSize.HasValue)
        dictionary["iconSize"] = (object) this.IconSize;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      return dictionary;
    }
  }
}
