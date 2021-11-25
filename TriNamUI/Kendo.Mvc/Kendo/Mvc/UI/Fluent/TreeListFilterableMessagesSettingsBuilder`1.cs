// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListFilterableMessagesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListFilterableMessagesSettingsBuilder<T> where T : class
  {
    public TreeListFilterableMessagesSettingsBuilder(TreeListFilterableMessagesSettings<T> container) => this.Container = container;

    protected TreeListFilterableMessagesSettings<T> Container { get; private set; }

    public TreeListFilterableMessagesSettingsBuilder<T> And(
      string value)
    {
      this.Container.And = value;
      return this;
    }

    public TreeListFilterableMessagesSettingsBuilder<T> Clear(
      string value)
    {
      this.Container.Clear = value;
      return this;
    }

    public TreeListFilterableMessagesSettingsBuilder<T> Filter(
      string value)
    {
      this.Container.Filter = value;
      return this;
    }

    public TreeListFilterableMessagesSettingsBuilder<T> Info(
      string value)
    {
      this.Container.Info = value;
      return this;
    }

    public TreeListFilterableMessagesSettingsBuilder<T> Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }

    public TreeListFilterableMessagesSettingsBuilder<T> IsFalse(
      string value)
    {
      this.Container.IsFalse = value;
      return this;
    }

    public TreeListFilterableMessagesSettingsBuilder<T> IsTrue(
      string value)
    {
      this.Container.IsTrue = value;
      return this;
    }

    public TreeListFilterableMessagesSettingsBuilder<T> Or(
      string value)
    {
      this.Container.Or = value;
      return this;
    }
  }
}
