// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MultiSelectMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class MultiSelectMessagesSettingsBuilder
  {
    public MultiSelectMessagesSettingsBuilder(MultiSelectMessagesSettings container) => this.Container = container;

    protected MultiSelectMessagesSettings Container { get; private set; }

    public MultiSelectMessagesSettingsBuilder Clear(string value)
    {
      this.Container.Clear = value;
      return this;
    }

    public MultiSelectMessagesSettingsBuilder DeleteTag(
      string value)
    {
      this.Container.DeleteTag = value;
      return this;
    }

    public MultiSelectMessagesSettingsBuilder DownArrow(
      string value)
    {
      this.Container.DownArrow = value;
      return this;
    }

    public MultiSelectMessagesSettingsBuilder NoData(string value)
    {
      this.Container.NoData = value;
      return this;
    }

    public MultiSelectMessagesSettingsBuilder SingleTag(
      string value)
    {
      this.Container.SingleTag = value;
      return this;
    }
  }
}
