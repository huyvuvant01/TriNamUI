// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PagerMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class PagerMessagesSettingsBuilder
  {
    public PagerMessagesSettingsBuilder(PagerMessagesSettings container) => this.Container = container;

    protected PagerMessagesSettings Container { get; private set; }

    public PagerMessagesSettingsBuilder Display(string value)
    {
      this.Container.Display = value;
      return this;
    }

    public PagerMessagesSettingsBuilder Empty(string value)
    {
      this.Container.Empty = value;
      return this;
    }

    public PagerMessagesSettingsBuilder AllPages(string value)
    {
      this.Container.AllPages = value;
      return this;
    }

    public PagerMessagesSettingsBuilder Page(string value)
    {
      this.Container.Page = value;
      return this;
    }

    public PagerMessagesSettingsBuilder PageButtonLabel(string value)
    {
      this.Container.PageButtonLabel = value;
      return this;
    }

    public PagerMessagesSettingsBuilder Of(string value)
    {
      this.Container.Of = value;
      return this;
    }

    public PagerMessagesSettingsBuilder ItemsPerPage(string value)
    {
      this.Container.ItemsPerPage = value;
      return this;
    }

    public PagerMessagesSettingsBuilder First(string value)
    {
      this.Container.First = value;
      return this;
    }

    public PagerMessagesSettingsBuilder Previous(string value)
    {
      this.Container.Previous = value;
      return this;
    }

    public PagerMessagesSettingsBuilder Next(string value)
    {
      this.Container.Next = value;
      return this;
    }

    public PagerMessagesSettingsBuilder Last(string value)
    {
      this.Container.Last = value;
      return this;
    }

    public PagerMessagesSettingsBuilder Refresh(string value)
    {
      this.Container.Refresh = value;
      return this;
    }
  }
}
