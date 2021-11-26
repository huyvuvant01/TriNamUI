// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ScrollViewMessagesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ScrollViewMessagesSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string NextButtonLabel { get; set; }

    public string PreviousButtonLabel { get; set; }

    public ScrollView ScrollView { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string nextButtonLabel = this.NextButtonLabel;
      if ((nextButtonLabel != null ? (nextButtonLabel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["nextButtonLabel"] = (object) this.NextButtonLabel;
      string previousButtonLabel = this.PreviousButtonLabel;
      if ((previousButtonLabel != null ? (previousButtonLabel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["previousButtonLabel"] = (object) this.PreviousButtonLabel;
      return dictionary;
    }
  }
}
