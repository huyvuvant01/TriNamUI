// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListPageableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListPageableSettingsBuilder<T> where T : class
  {
    public TreeListPageableSettingsBuilder(TreeListPageableSettings<T> container) => this.Container = container;

    protected TreeListPageableSettings<T> Container { get; private set; }

    public TreeListPageableSettingsBuilder<T> PageSizes(
      int[] pageSizes)
    {
      this.Container.PageSizes = pageSizes;
      return this;
    }

    public TreeListPageableSettingsBuilder<T> PageSizes(bool enabled)
    {
      if (enabled)
        this.Container.PageSizes = new int[3]{ 5, 10, 20 };
      else
        this.Container.PageSizes = (int[]) null;
      return this;
    }

    public TreeListPageableSettingsBuilder<T> AlwaysVisible(
      bool value)
    {
      this.Container.AlwaysVisible = new bool?(value);
      return this;
    }

    public TreeListPageableSettingsBuilder<T> PageSize(double value)
    {
      this.Container.PageSize = new double?(value);
      return this;
    }

    public TreeListPageableSettingsBuilder<T> PreviousNext(bool value)
    {
      this.Container.PreviousNext = new bool?(value);
      return this;
    }

    public TreeListPageableSettingsBuilder<T> Numeric(bool value)
    {
      this.Container.Numeric = new bool?(value);
      return this;
    }

    public TreeListPageableSettingsBuilder<T> ButtonCount(
      double value)
    {
      this.Container.ButtonCount = new double?(value);
      return this;
    }

    public TreeListPageableSettingsBuilder<T> Input(bool value)
    {
      this.Container.Input = new bool?(value);
      return this;
    }

    public TreeListPageableSettingsBuilder<T> Input()
    {
      this.Container.Input = new bool?(true);
      return this;
    }

    public TreeListPageableSettingsBuilder<T> Refresh(bool value)
    {
      this.Container.Refresh = new bool?(value);
      return this;
    }

    public TreeListPageableSettingsBuilder<T> Refresh()
    {
      this.Container.Refresh = new bool?(true);
      return this;
    }

    public TreeListPageableSettingsBuilder<T> Responsive(bool value)
    {
      this.Container.Responsive = new bool?(value);
      return this;
    }

    public TreeListPageableSettingsBuilder<T> Responsive()
    {
      this.Container.Responsive = new bool?(true);
      return this;
    }

    public TreeListPageableSettingsBuilder<T> Info(bool value)
    {
      this.Container.Info = new bool?(value);
      return this;
    }

    public TreeListPageableSettingsBuilder<T> Messages(
      Action<TreeListPageableMessagesSettingsBuilder<T>> configurator)
    {
      this.Container.Messages.TreeList = this.Container.TreeList;
      configurator(new TreeListPageableMessagesSettingsBuilder<T>(this.Container.Messages));
      return this;
    }
  }
}
