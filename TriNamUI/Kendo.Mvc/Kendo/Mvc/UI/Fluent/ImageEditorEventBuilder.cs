// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ImageEditorEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ImageEditorEventBuilder : EventBuilder
  {
    public ImageEditorEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public ImageEditorEventBuilder ImageLoaded(string handler)
    {
      this.Handler("imageLoaded", handler);
      return this;
    }

    public ImageEditorEventBuilder ImageLoaded(Func<object, object> handler)
    {
      this.Handler("imageLoaded", handler);
      return this;
    }

    public ImageEditorEventBuilder ImageRendered(string handler)
    {
      this.Handler("imageRendered", handler);
      return this;
    }

    public ImageEditorEventBuilder ImageRendered(Func<object, object> handler)
    {
      this.Handler("imageRendered", handler);
      return this;
    }

    public ImageEditorEventBuilder Execute(string handler)
    {
      this.Handler("execute", handler);
      return this;
    }

    public ImageEditorEventBuilder Execute(Func<object, object> handler)
    {
      this.Handler("execute", handler);
      return this;
    }

    public ImageEditorEventBuilder Error(string handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public ImageEditorEventBuilder Error(Func<object, object> handler)
    {
      this.Handler("error", handler);
      return this;
    }
  }
}
