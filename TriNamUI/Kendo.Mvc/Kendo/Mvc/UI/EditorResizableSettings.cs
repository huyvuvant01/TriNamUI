// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorResizableSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class EditorResizableSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Content { get; set; }

    public double? Min { get; set; }

    public double? Max { get; set; }

    public bool? Toolbar { get; set; }

    public bool? Enabled { get; set; }

    public Editor Editor { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Content.HasValue)
        dictionary["content"] = (object) this.Content;
      if (this.Min.HasValue)
        dictionary["min"] = (object) this.Min;
      if (this.Max.HasValue)
        dictionary["max"] = (object) this.Max;
      if (this.Toolbar.HasValue)
        dictionary["toolbar"] = (object) this.Toolbar;
      return dictionary;
    }
  }
}
