// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartValueAxisMajorTicksSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartValueAxisMajorTicksSettingsBuilder<T> where T : class
  {
    public ChartValueAxisMajorTicksSettingsBuilder(ChartValueAxisMajorTicksSettings<T> container) => this.Container = container;

    protected ChartValueAxisMajorTicksSettings<T> Container { get; private set; }

    public ChartValueAxisMajorTicksSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartValueAxisMajorTicksSettingsBuilder<T> Size(
      double value)
    {
      this.Container.Size = new double?(value);
      return this;
    }

    public ChartValueAxisMajorTicksSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartValueAxisMajorTicksSettingsBuilder<T> Step(
      double value)
    {
      this.Container.Step = new double?(value);
      return this;
    }

    public ChartValueAxisMajorTicksSettingsBuilder<T> Skip(
      double value)
    {
      this.Container.Skip = new double?(value);
      return this;
    }
  }
}
