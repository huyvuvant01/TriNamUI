// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartLegendInactiveItemsLabelsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartLegendInactiveItemsLabelsSettingsBuilder<T> where T : class
  {
    public ChartLegendInactiveItemsLabelsSettingsBuilder(
      ChartLegendInactiveItemsLabelsSettings<T> container)
    {
      this.Container = container;
    }

    protected ChartLegendInactiveItemsLabelsSettings<T> Container { get; private set; }

    public ChartLegendInactiveItemsLabelsSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartLegendInactiveItemsLabelsSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartLegendInactiveItemsLabelsSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartLegendInactiveItemsLabelsSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }
  }
}
