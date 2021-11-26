// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ListBoxDraggableSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ListBoxDraggableSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    public ClientHandlerDescriptor Hint { get; set; }

    public ClientHandlerDescriptor Placeholder { get; set; }

    public ListBox ListBox { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Enabled.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      ClientHandlerDescriptor hint = this.Hint;
      if ((hint != null ? (hint.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hint"] = (object) this.Hint;
      ClientHandlerDescriptor placeholder = this.Placeholder;
      if ((placeholder != null ? (placeholder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["placeholder"] = (object) this.Placeholder;
      return dictionary;
    }
  }
}
