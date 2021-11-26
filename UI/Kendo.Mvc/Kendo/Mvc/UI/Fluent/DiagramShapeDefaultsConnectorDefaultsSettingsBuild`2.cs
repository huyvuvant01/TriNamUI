// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeDefaultsConnectorDefaultsSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeDefaultsConnectorDefaultsSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeDefaultsConnectorDefaultsSettingsBuilder(
      DiagramShapeDefaultsConnectorDefaultsSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramShapeDefaultsConnectorDefaultsSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramShapeDefaultsConnectorDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public DiagramShapeDefaultsConnectorDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Height(
      double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public DiagramShapeDefaultsConnectorDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Hover(
      Action<DiagramShapeDefaultsConnectorDefaultsHoverSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Hover.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsConnectorDefaultsHoverSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Hover));
      return this;
    }

    public DiagramShapeDefaultsConnectorDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Fill(
      Action<DiagramShapeDefaultsConnectorDefaultsFillSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Fill.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsConnectorDefaultsFillSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Fill));
      return this;
    }

    public DiagramShapeDefaultsConnectorDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Stroke(
      Action<DiagramShapeDefaultsConnectorDefaultsStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Stroke.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsConnectorDefaultsStrokeSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Stroke));
      return this;
    }
  }
}
