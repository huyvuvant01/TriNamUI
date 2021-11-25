// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridColumnMenuMessagesBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridColumnMenuMessagesBuilder : IHideObjectMembers
  {
    private readonly GridColumnMenuMessages messages;

    public GridColumnMenuMessagesBuilder(GridColumnMenuMessages messages) => this.messages = messages;

    public GridColumnMenuMessagesBuilder Filter(string message)
    {
      this.messages.Filter = message;
      return this;
    }

    public GridColumnMenuMessagesBuilder Columns(string message)
    {
      this.messages.Columns = message;
      return this;
    }

    public GridColumnMenuMessagesBuilder SetColumnPosition(
      string message)
    {
      this.messages.SetColumnPosition = message;
      return this;
    }

    public GridColumnMenuMessagesBuilder SortAscending(string message)
    {
      this.messages.SortAscending = message;
      return this;
    }

    public GridColumnMenuMessagesBuilder SortDescending(string message)
    {
      this.messages.SortDescending = message;
      return this;
    }

    public GridColumnMenuMessagesBuilder ColumnSettings(string message)
    {
      this.messages.ColumnSettings = message;
      return this;
    }

    public GridColumnMenuMessagesBuilder Lock(string message)
    {
      this.messages.Lock = message;
      return this;
    }

    public GridColumnMenuMessagesBuilder Unlock(string message)
    {
      this.messages.Unlock = message;
      return this;
    }

    public GridColumnMenuMessagesBuilder Stick(string message)
    {
      this.messages.Stick = message;
      return this;
    }

    public GridColumnMenuMessagesBuilder Unstick(string message)
    {
      this.messages.Unstick = message;
      return this;
    }

    public GridColumnMenuMessagesBuilder Apply(string message)
    {
      this.messages.Apply = message;
      return this;
    }

    public GridColumnMenuMessagesBuilder Reset(string message)
    {
      this.messages.Reset = message;
      return this;
    }

    public GridColumnMenuMessagesBuilder ButtonTitle(string message)
    {
      this.messages.ButtonTitle = message;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
