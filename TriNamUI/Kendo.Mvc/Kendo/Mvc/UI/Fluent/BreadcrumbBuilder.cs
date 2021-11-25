// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.BreadcrumbBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class BreadcrumbBuilder : WidgetBuilderBase<Breadcrumb, BreadcrumbBuilder>
  {
    public BreadcrumbBuilder(Breadcrumb component)
      : base(component)
    {
    }

    public BreadcrumbBuilder Tag(string tag)
    {
      this.Component.Tag = tag;
      return this;
    }

    public BreadcrumbBuilder BindToLocation(bool value)
    {
      this.Container.BindToLocation = new bool?(value);
      return this;
    }

    public BreadcrumbBuilder BindToLocation()
    {
      this.Container.BindToLocation = new bool?(true);
      return this;
    }

    public BreadcrumbBuilder DelimiterIcon(string value)
    {
      this.Container.DelimiterIcon = value;
      return this;
    }

    public BreadcrumbBuilder Editable(bool value)
    {
      this.Container.Editable = new bool?(value);
      return this;
    }

    public BreadcrumbBuilder Editable()
    {
      this.Container.Editable = new bool?(true);
      return this;
    }

    public BreadcrumbBuilder Items(Action<BreadcrumbItemFactory> configurator)
    {
      configurator(new BreadcrumbItemFactory(this.Container.Items)
      {
        Breadcrumb = this.Container
      });
      return this;
    }

    public BreadcrumbBuilder Gap(double value)
    {
      this.Container.Gap = new double?(value);
      return this;
    }

    public BreadcrumbBuilder Messages(
      Action<BreadcrumbMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.Breadcrumb = this.Container;
      configurator(new BreadcrumbMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public BreadcrumbBuilder Navigational(bool value)
    {
      this.Container.Navigational = new bool?(value);
      return this;
    }

    public BreadcrumbBuilder Navigational()
    {
      this.Container.Navigational = new bool?(true);
      return this;
    }

    public BreadcrumbBuilder RootIcon(string value)
    {
      this.Container.RootIcon = value;
      return this;
    }

    public BreadcrumbBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public BreadcrumbBuilder Events(Action<BreadcrumbEventBuilder> configurator)
    {
      configurator(new BreadcrumbEventBuilder(this.Container.Events));
      return this;
    }
  }
}
