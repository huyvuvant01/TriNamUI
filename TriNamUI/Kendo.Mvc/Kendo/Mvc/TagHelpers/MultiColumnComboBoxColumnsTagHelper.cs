// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MultiColumnComboBoxColumnsTagHelper
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
  [HtmlTargetElement("multicolumncombobox-columns", ParentTag = "kendo-multicolumncombobox")]
  [HtmlTargetElement("multicolumncombobox-columns", ParentTag = "multicolumncombobox-editor")]
  [RestrictChildren("column", new string[] {})]
  [SuppressTagRendering]
  public class MultiColumnComboBoxColumnsTagHelper : 
    TagHelperCollectionBase<
    #nullable disable
    MultiColumnComboBoxColumnTagHelper>
  {
    public MultiColumnComboBoxColumnsTagHelper()
      : base((IList<MultiColumnComboBoxColumnTagHelper>) new List<MultiColumnComboBoxColumnTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (MultiColumnComboBoxTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as MultiColumnComboBoxTagHelper).Columns = this;
    }

    public IList<MultiColumnComboBoxColumnTagHelper> Columns => this.InternalRef;
  }
}
