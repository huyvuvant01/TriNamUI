// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramEditableSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramEditableSettingsBuilder(
      DiagramEditableSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramEditableSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel> ShapeTemplateName(
      string value)
    {
      this.Container.ShapeTemplateName = value;
      return this;
    }

    public DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel> ConnectionTemplate(
      string value)
    {
      this.Container.ConnectionTemplate = value;
      return this;
    }

    public DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel> ConnectionTemplateId(
      string templateId)
    {
      this.Container.ConnectionTemplateId = templateId;
      return this;
    }

    public DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel> Drag(
      Action<DiagramEditableDragSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Drag.Enabled = new bool?(true);
      this.Container.Drag.Diagram = this.Container.Diagram;
      configurator(new DiagramEditableDragSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Drag));
      return this;
    }

    public DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel> Drag(
      bool enabled)
    {
      this.Container.Drag.Enabled = new bool?(enabled);
      return this;
    }

    public DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel> Remove(
      bool value)
    {
      this.Container.Remove = new bool?(value);
      return this;
    }

    public DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel> Resize(
      Action<DiagramEditableResizeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Resize.Enabled = new bool?(true);
      this.Container.Resize.Diagram = this.Container.Diagram;
      configurator(new DiagramEditableResizeSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Resize));
      return this;
    }

    public DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel> Resize(
      bool enabled)
    {
      this.Container.Resize.Enabled = new bool?(enabled);
      return this;
    }

    public DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel> Rotate(
      Action<DiagramEditableRotateSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Rotate.Enabled = new bool?(true);
      this.Container.Rotate.Diagram = this.Container.Diagram;
      configurator(new DiagramEditableRotateSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Rotate));
      return this;
    }

    public DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel> Rotate(
      bool enabled)
    {
      this.Container.Rotate.Enabled = new bool?(enabled);
      return this;
    }

    public DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel> ShapeTemplate(
      string value)
    {
      this.Container.ShapeTemplate = value;
      return this;
    }

    public DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel> ShapeTemplateId(
      string templateId)
    {
      this.Container.ShapeTemplateId = templateId;
      return this;
    }

    public DiagramEditableSettingsBuilder<TShapeModel, TConnectionModel> Tools(
      Action<DiagramEditableSettingsToolFactory<TShapeModel, TConnectionModel>> configurator)
    {
      configurator(new DiagramEditableSettingsToolFactory<TShapeModel, TConnectionModel>(this.Container.Tools)
      {
        Diagram = this.Container.Diagram
      });
      return this;
    }
  }
}
