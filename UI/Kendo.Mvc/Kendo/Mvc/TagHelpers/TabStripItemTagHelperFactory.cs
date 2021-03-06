// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TabStripItemTagHelperFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  internal class TabStripItemTagHelperFactory : NavigationTagHelperFactory
  {
    public TabStripItemTagHelperFactory(
    #nullable disable
    TagHelperContext context, ViewContext viewContext)
      : base(context, viewContext)
    {
    }

    public async Task GenerateItemAsync(TabStripItemBase item)
    {
      TabStripItemTagHelperFactory tagHelperFactory = this;
      tagHelperFactory.ClearOutput();
      TabStripItemTagHelper stripItemTagHelper = new TabStripItemTagHelper(tagHelperFactory.htmlGenerator);
      stripItemTagHelper.ViewContext = tagHelperFactory.viewContext;
      TabStripItemTagHelper menuItem = stripItemTagHelper;
      NavigationTagHelperFactory.MergeProperties<TabStripItemBase, TabStripItemTagHelper>(item, menuItem);
      await menuItem.ProcessAsync(tagHelperFactory.context, tagHelperFactory.Output);
    }
  }
}
