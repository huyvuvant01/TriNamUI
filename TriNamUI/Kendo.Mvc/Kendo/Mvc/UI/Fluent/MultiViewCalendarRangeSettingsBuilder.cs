﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MultiViewCalendarRangeSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class MultiViewCalendarRangeSettingsBuilder
  {
    public MultiViewCalendarRangeSettingsBuilder(MultiViewCalendarRangeSettings container) => this.Container = container;

    protected MultiViewCalendarRangeSettings Container { get; private set; }

    public MultiViewCalendarRangeSettingsBuilder Start(
      DateTime value)
    {
      this.Container.Start = new DateTime?(value);
      return this;
    }

    public MultiViewCalendarRangeSettingsBuilder End(
      DateTime value)
    {
      this.Container.End = new DateTime?(value);
      return this;
    }
  }
}
