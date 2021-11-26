// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesNotesLabelSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesNotesLabelSettingsBuilder<T> where T : class
  {
    public ChartSeriesNotesLabelSettingsBuilder(ChartSeriesNotesLabelSettings<T> container) => this.Container = container;

    protected ChartSeriesNotesLabelSettings<T> Container { get; private set; }

    public ChartSeriesNotesLabelSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartSeriesNotesLabelSettingsBuilder<T> Border(
      Action<ChartSeriesNotesLabelBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartSeriesNotesLabelBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartSeriesNotesLabelSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartSeriesNotesLabelSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartSeriesNotesLabelSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartSeriesNotesLabelSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartSeriesNotesLabelSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartSeriesNotesLabelSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.Rotation = new double?(value);
      return this;
    }

    public ChartSeriesNotesLabelSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public ChartSeriesNotesLabelSettingsBuilder<T> Position(
      ChartNoteLabelPosition value)
    {
      this.Container.Position = new ChartNoteLabelPosition?(value);
      return this;
    }
  }
}
