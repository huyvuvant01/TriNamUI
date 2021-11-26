// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartCategoryAxisNotesLabelSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartCategoryAxisNotesLabelSettingsBuilder<T> where T : class
  {
    public ChartCategoryAxisNotesLabelSettingsBuilder(
      ChartCategoryAxisNotesLabelSettings<T> container)
    {
      this.Container = container;
    }

    protected ChartCategoryAxisNotesLabelSettings<T> Container { get; private set; }

    public ChartCategoryAxisNotesLabelSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartCategoryAxisNotesLabelSettingsBuilder<T> Border(
      Action<ChartCategoryAxisNotesLabelBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisNotesLabelBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartCategoryAxisNotesLabelSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartCategoryAxisNotesLabelSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartCategoryAxisNotesLabelSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartCategoryAxisNotesLabelSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartCategoryAxisNotesLabelSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartCategoryAxisNotesLabelSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.Rotation = new double?(value);
      return this;
    }

    public ChartCategoryAxisNotesLabelSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public ChartCategoryAxisNotesLabelSettingsBuilder<T> Position(
      ChartNoteLabelPosition value)
    {
      this.Container.Position = new ChartNoteLabelPosition?(value);
      return this;
    }
  }
}
