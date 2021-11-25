// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MediaPlayerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class MediaPlayerBuilder : WidgetBuilderBase<MediaPlayer, MediaPlayerBuilder>
  {
    public MediaPlayerBuilder(MediaPlayer component)
      : base(component)
    {
    }

    public MediaPlayerBuilder Media(Action<MediaPlayerMediaBuilder> configurator)
    {
      configurator(new MediaPlayerMediaBuilder(this.Component));
      return this;
    }

    public MediaPlayerBuilder AutoPlay(bool value)
    {
      this.Container.AutoPlay = new bool?(value);
      return this;
    }

    public MediaPlayerBuilder AutoPlay()
    {
      this.Container.AutoPlay = new bool?(true);
      return this;
    }

    public MediaPlayerBuilder AutoRepeat(bool value)
    {
      this.Container.AutoRepeat = new bool?(value);
      return this;
    }

    public MediaPlayerBuilder AutoRepeat()
    {
      this.Container.AutoRepeat = new bool?(true);
      return this;
    }

    public MediaPlayerBuilder ForwardSeek(bool value)
    {
      this.Container.ForwardSeek = new bool?(value);
      return this;
    }

    public MediaPlayerBuilder FullScreen(bool value)
    {
      this.Container.FullScreen = new bool?(value);
      return this;
    }

    public MediaPlayerBuilder FullScreen()
    {
      this.Container.FullScreen = new bool?(true);
      return this;
    }

    public MediaPlayerBuilder Messages(
      Action<MediaPlayerMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.MediaPlayer = this.Container;
      configurator(new MediaPlayerMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public MediaPlayerBuilder Mute(bool value)
    {
      this.Container.Mute = new bool?(value);
      return this;
    }

    public MediaPlayerBuilder Mute()
    {
      this.Container.Mute = new bool?(true);
      return this;
    }

    public MediaPlayerBuilder Navigatable(bool value)
    {
      this.Container.Navigatable = new bool?(value);
      return this;
    }

    public MediaPlayerBuilder Navigatable()
    {
      this.Container.Navigatable = new bool?(true);
      return this;
    }

    public MediaPlayerBuilder Volume(double value)
    {
      this.Container.Volume = new double?(value);
      return this;
    }

    public MediaPlayerBuilder Events(Action<MediaPlayerEventBuilder> configurator)
    {
      configurator(new MediaPlayerEventBuilder(this.Container.Events));
      return this;
    }
  }
}
