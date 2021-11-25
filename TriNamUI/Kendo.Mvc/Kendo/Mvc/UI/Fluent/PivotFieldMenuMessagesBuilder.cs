// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotFieldMenuMessagesBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotFieldMenuMessagesBuilder
  {
    private readonly PivotFieldMenuMessages messages;

    public PivotFieldMenuMessagesBuilder(PivotFieldMenuMessages messages) => this.messages = messages;

    public PivotFieldMenuMessagesBuilder Info(string message)
    {
      this.messages.Info = message;
      return this;
    }

    public PivotFieldMenuMessagesBuilder FilterFields(string message)
    {
      this.messages.FilterFields = message;
      return this;
    }

    public PivotFieldMenuMessagesBuilder Filter(string message)
    {
      this.messages.Filter = message;
      return this;
    }

    public PivotFieldMenuMessagesBuilder Include(string message)
    {
      this.messages.Include = message;
      return this;
    }

    public PivotFieldMenuMessagesBuilder Title(string message)
    {
      this.messages.Title = message;
      return this;
    }

    public PivotFieldMenuMessagesBuilder Clear(string message)
    {
      this.messages.Clear = message;
      return this;
    }

    public PivotFieldMenuMessagesBuilder Ok(string message)
    {
      this.messages.Ok = message;
      return this;
    }

    public PivotFieldMenuMessagesBuilder Cancel(string message)
    {
      this.messages.Cancel = message;
      return this;
    }

    public PivotFieldMenuMessagesBuilder Operators(
      Action<StringOperatorsBuilder> addViewAction)
    {
      StringOperatorsBuilder operatorsBuilder = new StringOperatorsBuilder(this.messages.Operators);
      addViewAction(operatorsBuilder);
      return this;
    }
  }
}
