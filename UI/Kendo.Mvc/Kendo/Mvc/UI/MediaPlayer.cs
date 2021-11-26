// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MediaPlayer
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class MediaPlayer : WidgetBase
  {
    public MediaPlayer(ViewContext viewContext)
      : base(viewContext)
    {
      this.Media = new MediaPlayerMedia();
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Media.Source != null && !string.IsNullOrEmpty(this.Media.Title))
        dictionary["media"] = (object) this.Media.ToJson();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (MediaPlayer), (IDictionary<string, object>) dictionary));
    }

    public MediaPlayerMedia Media { get; set; }

    public bool? AutoPlay { get; set; }

    public bool? AutoRepeat { get; set; }

    public bool? ForwardSeek { get; set; }

    public bool? FullScreen { get; set; }

    public MediaPlayerMessagesSettings Messages { get; } = new MediaPlayerMessagesSettings();

    public bool? Mute { get; set; }

    public bool? Navigatable { get; set; }

    public double? Volume { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoPlay.HasValue)
        dictionary["autoPlay"] = (object) this.AutoPlay;
      if (this.AutoRepeat.HasValue)
        dictionary["autoRepeat"] = (object) this.AutoRepeat;
      if (this.ForwardSeek.HasValue)
        dictionary["forwardSeek"] = (object) this.ForwardSeek;
      if (this.FullScreen.HasValue)
        dictionary["fullScreen"] = (object) this.FullScreen;
      Dictionary<string, object> source = this.Messages.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source;
      if (this.Mute.HasValue)
        dictionary["mute"] = (object) this.Mute;
      if (this.Navigatable.HasValue)
        dictionary["navigatable"] = (object) this.Navigatable;
      if (this.Volume.HasValue)
        dictionary["volume"] = (object) this.Volume;
      return dictionary;
    }
  }
}
