// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorSerializationSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorSerializationSettingsBuilder
  {
    public EditorSerializationSettingsBuilder(EditorSerializationSettings container) => this.Container = container;

    protected EditorSerializationSettings Container { get; private set; }

    public EditorSerializationSettingsBuilder Custom(
      string handler)
    {
      this.Container.Custom = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public EditorSerializationSettingsBuilder Custom(
      Func<object, object> handler)
    {
      this.Container.Custom = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public EditorSerializationSettingsBuilder Entities(bool value)
    {
      this.Container.Entities = new bool?(value);
      return this;
    }

    public EditorSerializationSettingsBuilder Scripts(bool value)
    {
      this.Container.Scripts = new bool?(value);
      return this;
    }

    public EditorSerializationSettingsBuilder Scripts()
    {
      this.Container.Scripts = new bool?(true);
      return this;
    }

    public EditorSerializationSettingsBuilder Semantic(bool value)
    {
      this.Container.Semantic = new bool?(value);
      return this;
    }
  }
}
