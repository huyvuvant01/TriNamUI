// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PopupAnimation
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PopupAnimation : JsonObject
  {
    public PopupAnimation()
    {
      this.Enabled = true;
      this.Open = new Effects("open");
      this.Close = new Effects("close");
    }

    public bool Enabled { get; set; }

    public Effects Open { get; set; }

    public Effects Close { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (!this.Enabled)
      {
        json["animation"] = (object) false;
      }
      else
      {
        IDictionary<string, object> json1 = this.Open.ToJson();
        DictionaryExtensions.Merge(json1, this.Close.ToJson());
        if (!json1.Keys.Any<string>())
          return;
        json["animation"] = (object) json1;
      }
    }
  }
}
