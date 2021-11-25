// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ReadOnlyCustomDataSourceModelDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ReadOnlyCustomDataSourceModelDescriptorFactory<TModel> : 
    DataSourceModelDescriptorFactoryBase<TModel>,
    IHideObjectMembers
    where TModel : class
  {
    public ReadOnlyCustomDataSourceModelDescriptorFactory(ModelDescriptor model)
      : base(model)
    {
    }

    public new void Id(string fieldName) => base.Id(fieldName);

    public virtual CustomDataSourceModelFieldDescriptorBuilder<TModel> Field(
      string memberName,
      Type memberType)
    {
      return this.AddFieldDescriptor<TModel>(memberName, memberType);
    }

    private CustomDataSourceModelFieldDescriptorBuilder<TValue> AddFieldDescriptor<TValue>(
      string memberName,
      Type memberType)
    {
      ModelFieldDescriptor descriptor = this.model.AddDescriptor(memberName);
      descriptor.MemberType = memberType;
      return new CustomDataSourceModelFieldDescriptorBuilder<TValue>(descriptor);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
