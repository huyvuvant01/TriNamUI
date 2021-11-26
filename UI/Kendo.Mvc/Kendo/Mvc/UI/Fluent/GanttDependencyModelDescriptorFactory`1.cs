// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttDependencyModelDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttDependencyModelDescriptorFactory<TModel> : 
    DataSourceModelDescriptorFactory<TModel>,
    IHideObjectMembers
    where TModel : class
  {
    private GanttDependencyModelDescriptor ganttDependencyModel;

    public GanttDependencyModelDescriptorFactory(GanttDependencyModelDescriptor model)
      : base((ModelDescriptor) model)
    {
      this.ganttDependencyModel = model;
    }

    public void Type<TValue>(Expression<Func<TModel, TValue>> expression) => this.ganttDependencyModel.Type = expression.MemberWithoutInstance();

    public void Type(string fieldName) => this.ganttDependencyModel.Type = fieldName;

    public void PredecessorId<TValue>(Expression<Func<TModel, TValue>> expression) => this.ganttDependencyModel.PredecessorId = expression.MemberWithoutInstance();

    public void PredecessorId(string fieldName) => this.ganttDependencyModel.PredecessorId = fieldName;

    public void SuccessorId<TValue>(Expression<Func<TModel, TValue>> expression) => this.ganttDependencyModel.SuccessorId = expression.MemberWithoutInstance();

    public void SuccessorId(string fieldName) => this.ganttDependencyModel.SuccessorId = fieldName;

    System.Type IHideObjectMembers.GetType() => this.GetType();
  }
}
