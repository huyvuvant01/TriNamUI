﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartAxisDefaultsTitlePaddingSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartAxisDefaultsTitlePaddingSettingsBuilder<T> where T : class
  {
    public ChartAxisDefaultsTitlePaddingSettingsBuilder(
      ChartAxisDefaultsTitlePaddingSettings<T> container)
    {
      this.Container = container;
    }

    protected ChartAxisDefaultsTitlePaddingSettings<T> Container { get; private set; }

    public ChartAxisDefaultsTitlePaddingSettingsBuilder<T> Bottom(
      double value)
    {
      this.Container.Bottom = new double?(value);
      return this;
    }

    public ChartAxisDefaultsTitlePaddingSettingsBuilder<T> Left(
      double value)
    {
      this.Container.Left = new double?(value);
      return this;
    }

    public ChartAxisDefaultsTitlePaddingSettingsBuilder<T> Right(
      double value)
    {
      this.Container.Right = new double?(value);
      return this;
    }

    public ChartAxisDefaultsTitlePaddingSettingsBuilder<T> Top(
      double value)
    {
      this.Container.Top = new double?(value);
      return this;
    }
  }
}
