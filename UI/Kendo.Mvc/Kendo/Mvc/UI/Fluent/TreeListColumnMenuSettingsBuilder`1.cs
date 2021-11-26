// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListColumnMenuSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListColumnMenuSettingsBuilder<T> where T : class
  {
    public TreeListColumnMenuSettingsBuilder(TreeListColumnMenuSettings<T> container) => this.Container = container;

    protected TreeListColumnMenuSettings<T> Container { get; private set; }

    public TreeListColumnMenuSettingsBuilder<T> Columns(bool value)
    {
      this.Container.Columns = new bool?(value);
      return this;
    }

    public TreeListColumnMenuSettingsBuilder<T> Filterable(
      bool value)
    {
      this.Container.Filterable = new bool?(value);
      return this;
    }

    public TreeListColumnMenuSettingsBuilder<T> Sortable(bool value)
    {
      this.Container.Sortable = new bool?(value);
      return this;
    }

    public TreeListColumnMenuSettingsBuilder<T> Messages(
      Action<TreeListColumnMenuMessagesSettingsBuilder<T>> configurator)
    {
      this.Container.Messages.TreeList = this.Container.TreeList;
      configurator(new TreeListColumnMenuMessagesSettingsBuilder<T>(this.Container.Messages));
      return this;
    }
  }
}
