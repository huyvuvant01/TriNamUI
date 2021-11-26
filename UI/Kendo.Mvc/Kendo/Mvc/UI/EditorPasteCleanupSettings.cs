// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorPasteCleanupSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class EditorPasteCleanupSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? All { get; set; }

    public bool? Css { get; set; }

    public ClientHandlerDescriptor Custom { get; set; }

    public bool? KeepNewLines { get; set; }

    public bool? MsAllFormatting { get; set; }

    public bool? MsConvertLists { get; set; }

    public bool? MsTags { get; set; }

    public bool? None { get; set; }

    public bool? Span { get; set; }

    public Editor Editor { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.All.HasValue)
        dictionary["all"] = (object) this.All;
      if (this.Css.HasValue)
        dictionary["css"] = (object) this.Css;
      ClientHandlerDescriptor custom = this.Custom;
      if ((custom != null ? (custom.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["custom"] = (object) this.Custom;
      if (this.KeepNewLines.HasValue)
        dictionary["keepNewLines"] = (object) this.KeepNewLines;
      if (this.MsAllFormatting.HasValue)
        dictionary["msAllFormatting"] = (object) this.MsAllFormatting;
      if (this.MsConvertLists.HasValue)
        dictionary["msConvertLists"] = (object) this.MsConvertLists;
      if (this.MsTags.HasValue)
        dictionary["msTags"] = (object) this.MsTags;
      if (this.None.HasValue)
        dictionary["none"] = (object) this.None;
      if (this.Span.HasValue)
        dictionary["span"] = (object) this.Span;
      return dictionary;
    }
  }
}
