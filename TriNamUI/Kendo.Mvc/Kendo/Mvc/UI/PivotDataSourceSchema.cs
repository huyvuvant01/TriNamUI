// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PivotDataSourceSchema
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PivotDataSourceSchema : JsonObject
  {
    public string Axes { get; set; }

    public ClientHandlerDescriptor FunctionAxes { get; set; }

    public string Cubes { get; set; }

    public ClientHandlerDescriptor FunctionCubes { get; set; }

    public string Catalogs { get; set; }

    public ClientHandlerDescriptor FunctionCatalogs { get; set; }

    public string Measures { get; set; }

    public ClientHandlerDescriptor FunctionMeasures { get; set; }

    public string Dimensions { get; set; }

    public ClientHandlerDescriptor FunctionDimensions { get; set; }

    public string Hierarchies { get; set; }

    public ClientHandlerDescriptor FunctionHierarchies { get; set; }

    public string Levels { get; set; }

    public ClientHandlerDescriptor FunctionLevels { get; set; }

    public string Type { get; set; }

    public PivotDataSourceSchemaCube Cube { get; set; }

    public string Data { get; set; }

    public string Total { get; set; }

    public string Errors { get; set; }

    public ModelDescriptor Model { get; set; }

    public PivotDataSourceSchema()
    {
      this.FunctionAxes = new ClientHandlerDescriptor();
      this.FunctionCubes = new ClientHandlerDescriptor();
      this.FunctionCatalogs = new ClientHandlerDescriptor();
      this.FunctionMeasures = new ClientHandlerDescriptor();
      this.FunctionDimensions = new ClientHandlerDescriptor();
      this.FunctionHierarchies = new ClientHandlerDescriptor();
      this.FunctionLevels = new ClientHandlerDescriptor();
      this.Cube = new PivotDataSourceSchemaCube();
    }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.FunctionAxes.HasValue())
        json.Add("axes", (object) this.FunctionAxes);
      else
        json.Add<string>("axes", this.Axes, string.Empty);
      if (this.FunctionCubes.HasValue())
        json.Add("cubes", (object) this.FunctionCubes);
      else
        json.Add<string>("cubes", this.Cubes, string.Empty);
      if (this.FunctionCatalogs.HasValue())
        json.Add("catalogs", (object) this.FunctionCatalogs);
      else
        json.Add<string>("catalogs", this.Catalogs, string.Empty);
      if (this.FunctionMeasures.HasValue())
        json.Add("measures", (object) this.FunctionMeasures);
      else
        json.Add<string>("measures", this.Measures, string.Empty);
      if (this.FunctionDimensions.HasValue())
        json.Add("dimensions", (object) this.FunctionDimensions);
      else
        json.Add<string>("dimensions", this.Dimensions, string.Empty);
      if (this.FunctionHierarchies.HasValue())
        json.Add("hierarchies", (object) this.FunctionHierarchies);
      else
        json.Add<string>("hierarchies", this.Hierarchies, string.Empty);
      if (this.FunctionLevels.HasValue())
        json.Add("levels", (object) this.FunctionLevels);
      else
        json.Add<string>("levels", this.Levels, string.Empty);
      if (!string.IsNullOrEmpty(this.Data))
        json.Add("data", (object) this.Data);
      if (!string.IsNullOrEmpty(this.Total))
        json.Add("total", (object) this.Total);
      if (!string.IsNullOrEmpty(this.Errors))
        json.Add("errors", (object) this.Errors);
      if (!string.IsNullOrEmpty(this.Type))
        json.Add("type", (object) this.Type);
      IDictionary<string, object> json1 = this.Cube.ToJson();
      if (json1.Keys.Any<string>())
        json["cube"] = (object) json1;
      if (this.Model == null)
        return;
      IDictionary<string, object> json2 = this.Model.ToJson();
      if (json2.Count <= 0)
        return;
      json.Add("model", (object) json2);
    }
  }
}
