// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DateTimePickerMonthTemplateSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class DateTimePickerMonthTemplateSettingsBuilder
  {
    public DateTimePickerMonthTemplateSettingsBuilder(DateTimePickerMonthTemplateSettings container) => this.Container = container;

    protected DateTimePickerMonthTemplateSettings Container { get; private set; }

    public DateTimePickerMonthTemplateSettingsBuilder Empty(
      string value)
    {
      this.Container.Empty = value;
      return this;
    }

    public DateTimePickerMonthTemplateSettingsBuilder EmptyId(
      string value)
    {
      this.Container.EmptyId = value;
      return this;
    }

    public DateTimePickerMonthTemplateSettingsBuilder Content(
      string value)
    {
      this.Container.Content = value;
      return this;
    }

    public DateTimePickerMonthTemplateSettingsBuilder ContentId(
      string value)
    {
      this.Container.ContentId = value;
      return this;
    }

    public DateTimePickerMonthTemplateSettingsBuilder WeekNumber(
      string value)
    {
      this.Container.WeekNumber = value;
      return this;
    }

    public DateTimePickerMonthTemplateSettingsBuilder WeekNumberId(
      string value)
    {
      this.Container.WeekNumberId = value;
      return this;
    }
  }
}
