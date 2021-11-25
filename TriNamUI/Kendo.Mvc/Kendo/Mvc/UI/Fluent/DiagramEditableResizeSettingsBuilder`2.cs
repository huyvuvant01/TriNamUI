// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramEditableResizeSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramEditableResizeSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramEditableResizeSettingsBuilder(
      DiagramEditableResizeSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramEditableResizeSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramEditableResizeSettingsBuilder<TShapeModel, TConnectionModel> Handles(
      Action<DiagramEditableResizeHandlesSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Handles.Diagram = this.Container.Diagram;
      configurator(new DiagramEditableResizeHandlesSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Handles));
      return this;
    }
  }
}
