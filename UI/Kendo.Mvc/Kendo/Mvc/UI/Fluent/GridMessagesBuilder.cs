// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridMessagesBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridMessagesBuilder : IHideObjectMembers
  {
    private readonly GridMessages settings;

    public GridMessagesBuilder(GridMessages settings) => this.settings = settings;

    public GridMessagesBuilder NoRecords(string value)
    {
      this.settings.NoRecords = value;
      return this;
    }

    public GridMessagesBuilder ExpandCollapseColumnHeader(string value)
    {
      this.settings.ЕxpandCollapseColumnHeader = value;
      return this;
    }

    public GridMessagesBuilder GroupHeader(string value)
    {
      this.settings.GroupHeader = value;
      return this;
    }

    public GridMessagesBuilder UngroupHeader(string value)
    {
      this.settings.UngroupHeader = value;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
