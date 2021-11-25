// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ISchedulerEvent
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI
{
  public interface ISchedulerEvent
  {
    string Title { get; set; }

    string Description { get; set; }

    bool IsAllDay { get; set; }

    DateTime Start { get; set; }

    DateTime End { get; set; }

    string StartTimezone { get; set; }

    string EndTimezone { get; set; }

    string RecurrenceRule { get; set; }

    string RecurrenceException { get; set; }
  }
}
