// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CalendarMonthSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class CalendarMonthSettingsBuilder
  {
    public CalendarMonthSettingsBuilder(CalendarMonthSettings container) => this.Container = container;

    protected CalendarMonthSettings Container { get; private set; }

    public CalendarMonthSettingsBuilder Content(string value)
    {
      this.Container.Content = value;
      return this;
    }

    public CalendarMonthSettingsBuilder Empty(string value)
    {
      this.Container.Empty = value;
      return this;
    }
  }
}
