// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MenuItemTagHelperFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  internal class MenuItemTagHelperFactory : NavigationTagHelperFactory
  {
    public MenuItemTagHelperFactory(
    #nullable disable
    TagHelperContext context, ViewContext viewContext)
      : base(context, viewContext)
    {
    }

    public async Task GenerateItemAsync(MenuItemBase item)
    {
      MenuItemTagHelperFactory tagHelperFactory = this;
      tagHelperFactory.ClearOutput();
      MenuItemTagHelper menuItemTagHelper = new MenuItemTagHelper(tagHelperFactory.htmlGenerator);
      menuItemTagHelper.ViewContext = tagHelperFactory.viewContext;
      MenuItemTagHelper menuItem = menuItemTagHelper;
      NavigationTagHelperFactory.MergeProperties<MenuItemBase, MenuItemTagHelper>(item, menuItem);
      await menuItem.ProcessAsync(tagHelperFactory.context, tagHelperFactory.Output);
    }
  }
}
