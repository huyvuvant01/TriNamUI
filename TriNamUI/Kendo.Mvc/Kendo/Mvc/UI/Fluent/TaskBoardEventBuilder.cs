// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TaskBoardEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TaskBoardEventBuilder : EventBuilder
  {
    public TaskBoardEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public TaskBoardEventBuilder ColumnsDataBinding(string handler)
    {
      this.Handler("columnsDataBinding", handler);
      return this;
    }

    public TaskBoardEventBuilder ColumnsDataBinding(
      Func<object, object> handler)
    {
      this.Handler("columnsDataBinding", handler);
      return this;
    }

    public TaskBoardEventBuilder ColumnsDataBound(string handler)
    {
      this.Handler("columnsDataBound", handler);
      return this;
    }

    public TaskBoardEventBuilder ColumnsDataBound(Func<object, object> handler)
    {
      this.Handler("columnsDataBound", handler);
      return this;
    }

    public TaskBoardEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public TaskBoardEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public TaskBoardEventBuilder DataBinding(string handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public TaskBoardEventBuilder DataBinding(Func<object, object> handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public TaskBoardEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public TaskBoardEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public TaskBoardEventBuilder DeleteCard(string handler)
    {
      this.Handler("deleteCard", handler);
      return this;
    }

    public TaskBoardEventBuilder DeleteCard(Func<object, object> handler)
    {
      this.Handler("deleteCard", handler);
      return this;
    }

    public TaskBoardEventBuilder DeleteColumn(string handler)
    {
      this.Handler("deleteColumn", handler);
      return this;
    }

    public TaskBoardEventBuilder DeleteColumn(Func<object, object> handler)
    {
      this.Handler("deleteColumn", handler);
      return this;
    }

    public TaskBoardEventBuilder EditCard(string handler)
    {
      this.Handler("editCard", handler);
      return this;
    }

    public TaskBoardEventBuilder EditCard(Func<object, object> handler)
    {
      this.Handler("editCard", handler);
      return this;
    }

    public TaskBoardEventBuilder EditColumn(string handler)
    {
      this.Handler("editColumn", handler);
      return this;
    }

    public TaskBoardEventBuilder EditColumn(Func<object, object> handler)
    {
      this.Handler("editColumn", handler);
      return this;
    }

    public TaskBoardEventBuilder Execute(string handler)
    {
      this.Handler("execute", handler);
      return this;
    }

    public TaskBoardEventBuilder Execute(Func<object, object> handler)
    {
      this.Handler("execute", handler);
      return this;
    }

    public TaskBoardEventBuilder Move(string handler)
    {
      this.Handler("move", handler);
      return this;
    }

    public TaskBoardEventBuilder Move(Func<object, object> handler)
    {
      this.Handler("move", handler);
      return this;
    }

    public TaskBoardEventBuilder MoveEnd(string handler)
    {
      this.Handler("moveEnd", handler);
      return this;
    }

    public TaskBoardEventBuilder MoveEnd(Func<object, object> handler)
    {
      this.Handler("moveEnd", handler);
      return this;
    }

    public TaskBoardEventBuilder MoveStart(string handler)
    {
      this.Handler("moveStart", handler);
      return this;
    }

    public TaskBoardEventBuilder MoveStart(Func<object, object> handler)
    {
      this.Handler("moveStart", handler);
      return this;
    }

    public TaskBoardEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public TaskBoardEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public TaskBoardEventBuilder SaveCard(string handler)
    {
      this.Handler("saveCard", handler);
      return this;
    }

    public TaskBoardEventBuilder SaveCard(Func<object, object> handler)
    {
      this.Handler("saveCard", handler);
      return this;
    }

    public TaskBoardEventBuilder SaveColumn(string handler)
    {
      this.Handler("saveColumn", handler);
      return this;
    }

    public TaskBoardEventBuilder SaveColumn(Func<object, object> handler)
    {
      this.Handler("saveColumn", handler);
      return this;
    }
  }
}
