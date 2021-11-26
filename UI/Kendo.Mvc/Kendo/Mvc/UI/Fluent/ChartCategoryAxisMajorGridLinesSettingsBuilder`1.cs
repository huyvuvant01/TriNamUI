// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartCategoryAxisMajorGridLinesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartCategoryAxisMajorGridLinesSettingsBuilder<T> where T : class
  {
    public ChartCategoryAxisMajorGridLinesSettingsBuilder(
      ChartCategoryAxisMajorGridLinesSettings<T> container)
    {
      this.Container = container;
    }

    protected ChartCategoryAxisMajorGridLinesSettings<T> Container { get; private set; }

    public ChartCategoryAxisMajorGridLinesSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }

    public ChartCategoryAxisMajorGridLinesSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartCategoryAxisMajorGridLinesSettingsBuilder<T> DashType(
      ChartDashType value)
    {
      this.Container.DashType = new ChartDashType?(value);
      return this;
    }

    public ChartCategoryAxisMajorGridLinesSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartCategoryAxisMajorGridLinesSettingsBuilder<T> Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public ChartCategoryAxisMajorGridLinesSettingsBuilder<T> Step(
      double value)
    {
      this.Container.Step = new double?(value);
      return this;
    }

    public ChartCategoryAxisMajorGridLinesSettingsBuilder<T> Skip(
      double value)
    {
      this.Container.Skip = new double?(value);
      return this;
    }
  }
}
