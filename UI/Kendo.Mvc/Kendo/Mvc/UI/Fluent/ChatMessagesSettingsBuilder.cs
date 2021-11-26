// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChatMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChatMessagesSettingsBuilder
  {
    public ChatMessagesSettingsBuilder(ChatMessagesSettings container) => this.Container = container;

    protected ChatMessagesSettings Container { get; private set; }

    public ChatMessagesSettingsBuilder Placeholder(string value)
    {
      this.Container.Placeholder = value;
      return this;
    }

    public ChatMessagesSettingsBuilder SendButton(string value)
    {
      this.Container.SendButton = value;
      return this;
    }

    public ChatMessagesSettingsBuilder ToggleButton(string value)
    {
      this.Container.ToggleButton = value;
      return this;
    }
  }
}
