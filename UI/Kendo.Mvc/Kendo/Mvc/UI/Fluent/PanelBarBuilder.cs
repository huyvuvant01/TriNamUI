// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PanelBarBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class PanelBarBuilder : WidgetBuilderBase<PanelBar, PanelBarBuilder>
  {
    public PanelBarBuilder(PanelBar component)
      : base(component)
    {
    }

    public PanelBarBuilder Items(Action<PanelBarItemFactory> addAction)
    {
      PanelBarItemFactory panelBarItemFactory = new PanelBarItemFactory((INavigationItemContainer<PanelBarItem>) this.Component, this.Component.ViewContext);
      addAction(panelBarItemFactory);
      return this;
    }

    public PanelBarBuilder DataSource(
      Action<HierarchicalDataSourceBuilder<object>> configurator)
    {
      configurator(new HierarchicalDataSourceBuilder<object>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public PanelBarBuilder DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public PanelBarBuilder BindTo(IEnumerable<PanelBarItemModel> items)
    {
      this.Component.BindTo<PanelBarItem>((IEnumerable) items, (Action<NavigationBindingFactory<PanelBarItem>>) (mapping => mapping.For<PanelBarItemModel>((Action<NavigationBindingBuilder<PanelBarItem, PanelBarItemModel>>) (binding => binding.ItemDataBound((Action<PanelBarItem, PanelBarItemModel>) ((item, node) =>
      {
        item.Text = node.Text;
        item.Enabled = node.Enabled;
        item.Expanded = node.Expanded;
        item.Encoded = node.Encoded;
        item.Id = node.Id;
        item.Selected = node.Selected;
        item.SpriteCssClasses = node.SpriteCssClass;
        item.Url = node.Url;
        item.ImageUrl = node.ImageUrl;
        foreach (string key in (IEnumerable<string>) node.ImageHtmlAttributes.Keys)
          item.ImageHtmlAttributes[key] = (object) node.ImageHtmlAttributes[key];
        foreach (string key in (IEnumerable<string>) node.HtmlAttributes.Keys)
          item.HtmlAttributes[key] = (object) node.HtmlAttributes[key];
        foreach (string key in (IEnumerable<string>) node.LinkHtmlAttributes.Keys)
          item.LinkHtmlAttributes[key] = (object) node.LinkHtmlAttributes[key];
      })).Children((Func<PanelBarItemModel, IEnumerable>) (item => (IEnumerable) item.Items))))));
      return this;
    }

    public PanelBarBuilder BindTo(
      IEnumerable dataSource,
      Action<NavigationBindingFactory<PanelBarItem>> factoryAction)
    {
      this.Component.BindTo<PanelBarItem>(dataSource, factoryAction);
      return this;
    }

    public PanelBarBuilder BindTo<T>(
      IEnumerable<T> dataSource,
      Action<PanelBarItem, T> itemDataBound)
    {
      this.Component.BindTo<PanelBarItem, T>(dataSource, itemDataBound);
      return this;
    }

    public PanelBarBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public PanelBarBuilder Animation(
      Action<ExpandableAnimationBuilder> animationAction)
    {
      animationAction(new ExpandableAnimationBuilder(this.Component.Animation));
      return this;
    }

    public PanelBarBuilder ItemAction(Action<PanelBarItem> action)
    {
      this.Component.ItemAction = action;
      return this;
    }

    public PanelBarBuilder HighlightPath(bool value)
    {
      this.Component.HighlightPath = value;
      return this;
    }

    public PanelBarBuilder ExpandAll(bool value)
    {
      this.Component.ExpandAll = value;
      return this;
    }

    public PanelBarBuilder SelectedIndex(int index)
    {
      this.Component.SelectedIndex = index;
      return this;
    }

    public PanelBarBuilder AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public PanelBarBuilder DataImageUrlField(string value)
    {
      this.Container.DataImageUrlField = value;
      return this;
    }

    public PanelBarBuilder DataSpriteCssClassField(string value)
    {
      this.Container.DataSpriteCssClassField = value;
      return this;
    }

    public PanelBarBuilder DataTextField(params string[] value)
    {
      this.Container.DataTextField = value;
      return this;
    }

    public PanelBarBuilder DataUrlField(string value)
    {
      this.Container.DataUrlField = value;
      return this;
    }

    public PanelBarBuilder LoadOnDemand(bool value)
    {
      this.Container.LoadOnDemand = new bool?(value);
      return this;
    }

    public PanelBarBuilder Messages(
      Action<PanelBarMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.PanelBar = this.Container;
      configurator(new PanelBarMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public PanelBarBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public PanelBarBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public PanelBarBuilder ExpandMode(PanelBarExpandMode value)
    {
      this.Container.ExpandMode = new PanelBarExpandMode?(value);
      return this;
    }

    public PanelBarBuilder Events(Action<PanelBarEventBuilder> configurator)
    {
      configurator(new PanelBarEventBuilder(this.Container.Events));
      return this;
    }
  }
}
