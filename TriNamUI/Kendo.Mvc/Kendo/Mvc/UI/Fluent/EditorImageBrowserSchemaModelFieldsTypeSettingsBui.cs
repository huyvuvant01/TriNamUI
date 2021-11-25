﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorImageBrowserSchemaModelFieldsTypeSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorImageBrowserSchemaModelFieldsTypeSettingsBuilder
  {
    public EditorImageBrowserSchemaModelFieldsTypeSettingsBuilder(
      EditorImageBrowserSchemaModelFieldsTypeSettings container)
    {
      this.Container = container;
    }

    protected EditorImageBrowserSchemaModelFieldsTypeSettings Container { get; private set; }

    public EditorImageBrowserSchemaModelFieldsTypeSettingsBuilder Parse(
      string handler)
    {
      this.Container.Parse = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public EditorImageBrowserSchemaModelFieldsTypeSettingsBuilder Parse(
      Func<object, object> handler)
    {
      this.Container.Parse = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public EditorImageBrowserSchemaModelFieldsTypeSettingsBuilder Field(
      string value)
    {
      this.Container.Field = value;
      return this;
    }
  }
}
