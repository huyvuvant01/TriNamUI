// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChatToolbarSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChatToolbarSettings
  {
    public ExpandableAnimation Animation { get; private set; }

    public ChatToolbarSettings() => this.Animation = new ExpandableAnimation();

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      IDictionary<string, object> json = this.Animation.ToJson();
      if (json.Keys.Any<string>())
        dictionary["animation"] = json["animation"];
      return dictionary;
    }

    public List<ChatToolbarSettingsButton> Buttons { get; set; } = new List<ChatToolbarSettingsButton>();

    public bool? Scrollable { get; set; }

    public bool? Toggleable { get; set; }

    public Chat Chat { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IEnumerable<Dictionary<string, object>> source = this.Buttons.Select<ChatToolbarSettingsButton, Dictionary<string, object>>((Func<ChatToolbarSettingsButton, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["buttons"] = (object) source;
      bool? nullable = this.Scrollable;
      if (nullable.HasValue)
        dictionary["scrollable"] = (object) this.Scrollable;
      nullable = this.Toggleable;
      if (nullable.HasValue)
        dictionary["toggleable"] = (object) this.Toggleable;
      return dictionary;
    }
  }
}
