// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TabStripScrollableSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class TabStripScrollableSettingsBuilder
  {
    public TabStripScrollableSettingsBuilder(TabStripScrollableSettings container) => this.Container = container;

    protected TabStripScrollableSettings Container { get; private set; }

    public virtual TabStripScrollableSettingsBuilder Enabled(
      bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public TabStripScrollableSettingsBuilder Distance(int value)
    {
      this.Container.Distance = new int?(value);
      return this;
    }
  }
}
