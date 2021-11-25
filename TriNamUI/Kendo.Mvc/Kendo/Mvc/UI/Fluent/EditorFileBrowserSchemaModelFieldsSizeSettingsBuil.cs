// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorFileBrowserSchemaModelFieldsSizeSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorFileBrowserSchemaModelFieldsSizeSettingsBuilder
  {
    public EditorFileBrowserSchemaModelFieldsSizeSettingsBuilder(
      EditorFileBrowserSchemaModelFieldsSizeSettings container)
    {
      this.Container = container;
    }

    protected EditorFileBrowserSchemaModelFieldsSizeSettings Container { get; private set; }

    public EditorFileBrowserSchemaModelFieldsSizeSettingsBuilder Field(
      string value)
    {
      this.Container.Field = value;
      return this;
    }

    public EditorFileBrowserSchemaModelFieldsSizeSettingsBuilder Parse(
      string handler)
    {
      this.Container.Parse = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public EditorFileBrowserSchemaModelFieldsSizeSettingsBuilder Parse(
      Func<object, object> handler)
    {
      this.Container.Parse = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
