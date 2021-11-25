// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerEventBuilder : EventBuilder
  {
    public FileManagerEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public FileManagerEventBuilder Navigate(string handler)
    {
      this.Handler("navigate", handler);
      return this;
    }

    public FileManagerEventBuilder Navigate(Func<object, object> handler)
    {
      this.Handler("navigate", handler);
      return this;
    }

    public FileManagerEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public FileManagerEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public FileManagerEventBuilder Open(string handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public FileManagerEventBuilder Open(Func<object, object> handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public FileManagerEventBuilder Execute(string handler)
    {
      this.Handler("execute", handler);
      return this;
    }

    public FileManagerEventBuilder Execute(Func<object, object> handler)
    {
      this.Handler("execute", handler);
      return this;
    }

    public FileManagerEventBuilder Error(string handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public FileManagerEventBuilder Error(Func<object, object> handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public FileManagerEventBuilder DataBinding(string handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public FileManagerEventBuilder DataBinding(Func<object, object> handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public FileManagerEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public FileManagerEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public FileManagerEventBuilder Drop(string handler)
    {
      this.Handler("drop", handler);
      return this;
    }

    public FileManagerEventBuilder Drop(Func<object, object> handler)
    {
      this.Handler("drop", handler);
      return this;
    }

    public FileManagerEventBuilder Command(string handler)
    {
      this.Handler("command", handler);
      return this;
    }

    public FileManagerEventBuilder Command(Func<object, object> handler)
    {
      this.Handler("command", handler);
      return this;
    }
  }
}
