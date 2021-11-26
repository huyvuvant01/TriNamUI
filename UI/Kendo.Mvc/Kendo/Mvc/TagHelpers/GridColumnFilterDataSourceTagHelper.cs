// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridColumnFilterDataSourceTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("datasource", ParentTag = "filterable")]
  [RestrictChildren("schema", new string[] {"filters", "transport"})]
  public class GridColumnFilterDataSourceTagHelper : DataSourceTagHelper
  {
    public GridColumnFilterDataSourceTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    protected override void SetDataSource(object item)
    {
      if (!(item is IDataBoundWidget<GridColumnFilterDataSourceTagHelper>))
        return;
      (item as IDataBoundWidget<GridColumnFilterDataSourceTagHelper>).Datasource = this;
      this.IsNested = true;
    }

    internal override Dictionary<string, object> Serialize() => base.Serialize();
  }
}
