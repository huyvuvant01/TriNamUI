// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramConnectionBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramConnectionBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramConnectionBuilder(
      DiagramConnection<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramConnection<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramConnectionBuilder<TShapeModel, TConnectionModel> Content(
      Action<DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Content.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Content));
      return this;
    }

    public DiagramConnectionBuilder<TShapeModel, TConnectionModel> Editable(
      Action<DiagramConnectionEditableSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Editable.Enabled = new bool?(true);
      this.Container.Editable.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionEditableSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Editable));
      return this;
    }

    public DiagramConnectionBuilder<TShapeModel, TConnectionModel> Editable(
      bool enabled)
    {
      this.Container.Editable.Enabled = new bool?(enabled);
      return this;
    }

    public DiagramConnectionBuilder<TShapeModel, TConnectionModel> EndCap(
      Action<DiagramConnectionEndCapSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.EndCap.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionEndCapSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.EndCap));
      return this;
    }

    public DiagramConnectionBuilder<TShapeModel, TConnectionModel> From(
      Action<DiagramConnectionFromSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.From.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionFromSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.From));
      return this;
    }

    public DiagramConnectionBuilder<TShapeModel, TConnectionModel> FromConnector(
      string value)
    {
      this.Container.FromConnector = value;
      return this;
    }

    public DiagramConnectionBuilder<TShapeModel, TConnectionModel> Hover(
      Action<DiagramConnectionHoverSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Hover.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionHoverSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Hover));
      return this;
    }

    public DiagramConnectionBuilder<TShapeModel, TConnectionModel> Points(
      Action<DiagramConnectionPointFactory<TShapeModel, TConnectionModel>> configurator)
    {
      configurator(new DiagramConnectionPointFactory<TShapeModel, TConnectionModel>(this.Container.Points)
      {
        Diagram = this.Container.Diagram
      });
      return this;
    }

    public DiagramConnectionBuilder<TShapeModel, TConnectionModel> Selection(
      Action<DiagramConnectionSelectionSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Selection.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionSelectionSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Selection));
      return this;
    }

    public DiagramConnectionBuilder<TShapeModel, TConnectionModel> StartCap(
      Action<DiagramConnectionStartCapSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.StartCap.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionStartCapSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.StartCap));
      return this;
    }

    public DiagramConnectionBuilder<TShapeModel, TConnectionModel> Stroke(
      Action<DiagramConnectionStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Stroke.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionStrokeSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Stroke));
      return this;
    }

    public DiagramConnectionBuilder<TShapeModel, TConnectionModel> To(
      Action<DiagramConnectionToSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.To.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionToSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.To));
      return this;
    }

    public DiagramConnectionBuilder<TShapeModel, TConnectionModel> ToConnector(
      string value)
    {
      this.Container.ToConnector = value;
      return this;
    }

    public DiagramConnectionBuilder<TShapeModel, TConnectionModel> Type(
      DiagramConnectionType value)
    {
      this.Container.Type = new DiagramConnectionType?(value);
      return this;
    }
  }
}
