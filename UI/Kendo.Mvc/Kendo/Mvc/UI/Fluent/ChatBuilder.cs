// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChatBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChatBuilder : WidgetBuilderBase<Chat, ChatBuilder>
  {
    public ChatBuilder(Chat component)
      : base(component)
    {
    }

    public ChatBuilder Messages(Action<ChatMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.Chat = this.Container;
      configurator(new ChatMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public ChatBuilder User(Action<ChatUserSettingsBuilder> configurator)
    {
      this.Container.User.Chat = this.Container;
      configurator(new ChatUserSettingsBuilder(this.Container.User));
      return this;
    }

    public ChatBuilder Toolbar(Action<ChatToolbarSettingsBuilder> configurator)
    {
      this.Container.Toolbar.Chat = this.Container;
      configurator(new ChatToolbarSettingsBuilder(this.Container.Toolbar));
      return this;
    }

    public ChatBuilder Events(Action<ChatEventBuilder> configurator)
    {
      configurator(new ChatEventBuilder(this.Container.Events));
      return this;
    }
  }
}
