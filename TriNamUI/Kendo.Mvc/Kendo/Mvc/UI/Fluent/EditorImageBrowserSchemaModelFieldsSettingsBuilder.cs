// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorImageBrowserSchemaModelFieldsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorImageBrowserSchemaModelFieldsSettingsBuilder
  {
    public EditorImageBrowserSchemaModelFieldsSettingsBuilder(
      EditorImageBrowserSchemaModelFieldsSettings container)
    {
      this.Container = container;
    }

    protected EditorImageBrowserSchemaModelFieldsSettings Container { get; private set; }

    public EditorImageBrowserSchemaModelFieldsSettingsBuilder Name(
      Action<EditorImageBrowserSchemaModelFieldsNameSettingsBuilder> configurator)
    {
      this.Container.Name.Editor = this.Container.Editor;
      configurator(new EditorImageBrowserSchemaModelFieldsNameSettingsBuilder(this.Container.Name));
      return this;
    }

    public EditorImageBrowserSchemaModelFieldsSettingsBuilder Type(
      Action<EditorImageBrowserSchemaModelFieldsTypeSettingsBuilder> configurator)
    {
      this.Container.Type.Editor = this.Container.Editor;
      configurator(new EditorImageBrowserSchemaModelFieldsTypeSettingsBuilder(this.Container.Type));
      return this;
    }

    public EditorImageBrowserSchemaModelFieldsSettingsBuilder Size(
      Action<EditorImageBrowserSchemaModelFieldsSizeSettingsBuilder> configurator)
    {
      this.Container.Size.Editor = this.Container.Editor;
      configurator(new EditorImageBrowserSchemaModelFieldsSizeSettingsBuilder(this.Container.Size));
      return this;
    }
  }
}
