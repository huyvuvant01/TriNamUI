// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorCategoryAxisNotesIconBorderSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorCategoryAxisNotesIconBorderSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorCategoryAxisNotesIconBorderSettingsBuilder(
      StockChartNavigatorCategoryAxisNotesIconBorderSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorCategoryAxisNotesIconBorderSettings<T> Container { get; private set; }

    public StockChartNavigatorCategoryAxisNotesIconBorderSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesIconBorderSettingsBuilder<T> Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
