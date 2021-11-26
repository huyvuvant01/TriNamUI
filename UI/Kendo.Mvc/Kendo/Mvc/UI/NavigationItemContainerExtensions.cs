// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.NavigationItemContainerExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI.Fluent;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;

namespace Kendo.Mvc.UI
{
  public static class NavigationItemContainerExtensions
  {
    public static void WriteItem<TComponent, TItem>(
      this TItem item,
      TComponent component,
      IHtmlNode parentTag,
      INavigationComponentHtmlBuilder<TItem> builder)
      where TComponent : WidgetBase, INavigationItemComponent<TItem>
      where TItem : NavigationItem<TItem>, IContentContainer, INavigationItemContainer<TItem>
    {
      bool flag = true;
      if (component.ItemAction != null)
        component.ItemAction(item);
      if (!(item.Visible & flag))
        return;
      bool hasAccessibleChildren = item.Items.Any<TItem>() && item.Items.Any<TItem>((Func<TItem, bool>) (i => i.Visible));
      IHtmlNode parent = builder.ItemTag(item).AppendTo(parentTag);
      builder.ItemInnerContentTag(item, hasAccessibleChildren).AppendTo(parent);
      if (item.Template.HasValue() || ((object) item is IAsyncContentContainer ? (!string.IsNullOrEmpty(((IAsyncContentContainer) (object) item).ContentUrl) ? 1 : 0) : 0) != 0)
      {
        builder.ItemContentTag(item).AppendTo(parent);
      }
      else
      {
        if (!hasAccessibleChildren)
          return;
        IHtmlNode ul = builder.ChildrenTag(item).AppendTo(parent);
        item.Items.Each<TItem>((Action<TItem>) (child => child.WriteItem<TComponent, TItem>(component, ul, builder)));
      }
    }

    public static string GetImageUrl<T>(this T item, ViewContext viewContext) where T : NavigationItem<T> => NavigatableExtensions.GetUrlHelper((ActionContext) viewContext).Content(item.ImageUrl);

    public static string GetItemContentId<TComponent, TItem>(this TComponent component, TItem item)
      where TComponent : WidgetBase, INavigationItemContainer<TItem>
      where TItem : NavigationItem<TItem>, IContentContainer
    {
      return !item.ContentHtmlAttributes.ContainsKey("id") ? "{0}-{1}".FormatWith((object) component.Id, (object) (component.Items.Where<TItem>((Func<TItem, bool>) (i => i.Visible)).IndexOf((object) item) + 1).ToString((IFormatProvider) CultureInfo.InvariantCulture)) : "{0}".FormatWith((object) item.ContentHtmlAttributes["id"].ToString());
    }

    public static string GetItemUrl<TComponent, TItem>(this TComponent component, TItem item)
      where TComponent : WidgetBase, INavigationItemComponent<TItem>
      where TItem : NavigationItem<TItem>, IContentContainer
    {
      return component.GetItemUrl<TComponent, TItem>(item, "#");
    }

    public static string GetItemUrl<TComponent, TItem>(
      this TComponent component,
      TItem item,
      string defaultValue)
      where TComponent : WidgetBase, INavigationItemComponent<TItem>
      where TItem : NavigationItem<TItem>, IContentContainer
    {
      string url = item.GenerateUrl(component.ViewContext, component.UrlGenerator);
      if (url != null)
        return url;
      return item is IAsyncContentContainer contentContainer && contentContainer.ContentUrl.HasValue() ? (!component.IsSelfInitialized ? contentContainer.ContentUrl : WebUtility.UrlDecode(contentContainer.ContentUrl)) : (item.Template.HasValue() && !item.RouteName.HasValue() && !item.Url.HasValue() && !item.ActionName.HasValue() && !item.ControllerName.HasValue() ? (component.IsInClientTemplate ? "\\#" : "#") + component.GetItemContentId<TComponent, TItem>(item) : defaultValue);
    }

    public static void BindTo<TNavigationItem, TDataItem>(
      this INavigationItemComponent<TNavigationItem> component,
      IEnumerable<TDataItem> dataSource,
      Action<TNavigationItem, TDataItem> action)
      where TNavigationItem : NavigationItem<TNavigationItem>, new()
    {
      foreach (TDataItem dataItem in dataSource)
      {
        TNavigationItem navigationItem = new TNavigationItem();
        component.Items.Add(navigationItem);
        action(navigationItem, dataItem);
      }
    }

    public static void BindTo<TNavigationItem>(
      this INavigationItemContainer<TNavigationItem> component,
      IEnumerable dataSource,
      Action<NavigationBindingFactory<TNavigationItem>> factoryAction)
      where TNavigationItem : NavigationItem<TNavigationItem>, INavigationItemContainer<TNavigationItem>, new()
    {
      NavigationBindingFactory<TNavigationItem> factory = new NavigationBindingFactory<TNavigationItem>();
      factoryAction(factory);
      foreach (object dataItem in dataSource)
      {
        TNavigationItem component1 = new TNavigationItem();
        component.Items.Add(component1);
        NavigationItemContainerExtensions.Bind<TNavigationItem>(component1, dataItem, factory);
      }
    }

    public static void Bind<TNavigationItem>(
      TNavigationItem component,
      object dataItem,
      NavigationBindingFactory<TNavigationItem> factory)
      where TNavigationItem : NavigationItem<TNavigationItem>, INavigationItemContainer<TNavigationItem>, new()
    {
      Type dataItemType = dataItem.GetType();
      INavigationBinding<TNavigationItem> navigationBinding = factory.container.Where<INavigationBinding<TNavigationItem>>((Func<INavigationBinding<TNavigationItem>, bool>) (b => dataItemType.IsCompatibleWith(b.Type))).First<INavigationBinding<TNavigationItem>>();
      navigationBinding.ItemDataBound(component, dataItem);
      IEnumerable enumerable = navigationBinding.Children(dataItem);
      if (enumerable == null)
        return;
      foreach (object dataItem1 in enumerable)
      {
        TNavigationItem component1 = new TNavigationItem();
        component.Items.Add(component1);
        NavigationItemContainerExtensions.Bind<TNavigationItem>(component1, dataItem1, factory);
      }
    }
  }
}
