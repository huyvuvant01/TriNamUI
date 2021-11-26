// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartValueAxisMajorGridLinesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartValueAxisMajorGridLinesSettingsBuilder<T> where T : class
  {
    public ChartValueAxisMajorGridLinesSettingsBuilder(
      ChartValueAxisMajorGridLinesSettings<T> container)
    {
      this.Container = container;
    }

    protected ChartValueAxisMajorGridLinesSettings<T> Container { get; private set; }

    public ChartValueAxisMajorGridLinesSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }

    public ChartValueAxisMajorGridLinesSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartValueAxisMajorGridLinesSettingsBuilder<T> DashType(
      ChartDashType value)
    {
      this.Container.DashType = new ChartDashType?(value);
      return this;
    }

    public ChartValueAxisMajorGridLinesSettingsBuilder<T> Type(
      string value)
    {
      this.Container.Type = value;
      return this;
    }

    public ChartValueAxisMajorGridLinesSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartValueAxisMajorGridLinesSettingsBuilder<T> Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public ChartValueAxisMajorGridLinesSettingsBuilder<T> Step(
      double value)
    {
      this.Container.Step = new double?(value);
      return this;
    }

    public ChartValueAxisMajorGridLinesSettingsBuilder<T> Skip(
      double value)
    {
      this.Container.Skip = new double?(value);
      return this;
    }
  }
}
