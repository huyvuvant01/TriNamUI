// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FormItemsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("form-items", ParentTag = "kendo-form")]
  [HtmlTargetElement("form-items", ParentTag = "form-item")]
  [HtmlTargetElement("form-items", ParentTag = "wizard-step-form")]
  [RestrictChildren("form-item", new string[] {})]
  [SuppressTagRendering]
  public class FormItemsTagHelper : TagHelperCollectionBase<
  #nullable disable
  FormItemTagHelper>
  {
    public FormItemsTagHelper()
      : base((IList<FormItemTagHelper>) new List<FormItemTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in context.Items.Reverse<KeyValuePair<object, object>>())
      {
        if (keyValuePair.Value is FormItemTagHelper formItemTagHelper2)
        {
          formItemTagHelper2.Items = this;
          break;
        }
        if (keyValuePair.Value is FormTagHelper formTagHelper2)
        {
          formTagHelper2.Items = this;
          break;
        }
      }
    }

    public IList<FormItemTagHelper> Items => this.InternalRef;
  }
}
