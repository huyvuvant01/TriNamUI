// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MenuScrollableSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class MenuScrollableSettingsBuilder
  {
    public MenuScrollableSettingsBuilder(MenuScrollableSettings container) => this.Container = container;

    protected MenuScrollableSettings Container { get; private set; }

    public MenuScrollableSettingsBuilder Distance(double value)
    {
      this.Container.Distance = new double?(value);
      return this;
    }
  }
}
