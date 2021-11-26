// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ComboBoxBuilder
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
  public class ComboBoxBuilder : WidgetBuilderBase<ComboBox, ComboBoxBuilder>
  {
    public ComboBoxBuilder(ComboBox component)
      : base(component)
    {
    }

    public ComboBoxBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public ComboBoxBuilder Animation(Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public ComboBoxBuilder BindTo(IEnumerable data)
    {
      this.Component.DataSource.Data = data;
      return this;
    }

    public ComboBoxBuilder BindTo(IEnumerable<SelectListItem> dataSource)
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

    public ComboBoxBuilder Items(Action<SelectListItemFactory> addAction)
    {
      List<SelectListItem> selectListItemList = new List<SelectListItem>();
      addAction(new SelectListItemFactory((IList<SelectListItem>) selectListItemList));
      return this.BindTo((IEnumerable<SelectListItem>) selectListItemList);
    }

    public ComboBoxBuilder DataSource(Action<ReadOnlyDataSourceBuilder> configurator)
    {
      configurator(new ReadOnlyDataSourceBuilder(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public ComboBoxBuilder DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ComboBoxBuilder Filter(string value)
    {
      this.Container.Filter = new FilterType?((FilterType) Enum.Parse(typeof (FilterType), value, true));
      return this;
    }

    public ComboBoxBuilder SelectedIndex(int value)
    {
      this.Container.SelectedIndex = new int?(value);
      return this;
    }

    public ComboBoxBuilder AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public ComboBoxBuilder AutoWidth(bool value)
    {
      this.Container.AutoWidth = new bool?(value);
      return this;
    }

    public ComboBoxBuilder CascadeFrom(string value)
    {
      this.Container.CascadeFrom = value;
      return this;
    }

    public ComboBoxBuilder CascadeFromField(string value)
    {
      this.Container.CascadeFromField = value;
      return this;
    }

    public ComboBoxBuilder CascadeFromParentField(string value)
    {
      this.Container.CascadeFromParentField = value;
      return this;
    }

    public ComboBoxBuilder ClearButton(bool value)
    {
      this.Container.ClearButton = new bool?(value);
      return this;
    }

    public ComboBoxBuilder DataTextField(string value)
    {
      this.Container.DataTextField = value;
      return this;
    }

    public ComboBoxBuilder DataValueField(string value)
    {
      this.Container.DataValueField = value;
      return this;
    }

    public ComboBoxBuilder Delay(double value)
    {
      this.Container.Delay = new double?(value);
      return this;
    }

    public ComboBoxBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public ComboBoxBuilder EnforceMinLength(bool value)
    {
      this.Container.EnforceMinLength = new bool?(value);
      return this;
    }

    public ComboBoxBuilder EnforceMinLength()
    {
      this.Container.EnforceMinLength = new bool?(true);
      return this;
    }

    public ComboBoxBuilder FixedGroupTemplate(string value)
    {
      this.Container.FixedGroupTemplate = value;
      return this;
    }

    public ComboBoxBuilder FixedGroupTemplateId(string templateId)
    {
      this.Container.FixedGroupTemplateId = templateId;
      return this;
    }

    public ComboBoxBuilder FooterTemplate(string value)
    {
      this.Container.FooterTemplate = value;
      return this;
    }

    public ComboBoxBuilder FooterTemplateId(string templateId)
    {
      this.Container.FooterTemplateId = templateId;
      return this;
    }

    public ComboBoxBuilder GroupTemplate(string value)
    {
      this.Container.GroupTemplate = value;
      return this;
    }

    public ComboBoxBuilder GroupTemplateId(string templateId)
    {
      this.Container.GroupTemplateId = templateId;
      return this;
    }

    public ComboBoxBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public ComboBoxBuilder HighlightFirst(bool value)
    {
      this.Container.HighlightFirst = new bool?(value);
      return this;
    }

    public ComboBoxBuilder IgnoreCase(bool value)
    {
      this.Container.IgnoreCase = new bool?(value);
      return this;
    }

    public ComboBoxBuilder Messages(
      Action<ComboBoxMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.ComboBox = this.Container;
      configurator(new ComboBoxMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public ComboBoxBuilder MinLength(double value)
    {
      this.Container.MinLength = new double?(value);
      return this;
    }

    public ComboBoxBuilder NoDataTemplate(string value)
    {
      this.Container.NoDataTemplate = value;
      return this;
    }

    public ComboBoxBuilder NoDataTemplateId(string templateId)
    {
      this.Container.NoDataTemplateId = templateId;
      return this;
    }

    public ComboBoxBuilder Placeholder(string value)
    {
      this.Container.Placeholder = value;
      return this;
    }

    public ComboBoxBuilder Popup(Action<ComboBoxPopupSettingsBuilder> configurator)
    {
      this.Container.Popup.ComboBox = this.Container;
      configurator(new ComboBoxPopupSettingsBuilder(this.Container.Popup));
      return this;
    }

    public ComboBoxBuilder Suggest(bool value)
    {
      this.Container.Suggest = new bool?(value);
      return this;
    }

    public ComboBoxBuilder Suggest()
    {
      this.Container.Suggest = new bool?(true);
      return this;
    }

    public ComboBoxBuilder SyncValueAndText(bool value)
    {
      this.Container.SyncValueAndText = new bool?(value);
      return this;
    }

    public ComboBoxBuilder HeaderTemplate(string value)
    {
      this.Container.HeaderTemplate = value;
      return this;
    }

    public ComboBoxBuilder HeaderTemplateId(string templateId)
    {
      this.Container.HeaderTemplateId = templateId;
      return this;
    }

    public ComboBoxBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ComboBoxBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ComboBoxBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ComboBoxBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public ComboBoxBuilder ValuePrimitive(bool value)
    {
      this.Container.ValuePrimitive = new bool?(value);
      return this;
    }

    public ComboBoxBuilder ValuePrimitive()
    {
      this.Container.ValuePrimitive = new bool?(true);
      return this;
    }

    public ComboBoxBuilder Virtual(
      Action<ComboBoxVirtualSettingsBuilder> configurator)
    {
      this.Container.Virtual.Enabled = new bool?(true);
      this.Container.Virtual.ComboBox = this.Container;
      configurator(new ComboBoxVirtualSettingsBuilder(this.Container.Virtual));
      return this;
    }

    public ComboBoxBuilder Virtual()
    {
      this.Container.Virtual.Enabled = new bool?(true);
      return this;
    }

    public ComboBoxBuilder Virtual(bool enabled)
    {
      this.Container.Virtual.Enabled = new bool?(enabled);
      return this;
    }

    public ComboBoxBuilder Filter(FilterType value)
    {
      this.Container.Filter = new FilterType?(value);
      return this;
    }

    public ComboBoxBuilder Events(Action<ComboBoxEventBuilder> configurator)
    {
      configurator(new ComboBoxEventBuilder(this.Container.Events));
      return this;
    }
  }
}
