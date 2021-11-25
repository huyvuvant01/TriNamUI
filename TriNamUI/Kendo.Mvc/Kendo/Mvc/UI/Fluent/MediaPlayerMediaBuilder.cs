// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MediaPlayerMediaBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class MediaPlayerMediaBuilder
  {
    protected MediaPlayer Component { get; private set; }

    public MediaPlayerMediaBuilder(MediaPlayer component) => this.Component = component;

    public MediaPlayerMediaBuilder Title(string title)
    {
      this.Component.Media.Title = title;
      return this;
    }

    public MediaPlayerMediaBuilder Source(object source)
    {
      this.Component.Media.Source = source;
      return this;
    }
  }
}
