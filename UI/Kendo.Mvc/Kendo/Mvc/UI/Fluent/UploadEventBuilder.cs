// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.UploadEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class UploadEventBuilder : EventBuilder
  {
    public UploadEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public UploadEventBuilder Cancel(string handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public UploadEventBuilder Cancel(Func<object, object> handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public UploadEventBuilder Clear(string handler)
    {
      this.Handler("clear", handler);
      return this;
    }

    public UploadEventBuilder Clear(Func<object, object> handler)
    {
      this.Handler("clear", handler);
      return this;
    }

    public UploadEventBuilder Complete(string handler)
    {
      this.Handler("complete", handler);
      return this;
    }

    public UploadEventBuilder Complete(Func<object, object> handler)
    {
      this.Handler("complete", handler);
      return this;
    }

    public UploadEventBuilder Error(string handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public UploadEventBuilder Error(Func<object, object> handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public UploadEventBuilder Pause(string handler)
    {
      this.Handler("pause", handler);
      return this;
    }

    public UploadEventBuilder Pause(Func<object, object> handler)
    {
      this.Handler("pause", handler);
      return this;
    }

    public UploadEventBuilder Progress(string handler)
    {
      this.Handler("progress", handler);
      return this;
    }

    public UploadEventBuilder Progress(Func<object, object> handler)
    {
      this.Handler("progress", handler);
      return this;
    }

    public UploadEventBuilder Resume(string handler)
    {
      this.Handler("resume", handler);
      return this;
    }

    public UploadEventBuilder Resume(Func<object, object> handler)
    {
      this.Handler("resume", handler);
      return this;
    }

    public UploadEventBuilder Remove(string handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public UploadEventBuilder Remove(Func<object, object> handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public UploadEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public UploadEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public UploadEventBuilder Success(string handler)
    {
      this.Handler("success", handler);
      return this;
    }

    public UploadEventBuilder Success(Func<object, object> handler)
    {
      this.Handler("success", handler);
      return this;
    }

    public UploadEventBuilder Upload(string handler)
    {
      this.Handler("upload", handler);
      return this;
    }

    public UploadEventBuilder Upload(Func<object, object> handler)
    {
      this.Handler("upload", handler);
      return this;
    }
  }
}
