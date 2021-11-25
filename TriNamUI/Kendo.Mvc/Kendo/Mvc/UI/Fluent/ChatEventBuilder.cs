// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChatEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChatEventBuilder : EventBuilder
  {
    public ChatEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public ChatEventBuilder ActionClick(string handler)
    {
      this.Handler("actionClick", handler);
      return this;
    }

    public ChatEventBuilder ActionClick(Func<object, object> handler)
    {
      this.Handler("actionClick", handler);
      return this;
    }

    public ChatEventBuilder Post(string handler)
    {
      this.Handler("post", handler);
      return this;
    }

    public ChatEventBuilder Post(Func<object, object> handler)
    {
      this.Handler("post", handler);
      return this;
    }

    public ChatEventBuilder SendMessage(string handler)
    {
      this.Handler("sendMessage", handler);
      return this;
    }

    public ChatEventBuilder SendMessage(Func<object, object> handler)
    {
      this.Handler("sendMessage", handler);
      return this;
    }

    public ChatEventBuilder TypingEnd(string handler)
    {
      this.Handler("typingEnd", handler);
      return this;
    }

    public ChatEventBuilder TypingEnd(Func<object, object> handler)
    {
      this.Handler("typingEnd", handler);
      return this;
    }

    public ChatEventBuilder TypingStart(string handler)
    {
      this.Handler("typingStart", handler);
      return this;
    }

    public ChatEventBuilder TypingStart(Func<object, object> handler)
    {
      this.Handler("typingStart", handler);
      return this;
    }

    public ChatEventBuilder ToolClick(string handler)
    {
      this.Handler("toolClick", handler);
      return this;
    }

    public ChatEventBuilder ToolClick(Func<object, object> handler)
    {
      this.Handler("toolClick", handler);
      return this;
    }
  }
}
