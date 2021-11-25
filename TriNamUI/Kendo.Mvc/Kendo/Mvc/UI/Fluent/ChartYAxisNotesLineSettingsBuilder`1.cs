// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartYAxisNotesLineSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartYAxisNotesLineSettingsBuilder<T> where T : class
  {
    public ChartYAxisNotesLineSettingsBuilder(ChartYAxisNotesLineSettings<T> container) => this.Container = container;

    protected ChartYAxisNotesLineSettings<T> Container { get; private set; }

    public ChartYAxisNotesLineSettingsBuilder<T> DashType(
      ChartDashType value)
    {
      this.Container.DashType = new ChartDashType?(value);
      return this;
    }

    public ChartYAxisNotesLineSettingsBuilder<T> Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public ChartYAxisNotesLineSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartYAxisNotesLineSettingsBuilder<T> Length(
      double value)
    {
      this.Container.Length = new double?(value);
      return this;
    }
  }
}
