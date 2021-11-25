// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DrawerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DrawerBuilder : WidgetBuilderBase<Drawer, DrawerBuilder>
  {
    public DrawerBuilder(Drawer component)
      : base(component)
    {
    }

    public DrawerBuilder Content(Action value)
    {
      this.Container.Content.Content = value;
      return this;
    }

    public DrawerBuilder Content(Func<object, object> value)
    {
      this.Container.Content.InlineTemplate = value;
      return this;
    }

    public DrawerBuilder Content(string value)
    {
      this.Container.Content.Html = value;
      return this;
    }

    public DrawerBuilder AutoCollapse(bool value)
    {
      this.Container.AutoCollapse = new bool?(value);
      return this;
    }

    public DrawerBuilder Position(string value)
    {
      this.Container.Position = value;
      return this;
    }

    public DrawerBuilder Mode(string value)
    {
      this.Container.Mode = value;
      return this;
    }

    public DrawerBuilder Navigatable(bool value)
    {
      this.Container.Navigatable = new bool?(value);
      return this;
    }

    public DrawerBuilder Navigatable()
    {
      this.Container.Navigatable = new bool?(true);
      return this;
    }

    public DrawerBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public DrawerBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public DrawerBuilder MinHeight(double value)
    {
      this.Container.MinHeight = new double?(value);
      return this;
    }

    public DrawerBuilder Mini(Action<DrawerMiniSettingsBuilder> configurator)
    {
      this.Container.Mini.Enabled = new bool?(true);
      this.Container.Mini.Drawer = this.Container;
      configurator(new DrawerMiniSettingsBuilder(this.Container.Mini));
      return this;
    }

    public DrawerBuilder Mini(bool enabled)
    {
      this.Container.Mini.Enabled = new bool?(enabled);
      return this;
    }

    public DrawerBuilder SwipeToOpen(bool value)
    {
      this.Container.SwipeToOpen = new bool?(value);
      return this;
    }

    public DrawerBuilder Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public DrawerBuilder Events(Action<DrawerEventBuilder> configurator)
    {
      configurator(new DrawerEventBuilder(this.Container.Events));
      return this;
    }
  }
}
