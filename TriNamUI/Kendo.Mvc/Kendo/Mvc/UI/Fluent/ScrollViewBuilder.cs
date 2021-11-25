// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ScrollViewBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ScrollViewBuilder : WidgetBuilderBase<ScrollView, ScrollViewBuilder>
  {
    public ScrollViewBuilder(ScrollView component)
      : base(component)
    {
    }

    public ScrollViewBuilder ContentHeight(int value)
    {
      this.Component.ContentHeight = value.ToString() + "px";
      return this;
    }

    public ScrollViewBuilder DataSource(
      Action<DataSourceBuilder<object>> configurator)
    {
      this.Component.DataSource.ServerAggregates = true;
      this.Component.DataSource.ServerFiltering = true;
      this.Component.DataSource.ServerGrouping = true;
      this.Component.DataSource.ServerPaging = true;
      this.Component.DataSource.ServerSorting = true;
      configurator(new DataSourceBuilder<object>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public ScrollViewBuilder DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public ScrollViewBuilder Items(Action<ScrollViewItemFactory> addAction)
    {
      ScrollViewItemFactory scrollViewItemFactory = new ScrollViewItemFactory((INavigationItemContainer<ScrollViewItem>) this.Component, this.Component.ViewContext);
      addAction(scrollViewItemFactory);
      return this;
    }

    public ScrollViewBuilder ARIATemplate(string value)
    {
      this.Container.ARIATemplate = value;
      return this;
    }

    public ScrollViewBuilder ARIATemplateId(string templateId)
    {
      this.Container.ARIATemplateId = templateId;
      return this;
    }

    public ScrollViewBuilder AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public ScrollViewBuilder BounceVelocityThreshold(double value)
    {
      this.Container.BounceVelocityThreshold = new double?(value);
      return this;
    }

    public ScrollViewBuilder Duration(double value)
    {
      this.Container.Duration = new double?(value);
      return this;
    }

    public ScrollViewBuilder EmptyTemplate(string value)
    {
      this.Container.EmptyTemplate = value;
      return this;
    }

    public ScrollViewBuilder EmptyTemplateId(string templateId)
    {
      this.Container.EmptyTemplateId = templateId;
      return this;
    }

    public ScrollViewBuilder EnablePager(bool value)
    {
      this.Container.EnablePager = new bool?(value);
      return this;
    }

    public ScrollViewBuilder Messages(
      Action<ScrollViewMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.ScrollView = this.Container;
      configurator(new ScrollViewMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public ScrollViewBuilder Navigatable(bool value)
    {
      this.Container.Navigatable = new bool?(value);
      return this;
    }

    public ScrollViewBuilder Navigatable()
    {
      this.Container.Navigatable = new bool?(true);
      return this;
    }

    public ScrollViewBuilder Pageable(
      Action<ScrollViewPageableSettingsBuilder> configurator)
    {
      this.Container.Pageable.Enabled = new bool?(true);
      this.Container.Pageable.ScrollView = this.Container;
      configurator(new ScrollViewPageableSettingsBuilder(this.Container.Pageable));
      return this;
    }

    public ScrollViewBuilder Pageable()
    {
      this.Container.Pageable.Enabled = new bool?(true);
      return this;
    }

    public ScrollViewBuilder Pageable(bool enabled)
    {
      this.Container.Pageable.Enabled = new bool?(enabled);
      return this;
    }

    public ScrollViewBuilder Page(double value)
    {
      this.Container.Page = new double?(value);
      return this;
    }

    public ScrollViewBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ScrollViewBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ScrollViewBuilder VelocityThreshold(double value)
    {
      this.Container.VelocityThreshold = new double?(value);
      return this;
    }

    public ScrollViewBuilder ContentHeight(string value)
    {
      this.Container.ContentHeight = value;
      return this;
    }

    public ScrollViewBuilder Events(Action<ScrollViewEventBuilder> configurator)
    {
      configurator(new ScrollViewEventBuilder(this.Container.Events));
      return this;
    }
  }
}
