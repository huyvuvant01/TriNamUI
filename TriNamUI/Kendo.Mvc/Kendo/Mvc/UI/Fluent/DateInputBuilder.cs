// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DateInputBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DateInputBuilder : WidgetBuilderBase<DateInput, DateInputBuilder>
  {
    public DateInputBuilder(DateInput component)
      : base(component)
    {
    }

    public DateInputBuilder Max(DateTime? value)
    {
      this.Container.Max = value;
      return this;
    }

    public DateInputBuilder Min(DateTime? value)
    {
      this.Container.Min = value;
      return this;
    }

    public DateInputBuilder Value(DateTime? value)
    {
      this.Container.Value = value;
      return this;
    }

    public DateInputBuilder Format(string value)
    {
      this.Container.Format = value;
      return this;
    }

    public DateInputBuilder Max(DateTime value)
    {
      this.Container.Max = new DateTime?(value);
      return this;
    }

    public DateInputBuilder Min(DateTime value)
    {
      this.Container.Min = new DateTime?(value);
      return this;
    }

    public DateInputBuilder Value(DateTime value)
    {
      this.Container.Value = new DateTime?(value);
      return this;
    }

    public DateInputBuilder Messages(
      Action<DateInputMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.DateInput = this.Container;
      configurator(new DateInputMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public DateInputBuilder Events(Action<DateInputEventBuilder> configurator)
    {
      configurator(new DateInputEventBuilder(this.Container.Events));
      return this;
    }
  }
}
