// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramSelectableSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramSelectableSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramSelectableSettingsBuilder(
      DiagramSelectableSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramSelectableSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramSelectableSettingsBuilder<TShapeModel, TConnectionModel> Multiple(
      bool value)
    {
      this.Container.Multiple = new bool?(value);
      return this;
    }

    public DiagramSelectableSettingsBuilder<TShapeModel, TConnectionModel> Stroke(
      Action<DiagramSelectableStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Stroke.Diagram = this.Container.Diagram;
      configurator(new DiagramSelectableStrokeSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Stroke));
      return this;
    }

    public DiagramSelectableSettingsBuilder<TShapeModel, TConnectionModel> Key(
      DiagramSelectableKey value)
    {
      this.Container.Key = new DiagramSelectableKey?(value);
      return this;
    }
  }
}
