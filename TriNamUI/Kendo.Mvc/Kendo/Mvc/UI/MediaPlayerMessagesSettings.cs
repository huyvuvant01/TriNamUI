// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MediaPlayerMessagesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class MediaPlayerMessagesSettings
  {
    private readonly string MuteDefault = nameof (Mute);
    private readonly string PlayDefault = nameof (Play);
    private readonly string PauseDefault = nameof (Pause);
    private readonly string QualityDefault = nameof (Quality);
    private readonly string UnmuteDefault = nameof (Unmute);
    private readonly string FullscreenDefault = "Full Screen";

    public MediaPlayerMessagesSettings()
    {
      if (Messages.MediaPlayer_Mute != this.MuteDefault)
        this.Mute = Messages.MediaPlayer_Mute;
      if (Messages.MediaPlayer_Pause != this.PauseDefault)
        this.Pause = Messages.MediaPlayer_Pause;
      if (Messages.MediaPlayer_Play != this.PlayDefault)
        this.Play = Messages.MediaPlayer_Play;
      if (Messages.MediaPlayer_Quality != this.QualityDefault)
        this.Quality = Messages.MediaPlayer_Quality;
      if (Messages.MediaPlayer_Unmute != this.UnmuteDefault)
        this.Unmute = Messages.MediaPlayer_Unmute;
      if (!(Messages.MediaPlayer_Fullscreen != this.FullscreenDefault))
        return;
      this.Fullscreen = Messages.MediaPlayer_Fullscreen;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Pause { get; set; }

    public string Play { get; set; }

    public string Mute { get; set; }

    public string Unmute { get; set; }

    public string Quality { get; set; }

    public string Fullscreen { get; set; }

    public MediaPlayer MediaPlayer { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string pause = this.Pause;
      if ((pause != null ? (pause.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pause"] = (object) this.Pause;
      string play = this.Play;
      if ((play != null ? (play.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["play"] = (object) this.Play;
      string mute = this.Mute;
      if ((mute != null ? (mute.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["mute"] = (object) this.Mute;
      string unmute = this.Unmute;
      if ((unmute != null ? (unmute.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["unmute"] = (object) this.Unmute;
      string quality = this.Quality;
      if ((quality != null ? (quality.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["quality"] = (object) this.Quality;
      string fullscreen = this.Fullscreen;
      if ((fullscreen != null ? (fullscreen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fullscreen"] = (object) this.Fullscreen;
      return dictionary;
    }
  }
}
