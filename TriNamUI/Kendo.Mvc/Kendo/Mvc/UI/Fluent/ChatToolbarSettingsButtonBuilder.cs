// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChatToolbarSettingsButtonBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChatToolbarSettingsButtonBuilder
  {
    public ChatToolbarSettingsButtonBuilder(ChatToolbarSettingsButton container) => this.Container = container;

    protected ChatToolbarSettingsButton Container { get; private set; }

    public ChatToolbarSettingsButtonBuilder Attr(object attributes)
    {
      this.Container.Attr = attributes;
      return this;
    }

    public ChatToolbarSettingsButtonBuilder Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public ChatToolbarSettingsButtonBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ChatToolbarSettingsButtonBuilder IconClass(string value)
    {
      this.Container.IconClass = value;
      return this;
    }
  }
}
