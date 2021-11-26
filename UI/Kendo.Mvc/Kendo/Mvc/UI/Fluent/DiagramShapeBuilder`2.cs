// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeBuilder(
      DiagramShape<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramShape<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Connectors(
      Action<DiagramShapeConnectorFactory<TShapeModel, TConnectionModel>> configurator)
    {
      configurator(new DiagramShapeConnectorFactory<TShapeModel, TConnectionModel>(this.Container.Connectors)
      {
        Diagram = this.Container.Diagram
      });
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> ConnectorDefaults(
      Action<DiagramShapeConnectorDefaultsSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.ConnectorDefaults.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeConnectorDefaultsSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.ConnectorDefaults));
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Content(
      Action<DiagramShapeContentSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Content.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeContentSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Content));
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Editable(
      Action<DiagramShapeEditableSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Editable.Enabled = new bool?(true);
      this.Container.Editable.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeEditableSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Editable));
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Editable(
      bool enabled)
    {
      this.Container.Editable.Enabled = new bool?(enabled);
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Fill(
      Action<DiagramShapeFillSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Fill.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeFillSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Fill));
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Hover(
      Action<DiagramShapeHoverSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Hover.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeHoverSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Hover));
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Id(string value)
    {
      this.Container.Id = value;
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> MinHeight(
      double value)
    {
      this.Container.MinHeight = new double?(value);
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> MinWidth(
      double value)
    {
      this.Container.MinWidth = new double?(value);
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Path(string value)
    {
      this.Container.Path = value;
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Rotation(
      Action<DiagramShapeRotationSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Rotation.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeRotationSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Rotation));
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Source(string value)
    {
      this.Container.Source = value;
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Stroke(
      Action<DiagramShapeStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Stroke.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeStrokeSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Stroke));
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Type(string value)
    {
      this.Container.Type = value;
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> X(double value)
    {
      this.Container.X = new double?(value);
      return this;
    }

    public DiagramShapeBuilder<TShapeModel, TConnectionModel> Y(double value)
    {
      this.Container.Y = new double?(value);
      return this;
    }
  }
}
