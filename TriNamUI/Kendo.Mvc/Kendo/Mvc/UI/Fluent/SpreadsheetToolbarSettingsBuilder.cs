// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetToolbarSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetToolbarSettingsBuilder
  {
    public SpreadsheetToolbarSettingsBuilder(SpreadsheetToolbarSettings container) => this.Container = container;

    protected SpreadsheetToolbarSettings Container { get; private set; }

    public SpreadsheetToolbarSettingsBuilder Home(
      Action<SpreadsheetToolFactory> configurator)
    {
      this.Container.Home.Enabled = true;
      configurator(new SpreadsheetToolFactory(this.Container.Home));
      return this;
    }

    public SpreadsheetToolbarSettingsBuilder Insert(
      Action<SpreadsheetToolFactory> configurator)
    {
      this.Container.Insert.Enabled = true;
      configurator(new SpreadsheetToolFactory(this.Container.Insert));
      return this;
    }

    public SpreadsheetToolbarSettingsBuilder Data(
      Action<SpreadsheetToolFactory> configurator)
    {
      this.Container.Data.Enabled = true;
      configurator(new SpreadsheetToolFactory(this.Container.Data));
      return this;
    }

    public SpreadsheetToolbarSettingsBuilder Home(bool value)
    {
      this.Container.Home.Enabled = value;
      return this;
    }

    public SpreadsheetToolbarSettingsBuilder Insert(bool value)
    {
      this.Container.Insert.Enabled = value;
      return this;
    }

    public SpreadsheetToolbarSettingsBuilder Data(bool value)
    {
      this.Container.Data.Enabled = value;
      return this;
    }
  }
}
