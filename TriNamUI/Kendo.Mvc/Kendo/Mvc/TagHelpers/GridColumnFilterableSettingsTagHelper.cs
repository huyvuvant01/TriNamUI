// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridColumnFilterableSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("filterable", ParentTag = "column", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("cell", new string[] {"operators", "datasource"})]
  [SuppressTagRendering]
  public class GridColumnFilterableSettingsTagHelper : 
    TagHelperChildBase,
    IDataBoundWidget<
    #nullable disable
    GridColumnFilterDataSourceTagHelper>
  {
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridColumnTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridColumnTagHelper).Filterable = this;
    }

    public bool? Enabled { get; set; }

    public string FilterUI { get; set; }

    public string FilterUIHandler { get; set; }

    public bool? Multi { get; set; }

    public string ItemTemplate { get; set; }

    public bool? CheckAll { get; set; }

    public bool? Search { get; set; }

    public bool? IgnoreCase { get; set; }

    public bool? Extra { get; set; }

    public GridColumnFilterableCellSettings CellSettings { get; set; }

    public GridFilterableOperatorsSettingsTagHelper Operators { get; set; }

    public GridColumnFilterDataSourceTagHelper Datasource { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string filterUi = this.FilterUI;
      if ((filterUi != null ? (filterUi.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["ui"] = (object) this.FilterUI;
      string filterUiHandler = this.FilterUIHandler;
      if ((filterUiHandler != null ? (filterUiHandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["ui"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = this.FilterUIHandler
        };
      Dictionary<string, object> source1 = this.CellSettings?.SerializeSettings();
      if (source1 != null && source1.Any<KeyValuePair<string, object>>())
        dictionary["cell"] = (object) source1;
      bool? nullable = this.Multi;
      if (nullable.HasValue)
        dictionary["multi"] = (object) this.Multi;
      nullable = this.Extra;
      if (nullable.HasValue)
        dictionary["extra"] = (object) this.Extra;
      if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      if (this.Operators != null)
      {
        Dictionary<string, object> source2 = this.Operators.Serialize();
        if (source2.Any<KeyValuePair<string, object>>())
          dictionary["operators"] = (object) source2;
      }
      string itemTemplate = this.ItemTemplate;
      if ((itemTemplate != null ? (itemTemplate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["itemTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = this.ItemTemplate
        };
      nullable = this.CheckAll;
      if (nullable.HasValue)
        dictionary["checkAll"] = (object) this.CheckAll;
      nullable = this.Search;
      if (nullable.HasValue)
        dictionary["search"] = (object) this.Search;
      nullable = this.IgnoreCase;
      if (nullable.HasValue)
        dictionary["ignoreCase"] = (object) this.IgnoreCase;
      return dictionary;
    }
  }
}
