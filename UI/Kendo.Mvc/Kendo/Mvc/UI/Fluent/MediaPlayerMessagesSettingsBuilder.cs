// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MediaPlayerMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class MediaPlayerMessagesSettingsBuilder
  {
    public MediaPlayerMessagesSettingsBuilder(MediaPlayerMessagesSettings container) => this.Container = container;

    protected MediaPlayerMessagesSettings Container { get; private set; }

    public MediaPlayerMessagesSettingsBuilder Pause(string value)
    {
      this.Container.Pause = value;
      return this;
    }

    public MediaPlayerMessagesSettingsBuilder Play(string value)
    {
      this.Container.Play = value;
      return this;
    }

    public MediaPlayerMessagesSettingsBuilder Mute(string value)
    {
      this.Container.Mute = value;
      return this;
    }

    public MediaPlayerMessagesSettingsBuilder Unmute(string value)
    {
      this.Container.Unmute = value;
      return this;
    }

    public MediaPlayerMessagesSettingsBuilder Quality(string value)
    {
      this.Container.Quality = value;
      return this;
    }

    public MediaPlayerMessagesSettingsBuilder Fullscreen(
      string value)
    {
      this.Container.Fullscreen = value;
      return this;
    }
  }
}
