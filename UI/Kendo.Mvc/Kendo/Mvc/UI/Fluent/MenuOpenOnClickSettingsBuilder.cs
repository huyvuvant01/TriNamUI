// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MenuOpenOnClickSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class MenuOpenOnClickSettingsBuilder
  {
    public MenuOpenOnClickSettingsBuilder(MenuOpenOnClickSettings container) => this.Container = container;

    protected MenuOpenOnClickSettings Container { get; private set; }

    public MenuOpenOnClickSettingsBuilder RootMenuItems(bool value)
    {
      this.Container.RootMenuItems = new bool?(value);
      return this;
    }

    public MenuOpenOnClickSettingsBuilder RootMenuItems()
    {
      this.Container.RootMenuItems = new bool?(true);
      return this;
    }

    public MenuOpenOnClickSettingsBuilder SubMenuItems(bool value)
    {
      this.Container.SubMenuItems = new bool?(value);
      return this;
    }

    public MenuOpenOnClickSettingsBuilder SubMenuItems()
    {
      this.Container.SubMenuItems = new bool?(true);
      return this;
    }
  }
}
