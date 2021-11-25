// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramConnectionDefaultsSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramConnectionDefaultsSettingsBuilder(
      DiagramConnectionDefaultsSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramConnectionDefaultsSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Content(
      Action<DiagramConnectionDefaultsContentSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Content.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionDefaultsContentSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Content));
      return this;
    }

    public DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Editable(
      Action<DiagramConnectionDefaultsEditableSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Editable.Enabled = new bool?(true);
      this.Container.Editable.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionDefaultsEditableSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Editable));
      return this;
    }

    public DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Editable(
      bool enabled)
    {
      this.Container.Editable.Enabled = new bool?(enabled);
      return this;
    }

    public DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel> EndCap(
      Action<DiagramConnectionDefaultsEndCapSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.EndCap.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionDefaultsEndCapSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.EndCap));
      return this;
    }

    public DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel> FromConnector(
      string value)
    {
      this.Container.FromConnector = value;
      return this;
    }

    public DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Hover(
      Action<DiagramConnectionDefaultsHoverSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Hover.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionDefaultsHoverSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Hover));
      return this;
    }

    public DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Selectable(
      bool value)
    {
      this.Container.Selectable = new bool?(value);
      return this;
    }

    public DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Selection(
      Action<DiagramConnectionDefaultsSelectionSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Selection.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionDefaultsSelectionSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Selection));
      return this;
    }

    public DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel> StartCap(
      Action<DiagramConnectionDefaultsStartCapSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.StartCap.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionDefaultsStartCapSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.StartCap));
      return this;
    }

    public DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Stroke(
      Action<DiagramConnectionDefaultsStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Stroke.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionDefaultsStrokeSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Stroke));
      return this;
    }

    public DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel> ToConnector(
      string value)
    {
      this.Container.ToConnector = value;
      return this;
    }

    public DiagramConnectionDefaultsSettingsBuilder<TShapeModel, TConnectionModel> Type(
      DiagramConnectionType value)
    {
      this.Container.Type = new DiagramConnectionType?(value);
      return this;
    }
  }
}
