// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FilterableMessagesBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FilterableMessagesBuilder : IHideObjectMembers
  {
    private readonly GridFilterableMessages messages;

    public FilterableMessagesBuilder(GridFilterableMessages messages) => this.messages = messages;

    public FilterableMessagesBuilder Info(string message)
    {
      this.messages.Info = message;
      return this;
    }

    public FilterableMessagesBuilder Title(string message)
    {
      this.messages.Title = message;
      return this;
    }

    public FilterableMessagesBuilder And(string message)
    {
      this.messages.And = message;
      return this;
    }

    public FilterableMessagesBuilder Or(string message)
    {
      this.messages.Or = message;
      return this;
    }

    public FilterableMessagesBuilder IsTrue(string message)
    {
      this.messages.IsTrue = message;
      return this;
    }

    public FilterableMessagesBuilder IsFalse(string message)
    {
      this.messages.IsFalse = message;
      return this;
    }

    public FilterableMessagesBuilder Filter(string message)
    {
      this.messages.Filter = message;
      return this;
    }

    public FilterableMessagesBuilder SelectValue(string message)
    {
      this.messages.SelectValue = message;
      return this;
    }

    public FilterableMessagesBuilder Clear(string message)
    {
      this.messages.Clear = message;
      return this;
    }

    public FilterableMessagesBuilder Operator(string message)
    {
      this.messages.Operator = message;
      return this;
    }

    public FilterableMessagesBuilder AdditionalOperator(string message)
    {
      this.messages.AdditionalOperator = message;
      return this;
    }

    public FilterableMessagesBuilder Value(string message)
    {
      this.messages.Value = message;
      return this;
    }

    public FilterableMessagesBuilder AdditionalValue(string message)
    {
      this.messages.AdditionalValue = message;
      return this;
    }

    public FilterableMessagesBuilder Search(string message)
    {
      this.messages.Search = message;
      return this;
    }

    public FilterableMessagesBuilder Logic(string message)
    {
      this.messages.Logic = message;
      return this;
    }

    public FilterableMessagesBuilder SelectedItemsFormat(string message)
    {
      this.messages.SelectedItemsFormat = message;
      return this;
    }

    public FilterableMessagesBuilder ButtonTitle(string message)
    {
      this.messages.ButtonTitle = message;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
