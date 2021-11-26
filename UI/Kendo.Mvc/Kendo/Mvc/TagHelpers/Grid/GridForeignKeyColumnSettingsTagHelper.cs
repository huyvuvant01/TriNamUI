// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.Grid.GridForeignKeyColumnSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.TagHelpers.Grid
{
  [HtmlTargetElement("foreign-key-column", ParentTag = "columns", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("filterable", new string[] {"commands", "columns", "sortable", "groupable", "datasource"})]
  [SuppressTagRendering]
  public class GridForeignKeyColumnSettingsTagHelper : 
    GridColumnTagHelper,
    IDataBoundWidget<DataSourceTagHelper>
  {
    private SelectList Data { get; set; }

    public IEnumerable Values { get; set; }

    public string TextField { get; set; }

    public string ValueField { get; set; }

    public DataSourceTagHelper Datasource { get; set; }

    internal override Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = base.Serialize();
      if (this.Values != null)
      {
        this.Data = new SelectList(this.Values, this.ValueField, this.TextField);
        dictionary["values"] = (object) this.Data.Select(i => new
        {
          text = i.Text,
          value = i.Value
        });
      }
      if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      if (!string.IsNullOrEmpty(this.ValueField))
        dictionary["dataValueField"] = (object) this.ValueField;
      if (!string.IsNullOrEmpty(this.TextField))
        dictionary["dataTextField"] = (object) this.TextField;
      return dictionary;
    }
  }
}
