// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridScrollSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridScrollSettingsBuilder : IHideObjectMembers
  {
    private readonly GridScrollableSettings settings;

    public GridScrollSettingsBuilder(GridScrollableSettings settings) => this.settings = settings;

    public virtual GridScrollSettingsBuilder Enabled(bool value)
    {
      this.settings.Enabled = value;
      return this;
    }

    public virtual GridScrollSettingsBuilder Height(int pixelHeight)
    {
      this.settings.Height = pixelHeight.ToString() + "px";
      return this;
    }

    public virtual GridScrollSettingsBuilder Height(string value)
    {
      this.settings.Height = value;
      return this;
    }

    public virtual GridScrollSettingsBuilder Virtual(bool value)
    {
      this.settings.Virtual.Enabled = value;
      return this;
    }

    public virtual GridScrollSettingsBuilder Virtual(
      GridVirtualizationMode value)
    {
      this.settings.Virtual.Mode = new GridVirtualizationMode?(value);
      return this;
    }

    public virtual GridScrollSettingsBuilder Endless(bool value)
    {
      this.settings.Endless = value;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
