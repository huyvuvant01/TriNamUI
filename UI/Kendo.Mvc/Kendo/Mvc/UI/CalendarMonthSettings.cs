// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.CalendarMonthSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class CalendarMonthSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Content { get; set; }

    public string Empty { get; set; }

    public Calendar Calendar { get; set; }

    protected Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string content = this.Content;
      if ((content != null ? (content.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["content"] = (object) this.Content;
      string empty = this.Empty;
      if ((empty != null ? (empty.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["empty"] = (object) this.Empty;
      return dictionary;
    }
  }
}
