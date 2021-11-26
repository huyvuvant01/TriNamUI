// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FloatingActionButtonItemsTagHelper
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
  [HtmlTargetElement("floatingactionbutton-items", ParentTag = "kendo-floatingactionbutton")]
  [RestrictChildren("floatingactionbutton-item", new string[] {})]
  [SuppressTagRendering]
  public class FloatingActionButtonItemsTagHelper : 
    TagHelperCollectionBase<
    #nullable disable
    FloatingActionButtonItemTagHelper>
  {
    public FloatingActionButtonItemsTagHelper()
      : base((IList<FloatingActionButtonItemTagHelper>) new List<FloatingActionButtonItemTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (FloatingActionButtonTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as FloatingActionButtonTagHelper).Items = this;
    }

    public IList<FloatingActionButtonItemTagHelper> Items => this.InternalRef;
  }
}
