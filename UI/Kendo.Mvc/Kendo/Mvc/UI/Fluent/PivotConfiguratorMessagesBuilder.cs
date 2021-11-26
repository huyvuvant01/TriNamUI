// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotConfiguratorMessagesBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotConfiguratorMessagesBuilder
  {
    private readonly PivotConfiguratorMessages messages;

    public PivotConfiguratorMessagesBuilder(PivotConfiguratorMessages messages) => this.messages = messages;

    public PivotConfiguratorMessagesBuilder Measures(string message)
    {
      this.messages.Measures = message;
      return this;
    }

    public PivotConfiguratorMessagesBuilder Columns(string message)
    {
      this.messages.Columns = message;
      return this;
    }

    public PivotConfiguratorMessagesBuilder Rows(string message)
    {
      this.messages.Rows = message;
      return this;
    }

    public PivotConfiguratorMessagesBuilder MeasuresLabel(
      string message)
    {
      this.messages.MeasuresLabel = message;
      return this;
    }

    public PivotConfiguratorMessagesBuilder ColumnsLabel(
      string message)
    {
      this.messages.ColumnsLabel = message;
      return this;
    }

    public PivotConfiguratorMessagesBuilder RowsLabel(string message)
    {
      this.messages.RowsLabel = message;
      return this;
    }

    public PivotConfiguratorMessagesBuilder FieldsLabel(
      string message)
    {
      this.messages.FieldsLabel = message;
      return this;
    }

    public PivotConfiguratorMessagesBuilder FieldMenu(
      Action<PivotFieldMenuMessagesBuilder> addViewAction)
    {
      PivotFieldMenuMessagesBuilder menuMessagesBuilder = new PivotFieldMenuMessagesBuilder(this.messages.FieldMenu);
      addViewAction(menuMessagesBuilder);
      return this;
    }
  }
}
