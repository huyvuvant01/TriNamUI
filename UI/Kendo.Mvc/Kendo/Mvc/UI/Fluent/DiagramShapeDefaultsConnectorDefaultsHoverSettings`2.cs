// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeDefaultsConnectorDefaultsHoverSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeDefaultsConnectorDefaultsHoverSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeDefaultsConnectorDefaultsHoverSettingsBuilder(
      DiagramShapeDefaultsConnectorDefaultsHoverSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramShapeDefaultsConnectorDefaultsHoverSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramShapeDefaultsConnectorDefaultsHoverSettingsBuilder<TShapeModel, TConnectionModel> Fill(
      Action<DiagramShapeDefaultsConnectorDefaultsHoverFillSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Fill.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsConnectorDefaultsHoverFillSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Fill));
      return this;
    }

    public DiagramShapeDefaultsConnectorDefaultsHoverSettingsBuilder<TShapeModel, TConnectionModel> Stroke(
      Action<DiagramShapeDefaultsConnectorDefaultsHoverStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Stroke.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsConnectorDefaultsHoverStrokeSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Stroke));
      return this;
    }
  }
}
