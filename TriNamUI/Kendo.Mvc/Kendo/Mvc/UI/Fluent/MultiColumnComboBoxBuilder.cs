// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MultiColumnComboBoxBuilder
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
  public class MultiColumnComboBoxBuilder : 
    WidgetBuilderBase<MultiColumnComboBox, MultiColumnComboBoxBuilder>
  {
    public MultiColumnComboBoxBuilder(MultiColumnComboBox component)
      : base(component)
    {
    }

    public MultiColumnComboBoxBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public MultiColumnComboBoxBuilder Animation(
      Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public MultiColumnComboBoxBuilder BindTo(IEnumerable data)
    {
      this.Component.DataSource.Data = data;
      return this;
    }

    public MultiColumnComboBoxBuilder BindTo(
      IEnumerable<SelectListItem> dataSource)
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

    public MultiColumnComboBoxBuilder Items(
      Action<SelectListItemFactory> addAction)
    {
      List<SelectListItem> selectListItemList = new List<SelectListItem>();
      addAction(new SelectListItemFactory((IList<SelectListItem>) selectListItemList));
      return this.BindTo((IEnumerable<SelectListItem>) selectListItemList);
    }

    public MultiColumnComboBoxBuilder DataSource(
      Action<ReadOnlyDataSourceBuilder> configurator)
    {
      configurator(new ReadOnlyDataSourceBuilder(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public MultiColumnComboBoxBuilder DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public MultiColumnComboBoxBuilder Filter(string value)
    {
      this.Container.Filter = new FilterType?((FilterType) Enum.Parse(typeof (FilterType), value, true));
      return this;
    }

    public MultiColumnComboBoxBuilder SelectedIndex(int value)
    {
      this.Container.SelectedIndex = new int?(value);
      return this;
    }

    public MultiColumnComboBoxBuilder AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public MultiColumnComboBoxBuilder CascadeFrom(string value)
    {
      this.Container.CascadeFrom = value;
      return this;
    }

    public MultiColumnComboBoxBuilder CascadeFromField(string value)
    {
      this.Container.CascadeFromField = value;
      return this;
    }

    public MultiColumnComboBoxBuilder CascadeFromParentField(string value)
    {
      this.Container.CascadeFromParentField = value;
      return this;
    }

    public MultiColumnComboBoxBuilder Columns(
      Action<MultiColumnComboBoxColumnFactory> configurator)
    {
      configurator(new MultiColumnComboBoxColumnFactory(this.Container.Columns)
      {
        MultiColumnComboBox = this.Container
      });
      return this;
    }

    public MultiColumnComboBoxBuilder ClearButton(bool value)
    {
      this.Container.ClearButton = new bool?(value);
      return this;
    }

    public MultiColumnComboBoxBuilder DataTextField(string value)
    {
      this.Container.DataTextField = value;
      return this;
    }

    public MultiColumnComboBoxBuilder DataValueField(string value)
    {
      this.Container.DataValueField = value;
      return this;
    }

    public MultiColumnComboBoxBuilder Delay(double value)
    {
      this.Container.Delay = new double?(value);
      return this;
    }

    public MultiColumnComboBoxBuilder DropDownWidth(string value)
    {
      this.Container.DropDownWidth = value;
      return this;
    }

    public MultiColumnComboBoxBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public MultiColumnComboBoxBuilder EnforceMinLength(bool value)
    {
      this.Container.EnforceMinLength = new bool?(value);
      return this;
    }

    public MultiColumnComboBoxBuilder EnforceMinLength()
    {
      this.Container.EnforceMinLength = new bool?(true);
      return this;
    }

    public MultiColumnComboBoxBuilder FilterFields(params string[] value)
    {
      this.Container.FilterFields = value;
      return this;
    }

    public MultiColumnComboBoxBuilder FixedGroupTemplate(string value)
    {
      this.Container.FixedGroupTemplate = value;
      return this;
    }

    public MultiColumnComboBoxBuilder FixedGroupTemplateId(
      string templateId)
    {
      this.Container.FixedGroupTemplateId = templateId;
      return this;
    }

    public MultiColumnComboBoxBuilder FooterTemplate(string value)
    {
      this.Container.FooterTemplate = value;
      return this;
    }

    public MultiColumnComboBoxBuilder FooterTemplateId(string templateId)
    {
      this.Container.FooterTemplateId = templateId;
      return this;
    }

    public MultiColumnComboBoxBuilder GroupTemplate(string value)
    {
      this.Container.GroupTemplate = value;
      return this;
    }

    public MultiColumnComboBoxBuilder GroupTemplateId(string templateId)
    {
      this.Container.GroupTemplateId = templateId;
      return this;
    }

    public MultiColumnComboBoxBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public MultiColumnComboBoxBuilder HighlightFirst(bool value)
    {
      this.Container.HighlightFirst = new bool?(value);
      return this;
    }

    public MultiColumnComboBoxBuilder IgnoreCase(bool value)
    {
      this.Container.IgnoreCase = new bool?(value);
      return this;
    }

    public MultiColumnComboBoxBuilder Messages(
      Action<MultiColumnComboBoxMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.MultiColumnComboBox = this.Container;
      configurator(new MultiColumnComboBoxMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public MultiColumnComboBoxBuilder MinLength(double value)
    {
      this.Container.MinLength = new double?(value);
      return this;
    }

    public MultiColumnComboBoxBuilder NoDataTemplate(string value)
    {
      this.Container.NoDataTemplate = value;
      return this;
    }

    public MultiColumnComboBoxBuilder NoDataTemplateId(string templateId)
    {
      this.Container.NoDataTemplateId = templateId;
      return this;
    }

    public MultiColumnComboBoxBuilder Placeholder(string value)
    {
      this.Container.Placeholder = value;
      return this;
    }

    public MultiColumnComboBoxBuilder Popup(
      Action<MultiColumnComboBoxPopupSettingsBuilder> configurator)
    {
      this.Container.Popup.MultiColumnComboBox = this.Container;
      configurator(new MultiColumnComboBoxPopupSettingsBuilder(this.Container.Popup));
      return this;
    }

    public MultiColumnComboBoxBuilder Suggest(bool value)
    {
      this.Container.Suggest = new bool?(value);
      return this;
    }

    public MultiColumnComboBoxBuilder Suggest()
    {
      this.Container.Suggest = new bool?(true);
      return this;
    }

    public MultiColumnComboBoxBuilder SyncValueAndText(bool value)
    {
      this.Container.SyncValueAndText = new bool?(value);
      return this;
    }

    public MultiColumnComboBoxBuilder HeaderTemplate(string value)
    {
      this.Container.HeaderTemplate = value;
      return this;
    }

    public MultiColumnComboBoxBuilder HeaderTemplateId(string templateId)
    {
      this.Container.HeaderTemplateId = templateId;
      return this;
    }

    public MultiColumnComboBoxBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public MultiColumnComboBoxBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public MultiColumnComboBoxBuilder ValuePrimitive(bool value)
    {
      this.Container.ValuePrimitive = new bool?(value);
      return this;
    }

    public MultiColumnComboBoxBuilder ValuePrimitive()
    {
      this.Container.ValuePrimitive = new bool?(true);
      return this;
    }

    public MultiColumnComboBoxBuilder Virtual(
      Action<MultiColumnComboBoxVirtualSettingsBuilder> configurator)
    {
      this.Container.Virtual.Enabled = new bool?(true);
      this.Container.Virtual.MultiColumnComboBox = this.Container;
      configurator(new MultiColumnComboBoxVirtualSettingsBuilder(this.Container.Virtual));
      return this;
    }

    public MultiColumnComboBoxBuilder Virtual()
    {
      this.Container.Virtual.Enabled = new bool?(true);
      return this;
    }

    public MultiColumnComboBoxBuilder Virtual(bool enabled)
    {
      this.Container.Virtual.Enabled = new bool?(enabled);
      return this;
    }

    public MultiColumnComboBoxBuilder Filter(FilterType value)
    {
      this.Container.Filter = new FilterType?(value);
      return this;
    }

    public MultiColumnComboBoxBuilder Events(
      Action<MultiColumnComboBoxEventBuilder> configurator)
    {
      configurator(new MultiColumnComboBoxEventBuilder(this.Container.Events));
      return this;
    }
  }
}
