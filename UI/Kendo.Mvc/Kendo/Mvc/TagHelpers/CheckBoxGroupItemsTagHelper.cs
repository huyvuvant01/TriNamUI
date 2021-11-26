// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.CheckBoxGroupItemsTagHelper
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
  [HtmlTargetElement("kendo-checkboxgroup-items", ParentTag = "kendo-checkboxgroup")]
  [HtmlTargetElement("kendo-checkboxgroup-items", ParentTag = "checkboxgroup-editor")]
  [RestrictChildren("kendo-checkboxgroup-item", new string[] {})]
  [SuppressTagRendering]
  public class CheckBoxGroupItemsTagHelper : TagHelperCollectionBase<
  #nullable disable
  CheckBoxGroupItemTagHelper>
  {
    public CheckBoxGroupItemsTagHelper()
      : base((IList<CheckBoxGroupItemTagHelper>) new List<CheckBoxGroupItemTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (CheckBoxGroupTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as CheckBoxGroupTagHelper).Items = this;
    }

    public IList<CheckBoxGroupItemTagHelper> Items => this.InternalRef;
  }
}
