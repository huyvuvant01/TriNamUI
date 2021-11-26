// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MultiSelectBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Kendo.Mvc.UI.Fluent
{
  public class MultiSelectBuilder : WidgetBuilderBase<MultiSelect, MultiSelectBuilder>
  {
    public MultiSelectBuilder(MultiSelect component)
      : base(component)
    {
    }

    public MultiSelectBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public MultiSelectBuilder Animation(
      Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public MultiSelectBuilder BindTo(IEnumerable data)
    {
      this.Component.DataSource.Data = data;
      return this;
    }

    public MultiSelectBuilder BindTo(IEnumerable<SelectListItem> dataSource)
    {
      if (string.IsNullOrEmpty(this.Component.DataValueField) && string.IsNullOrEmpty(this.Component.DataTextField))
      {
        this.DataValueField("Value");
        this.DataTextField("Text");
      }
      this.Component.DataSource.Data = (IEnumerable) dataSource.Select(item => new
      {
        Text = item.Text,
        Value = item.Value ?? item.Text,
        Selected = item.Selected
      });
      if (this.Component.Value == null)
        this.Component.Value = (IEnumerable) dataSource.Where<SelectListItem>((Func<SelectListItem, bool>) (item => item.Selected)).Select<SelectListItem, string>((Func<SelectListItem, string>) (item => item.Value ?? item.Text));
      return this;
    }

    public MultiSelectBuilder Items(Action<SelectListItemFactory> addAction)
    {
      List<SelectListItem> selectListItemList = new List<SelectListItem>();
      addAction(new SelectListItemFactory((IList<SelectListItem>) selectListItemList));
      return this.BindTo((IEnumerable<SelectListItem>) selectListItemList);
    }

    public MultiSelectBuilder DataSource(
      Action<ReadOnlyDataSourceBuilder> configurator)
    {
      configurator(new ReadOnlyDataSourceBuilder(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public MultiSelectBuilder DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public MultiSelectBuilder Filter(string value)
    {
      this.Container.Filter = new FilterType?((FilterType) Enum.Parse(typeof (FilterType), value, true));
      return this;
    }

    public MultiSelectBuilder Value(IEnumerable value)
    {
      this.Component.Value = value;
      return this;
    }

    public MultiSelectBuilder AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public MultiSelectBuilder AutoClose(bool value)
    {
      this.Container.AutoClose = new bool?(value);
      return this;
    }

    public MultiSelectBuilder AutoWidth(bool value)
    {
      this.Container.AutoWidth = new bool?(value);
      return this;
    }

    public MultiSelectBuilder ClearButton(bool value)
    {
      this.Container.ClearButton = new bool?(value);
      return this;
    }

    public MultiSelectBuilder DataTextField(string value)
    {
      this.Container.DataTextField = value;
      return this;
    }

    public MultiSelectBuilder DataValueField(string value)
    {
      this.Container.DataValueField = value;
      return this;
    }

    public MultiSelectBuilder Delay(double value)
    {
      this.Container.Delay = new double?(value);
      return this;
    }

    public MultiSelectBuilder DownArrow(bool value)
    {
      this.Container.DownArrow = new bool?(value);
      return this;
    }

    public MultiSelectBuilder DownArrow()
    {
      this.Container.DownArrow = new bool?(true);
      return this;
    }

    public MultiSelectBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public MultiSelectBuilder EnforceMinLength(bool value)
    {
      this.Container.EnforceMinLength = new bool?(value);
      return this;
    }

    public MultiSelectBuilder EnforceMinLength()
    {
      this.Container.EnforceMinLength = new bool?(true);
      return this;
    }

    public MultiSelectBuilder FixedGroupTemplate(string value)
    {
      this.Container.FixedGroupTemplate = value;
      return this;
    }

    public MultiSelectBuilder FixedGroupTemplateId(string templateId)
    {
      this.Container.FixedGroupTemplateId = templateId;
      return this;
    }

    public MultiSelectBuilder FooterTemplate(string value)
    {
      this.Container.FooterTemplate = value;
      return this;
    }

    public MultiSelectBuilder FooterTemplateId(string templateId)
    {
      this.Container.FooterTemplateId = templateId;
      return this;
    }

    public MultiSelectBuilder GroupTemplate(string value)
    {
      this.Container.GroupTemplate = value;
      return this;
    }

    public MultiSelectBuilder GroupTemplateId(string templateId)
    {
      this.Container.GroupTemplateId = templateId;
      return this;
    }

    public MultiSelectBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public MultiSelectBuilder HighlightFirst(bool value)
    {
      this.Container.HighlightFirst = new bool?(value);
      return this;
    }

    public MultiSelectBuilder IgnoreCase(bool value)
    {
      this.Container.IgnoreCase = new bool?(value);
      return this;
    }

    public MultiSelectBuilder Messages(
      Action<MultiSelectMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.MultiSelect = this.Container;
      configurator(new MultiSelectMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public MultiSelectBuilder MinLength(double value)
    {
      this.Container.MinLength = new double?(value);
      return this;
    }

    public MultiSelectBuilder MaxSelectedItems(double value)
    {
      this.Container.MaxSelectedItems = new double?(value);
      return this;
    }

    public MultiSelectBuilder NoDataTemplate(string value)
    {
      this.Container.NoDataTemplate = value;
      return this;
    }

    public MultiSelectBuilder NoDataTemplateId(string templateId)
    {
      this.Container.NoDataTemplateId = templateId;
      return this;
    }

    public MultiSelectBuilder Placeholder(string value)
    {
      this.Container.Placeholder = value;
      return this;
    }

    public MultiSelectBuilder Popup(
      Action<MultiSelectPopupSettingsBuilder> configurator)
    {
      this.Container.Popup.MultiSelect = this.Container;
      configurator(new MultiSelectPopupSettingsBuilder(this.Container.Popup));
      return this;
    }

    public MultiSelectBuilder HeaderTemplate(string value)
    {
      this.Container.HeaderTemplate = value;
      return this;
    }

    public MultiSelectBuilder HeaderTemplateId(string templateId)
    {
      this.Container.HeaderTemplateId = templateId;
      return this;
    }

    public MultiSelectBuilder ItemTemplate(string value)
    {
      this.Container.ItemTemplate = value;
      return this;
    }

    public MultiSelectBuilder ItemTemplateId(string templateId)
    {
      this.Container.ItemTemplateId = templateId;
      return this;
    }

    public MultiSelectBuilder TagTemplate(string value)
    {
      this.Container.TagTemplate = value;
      return this;
    }

    public MultiSelectBuilder TagTemplateId(string templateId)
    {
      this.Container.TagTemplateId = templateId;
      return this;
    }

    public MultiSelectBuilder TagMode(MultiSelectTagMode value)
    {
      this.Container.TagMode = new MultiSelectTagMode?(value);
      return this;
    }

    public MultiSelectBuilder ValuePrimitive(bool value)
    {
      this.Container.ValuePrimitive = new bool?(value);
      return this;
    }

    public MultiSelectBuilder ValuePrimitive()
    {
      this.Container.ValuePrimitive = new bool?(true);
      return this;
    }

    public MultiSelectBuilder Virtual(
      Action<MultiSelectVirtualSettingsBuilder> configurator)
    {
      this.Container.Virtual.Enabled = new bool?(true);
      this.Container.Virtual.MultiSelect = this.Container;
      configurator(new MultiSelectVirtualSettingsBuilder(this.Container.Virtual));
      return this;
    }

    public MultiSelectBuilder Virtual()
    {
      this.Container.Virtual.Enabled = new bool?(true);
      return this;
    }

    public MultiSelectBuilder Virtual(bool enabled)
    {
      this.Container.Virtual.Enabled = new bool?(enabled);
      return this;
    }

    public MultiSelectBuilder Filter(FilterType value)
    {
      this.Container.Filter = new FilterType?(value);
      return this;
    }

    public MultiSelectBuilder Events(Action<MultiSelectEventBuilder> configurator)
    {
      configurator(new MultiSelectEventBuilder(this.Container.Events));
      return this;
    }
  }
}
