// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DateRangePickerRangeSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DateRangePickerRangeSettingsBuilder
  {
    public DateRangePickerRangeSettingsBuilder(DateRangePickerRangeSettings container) => this.Container = container;

    protected DateRangePickerRangeSettings Container { get; private set; }

    public DateRangePickerRangeSettingsBuilder Start(
      DateTime? value)
    {
      this.Container.Start = value;
      return this;
    }

    public DateRangePickerRangeSettingsBuilder End(
      DateTime? value)
    {
      this.Container.End = value;
      return this;
    }

    public DateRangePickerRangeSettingsBuilder Start(
      DateTime value)
    {
      this.Container.Start = new DateTime?(value);
      return this;
    }

    public DateRangePickerRangeSettingsBuilder End(DateTime value)
    {
      this.Container.End = new DateTime?(value);
      return this;
    }
  }
}
