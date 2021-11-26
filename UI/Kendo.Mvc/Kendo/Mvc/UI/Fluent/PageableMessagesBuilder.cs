// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PageableMessagesBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PageableMessagesBuilder : IHideObjectMembers
  {
    private readonly PageableMessages messages;

    public PageableMessagesBuilder(PageableMessages messages) => this.messages = messages;

    public PageableMessagesBuilder Display(string message)
    {
      this.messages.Display = message;
      return this;
    }

    public PageableMessagesBuilder Empty(string message)
    {
      this.messages.Empty = message;
      return this;
    }

    public PageableMessagesBuilder Page(string message)
    {
      this.messages.Page = message;
      return this;
    }

    public PageableMessagesBuilder Of(string message)
    {
      this.messages.Of = message;
      return this;
    }

    public PageableMessagesBuilder ItemsPerPage(string message)
    {
      this.messages.ItemsPerPage = message;
      return this;
    }

    public PageableMessagesBuilder First(string message)
    {
      this.messages.First = message;
      return this;
    }

    public PageableMessagesBuilder Previous(string message)
    {
      this.messages.Previous = message;
      return this;
    }

    public PageableMessagesBuilder Next(string message)
    {
      this.messages.Next = message;
      return this;
    }

    public PageableMessagesBuilder Last(string message)
    {
      this.messages.Last = message;
      return this;
    }

    public PageableMessagesBuilder Refresh(string message)
    {
      this.messages.Refresh = message;
      return this;
    }

    public PageableMessagesBuilder MorePages(string message)
    {
      this.messages.MorePages = message;
      return this;
    }

    public PageableMessagesBuilder PageButtonLabel(string message)
    {
      this.messages.PageButtonLabel = message;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
