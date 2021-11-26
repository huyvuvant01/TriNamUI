// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListPageableMessagesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListPageableMessagesSettingsBuilder<T> where T : class
  {
    public TreeListPageableMessagesSettingsBuilder(TreeListPageableMessagesSettings<T> container) => this.Container = container;

    protected TreeListPageableMessagesSettings<T> Container { get; private set; }

    public TreeListPageableMessagesSettingsBuilder<T> Display(
      string value)
    {
      this.Container.Display = value;
      return this;
    }

    public TreeListPageableMessagesSettingsBuilder<T> Empty(
      string value)
    {
      this.Container.Empty = value;
      return this;
    }

    public TreeListPageableMessagesSettingsBuilder<T> Page(
      string value)
    {
      this.Container.Page = value;
      return this;
    }

    public TreeListPageableMessagesSettingsBuilder<T> Of(
      string value)
    {
      this.Container.Of = value;
      return this;
    }

    public TreeListPageableMessagesSettingsBuilder<T> ItemsPerPage(
      string value)
    {
      this.Container.ItemsPerPage = value;
      return this;
    }

    public TreeListPageableMessagesSettingsBuilder<T> First(
      string value)
    {
      this.Container.First = value;
      return this;
    }

    public TreeListPageableMessagesSettingsBuilder<T> Last(
      string value)
    {
      this.Container.Last = value;
      return this;
    }

    public TreeListPageableMessagesSettingsBuilder<T> Next(
      string value)
    {
      this.Container.Next = value;
      return this;
    }

    public TreeListPageableMessagesSettingsBuilder<T> Previous(
      string value)
    {
      this.Container.Previous = value;
      return this;
    }

    public TreeListPageableMessagesSettingsBuilder<T> Refresh(
      string value)
    {
      this.Container.Refresh = value;
      return this;
    }

    public TreeListPageableMessagesSettingsBuilder<T> MorePages(
      string value)
    {
      this.Container.MorePages = value;
      return this;
    }
  }
}
