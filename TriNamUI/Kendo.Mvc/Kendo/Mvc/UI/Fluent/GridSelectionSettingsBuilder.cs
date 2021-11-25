// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridSelectionSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class GridSelectionSettingsBuilder : IHideObjectMembers
  {
    private readonly GridSelectableSettings settings;

    public GridSelectionSettingsBuilder(GridSelectableSettings settings) => this.settings = settings;

    public GridSelectionSettingsBuilder Enabled(bool value)
    {
      this.settings.Enabled = value;
      return this;
    }

    public GridSelectionSettingsBuilder Mode(GridSelectionMode mode)
    {
      this.settings.Mode = mode;
      return this;
    }

    public GridSelectionSettingsBuilder Type(GridSelectionType type)
    {
      this.settings.Type = type;
      return this;
    }

    public GridSelectionSettingsBuilder IgnoreOverlapped(
      bool ignoreOverlapped)
    {
      this.settings.IgnoreOverlapped = ignoreOverlapped;
      return this;
    }

    System.Type IHideObjectMembers.GetType() => this.GetType();
  }
}
