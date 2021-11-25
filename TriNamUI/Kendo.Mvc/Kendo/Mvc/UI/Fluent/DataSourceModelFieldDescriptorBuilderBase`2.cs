// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceModelFieldDescriptorBuilderBase`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class DataSourceModelFieldDescriptorBuilderBase<T, TDataSourceModelFieldDescriptorBuilder>
    where TDataSourceModelFieldDescriptorBuilder : DataSourceModelFieldDescriptorBuilderBase<T, TDataSourceModelFieldDescriptorBuilder>
  {
    protected readonly ModelFieldDescriptor descriptor;

    public DataSourceModelFieldDescriptorBuilderBase(ModelFieldDescriptor descriptor) => this.descriptor = descriptor;

    public virtual TDataSourceModelFieldDescriptorBuilder DefaultValue(T value)
    {
      this.descriptor.DefaultValue = (object) value;
      return (TDataSourceModelFieldDescriptorBuilder) this;
    }

    public virtual TDataSourceModelFieldDescriptorBuilder DefaultValue(object value)
    {
      this.descriptor.DefaultValue = value;
      return (TDataSourceModelFieldDescriptorBuilder) this;
    }

    public virtual TDataSourceModelFieldDescriptorBuilder Editable()
    {
      this.descriptor.IsEditable = true;
      return (TDataSourceModelFieldDescriptorBuilder) this;
    }

    public virtual TDataSourceModelFieldDescriptorBuilder Editable(bool enabled)
    {
      this.descriptor.IsEditable = enabled;
      return (TDataSourceModelFieldDescriptorBuilder) this;
    }
  }
}
