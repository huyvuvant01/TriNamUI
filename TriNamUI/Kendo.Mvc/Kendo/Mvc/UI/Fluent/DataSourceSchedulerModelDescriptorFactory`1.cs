// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceSchedulerModelDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceSchedulerModelDescriptorFactory<TModel> : 
    DataSourceModelDescriptorFactory<TModel>,
    IHideObjectMembers
    where TModel : class
  {
    private SchedulerModelDescriptor schedulerModel;

    public DataSourceSchedulerModelDescriptorFactory(SchedulerModelDescriptor model)
      : base((ModelDescriptor) model)
    {
      this.schedulerModel = model;
    }

    public void RecurrenceId<TValue>(Expression<Func<TModel, TValue>> expression) => this.schedulerModel.RecurrenceId = expression.MemberWithoutInstance();

    public void RecurrenceId(string fieldName) => this.schedulerModel.RecurrenceId = fieldName;

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
