// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Diagram.Fluent.DiagramShapeModelDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI.Fluent;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Diagram.Fluent
{
  public class DiagramShapeModelDescriptorFactory<TModel> : 
    DataSourceModelDescriptorFactory<TModel>,
    IHideObjectMembers
    where TModel : class
  {
    private DiagramShapeModelDescriptor shapeModel;

    public DiagramShapeModelDescriptorFactory(DiagramShapeModelDescriptor model)
      : base((ModelDescriptor) model)
    {
      this.shapeModel = model;
    }

    public void Width<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.Width = expression.MemberWithoutInstance();

    public void Width(string fieldName) => this.shapeModel.Width = fieldName;

    public void Height<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.Height = expression.MemberWithoutInstance();

    public void Height(string fieldName) => this.shapeModel.Height = fieldName;

    public void X<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.X = expression.MemberWithoutInstance();

    public void X(string fieldName) => this.shapeModel.X = fieldName;

    public void Y<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.Y = expression.MemberWithoutInstance();

    public void Y(string fieldName) => this.shapeModel.Y = fieldName;

    public void Type<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.Type = expression.MemberWithoutInstance();

    public void Type(string fieldName) => this.shapeModel.Type = fieldName;

    public void Text<TValue>(Expression<Func<TModel, TValue>> expression) => this.shapeModel.Text = expression.MemberWithoutInstance();

    public void Text(string fieldName) => this.shapeModel.Text = fieldName;

    System.Type IHideObjectMembers.GetType() => this.GetType();
  }
}
