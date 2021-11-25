﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridColumnMenuColumnsGroupsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("column-menu-columns-groups", ParentTag = "column-menu-columns")]
  [RestrictChildren("column-menu-columns-group", new string[] {})]
  [SuppressTagRendering]
  public class GridColumnMenuColumnsGroupsTagHelper : 
    TagHelperCollectionBase<
    #nullable disable
    GridColumnMenuColumnsGroupTagHelper>
  {
    public IList<GridColumnMenuColumnsGroupTagHelper> Groups => this.InternalRef;

    public GridColumnMenuColumnsGroupsTagHelper()
      : base((IList<GridColumnMenuColumnsGroupTagHelper>) new List<GridColumnMenuColumnsGroupTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      GridColumnMenuColumnsGroupsTagHelper columnsGroupsTagHelper = this;
      context.Items[(object) columnsGroupsTagHelper.GetType()] = (object) columnsGroupsTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      columnsGroupsTagHelper.AddSelfToParent(context);
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridColumnMenuColumnsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridColumnMenuColumnsSettingsTagHelper).Groups = this;
    }
  }
}
