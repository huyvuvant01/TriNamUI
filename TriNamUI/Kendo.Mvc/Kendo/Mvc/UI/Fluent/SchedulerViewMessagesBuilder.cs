// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerViewMessagesBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerViewMessagesBuilder : IHideObjectMembers
  {
    private readonly SchedulerViewMessages viewMessages;

    public SchedulerViewMessagesBuilder(SchedulerViewMessages viewMessages) => this.viewMessages = viewMessages;

    public SchedulerViewMessagesBuilder Day(string message)
    {
      this.viewMessages.Day = message;
      return this;
    }

    public SchedulerViewMessagesBuilder Week(string message)
    {
      this.viewMessages.Week = message;
      return this;
    }

    public SchedulerViewMessagesBuilder WorkWeek(string message)
    {
      this.viewMessages.WorkWeek = message;
      return this;
    }

    public SchedulerViewMessagesBuilder Month(string message)
    {
      this.viewMessages.Month = message;
      return this;
    }

    public SchedulerViewMessagesBuilder Agenda(string message)
    {
      this.viewMessages.Agenda = message;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
