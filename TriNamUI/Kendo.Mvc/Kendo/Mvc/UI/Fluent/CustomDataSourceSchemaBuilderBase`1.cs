// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CustomDataSourceSchemaBuilderBase`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class CustomDataSourceSchemaBuilderBase<TDataSourceSchemaBuilder> : 
    IHideObjectMembers
    where TDataSourceSchemaBuilder : CustomDataSourceSchemaBuilderBase<TDataSourceSchemaBuilder>
  {
    protected readonly DataSourceSchema schema;

    public CustomDataSourceSchemaBuilderBase(DataSourceSchema schema) => this.schema = schema;

    public virtual TDataSourceSchemaBuilder Aggregates(string aggregates)
    {
      this.schema.Aggregates = aggregates;
      return (TDataSourceSchemaBuilder) this;
    }

    public virtual TDataSourceSchemaBuilder Aggregates(Func<object, object> handler)
    {
      this.schema.FunctionAggregates.TemplateDelegate = handler;
      return (TDataSourceSchemaBuilder) this;
    }

    public virtual TDataSourceSchemaBuilder Groups(string groups)
    {
      this.schema.Groups = groups;
      return (TDataSourceSchemaBuilder) this;
    }

    public virtual TDataSourceSchemaBuilder Groups(Func<object, object> handler)
    {
      this.schema.FunctionGroups.TemplateDelegate = handler;
      return (TDataSourceSchemaBuilder) this;
    }

    public virtual TDataSourceSchemaBuilder Data(string data)
    {
      this.schema.Data = data;
      return (TDataSourceSchemaBuilder) this;
    }

    public virtual TDataSourceSchemaBuilder Data(Func<object, object> handler)
    {
      this.schema.FunctionData.TemplateDelegate = handler;
      return (TDataSourceSchemaBuilder) this;
    }

    public virtual TDataSourceSchemaBuilder Total(string total)
    {
      this.schema.Total = total;
      return (TDataSourceSchemaBuilder) this;
    }

    public virtual TDataSourceSchemaBuilder Total(Func<object, object> handler)
    {
      this.schema.FunctionTotal.TemplateDelegate = handler;
      return (TDataSourceSchemaBuilder) this;
    }

    public virtual TDataSourceSchemaBuilder Errors(string errors)
    {
      this.schema.Errors = errors;
      return (TDataSourceSchemaBuilder) this;
    }

    public virtual TDataSourceSchemaBuilder Errors(Func<object, object> handler)
    {
      this.schema.FunctionErrors.TemplateDelegate = handler;
      return (TDataSourceSchemaBuilder) this;
    }

    public virtual TDataSourceSchemaBuilder Parse(Func<object, object> handler)
    {
      this.schema.Parse.TemplateDelegate = handler;
      return (TDataSourceSchemaBuilder) this;
    }

    public virtual TDataSourceSchemaBuilder Type(string type)
    {
      this.schema.Type = type;
      return (TDataSourceSchemaBuilder) this;
    }

    System.Type IHideObjectMembers.GetType() => this.GetType();
  }
}
