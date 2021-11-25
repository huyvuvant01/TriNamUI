// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorImmutablesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorImmutablesSettingsBuilder
  {
    public EditorImmutablesSettingsBuilder(EditorImmutablesSettings container) => this.Container = container;

    protected EditorImmutablesSettings Container { get; private set; }

    public EditorImmutablesSettingsBuilder Deserialization(
      string handler)
    {
      this.Container.Deserialization = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public EditorImmutablesSettingsBuilder Deserialization(
      Func<object, object> handler)
    {
      this.Container.Deserialization = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public EditorImmutablesSettingsBuilder Serialization(string value)
    {
      this.Container.SerializationHandler = (ClientHandlerDescriptor) null;
      this.Container.Serialization = value;
      return this;
    }

    public EditorImmutablesSettingsBuilder SerializationHandler(
      string handler)
    {
      this.Container.Serialization = (string) null;
      this.Container.SerializationHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public EditorImmutablesSettingsBuilder SerializationHandler(
      Func<object, object> handler)
    {
      this.Container.Serialization = (string) null;
      this.Container.SerializationHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
