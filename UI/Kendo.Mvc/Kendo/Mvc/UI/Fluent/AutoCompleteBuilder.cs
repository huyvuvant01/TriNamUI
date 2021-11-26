// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.AutoCompleteBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
  public class AutoCompleteBuilder : WidgetBuilderBase<AutoComplete, AutoCompleteBuilder>
  {
    public AutoCompleteBuilder(AutoComplete component)
      : base(component)
    {
    }

    public AutoCompleteBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public AutoCompleteBuilder Animation(
      Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public AutoCompleteBuilder BindTo(IEnumerable data)
    {
      this.Component.DataSource.Data = data;
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public AutoCompleteBuilder Filter(string value)
    {
      this.Container.Filter = new FilterType?((FilterType) Enum.Parse(typeof (FilterType), value, true));
      return this;
    }

    public AutoCompleteBuilder DataSource(
      Action<ReadOnlyDataSourceBuilder> configurator)
    {
      configurator(new ReadOnlyDataSourceBuilder(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public AutoCompleteBuilder DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public AutoCompleteBuilder Separator(string[] value)
    {
      this.Container.Separators = value;
      return this;
    }

    public AutoCompleteBuilder AutoWidth(bool value)
    {
      this.Container.AutoWidth = new bool?(value);
      return this;
    }

    public AutoCompleteBuilder ClearButton(bool value)
    {
      this.Container.ClearButton = new bool?(value);
      return this;
    }

    public AutoCompleteBuilder DataTextField(string value)
    {
      this.Container.DataTextField = value;
      return this;
    }

    public AutoCompleteBuilder Delay(double value)
    {
      this.Container.Delay = new double?(value);
      return this;
    }

    public AutoCompleteBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public AutoCompleteBuilder EnforceMinLength(bool value)
    {
      this.Container.EnforceMinLength = new bool?(value);
      return this;
    }

    public AutoCompleteBuilder EnforceMinLength()
    {
      this.Container.EnforceMinLength = new bool?(true);
      return this;
    }

    public AutoCompleteBuilder FixedGroupTemplate(string value)
    {
      this.Container.FixedGroupTemplate = value;
      return this;
    }

    public AutoCompleteBuilder FixedGroupTemplateId(string templateId)
    {
      this.Container.FixedGroupTemplateId = templateId;
      return this;
    }

    public AutoCompleteBuilder FooterTemplate(string value)
    {
      this.Container.FooterTemplate = value;
      return this;
    }

    public AutoCompleteBuilder FooterTemplateId(string templateId)
    {
      this.Container.FooterTemplateId = templateId;
      return this;
    }

    public AutoCompleteBuilder GroupTemplate(string value)
    {
      this.Container.GroupTemplate = value;
      return this;
    }

    public AutoCompleteBuilder GroupTemplateId(string templateId)
    {
      this.Container.GroupTemplateId = templateId;
      return this;
    }

    public AutoCompleteBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public AutoCompleteBuilder HighlightFirst(bool value)
    {
      this.Container.HighlightFirst = new bool?(value);
      return this;
    }

    public AutoCompleteBuilder HighlightFirst()
    {
      this.Container.HighlightFirst = new bool?(true);
      return this;
    }

    public AutoCompleteBuilder IgnoreCase(bool value)
    {
      this.Container.IgnoreCase = new bool?(value);
      return this;
    }

    public AutoCompleteBuilder Messages(
      Action<AutoCompleteMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.AutoComplete = this.Container;
      configurator(new AutoCompleteMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public AutoCompleteBuilder MinLength(double value)
    {
      this.Container.MinLength = new double?(value);
      return this;
    }

    public AutoCompleteBuilder NoDataTemplate(string value)
    {
      this.Container.NoDataTemplate = value;
      return this;
    }

    public AutoCompleteBuilder NoDataTemplateId(string templateId)
    {
      this.Container.NoDataTemplateId = templateId;
      return this;
    }

    public AutoCompleteBuilder Placeholder(string value)
    {
      this.Container.Placeholder = value;
      return this;
    }

    public AutoCompleteBuilder Separator(string value)
    {
      this.Container.Separator = value;
      return this;
    }

    public AutoCompleteBuilder Suggest(bool value)
    {
      this.Container.Suggest = new bool?(value);
      return this;
    }

    public AutoCompleteBuilder Suggest()
    {
      this.Container.Suggest = new bool?(true);
      return this;
    }

    public AutoCompleteBuilder HeaderTemplate(string value)
    {
      this.Container.HeaderTemplate = value;
      return this;
    }

    public AutoCompleteBuilder HeaderTemplateId(string templateId)
    {
      this.Container.HeaderTemplateId = templateId;
      return this;
    }

    public AutoCompleteBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public AutoCompleteBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public AutoCompleteBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public AutoCompleteBuilder ValuePrimitive(bool value)
    {
      this.Container.ValuePrimitive = new bool?(value);
      return this;
    }

    public AutoCompleteBuilder ValuePrimitive()
    {
      this.Container.ValuePrimitive = new bool?(true);
      return this;
    }

    public AutoCompleteBuilder Virtual(
      Action<AutoCompleteVirtualSettingsBuilder> configurator)
    {
      this.Container.Virtual.Enabled = new bool?(true);
      this.Container.Virtual.AutoComplete = this.Container;
      configurator(new AutoCompleteVirtualSettingsBuilder(this.Container.Virtual));
      return this;
    }

    public AutoCompleteBuilder Virtual()
    {
      this.Container.Virtual.Enabled = new bool?(true);
      return this;
    }

    public AutoCompleteBuilder Virtual(bool enabled)
    {
      this.Container.Virtual.Enabled = new bool?(enabled);
      return this;
    }

    public AutoCompleteBuilder Filter(FilterType value)
    {
      this.Container.Filter = new FilterType?(value);
      return this;
    }

    public AutoCompleteBuilder Events(
      Action<AutoCompleteEventBuilder> configurator)
    {
      configurator(new AutoCompleteEventBuilder(this.Container.Events));
      return this;
    }
  }
}
