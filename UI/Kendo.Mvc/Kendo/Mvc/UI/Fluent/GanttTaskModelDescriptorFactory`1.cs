// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttTaskModelDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttTaskModelDescriptorFactory<TModel> : 
    DataSourceModelDescriptorFactory<TModel>,
    IHideObjectMembers
    where TModel : class
  {
    private GanttTaskModelDescriptor ganttTaskModel;

    public GanttTaskModelDescriptorFactory(GanttTaskModelDescriptor model)
      : base((ModelDescriptor) model)
    {
      this.ganttTaskModel = model;
    }

    public void OrderId<TValue>(Expression<Func<TModel, TValue>> expression) => this.ganttTaskModel.OrderId = expression.MemberWithoutInstance();

    public void OrderId(string fieldName) => this.ganttTaskModel.OrderId = fieldName;

    public void ParentId<TValue>(Expression<Func<TModel, TValue>> expression) => this.ganttTaskModel.ParentId = expression.MemberWithoutInstance();

    public void ParentId(string fieldName) => this.ganttTaskModel.ParentId = fieldName;

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
