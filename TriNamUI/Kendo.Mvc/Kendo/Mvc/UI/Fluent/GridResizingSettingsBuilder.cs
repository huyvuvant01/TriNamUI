﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridResizingSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridResizingSettingsBuilder : IHideObjectMembers
  {
    private readonly GridSettings settings;

    public GridResizingSettingsBuilder(GridSettings settings) => this.settings = settings;

    public GridResizingSettingsBuilder Columns(bool value)
    {
      this.settings.Enabled = value;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
