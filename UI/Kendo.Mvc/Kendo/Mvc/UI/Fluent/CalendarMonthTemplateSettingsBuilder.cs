// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CalendarMonthTemplateSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class CalendarMonthTemplateSettingsBuilder
  {
    public CalendarMonthTemplateSettingsBuilder(CalendarMonthTemplateSettings container) => this.Container = container;

    protected CalendarMonthTemplateSettings Container { get; private set; }

    public CalendarMonthTemplateSettingsBuilder Empty(
      string value)
    {
      this.Container.Empty = value;
      return this;
    }

    public CalendarMonthTemplateSettingsBuilder EmptyId(
      string value)
    {
      this.Container.EmptyId = value;
      return this;
    }

    public CalendarMonthTemplateSettingsBuilder Content(
      string value)
    {
      this.Container.Content = value;
      return this;
    }

    public CalendarMonthTemplateSettingsBuilder ContentId(
      string value)
    {
      this.Container.ContentId = value;
      return this;
    }

    public CalendarMonthTemplateSettingsBuilder WeekNumber(
      string value)
    {
      this.Container.WeekNumber = value;
      return this;
    }

    public CalendarMonthTemplateSettingsBuilder WeekNumberId(
      string value)
    {
      this.Container.WeekNumberId = value;
      return this;
    }
  }
}
