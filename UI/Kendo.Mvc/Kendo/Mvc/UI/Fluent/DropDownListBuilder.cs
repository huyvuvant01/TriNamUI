// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DropDownListBuilder
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
  public class DropDownListBuilder : WidgetBuilderBase<DropDownList, DropDownListBuilder>
  {
    public DropDownListBuilder(DropDownList component)
      : base(component)
    {
    }

    public DropDownListBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public DropDownListBuilder Animation(
      Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public DropDownListBuilder BindTo(IEnumerable data)
    {
      this.Component.DataSource.Data = data;
      return this;
    }

    public DropDownListBuilder BindTo(IEnumerable<SelectListItem> dataSource)
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
        this.Component.Value = dataSource.SelectedValue();
      return this;
    }

    public DropDownListBuilder Items(Action<SelectListItemFactory> addAction)
    {
      List<SelectListItem> selectListItemList = new List<SelectListItem>();
      addAction(new SelectListItemFactory((IList<SelectListItem>) selectListItemList));
      return this.BindTo((IEnumerable<SelectListItem>) selectListItemList);
    }

    public DropDownListBuilder DataSource(
      Action<ReadOnlyDataSourceBuilder> configurator)
    {
      configurator(new ReadOnlyDataSourceBuilder(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public DropDownListBuilder DataSource(string dataSourceId)
    {
      this.Container.DataSourceId = dataSourceId;
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public DropDownListBuilder Filter(string value)
    {
      this.Container.Filter = new FilterType?((FilterType) Enum.Parse(typeof (FilterType), value, true));
      return this;
    }

    public DropDownListBuilder SelectedIndex(int value)
    {
      this.Container.SelectedIndex = new int?(value);
      return this;
    }

    public DropDownListBuilder AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public DropDownListBuilder AutoWidth(bool value)
    {
      this.Container.AutoWidth = new bool?(value);
      return this;
    }

    public DropDownListBuilder CascadeFrom(string value)
    {
      this.Container.CascadeFrom = value;
      return this;
    }

    public DropDownListBuilder CascadeFromField(string value)
    {
      this.Container.CascadeFromField = value;
      return this;
    }

    public DropDownListBuilder CascadeFromParentField(string value)
    {
      this.Container.CascadeFromParentField = value;
      return this;
    }

    public DropDownListBuilder DataTextField(string value)
    {
      this.Container.DataTextField = value;
      return this;
    }

    public DropDownListBuilder DataValueField(string value)
    {
      this.Container.DataValueField = value;
      return this;
    }

    public DropDownListBuilder Delay(double value)
    {
      this.Container.Delay = new double?(value);
      return this;
    }

    public DropDownListBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public DropDownListBuilder EnforceMinLength(bool value)
    {
      this.Container.EnforceMinLength = new bool?(value);
      return this;
    }

    public DropDownListBuilder EnforceMinLength()
    {
      this.Container.EnforceMinLength = new bool?(true);
      return this;
    }

    public DropDownListBuilder FilterTitle(string value)
    {
      this.Container.FilterTitle = value;
      return this;
    }

    public DropDownListBuilder FixedGroupTemplate(string value)
    {
      this.Container.FixedGroupTemplate = value;
      return this;
    }

    public DropDownListBuilder FixedGroupTemplateId(string templateId)
    {
      this.Container.FixedGroupTemplateId = templateId;
      return this;
    }

    public DropDownListBuilder FooterTemplate(string value)
    {
      this.Container.FooterTemplate = value;
      return this;
    }

    public DropDownListBuilder FooterTemplateId(string templateId)
    {
      this.Container.FooterTemplateId = templateId;
      return this;
    }

    public DropDownListBuilder GroupTemplate(string value)
    {
      this.Container.GroupTemplate = value;
      return this;
    }

    public DropDownListBuilder GroupTemplateId(string templateId)
    {
      this.Container.GroupTemplateId = templateId;
      return this;
    }

    public DropDownListBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public DropDownListBuilder IgnoreCase(bool value)
    {
      this.Container.IgnoreCase = new bool?(value);
      return this;
    }

    public DropDownListBuilder Messages(
      Action<DropDownListMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.DropDownList = this.Container;
      configurator(new DropDownListMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public DropDownListBuilder MinLength(double value)
    {
      this.Container.MinLength = new double?(value);
      return this;
    }

    public DropDownListBuilder NoDataTemplate(string value)
    {
      this.Container.NoDataTemplate = value;
      return this;
    }

    public DropDownListBuilder NoDataTemplateId(string templateId)
    {
      this.Container.NoDataTemplateId = templateId;
      return this;
    }

    public DropDownListBuilder Popup(
      Action<DropDownListPopupSettingsBuilder> configurator)
    {
      this.Container.Popup.DropDownList = this.Container;
      configurator(new DropDownListPopupSettingsBuilder(this.Container.Popup));
      return this;
    }

    public DropDownListBuilder OptionLabel(object value)
    {
      this.Container.OptionLabel = value;
      return this;
    }

    public DropDownListBuilder OptionLabelTemplate(string value)
    {
      this.Container.OptionLabelTemplate = value;
      return this;
    }

    public DropDownListBuilder OptionLabelTemplateId(string templateId)
    {
      this.Container.OptionLabelTemplateId = templateId;
      return this;
    }

    public DropDownListBuilder HeaderTemplate(string value)
    {
      this.Container.HeaderTemplate = value;
      return this;
    }

    public DropDownListBuilder HeaderTemplateId(string templateId)
    {
      this.Container.HeaderTemplateId = templateId;
      return this;
    }

    public DropDownListBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public DropDownListBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public DropDownListBuilder ValueTemplate(string value)
    {
      this.Container.ValueTemplate = value;
      return this;
    }

    public DropDownListBuilder ValueTemplateId(string templateId)
    {
      this.Container.ValueTemplateId = templateId;
      return this;
    }

    public DropDownListBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public DropDownListBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public DropDownListBuilder ValuePrimitive(bool value)
    {
      this.Container.ValuePrimitive = new bool?(value);
      return this;
    }

    public DropDownListBuilder ValuePrimitive()
    {
      this.Container.ValuePrimitive = new bool?(true);
      return this;
    }

    public DropDownListBuilder Virtual(
      Action<DropDownListVirtualSettingsBuilder> configurator)
    {
      this.Container.Virtual.Enabled = new bool?(true);
      this.Container.Virtual.DropDownList = this.Container;
      configurator(new DropDownListVirtualSettingsBuilder(this.Container.Virtual));
      return this;
    }

    public DropDownListBuilder Virtual()
    {
      this.Container.Virtual.Enabled = new bool?(true);
      return this;
    }

    public DropDownListBuilder Virtual(bool enabled)
    {
      this.Container.Virtual.Enabled = new bool?(enabled);
      return this;
    }

    public DropDownListBuilder Filter(FilterType value)
    {
      this.Container.Filter = new FilterType?(value);
      return this;
    }

    public DropDownListBuilder Events(
      Action<DropDownListEventBuilder> configurator)
    {
      configurator(new DropDownListEventBuilder(this.Container.Events));
      return this;
    }
  }
}
