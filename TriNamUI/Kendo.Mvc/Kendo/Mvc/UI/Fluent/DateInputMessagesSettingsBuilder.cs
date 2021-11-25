// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DateInputMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class DateInputMessagesSettingsBuilder
  {
    public DateInputMessagesSettingsBuilder(DateInputMessagesSettings container) => this.Container = container;

    protected DateInputMessagesSettings Container { get; private set; }

    public DateInputMessagesSettingsBuilder Year(string value)
    {
      this.Container.Year = value;
      return this;
    }

    public DateInputMessagesSettingsBuilder Month(string value)
    {
      this.Container.Month = value;
      return this;
    }

    public DateInputMessagesSettingsBuilder Day(string value)
    {
      this.Container.Day = value;
      return this;
    }

    public DateInputMessagesSettingsBuilder Weekday(string value)
    {
      this.Container.Weekday = value;
      return this;
    }

    public DateInputMessagesSettingsBuilder Hour(string value)
    {
      this.Container.Hour = value;
      return this;
    }

    public DateInputMessagesSettingsBuilder Minute(string value)
    {
      this.Container.Minute = value;
      return this;
    }

    public DateInputMessagesSettingsBuilder Second(string value)
    {
      this.Container.Second = value;
      return this;
    }

    public DateInputMessagesSettingsBuilder Dayperiod(string value)
    {
      this.Container.Dayperiod = value;
      return this;
    }
  }
}
