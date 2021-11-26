// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramEditableResizeHandlesSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramEditableResizeHandlesSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramEditableResizeHandlesSettingsBuilder(
      DiagramEditableResizeHandlesSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramEditableResizeHandlesSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramEditableResizeHandlesSettingsBuilder<TShapeModel, TConnectionModel> Fill(
      Action<DiagramEditableResizeHandlesFillSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Fill.Diagram = this.Container.Diagram;
      configurator(new DiagramEditableResizeHandlesFillSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Fill));
      return this;
    }

    public DiagramEditableResizeHandlesSettingsBuilder<TShapeModel, TConnectionModel> Height(
      double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public DiagramEditableResizeHandlesSettingsBuilder<TShapeModel, TConnectionModel> Hover(
      Action<DiagramEditableResizeHandlesHoverSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Hover.Diagram = this.Container.Diagram;
      configurator(new DiagramEditableResizeHandlesHoverSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Hover));
      return this;
    }

    public DiagramEditableResizeHandlesSettingsBuilder<TShapeModel, TConnectionModel> Stroke(
      Action<DiagramEditableResizeHandlesStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Stroke.Diagram = this.Container.Diagram;
      configurator(new DiagramEditableResizeHandlesStrokeSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Stroke));
      return this;
    }

    public DiagramEditableResizeHandlesSettingsBuilder<TShapeModel, TConnectionModel> Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
