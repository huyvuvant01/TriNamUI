// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeDefaultsSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeDefaultsSettingsBuilder(
      DiagramShapeDefaultsSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramShapeDefaultsSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Connectors(
      Action<DiagramShapeDefaultsSettingsConnectorFactory<TShapeModel, TConnectionModel>> configurator)
    {
      configurator(new DiagramShapeDefaultsSettingsConnectorFactory<TShapeModel, TConnectionModel>(this.Container.Connectors)
      {
        Diagram = this.Container.Diagram
      });
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> ConnectorDefaults(
      Action<DiagramShapeDefaultsConnectorDefaultsSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.ConnectorDefaults.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsConnectorDefaultsSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.ConnectorDefaults));
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Content(
      Action<DiagramShapeDefaultsContentSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Content.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsContentSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Content));
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Editable(
      Action<DiagramShapeDefaultsEditableSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Editable.Enabled = new bool?(true);
      this.Container.Editable.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsEditableSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Editable));
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Editable(
      bool enabled)
    {
      this.Container.Editable.Enabled = new bool?(enabled);
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Fill(
      Action<DiagramShapeDefaultsFillSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Fill.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsFillSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Fill));
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Height(
      double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Hover(
      Action<DiagramShapeDefaultsHoverSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Hover.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsHoverSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Hover));
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> MinHeight(
      double value)
    {
      this.Container.MinHeight = new double?(value);
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> MinWidth(
      double value)
    {
      this.Container.MinWidth = new double?(value);
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Path(
      string value)
    {
      this.Container.Path = value;
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Rotation(
      Action<DiagramShapeDefaultsRotationSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Rotation.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsRotationSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Rotation));
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Selectable(
      bool value)
    {
      this.Container.Selectable = new bool?(value);
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Source(
      string value)
    {
      this.Container.Source = value;
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Stroke(
      Action<DiagramShapeDefaultsStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Stroke.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsStrokeSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Stroke));
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Type(
      string value)
    {
      this.Container.Type = value;
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> X(
      double value)
    {
      this.Container.X = new double?(value);
      return this;
    }

    public DiagramShapeDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Y(
      double value)
    {
      this.Container.Y = new double?(value);
      return this;
    }
  }
}
