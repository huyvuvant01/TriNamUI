// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartXAxisLineSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartXAxisLineSettingsBuilder<T> where T : class
  {
    public ChartXAxisLineSettingsBuilder(ChartXAxisLineSettings<T> container) => this.Container = container;

    protected ChartXAxisLineSettings<T> Container { get; private set; }

    public ChartXAxisLineSettingsBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartXAxisLineSettingsBuilder<T> DashType(
      ChartDashType value)
    {
      this.Container.DashType = new ChartDashType?(value);
      return this;
    }

    public ChartXAxisLineSettingsBuilder<T> Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartXAxisLineSettingsBuilder<T> Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
