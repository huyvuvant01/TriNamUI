// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder(
      StockChartNavigatorCategoryAxisNotesLabelSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorCategoryAxisNotesLabelSettings<T> Container { get; private set; }

    public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Border(
      Action<StockChartNavigatorCategoryAxisNotesLabelBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisNotesLabelBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.Rotation = new double?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }
  }
}
