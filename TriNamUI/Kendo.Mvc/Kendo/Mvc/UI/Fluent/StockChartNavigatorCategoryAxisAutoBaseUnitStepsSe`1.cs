// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder(
      StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettings<T> Container { get; private set; }

    public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Seconds(
      params int[] value)
    {
      this.Container.Seconds = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Minutes(
      params int[] value)
    {
      this.Container.Minutes = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Hours(
      params int[] value)
    {
      this.Container.Hours = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Days(
      params int[] value)
    {
      this.Container.Days = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Weeks(
      params int[] value)
    {
      this.Container.Weeks = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Months(
      params int[] value)
    {
      this.Container.Months = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T> Years(
      params int[] value)
    {
      this.Container.Years = value;
      return this;
    }
  }
}
