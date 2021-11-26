// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MediaPlayerEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class MediaPlayerEventBuilder : EventBuilder
  {
    public MediaPlayerEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public MediaPlayerEventBuilder End(string handler)
    {
      this.Handler("end", handler);
      return this;
    }

    public MediaPlayerEventBuilder End(Func<object, object> handler)
    {
      this.Handler("end", handler);
      return this;
    }

    public MediaPlayerEventBuilder Pause(string handler)
    {
      this.Handler("pause", handler);
      return this;
    }

    public MediaPlayerEventBuilder Pause(Func<object, object> handler)
    {
      this.Handler("pause", handler);
      return this;
    }

    public MediaPlayerEventBuilder Play(string handler)
    {
      this.Handler("play", handler);
      return this;
    }

    public MediaPlayerEventBuilder Play(Func<object, object> handler)
    {
      this.Handler("play", handler);
      return this;
    }

    public MediaPlayerEventBuilder Ready(string handler)
    {
      this.Handler("ready", handler);
      return this;
    }

    public MediaPlayerEventBuilder Ready(Func<object, object> handler)
    {
      this.Handler("ready", handler);
      return this;
    }

    public MediaPlayerEventBuilder TimeChange(string handler)
    {
      this.Handler("timeChange", handler);
      return this;
    }

    public MediaPlayerEventBuilder TimeChange(Func<object, object> handler)
    {
      this.Handler("timeChange", handler);
      return this;
    }

    public MediaPlayerEventBuilder VolumeChange(string handler)
    {
      this.Handler("volumeChange", handler);
      return this;
    }

    public MediaPlayerEventBuilder VolumeChange(Func<object, object> handler)
    {
      this.Handler("volumeChange", handler);
      return this;
    }
  }
}
