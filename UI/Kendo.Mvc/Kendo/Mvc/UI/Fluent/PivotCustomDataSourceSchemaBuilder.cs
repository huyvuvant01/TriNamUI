// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotCustomDataSourceSchemaBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotCustomDataSourceSchemaBuilder
  {
    protected readonly PivotDataSourceSchema schema;

    public PivotCustomDataSourceSchemaBuilder(PivotDataSourceSchema schema) => this.schema = schema;

    public virtual PivotCustomDataSourceSchemaBuilder Axes(
      string axes)
    {
      this.schema.Axes = axes;
      return this;
    }

    public virtual PivotCustomDataSourceSchemaBuilder Axes(
      Func<object, object> handler)
    {
      this.schema.FunctionAxes.TemplateDelegate = handler;
      return this;
    }

    public virtual PivotCustomDataSourceSchemaBuilder Cubes(
      string cubes)
    {
      this.schema.Cubes = cubes;
      return this;
    }

    public virtual PivotCustomDataSourceSchemaBuilder Cubes(
      Func<object, object> handler)
    {
      this.schema.FunctionCubes.TemplateDelegate = handler;
      return this;
    }

    public virtual PivotCustomDataSourceSchemaBuilder Catalogs(
      string catalogs)
    {
      this.schema.Catalogs = catalogs;
      return this;
    }

    public virtual PivotCustomDataSourceSchemaBuilder Catalogs(
      Func<object, object> handler)
    {
      this.schema.FunctionCatalogs.TemplateDelegate = handler;
      return this;
    }

    public virtual PivotCustomDataSourceSchemaBuilder Measures(
      string measures)
    {
      this.schema.Measures = measures;
      return this;
    }

    public virtual PivotCustomDataSourceSchemaBuilder Measures(
      Func<object, object> handler)
    {
      this.schema.FunctionMeasures.TemplateDelegate = handler;
      return this;
    }

    public virtual PivotCustomDataSourceSchemaBuilder Dimensions(
      string dimensions)
    {
      this.schema.Dimensions = dimensions;
      return this;
    }

    public virtual PivotCustomDataSourceSchemaBuilder Dimensions(
      Func<object, object> handler)
    {
      this.schema.FunctionDimensions.TemplateDelegate = handler;
      return this;
    }

    public virtual PivotCustomDataSourceSchemaBuilder Hierarchies(
      string hierarchies)
    {
      this.schema.Hierarchies = hierarchies;
      return this;
    }

    public virtual PivotCustomDataSourceSchemaBuilder Hierarchies(
      Func<object, object> handler)
    {
      this.schema.FunctionHierarchies.TemplateDelegate = handler;
      return this;
    }

    public virtual PivotCustomDataSourceSchemaBuilder Levels(
      string levels)
    {
      this.schema.Levels = levels;
      return this;
    }

    public virtual PivotCustomDataSourceSchemaBuilder Levels(
      Func<object, object> handler)
    {
      this.schema.FunctionLevels.TemplateDelegate = handler;
      return this;
    }

    public virtual PivotCustomDataSourceSchemaBuilder Type(
      string type)
    {
      this.schema.Type = type;
      return this;
    }
  }
}
