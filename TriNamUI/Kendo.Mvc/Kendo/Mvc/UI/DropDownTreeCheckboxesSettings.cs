// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DropDownTreeCheckboxesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class DropDownTreeCheckboxesSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? CheckChildren { get; set; }

    public string Name { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Enabled { get; set; }

    public DropDownTree DropDownTree { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.CheckChildren.HasValue)
        dictionary["checkChildren"] = (object) this.CheckChildren;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.DropDownTree.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      return dictionary;
    }
  }
}
