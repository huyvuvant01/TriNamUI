// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FilterMessagesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FilterMessagesSettingsBuilder<T> where T : class
  {
    public FilterMessagesSettingsBuilder(FilterMessagesSettings<T> container) => this.Container = container;

    protected FilterMessagesSettings<T> Container { get; private set; }

    public FilterMessagesSettingsBuilder<T> AddExpression(string value)
    {
      this.Container.AddExpression = value;
      return this;
    }

    public FilterMessagesSettingsBuilder<T> AddGroup(string value)
    {
      this.Container.AddGroup = value;
      return this;
    }

    public FilterMessagesSettingsBuilder<T> And(string value)
    {
      this.Container.And = value;
      return this;
    }

    public FilterMessagesSettingsBuilder<T> Apply(string value)
    {
      this.Container.Apply = value;
      return this;
    }

    public FilterMessagesSettingsBuilder<T> Close(string value)
    {
      this.Container.Close = value;
      return this;
    }

    public FilterMessagesSettingsBuilder<T> Fields(string value)
    {
      this.Container.Fields = value;
      return this;
    }

    public FilterMessagesSettingsBuilder<T> Operators(string value)
    {
      this.Container.Operators = value;
      return this;
    }

    public FilterMessagesSettingsBuilder<T> Or(string value)
    {
      this.Container.Or = value;
      return this;
    }
  }
}
