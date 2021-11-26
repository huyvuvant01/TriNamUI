// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.CheckBoxGroupItem
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class CheckBoxGroupItem
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public IDictionary<string, object> HtmlAttributes { get; set; }

    public string CssClass { get; set; }

    public bool? Enabled { get; set; }

    public bool? Encoded { get; set; }

    public string Label { get; set; }

    public string Value { get; set; }

    public CheckBoxGroup CheckBoxGroup { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IDictionary<string, object> htmlAttributes = this.HtmlAttributes;
      if ((htmlAttributes != null ? (htmlAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary["attributes"] = (object) this.HtmlAttributes;
      string cssClass = this.CssClass;
      if ((cssClass != null ? (cssClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cssClass"] = (object) this.CssClass;
      bool? nullable = this.Enabled;
      if (nullable.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      nullable = this.Encoded;
      if (nullable.HasValue)
        dictionary["encoded"] = (object) this.Encoded;
      string label = this.Label;
      if ((label != null ? (label.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["label"] = (object) this.Label;
      string str = this.Value;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["value"] = (object) this.Value;
      return dictionary;
    }
  }
}
