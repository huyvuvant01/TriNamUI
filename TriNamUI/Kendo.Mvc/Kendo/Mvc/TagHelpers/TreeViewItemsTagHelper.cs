﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeViewItemsTagHelper
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
  [HtmlTargetElement("items", ParentTag = "kendo-treeview")]
  [RestrictChildren("treeview-item", new string[] {})]
  [SuppressTagRendering]
  public class TreeViewItemsTagHelper : TagHelperCollectionBase<
  #nullable disable
  TreeViewItemTagHelper>
  {
    public IList<TreeViewItemTagHelper> Items => this.InternalRef;

    public TreeViewItemsTagHelper()
      : base((IList<TreeViewItemTagHelper>) new List<TreeViewItemTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      TreeViewItemsTagHelper viewItemsTagHelper = this;
      context.Items[(object) viewItemsTagHelper.GetType()] = (object) viewItemsTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      viewItemsTagHelper.AddSelfToParent(context);
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (TreeViewTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as TreeViewTagHelper).Items = this;
    }
  }
}
