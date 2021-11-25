// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartTooltipSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartTooltipSettingsBuilder<T> where T : class
  {
    public ChartTooltipSettingsBuilder(ChartTooltipSettings<T> container) => this.Container = container;

    protected ChartTooltipSettings<T> Container { get; private set; }

    public ChartTooltipSettingsBuilder<T> AutoHide(bool value)
    {
      this.Container.AutoHide = new bool?(value);
      return this;
    }

    public ChartTooltipSettingsBuilder<T> Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartTooltipSettingsBuilder<T> Border(
      Action<ChartTooltipBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartTooltipBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartTooltipSettingsBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartTooltipSettingsBuilder<T> Font(string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartTooltipSettingsBuilder<T> Format(string value)
    {
      this.Container.Format = value;
      return this;
    }

    public ChartTooltipSettingsBuilder<T> Opacity(double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public ChartTooltipSettingsBuilder<T> Padding(
      Action<ChartTooltipPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartTooltipPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartTooltipSettingsBuilder<T> Shared(bool value)
    {
      this.Container.Shared = new bool?(value);
      return this;
    }

    public ChartTooltipSettingsBuilder<T> Shared()
    {
      this.Container.Shared = new bool?(true);
      return this;
    }

    public ChartTooltipSettingsBuilder<T> SharedTemplate(string value)
    {
      this.Container.SharedTemplate = value;
      return this;
    }

    public ChartTooltipSettingsBuilder<T> SharedTemplateId(
      string templateId)
    {
      this.Container.SharedTemplateId = templateId;
      return this;
    }

    public ChartTooltipSettingsBuilder<T> Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartTooltipSettingsBuilder<T> TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartTooltipSettingsBuilder<T> Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartTooltipSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }
  }
}
