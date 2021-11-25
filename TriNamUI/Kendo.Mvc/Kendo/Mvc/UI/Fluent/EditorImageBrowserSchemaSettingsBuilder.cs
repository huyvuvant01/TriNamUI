// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorImageBrowserSchemaSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorImageBrowserSchemaSettingsBuilder
  {
    public EditorImageBrowserSchemaSettingsBuilder(EditorImageBrowserSchemaSettings container) => this.Container = container;

    protected EditorImageBrowserSchemaSettings Container { get; private set; }

    public EditorImageBrowserSchemaSettingsBuilder Model(
      Action<EditorImageBrowserSchemaModelSettingsBuilder> configurator)
    {
      this.Container.Model.Editor = this.Container.Editor;
      configurator(new EditorImageBrowserSchemaModelSettingsBuilder(this.Container.Model));
      return this;
    }
  }
}
