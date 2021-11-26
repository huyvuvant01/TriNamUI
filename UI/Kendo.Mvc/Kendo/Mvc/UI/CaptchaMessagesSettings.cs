// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.CaptchaMessagesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class CaptchaMessagesSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Audio { get; set; }

    public string ImageAlt { get; set; }

    public string Reset { get; set; }

    public string Success { get; set; }

    public Captcha Captcha { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string audio = this.Audio;
      if ((audio != null ? (audio.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["audio"] = (object) this.Audio;
      string imageAlt = this.ImageAlt;
      if ((imageAlt != null ? (imageAlt.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageAlt"] = (object) this.ImageAlt;
      string reset = this.Reset;
      if ((reset != null ? (reset.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["reset"] = (object) this.Reset;
      string success = this.Success;
      if ((success != null ? (success.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["success"] = (object) this.Success;
      return dictionary;
    }
  }
}
