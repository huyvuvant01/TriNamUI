// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridColumnFilterableCellSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GridColumnFilterableCellSettings : JsonObject
  {
    public GridColumnFilterableCellSettings(IModelMetadataProvider modelMetadataProvider)
    {
      this.Enabled = true;
      this.ShowOperators = true;
      this.Delay = 200.0;
      this.MinLength = 1;
      this.SuggestionOperator = FilterType.StartsWith;
      this.Operator = "eq";
      this.Template = new ClientHandlerDescriptor();
      this.DataSource = new DataSource(modelMetadataProvider);
      this.DataSource.Transport.SerializeEmptyPrefix = false;
      this.DataSource.Schema.Data = "";
      this.DataSource.Schema.Total = "";
      this.DataSource.Schema.Errors = "";
    }

    public string Operator { get; set; }

    public double Delay { get; set; }

    public int MinLength { get; set; }

    public FilterType SuggestionOperator { get; set; }

    public int? InputWidth { get; set; }

    public string DataTextField { get; set; }

    public bool Enabled { get; set; }

    public bool ShowOperators { get; set; }

    public ClientHandlerDescriptor Template { get; set; }

    public DataSource DataSource { get; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (!this.Enabled)
        json["enabled"] = (object) this.Enabled;
      if (this.Template.HasValue())
        json["template"] = (object) this.Template;
      if (!this.ShowOperators)
        json["showOperators"] = (object) this.ShowOperators;
      if (this.Delay != 200.0)
        json["delay"] = (object) this.Delay;
      if (this.InputWidth.HasValue)
        json["inputWidth"] = (object) this.InputWidth;
      if (this.SuggestionOperator != FilterType.StartsWith)
        json["suggestionOperator"] = (object) this.SuggestionOperator;
      if (this.MinLength != 1)
        json["minLength"] = (object) this.MinLength;
      if (this.Operator != "eq")
        json["operator"] = (object) this.Operator;
      if (this.DataTextField != null)
        json["dataTextField"] = (object) this.DataTextField;
      if (!string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
      {
        json["dataSource"] = (object) this.DataSource.ToJson();
      }
      else
      {
        if (this.DataSource.Data == null)
          return;
        json["dataSource"] = (object) this.DataSource.Data;
      }
    }
  }
}
