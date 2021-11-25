// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Diagram.Fluent.DiagramConnectionModelDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI.Fluent;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Diagram.Fluent
{
  public class DiagramConnectionModelDescriptorFactory<TModel> : 
    DataSourceModelDescriptorFactory<TModel>,
    IHideObjectMembers
    where TModel : class
  {
    private DiagramConnectionModelDescriptor shapeModel;

    public DiagramConnectionModelDescriptorFactory(DiagramConnectionModelDescriptor model)
      : base((ModelDescriptor) model)
    {
      this.shapeModel = model;
    }

    public void From<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.From = expression.MemberWithoutInstance();

    public void From(string fieldName) => this.shapeModel.From = fieldName;

    public void To<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.To = expression.MemberWithoutInstance();

    public void To(string fieldName) => this.shapeModel.To = fieldName;

    public void FromX<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.FromX = expression.MemberWithoutInstance();

    public void FromX(string fieldName) => this.shapeModel.FromX = fieldName;

    public void FromY<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.FromY = expression.MemberWithoutInstance();

    public void FromY(string fieldName) => this.shapeModel.FromY = fieldName;

    public void ToX<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.ToX = expression.MemberWithoutInstance();

    public void ToX(string fieldName) => this.shapeModel.ToX = fieldName;

    public void ToY<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.ToY = expression.MemberWithoutInstance();

    public void ToY(string fieldName) => this.shapeModel.ToY = fieldName;

    public void Type<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.Type = expression.MemberWithoutInstance();

    public void Type(string fieldName) => this.shapeModel.Type = fieldName;

    public void Text<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.Text = expression.MemberWithoutInstance();

    public void Text(string fieldName) => this.shapeModel.Text = fieldName;

    public void FromConnector<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.FromConnector = expression.MemberWithoutInstance();

    public void FromConnector(string fieldName) => this.shapeModel.FromConnector = fieldName;

    public void ToConnector<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.ToConnector = expression.MemberWithoutInstance();

    public void ToConnector(string fieldName) => this.shapeModel.ToConnector = fieldName;

    System.Type IHideObjectMembers.GetType() => this.GetType();
  }
}
