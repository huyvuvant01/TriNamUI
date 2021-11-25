// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CustomCrudOperationBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class CustomCrudOperationBuilder : 
    CrudOperationBuilderBase<CustomCrudOperationBuilder>,
    IHideObjectMembers
  {
    public CustomCrudOperationBuilder(
      CrudOperation operation,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(operation, viewContext, urlGenerator)
    {
    }

    public CustomCrudOperationBuilder ContentType(string type)
    {
      this.operation.ContentType = type;
      return this;
    }

    public CustomCrudOperationBuilder Cache(bool isEnabled)
    {
      this.operation.Cache = isEnabled;
      return this;
    }

    public CustomCrudOperationBuilder DataType(string type)
    {
      this.operation.DataType = type.ToLowerInvariant();
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
