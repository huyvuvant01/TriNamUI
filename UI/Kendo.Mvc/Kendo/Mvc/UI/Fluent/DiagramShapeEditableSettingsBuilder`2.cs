// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeEditableSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeEditableSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeEditableSettingsBuilder(
      DiagramShapeEditableSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramShapeEditableSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramShapeEditableSettingsBuilder<TShapeModel, TConnectionModel> Connect(
      bool value)
    {
      this.Container.Connect = new bool?(value);
      return this;
    }

    public DiagramShapeEditableSettingsBuilder<TShapeModel, TConnectionModel> Tools(
      Action<DiagramShapeEditableSettingsToolFactory<TShapeModel, TConnectionModel>> configurator)
    {
      configurator(new DiagramShapeEditableSettingsToolFactory<TShapeModel, TConnectionModel>(this.Container.Tools)
      {
        Diagram = this.Container.Diagram
      });
      return this;
    }
  }
}
