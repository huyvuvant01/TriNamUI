﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MultiColumnComboBoxPopupSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class MultiColumnComboBoxPopupSettingsBuilder
  {
    public MultiColumnComboBoxPopupSettingsBuilder(MultiColumnComboBoxPopupSettings container) => this.Container = container;

    protected MultiColumnComboBoxPopupSettings Container { get; private set; }

    public MultiColumnComboBoxPopupSettingsBuilder AppendTo(
      string value)
    {
      this.Container.AppendTo = value;
      return this;
    }

    public MultiColumnComboBoxPopupSettingsBuilder Origin(
      string value)
    {
      this.Container.Origin = value;
      return this;
    }

    public MultiColumnComboBoxPopupSettingsBuilder Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }
  }
}
