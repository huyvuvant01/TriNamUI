// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeDefaultsEditableSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeDefaultsEditableSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeDefaultsEditableSettingsBuilder(
      DiagramShapeDefaultsEditableSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramShapeDefaultsEditableSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramShapeDefaultsEditableSettingsBuilder<TShapeModel, TConnectionModel> Connect(
      bool value)
    {
      this.Container.Connect = new bool?(value);
      return this;
    }

    public DiagramShapeDefaultsEditableSettingsBuilder<TShapeModel, TConnectionModel> Drag(
      bool value)
    {
      this.Container.Drag = new bool?(value);
      return this;
    }

    public DiagramShapeDefaultsEditableSettingsBuilder<TShapeModel, TConnectionModel> Remove(
      bool value)
    {
      this.Container.Remove = new bool?(value);
      return this;
    }

    public DiagramShapeDefaultsEditableSettingsBuilder<TShapeModel, TConnectionModel> Tools(
      Action<DiagramShapeDefaultsEditableSettingsToolFactory<TShapeModel, TConnectionModel>> configurator)
    {
      configurator(new DiagramShapeDefaultsEditableSettingsToolFactory<TShapeModel, TConnectionModel>(this.Container.Tools)
      {
        Diagram = this.Container.Diagram
      });
      return this;
    }
  }
}
