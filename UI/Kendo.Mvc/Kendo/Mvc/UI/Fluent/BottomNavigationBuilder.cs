// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.BottomNavigationBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class BottomNavigationBuilder : WidgetBuilderBase<BottomNavigation, BottomNavigationBuilder>
  {
    public BottomNavigationBuilder(BottomNavigation component)
      : base(component)
    {
    }

    public BottomNavigationBuilder Border(bool value)
    {
      this.Container.Border = new bool?(value);
      return this;
    }

    public BottomNavigationBuilder Shadow(bool value)
    {
      this.Container.Shadow = new bool?(value);
      return this;
    }

    public BottomNavigationBuilder Shadow()
    {
      this.Container.Shadow = new bool?(true);
      return this;
    }

    public BottomNavigationBuilder Items(
      Action<BottomNavigationItemFactory> configurator)
    {
      configurator(new BottomNavigationItemFactory(this.Container.Items)
      {
        BottomNavigation = this.Container
      });
      return this;
    }

    public BottomNavigationBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public BottomNavigationBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public BottomNavigationBuilder Fill(BottomNavigationFill value)
    {
      this.Container.Fill = new BottomNavigationFill?(value);
      return this;
    }

    public BottomNavigationBuilder PositionMode(
      BottomNavigationPositionMode value)
    {
      this.Container.PositionMode = new BottomNavigationPositionMode?(value);
      return this;
    }

    public BottomNavigationBuilder ItemFlow(BottomNavigationItemFlow value)
    {
      this.Container.ItemFlow = new BottomNavigationItemFlow?(value);
      return this;
    }

    public BottomNavigationBuilder ThemeColor(
      BottomNavigationThemeColor value)
    {
      this.Container.ThemeColor = new BottomNavigationThemeColor?(value);
      return this;
    }

    public BottomNavigationBuilder Events(
      Action<BottomNavigationEventBuilder> configurator)
    {
      configurator(new BottomNavigationEventBuilder(this.Container.Events));
      return this;
    }
  }
}
