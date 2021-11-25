// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartTitleSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartTitleSettingsBuilder<T> where T : class
  {
    public ChartTitleSettingsBuilder(ChartTitleSettings<T> container) => this.Container = container;

    protected ChartTitleSettings<T> Container { get; private set; }

    public ChartTitleSettingsBuilder<T> Margin(
      int top,
      int right,
      int bottom,
      int left)
    {
      this.Container.Margin.Top = new double?((double) top);
      this.Container.Margin.Right = new double?((double) right);
      this.Container.Margin.Bottom = new double?((double) bottom);
      this.Container.Margin.Left = new double?((double) left);
      return this;
    }

    public ChartTitleSettingsBuilder<T> Margin(int margin)
    {
      this.Container.Margin.Top = new double?((double) margin);
      this.Container.Margin.Right = new double?((double) margin);
      this.Container.Margin.Bottom = new double?((double) margin);
      this.Container.Margin.Left = new double?((double) margin);
      return this;
    }

    public ChartTitleSettingsBuilder<T> Padding(
      int top,
      int right,
      int bottom,
      int left)
    {
      this.Container.Padding.Top = new double?((double) top);
      this.Container.Padding.Right = new double?((double) right);
      this.Container.Padding.Bottom = new double?((double) bottom);
      this.Container.Padding.Left = new double?((double) left);
      return this;
    }

    public ChartTitleSettingsBuilder<T> Padding(int padding)
    {
      this.Container.Padding.Top = new double?((double) padding);
      this.Container.Padding.Bottom = new double?((double) padding);
      this.Container.Padding.Right = new double?((double) padding);
      this.Container.Padding.Left = new double?((double) padding);
      return this;
    }

    public ChartTitleSettingsBuilder<T> Border(
      int width,
      string color,
      ChartDashType dashType)
    {
      this.Container.Border.Width = new double?((double) width);
      this.Container.Border.Color = color;
      this.Container.Border.DashType = new ChartDashType?(dashType);
      return this;
    }

    public ChartTitleSettingsBuilder<T> Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartTitleSettingsBuilder<T> Border(
      Action<ChartTitleBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartTitleBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartTitleSettingsBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartTitleSettingsBuilder<T> Font(string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartTitleSettingsBuilder<T> Margin(
      Action<ChartTitleMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartTitleMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartTitleSettingsBuilder<T> Padding(
      Action<ChartTitlePaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartTitlePaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartTitleSettingsBuilder<T> Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ChartTitleSettingsBuilder<T> Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartTitleSettingsBuilder<T> Align(ChartTextAlignment value)
    {
      this.Container.Align = new ChartTextAlignment?(value);
      return this;
    }

    public ChartTitleSettingsBuilder<T> Position(ChartTitlePosition value)
    {
      this.Container.Position = new ChartTitlePosition?(value);
      return this;
    }
  }
}
