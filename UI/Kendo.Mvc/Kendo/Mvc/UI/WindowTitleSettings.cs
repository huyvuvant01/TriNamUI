// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.WindowTitleSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class WindowTitleSettings : JsonObject
  {
    public WindowTitleSettings()
    {
      this.Enabled = true;
      this.Encoded = true;
      this.Text = "";
    }

    public string Text { get; set; }

    public bool Encoded { get; set; }

    public bool Enabled { get; set; }

    public Window Window { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (!this.Enabled)
      {
        json["title"] = (object) false;
      }
      else
      {
        string text = this.Text;
        if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
          json["text"] = (object) this.Text;
        if (this.Encoded)
          return;
        json["encoded"] = (object) this.Encoded;
      }
    }
  }
}
