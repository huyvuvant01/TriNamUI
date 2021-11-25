// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.NavigationTagHelperFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Reflection;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Kendo.Mvc.TagHelpers
{
  public class NavigationTagHelperFactory
  {
    internal IHtmlGenerator htmlGenerator { get; set; }

    internal ViewContext viewContext { get; set; }

    internal TagHelperContext context { get; set; }

    public TagHelperOutput Output { get; set; }

    public NavigationTagHelperFactory(TagHelperContext context, ViewContext viewContext)
    {
      this.context = context;
      this.viewContext = viewContext;
      this.htmlGenerator = (IHtmlGenerator) (viewContext.HttpContext.RequestServices.GetService(typeof (IHtmlGenerator)) as DefaultHtmlGenerator);
    }

    internal void ClearOutput() => this.Output = new TagHelperOutput("", new TagHelperAttributeList(), (Func<bool, HtmlEncoder, Task<TagHelperContent>>) ((useCachedResult, encoder) => Task.Factory.StartNew<TagHelperContent>((Func<TagHelperContent>) (() => (TagHelperContent) new DefaultTagHelperContent()))));

    internal static void MergeProperties<TItem, TTagHelper>(TItem item, TTagHelper menuItem)
    {
      foreach (PropertyInfo property in typeof (TItem).GetProperties())
        typeof (TTagHelper).GetProperty(property.Name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public).SetValue((object) menuItem, property.GetValue((object) item));
    }
  }
}
