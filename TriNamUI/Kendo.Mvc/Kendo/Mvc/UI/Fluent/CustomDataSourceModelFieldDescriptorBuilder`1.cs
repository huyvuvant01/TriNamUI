// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CustomDataSourceModelFieldDescriptorBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class CustomDataSourceModelFieldDescriptorBuilder<T> : 
    DataSourceModelFieldDescriptorBuilderBase<T, CustomDataSourceModelFieldDescriptorBuilder<T>>
  {
    public CustomDataSourceModelFieldDescriptorBuilder(ModelFieldDescriptor descriptor)
      : base(descriptor)
    {
    }

    public virtual CustomDataSourceModelFieldDescriptorBuilder<T> From(
      string fromField)
    {
      this.descriptor.From = fromField;
      return this;
    }

    public virtual CustomDataSourceModelFieldDescriptorBuilder<T> Parse(
      string handler)
    {
      this.descriptor.Parse.HandlerName = handler;
      return this;
    }

    public virtual CustomDataSourceModelFieldDescriptorBuilder<T> Parse(
      Func<object, object> handler)
    {
      this.descriptor.Parse.TemplateDelegate = handler;
      return this;
    }
  }
}
