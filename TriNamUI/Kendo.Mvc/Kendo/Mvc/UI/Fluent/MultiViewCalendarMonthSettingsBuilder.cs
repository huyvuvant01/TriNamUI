// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MultiViewCalendarMonthSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class MultiViewCalendarMonthSettingsBuilder
  {
    public MultiViewCalendarMonthSettingsBuilder(MultiViewCalendarMonthSettings container) => this.Container = container;

    protected MultiViewCalendarMonthSettings Container { get; private set; }

    public MultiViewCalendarMonthSettingsBuilder Content(
      string value)
    {
      this.Container.Content = value;
      return this;
    }

    public MultiViewCalendarMonthSettingsBuilder WeekNumber(
      string value)
    {
      this.Container.WeekNumber = value;
      return this;
    }

    public MultiViewCalendarMonthSettingsBuilder Empty(
      string value)
    {
      this.Container.Empty = value;
      return this;
    }
  }
}
