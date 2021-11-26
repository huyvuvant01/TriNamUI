// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ListViewEditingSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ListViewEditingSettingsBuilder<T> : IHideObjectMembers where T : class
  {
    private readonly ListViewEditingSettings<T> settings;

    public ListViewEditingSettingsBuilder(ListViewEditingSettings<T> settings)
    {
      this.settings = settings;
      this.settings.Enabled = true;
    }

    public ListViewEditingSettingsBuilder<T> Enabled(bool value)
    {
      this.settings.Enabled = value;
      return this;
    }

    public ListViewEditingSettingsBuilder<T> TemplateName(
      string templateName)
    {
      this.settings.TemplateName = templateName;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
