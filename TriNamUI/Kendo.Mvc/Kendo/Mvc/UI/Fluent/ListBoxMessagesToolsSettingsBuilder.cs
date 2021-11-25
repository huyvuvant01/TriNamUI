// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ListBoxMessagesToolsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ListBoxMessagesToolsSettingsBuilder
  {
    public ListBoxMessagesToolsSettingsBuilder(ListBoxMessagesToolsSettings container) => this.Container = container;

    protected ListBoxMessagesToolsSettings Container { get; private set; }

    public ListBoxMessagesToolsSettingsBuilder MoveDown(
      string value)
    {
      this.Container.MoveDown = value;
      return this;
    }

    public ListBoxMessagesToolsSettingsBuilder MoveUp(
      string value)
    {
      this.Container.MoveUp = value;
      return this;
    }

    public ListBoxMessagesToolsSettingsBuilder Remove(
      string value)
    {
      this.Container.Remove = value;
      return this;
    }

    public ListBoxMessagesToolsSettingsBuilder TransferAllFrom(
      string value)
    {
      this.Container.TransferAllFrom = value;
      return this;
    }

    public ListBoxMessagesToolsSettingsBuilder TransferAllTo(
      string value)
    {
      this.Container.TransferAllTo = value;
      return this;
    }

    public ListBoxMessagesToolsSettingsBuilder TransferFrom(
      string value)
    {
      this.Container.TransferFrom = value;
      return this;
    }

    public ListBoxMessagesToolsSettingsBuilder TransferTo(
      string value)
    {
      this.Container.TransferTo = value;
      return this;
    }
  }
}
