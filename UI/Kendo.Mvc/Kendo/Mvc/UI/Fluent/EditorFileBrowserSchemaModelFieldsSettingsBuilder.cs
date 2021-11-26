// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorFileBrowserSchemaModelFieldsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorFileBrowserSchemaModelFieldsSettingsBuilder
  {
    public EditorFileBrowserSchemaModelFieldsSettingsBuilder(
      EditorFileBrowserSchemaModelFieldsSettings container)
    {
      this.Container = container;
    }

    protected EditorFileBrowserSchemaModelFieldsSettings Container { get; private set; }

    public EditorFileBrowserSchemaModelFieldsSettingsBuilder Name(
      Action<EditorFileBrowserSchemaModelFieldsNameSettingsBuilder> configurator)
    {
      this.Container.Name.Editor = this.Container.Editor;
      configurator(new EditorFileBrowserSchemaModelFieldsNameSettingsBuilder(this.Container.Name));
      return this;
    }

    public EditorFileBrowserSchemaModelFieldsSettingsBuilder Type(
      Action<EditorFileBrowserSchemaModelFieldsTypeSettingsBuilder> configurator)
    {
      this.Container.Type.Editor = this.Container.Editor;
      configurator(new EditorFileBrowserSchemaModelFieldsTypeSettingsBuilder(this.Container.Type));
      return this;
    }

    public EditorFileBrowserSchemaModelFieldsSettingsBuilder Size(
      Action<EditorFileBrowserSchemaModelFieldsSizeSettingsBuilder> configurator)
    {
      this.Container.Size.Editor = this.Container.Editor;
      configurator(new EditorFileBrowserSchemaModelFieldsSizeSettingsBuilder(this.Container.Size));
      return this;
    }
  }
}
