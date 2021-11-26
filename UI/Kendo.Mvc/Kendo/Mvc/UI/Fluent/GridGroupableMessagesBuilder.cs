// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridGroupableMessagesBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridGroupableMessagesBuilder : IHideObjectMembers
  {
    private readonly GridGroupableMessages messages;

    public GridGroupableMessagesBuilder(GridGroupableMessages messages) => this.messages = messages;

    public GridGroupableMessagesBuilder Empty(string message)
    {
      this.messages.Empty = message;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
