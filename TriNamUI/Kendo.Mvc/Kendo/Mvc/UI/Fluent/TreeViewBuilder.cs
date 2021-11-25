// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeViewBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeViewBuilder : WidgetBuilderBase<TreeView, TreeViewBuilder>, IHideObjectMembers
  {
    public TreeViewBuilder(TreeView component)
      : base(component)
    {
    }

    public TreeViewBuilder Items(Action<TreeViewItemFactory> addAction)
    {
      TreeViewItemFactory treeViewItemFactory = new TreeViewItemFactory((INavigationItemContainer<TreeViewItem>) this.Component, this.Component.ViewContext);
      addAction(treeViewItemFactory);
      return this;
    }

    public TreeViewBuilder HighlightPath(bool value)
    {
      this.Component.HighlightPath = value;
      return this;
    }

    public TreeViewBuilder ExpandAll(bool value)
    {
      this.Component.ExpandAll = value;
      return this;
    }

    public TreeViewBuilder DataSource(
      Action<HierarchicalDataSourceBuilder<object>> configurator)
    {
      configurator(new HierarchicalDataSourceBuilder<object>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public TreeViewBuilder DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public TreeViewBuilder BindTo(IEnumerable<TreeViewItemModel> items)
    {
      this.Component.BindTo<TreeViewItem>((IEnumerable) items, (Action<NavigationBindingFactory<TreeViewItem>>) (mapping => mapping.For<TreeViewItemModel>((Action<NavigationBindingBuilder<TreeViewItem, TreeViewItemModel>>) (binding => binding.ItemDataBound((Action<TreeViewItem, TreeViewItemModel>) ((item, node) =>
      {
        item.Text = node.Text;
        item.Enabled = node.Enabled;
        item.Expanded = node.Expanded;
        item.Encoded = node.Encoded;
        item.Id = node.Id;
        item.Checked = node.Checked;
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
      })).Children((Func<TreeViewItemModel, IEnumerable>) (item => (IEnumerable) item.Items))))));
      return this;
    }

    public TreeViewBuilder BindTo(
      IEnumerable dataSource,
      Action<NavigationBindingFactory<TreeViewItem>> factoryAction)
    {
      this.Component.BindTo<TreeViewItem>(dataSource, factoryAction);
      return this;
    }

    public TreeViewBuilder BindTo<T>(
      IEnumerable<T> dataSource,
      Action<TreeViewItem, T> itemDataBound)
    {
      this.Component.BindTo<TreeViewItem, T>(dataSource, itemDataBound);
      return this;
    }

    public TreeViewBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public TreeViewBuilder Animation(
      Action<ExpandableAnimationBuilder> animationAction)
    {
      animationAction(new ExpandableAnimationBuilder(this.Component.Animation));
      return this;
    }

    public TreeViewBuilder CheckboxTemplate(string template) => this.Checkboxes((Action<TreeViewCheckboxesSettingsBuilder>) (config => config.Template(template)));

    public TreeViewBuilder CheckboxTemplateId(string templateId) => this.Checkboxes((Action<TreeViewCheckboxesSettingsBuilder>) (config => config.TemplateId(templateId)));

    public TreeViewBuilder AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public TreeViewBuilder AutoScroll(bool value)
    {
      this.Container.AutoScroll = new bool?(value);
      return this;
    }

    public TreeViewBuilder AutoScroll()
    {
      this.Container.AutoScroll = new bool?(true);
      return this;
    }

    public TreeViewBuilder Checkboxes(
      Action<TreeViewCheckboxesSettingsBuilder> configurator)
    {
      this.Container.Checkboxes.Enabled = new bool?(true);
      this.Container.Checkboxes.TreeView = this.Container;
      configurator(new TreeViewCheckboxesSettingsBuilder(this.Container.Checkboxes));
      return this;
    }

    public TreeViewBuilder Checkboxes()
    {
      this.Container.Checkboxes.Enabled = new bool?(true);
      return this;
    }

    public TreeViewBuilder Checkboxes(bool enabled)
    {
      this.Container.Checkboxes.Enabled = new bool?(enabled);
      return this;
    }

    public TreeViewBuilder DataImageUrlField(string value)
    {
      this.Container.DataImageUrlField = value;
      return this;
    }

    public TreeViewBuilder DataSpriteCssClassField(string value)
    {
      this.Container.DataSpriteCssClassField = value;
      return this;
    }

    public TreeViewBuilder DataTextField(params string[] value)
    {
      this.Container.DataTextField = value;
      return this;
    }

    public TreeViewBuilder DataUrlField(string value)
    {
      this.Container.DataUrlField = value;
      return this;
    }

    public TreeViewBuilder DragAndDrop(bool value)
    {
      this.Container.DragAndDrop = new bool?(value);
      return this;
    }

    public TreeViewBuilder DragAndDrop()
    {
      this.Container.DragAndDrop = new bool?(true);
      return this;
    }

    public TreeViewBuilder LoadOnDemand(bool value)
    {
      this.Container.LoadOnDemand = new bool?(value);
      return this;
    }

    public TreeViewBuilder Messages(
      Action<TreeViewMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.TreeView = this.Container;
      configurator(new TreeViewMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public TreeViewBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public TreeViewBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public TreeViewBuilder Events(Action<TreeViewEventBuilder> configurator)
    {
      configurator(new TreeViewEventBuilder(this.Container.Events));
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
