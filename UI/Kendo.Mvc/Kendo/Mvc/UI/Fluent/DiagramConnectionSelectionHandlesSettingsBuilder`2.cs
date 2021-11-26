// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramConnectionSelectionHandlesSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramConnectionSelectionHandlesSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramConnectionSelectionHandlesSettingsBuilder(
      DiagramConnectionSelectionHandlesSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramConnectionSelectionHandlesSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramConnectionSelectionHandlesSettingsBuilder<TShapeModel, TConnectionModel> Fill(
      Action<DiagramConnectionSelectionHandlesFillSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Fill.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionSelectionHandlesFillSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Fill));
      return this;
    }

    public DiagramConnectionSelectionHandlesSettingsBuilder<TShapeModel, TConnectionModel> Stroke(
      Action<DiagramConnectionSelectionHandlesStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Stroke.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionSelectionHandlesStrokeSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Stroke));
      return this;
    }

    public DiagramConnectionSelectionHandlesSettingsBuilder<TShapeModel, TConnectionModel> Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public DiagramConnectionSelectionHandlesSettingsBuilder<TShapeModel, TConnectionModel> Height(
      double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }
  }
}
