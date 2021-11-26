// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeConnectorDefaultsHoverSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeConnectorDefaultsHoverSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeConnectorDefaultsHoverSettingsBuilder(
      DiagramShapeConnectorDefaultsHoverSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramShapeConnectorDefaultsHoverSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramShapeConnectorDefaultsHoverSettingsBuilder<TShapeModel, TConnectionModel> Fill(
      Action<DiagramShapeConnectorDefaultsHoverFillSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Fill.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeConnectorDefaultsHoverFillSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Fill));
      return this;
    }

    public DiagramShapeConnectorDefaultsHoverSettingsBuilder<TShapeModel, TConnectionModel> Stroke(
      Action<DiagramShapeConnectorDefaultsHoverStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Stroke.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeConnectorDefaultsHoverStrokeSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Stroke));
      return this;
    }
  }
}
