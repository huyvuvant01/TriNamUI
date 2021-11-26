// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChatToolbarSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChatToolbarSettingsBuilder
  {
    public ChatToolbarSettingsBuilder(ChatToolbarSettings container) => this.Container = container;

    protected ChatToolbarSettings Container { get; private set; }

    public ChatToolbarSettingsBuilder Animation(bool enable)
    {
      this.Container.Animation.Enabled = enable;
      return this;
    }

    public ChatToolbarSettingsBuilder Animation(
      Action<ExpandableAnimationBuilder> animationAction)
    {
      animationAction(new ExpandableAnimationBuilder(this.Container.Animation));
      return this;
    }

    public ChatToolbarSettingsBuilder Buttons(
      Action<ChatToolbarSettingsButtonFactory> configurator)
    {
      configurator(new ChatToolbarSettingsButtonFactory(this.Container.Buttons)
      {
        Chat = this.Container.Chat
      });
      return this;
    }

    public ChatToolbarSettingsBuilder Scrollable(bool value)
    {
      this.Container.Scrollable = new bool?(value);
      return this;
    }

    public ChatToolbarSettingsBuilder Toggleable(bool value)
    {
      this.Container.Toggleable = new bool?(value);
      return this;
    }

    public ChatToolbarSettingsBuilder Toggleable()
    {
      this.Container.Toggleable = new bool?(true);
      return this;
    }
  }
}
