// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ExpansionPanelAnimationExpandSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ExpansionPanelAnimationExpandSettingsBuilder
  {
    public ExpansionPanelAnimationExpandSettingsBuilder(
      ExpansionPanelAnimationExpandSettings container)
    {
      this.Container = container;
    }

    protected ExpansionPanelAnimationExpandSettings Container { get; private set; }

    public ExpansionPanelAnimationExpandSettingsBuilder Duration(
      double value)
    {
      this.Container.Duration = new double?(value);
      return this;
    }

    public ExpansionPanelAnimationExpandSettingsBuilder Effects(
      string value)
    {
      this.Container.Effects = value;
      return this;
    }
  }
}
