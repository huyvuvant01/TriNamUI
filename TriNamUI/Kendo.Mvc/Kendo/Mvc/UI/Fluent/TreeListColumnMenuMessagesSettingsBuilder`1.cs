// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListColumnMenuMessagesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListColumnMenuMessagesSettingsBuilder<T> where T : class
  {
    public TreeListColumnMenuMessagesSettingsBuilder(TreeListColumnMenuMessagesSettings<T> container) => this.Container = container;

    protected TreeListColumnMenuMessagesSettings<T> Container { get; private set; }

    public TreeListColumnMenuMessagesSettingsBuilder<T> Columns(
      string value)
    {
      this.Container.Columns = value;
      return this;
    }

    public TreeListColumnMenuMessagesSettingsBuilder<T> Filter(
      string value)
    {
      this.Container.Filter = value;
      return this;
    }

    public TreeListColumnMenuMessagesSettingsBuilder<T> SortAscending(
      string value)
    {
      this.Container.SortAscending = value;
      return this;
    }

    public TreeListColumnMenuMessagesSettingsBuilder<T> SortDescending(
      string value)
    {
      this.Container.SortDescending = value;
      return this;
    }

    public TreeListColumnMenuMessagesSettingsBuilder<T> Settings(
      string value)
    {
      this.Container.Settings = value;
      return this;
    }

    public TreeListColumnMenuMessagesSettingsBuilder<T> Lock(
      string value)
    {
      this.Container.Lock = value;
      return this;
    }

    public TreeListColumnMenuMessagesSettingsBuilder<T> Unlock(
      string value)
    {
      this.Container.Unlock = value;
      return this;
    }
  }
}
