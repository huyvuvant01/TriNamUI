// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeDefaultsSettingsConnectorBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeDefaultsSettingsConnectorBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeDefaultsSettingsConnectorBuilder(
      DiagramShapeDefaultsSettingsConnector<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramShapeDefaultsSettingsConnector<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramShapeDefaultsSettingsConnectorBuilder<TShapeModel, TConnectionModel> Name(
      string value)
    {
      this.Container.Name = value;
      return this;
    }

    public DiagramShapeDefaultsSettingsConnectorBuilder<TShapeModel, TConnectionModel> Position(
      string handler)
    {
      this.Container.Position = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public DiagramShapeDefaultsSettingsConnectorBuilder<TShapeModel, TConnectionModel> Position(
      Func<object, object> handler)
    {
      this.Container.Position = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public DiagramShapeDefaultsSettingsConnectorBuilder<TShapeModel, TConnectionModel> Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public DiagramShapeDefaultsSettingsConnectorBuilder<TShapeModel, TConnectionModel> Height(
      double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public DiagramShapeDefaultsSettingsConnectorBuilder<TShapeModel, TConnectionModel> Hover(
      Action<DiagramShapeDefaultsConnectorHoverSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Hover.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsConnectorHoverSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Hover));
      return this;
    }

    public DiagramShapeDefaultsSettingsConnectorBuilder<TShapeModel, TConnectionModel> Fill(
      Action<DiagramShapeDefaultsConnectorFillSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Fill.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsConnectorFillSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Fill));
      return this;
    }

    public DiagramShapeDefaultsSettingsConnectorBuilder<TShapeModel, TConnectionModel> Stroke(
      Action<DiagramShapeDefaultsConnectorStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Stroke.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsConnectorStrokeSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Stroke));
      return this;
    }
  }
}
