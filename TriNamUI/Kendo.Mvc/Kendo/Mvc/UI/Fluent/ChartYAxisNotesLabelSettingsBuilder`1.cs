// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartYAxisNotesLabelSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartYAxisNotesLabelSettingsBuilder<T> where T : class
  {
    public ChartYAxisNotesLabelSettingsBuilder(ChartYAxisNotesLabelSettings<T> container) => this.Container = container;

    protected ChartYAxisNotesLabelSettings<T> Container { get; private set; }

    public ChartYAxisNotesLabelSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartYAxisNotesLabelSettingsBuilder<T> Border(
      Action<ChartYAxisNotesLabelBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartYAxisNotesLabelBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartYAxisNotesLabelSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartYAxisNotesLabelSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartYAxisNotesLabelSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartYAxisNotesLabelSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartYAxisNotesLabelSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartYAxisNotesLabelSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.Rotation = new double?(value);
      return this;
    }

    public ChartYAxisNotesLabelSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public ChartYAxisNotesLabelSettingsBuilder<T> Position(
      ChartNoteLabelPosition value)
    {
      this.Container.Position = new ChartNoteLabelPosition?(value);
      return this;
    }
  }
}
