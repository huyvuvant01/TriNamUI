// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DropDownTreeBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DropDownTreeBuilder : WidgetBuilderBase<DropDownTree, DropDownTreeBuilder>
  {
    public DropDownTreeBuilder(DropDownTree component)
      : base(component)
    {
    }

    public DropDownTreeBuilder Items(Action<DropDownTreeItemFactory> addAction)
    {
      DropDownTreeItemFactory downTreeItemFactory = new DropDownTreeItemFactory((INavigationItemContainer<DropDownTreeItem>) this.Component, this.Component.ViewContext);
      addAction(downTreeItemFactory);
      return this;
    }

    public DropDownTreeBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public DropDownTreeBuilder Animation(
      Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public DropDownTreeBuilder DataTextField(params string[] value)
    {
      this.Component.DataTextFieldArray.AddRange((IEnumerable<string>) value);
      return this;
    }

    public DropDownTreeBuilder DataSource(
      Action<HierarchicalDataSourceBuilder<object>> configurator)
    {
      configurator(new HierarchicalDataSourceBuilder<object>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public DropDownTreeBuilder DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public DropDownTreeBuilder Value(IEnumerable value)
    {
      this.Component.ValueArray = value;
      return this;
    }

    public DropDownTreeBuilder BindTo(IEnumerable<DropDownTreeItemModel> items)
    {
      this.Component.BindTo<DropDownTreeItem>((IEnumerable) items, (Action<NavigationBindingFactory<DropDownTreeItem>>) (mapping => mapping.For<DropDownTreeItemModel>((Action<NavigationBindingBuilder<DropDownTreeItem, DropDownTreeItemModel>>) (binding => binding.ItemDataBound((Action<DropDownTreeItem, DropDownTreeItemModel>) ((item, node) =>
      {
        item.Value = node.Value;
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
      })).Children((Func<DropDownTreeItemModel, IEnumerable>) (item => (IEnumerable) item.Items))))));
      return this;
    }

    public DropDownTreeBuilder BindTo(
      IEnumerable dataSource,
      Action<NavigationBindingFactory<DropDownTreeItem>> factoryAction)
    {
      this.Component.BindTo<DropDownTreeItem>(dataSource, factoryAction);
      return this;
    }

    public DropDownTreeBuilder BindTo<T>(
      IEnumerable<T> dataSource,
      Action<DropDownTreeItem, T> itemDataBound)
    {
      this.Component.BindTo<DropDownTreeItem, T>(dataSource, itemDataBound);
      return this;
    }

    public DropDownTreeBuilder AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public DropDownTreeBuilder AutoClose(bool value)
    {
      this.Container.AutoClose = new bool?(value);
      return this;
    }

    public DropDownTreeBuilder AutoWidth(bool value)
    {
      this.Container.AutoWidth = new bool?(value);
      return this;
    }

    public DropDownTreeBuilder CheckAll(bool value)
    {
      this.Container.CheckAll = new bool?(value);
      return this;
    }

    public DropDownTreeBuilder CheckAll()
    {
      this.Container.CheckAll = new bool?(true);
      return this;
    }

    public DropDownTreeBuilder CheckAllTemplate(string value)
    {
      this.Container.CheckAllTemplate = value;
      return this;
    }

    public DropDownTreeBuilder CheckAllTemplateId(string templateId)
    {
      this.Container.CheckAllTemplateId = templateId;
      return this;
    }

    public DropDownTreeBuilder Checkboxes(
      Action<DropDownTreeCheckboxesSettingsBuilder> configurator)
    {
      this.Container.Checkboxes.Enabled = new bool?(true);
      this.Container.Checkboxes.DropDownTree = this.Container;
      configurator(new DropDownTreeCheckboxesSettingsBuilder(this.Container.Checkboxes));
      return this;
    }

    public DropDownTreeBuilder Checkboxes(bool enabled)
    {
      this.Container.Checkboxes.Enabled = new bool?(enabled);
      return this;
    }

    public DropDownTreeBuilder ClearButton(bool value)
    {
      this.Container.ClearButton = new bool?(value);
      return this;
    }

    public DropDownTreeBuilder DataImageUrlField(string value)
    {
      this.Container.DataImageUrlField = value;
      return this;
    }

    public DropDownTreeBuilder DataSpriteCssClassField(string value)
    {
      this.Container.DataSpriteCssClassField = value;
      return this;
    }

    public DropDownTreeBuilder DataTextField(string value)
    {
      this.Container.DataTextField = value;
      return this;
    }

    public DropDownTreeBuilder DataUrlField(string value)
    {
      this.Container.DataUrlField = value;
      return this;
    }

    public DropDownTreeBuilder DataValueField(string value)
    {
      this.Container.DataValueField = value;
      return this;
    }

    public DropDownTreeBuilder Delay(double value)
    {
      this.Container.Delay = new double?(value);
      return this;
    }

    public DropDownTreeBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public DropDownTreeBuilder EnforceMinLength(bool value)
    {
      this.Container.EnforceMinLength = new bool?(value);
      return this;
    }

    public DropDownTreeBuilder EnforceMinLength()
    {
      this.Container.EnforceMinLength = new bool?(true);
      return this;
    }

    public DropDownTreeBuilder FooterTemplate(string value)
    {
      this.Container.FooterTemplate = value;
      return this;
    }

    public DropDownTreeBuilder FooterTemplateId(string templateId)
    {
      this.Container.FooterTemplateId = templateId;
      return this;
    }

    public DropDownTreeBuilder Height(string value)
    {
      this.Container.Height = value;
      return this;
    }

    public DropDownTreeBuilder IgnoreCase(bool value)
    {
      this.Container.IgnoreCase = new bool?(value);
      return this;
    }

    public DropDownTreeBuilder LoadOnDemand(bool value)
    {
      this.Container.LoadOnDemand = new bool?(value);
      return this;
    }

    public DropDownTreeBuilder LoadOnDemand()
    {
      this.Container.LoadOnDemand = new bool?(true);
      return this;
    }

    public DropDownTreeBuilder Messages(
      Action<DropDownTreeMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.DropDownTree = this.Container;
      configurator(new DropDownTreeMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public DropDownTreeBuilder MinLength(double value)
    {
      this.Container.MinLength = new double?(value);
      return this;
    }

    public DropDownTreeBuilder NoDataTemplate(string value)
    {
      this.Container.NoDataTemplate = value;
      return this;
    }

    public DropDownTreeBuilder NoDataTemplateId(string templateId)
    {
      this.Container.NoDataTemplateId = templateId;
      return this;
    }

    public DropDownTreeBuilder Placeholder(string value)
    {
      this.Container.Placeholder = value;
      return this;
    }

    public DropDownTreeBuilder Popup(
      Action<DropDownTreePopupSettingsBuilder> configurator)
    {
      this.Container.Popup.DropDownTree = this.Container;
      configurator(new DropDownTreePopupSettingsBuilder(this.Container.Popup));
      return this;
    }

    public DropDownTreeBuilder HeaderTemplate(string value)
    {
      this.Container.HeaderTemplate = value;
      return this;
    }

    public DropDownTreeBuilder HeaderTemplateId(string templateId)
    {
      this.Container.HeaderTemplateId = templateId;
      return this;
    }

    public DropDownTreeBuilder ValueTemplate(string value)
    {
      this.Container.ValueTemplate = value;
      return this;
    }

    public DropDownTreeBuilder ValueTemplateId(string templateId)
    {
      this.Container.ValueTemplateId = templateId;
      return this;
    }

    public DropDownTreeBuilder TagMode(DropDownTreeTagMode value)
    {
      this.Container.TagMode = new DropDownTreeTagMode?(value);
      return this;
    }

    public DropDownTreeBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public DropDownTreeBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public DropDownTreeBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public DropDownTreeBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public DropDownTreeBuilder ValuePrimitive(bool value)
    {
      this.Container.ValuePrimitive = new bool?(value);
      return this;
    }

    public DropDownTreeBuilder ValuePrimitive()
    {
      this.Container.ValuePrimitive = new bool?(true);
      return this;
    }

    public DropDownTreeBuilder Filter(FilterType value)
    {
      this.Container.Filter = new FilterType?(value);
      return this;
    }

    public DropDownTreeBuilder Events(
      Action<DropDownTreeEventBuilder> configurator)
    {
      configurator(new DropDownTreeEventBuilder(this.Container.Events));
      return this;
    }
  }
}
