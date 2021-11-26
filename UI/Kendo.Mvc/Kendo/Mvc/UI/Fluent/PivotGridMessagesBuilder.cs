// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotGridMessagesBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotGridMessagesBuilder
  {
    private readonly PivotGridMessages messages;

    public PivotGridMessagesBuilder(PivotGridMessages messages) => this.messages = messages;

    public PivotGridMessagesBuilder MeasureFields(string message)
    {
      this.messages.MeasureFields = message;
      return this;
    }

    public PivotGridMessagesBuilder ColumnFields(string message)
    {
      this.messages.ColumnFields = message;
      return this;
    }

    public PivotGridMessagesBuilder RowFields(string message)
    {
      this.messages.RowFields = message;
      return this;
    }

    public PivotGridMessagesBuilder FieldMenu(
      Action<PivotFieldMenuMessagesBuilder> addViewAction)
    {
      PivotFieldMenuMessagesBuilder menuMessagesBuilder = new PivotFieldMenuMessagesBuilder(this.messages.FieldMenu);
      addViewAction(menuMessagesBuilder);
      return this;
    }
  }
}
