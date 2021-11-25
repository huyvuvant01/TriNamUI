// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotDataSourceSchemaSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("schema", ParentTag = "kendo-pivotdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("schema", ParentTag = "pivot-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("cube", new string[] {})]
  public class PivotDataSourceSchemaSettingsTagHelper : DataSourceSchemaSettingsTagHelper
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PivotDataSourceTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PivotDataSourceTagHelper).Schema = this;
    }

    internal override Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = base.Serialize();
      string axes = this.Axes;
      if ((axes != null ? (axes.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["axes"] = (object) this.Axes;
      }
      else
      {
        string axesHandler = this.AxesHandler;
        if ((axesHandler != null ? (axesHandler.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["axes"] = (object) new ClientHandlerDescriptor()
          {
            HandlerName = this.AxesHandler
          };
      }
      string catalogs = this.Catalogs;
      if ((catalogs != null ? (catalogs.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["catalogs"] = (object) this.Catalogs;
      }
      else
      {
        string catalogsHandler = this.CatalogsHandler;
        if ((catalogsHandler != null ? (catalogsHandler.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["catalogs"] = (object) new ClientHandlerDescriptor()
          {
            HandlerName = this.CatalogsHandler
          };
      }
      string cubes = this.Cubes;
      if ((cubes != null ? (cubes.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["cubes"] = (object) this.Cubes;
      }
      else
      {
        string cubesHandler = this.CubesHandler;
        if ((cubesHandler != null ? (cubesHandler.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["cubes"] = (object) new ClientHandlerDescriptor()
          {
            HandlerName = this.CubesHandler
          };
      }
      if (this.Cube != null)
        dictionary["cube"] = (object) this.Cube.Serialize();
      string dimensions = this.Dimensions;
      if ((dimensions != null ? (dimensions.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["dimensions"] = (object) this.Dimensions;
      }
      else
      {
        string dimensionsHandler = this.DimensionsHandler;
        if ((dimensionsHandler != null ? (dimensionsHandler.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["dimensions"] = (object) new ClientHandlerDescriptor()
          {
            HandlerName = this.DimensionsHandler
          };
      }
      string hierarchies = this.Hierarchies;
      if ((hierarchies != null ? (hierarchies.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["hierarchies"] = (object) this.Hierarchies;
      }
      else
      {
        string hierarchiesHandler = this.HierarchiesHandler;
        if ((hierarchiesHandler != null ? (hierarchiesHandler.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["hierarchies"] = (object) new ClientHandlerDescriptor()
          {
            HandlerName = this.HierarchiesHandler
          };
      }
      string levels = this.Levels;
      if ((levels != null ? (levels.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["levels"] = (object) this.Levels;
      }
      else
      {
        string levelsHandler = this.LevelsHandler;
        if ((levelsHandler != null ? (levelsHandler.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["levels"] = (object) new ClientHandlerDescriptor()
          {
            HandlerName = this.LevelsHandler
          };
      }
      string measures = this.Measures;
      if ((measures != null ? (measures.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["measures"] = (object) this.Measures;
      }
      else
      {
        string measuresHandler = this.MeasuresHandler;
        if ((measuresHandler != null ? (measuresHandler.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["measures"] = (object) new ClientHandlerDescriptor()
          {
            HandlerName = this.MeasuresHandler
          };
      }
      return dictionary;
    }

    public string Axes { get; set; }

    public string AxesHandler { get; set; }

    public string Catalogs { get; set; }

    public string CatalogsHandler { get; set; }

    public string Cubes { get; set; }

    public string CubesHandler { get; set; }

    public new string Datahandler { get; set; }

    public string Dimensions { get; set; }

    public string DimensionsHandler { get; set; }

    public string Hierarchies { get; set; }

    public string HierarchiesHandler { get; set; }

    public string Levels { get; set; }

    public string LevelsHandler { get; set; }

    public string Measures { get; set; }

    public string MeasuresHandler { get; set; }

    public PivotDataSourceSchemaCubeTagHelper Cube { get; set; }
  }
}
