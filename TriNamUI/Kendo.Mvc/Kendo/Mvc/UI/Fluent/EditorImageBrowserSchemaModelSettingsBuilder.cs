// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorImageBrowserSchemaModelSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorImageBrowserSchemaModelSettingsBuilder
  {
    public EditorImageBrowserSchemaModelSettingsBuilder(
      EditorImageBrowserSchemaModelSettings container)
    {
      this.Container = container;
    }

    protected EditorImageBrowserSchemaModelSettings Container { get; private set; }

    public EditorImageBrowserSchemaModelSettingsBuilder Id(
      string value)
    {
      this.Container.Id = value;
      return this;
    }

    public EditorImageBrowserSchemaModelSettingsBuilder Fields(
      Action<EditorImageBrowserSchemaModelFieldsSettingsBuilder> configurator)
    {
      this.Container.Fields.Editor = this.Container.Editor;
      configurator(new EditorImageBrowserSchemaModelFieldsSettingsBuilder(this.Container.Fields));
      return this;
    }
  }
}
