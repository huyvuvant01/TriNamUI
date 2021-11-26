// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeConnectorBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeConnectorBuilder(
      DiagramShapeConnector<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramShapeConnector<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Description(
      string value)
    {
      this.Container.Description = value;
      return this;
    }

    public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Name(
      string value)
    {
      this.Container.Name = value;
      return this;
    }

    public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Position(
      string handler)
    {
      this.Container.Position = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Position(
      Func<object, object> handler)
    {
      this.Container.Position = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Height(
      double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Hover(
      Action<DiagramShapeConnectorHoverSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Hover.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeConnectorHoverSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Hover));
      return this;
    }

    public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Fill(
      Action<DiagramShapeConnectorFillSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Fill.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeConnectorFillSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Fill));
      return this;
    }

    public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Stroke(
      Action<DiagramShapeConnectorStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Stroke.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeConnectorStrokeSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Stroke));
      return this;
    }
  }
}
