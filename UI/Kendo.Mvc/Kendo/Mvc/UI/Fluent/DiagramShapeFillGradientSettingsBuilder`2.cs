// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeFillGradientSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeFillGradientSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeFillGradientSettingsBuilder(
      DiagramShapeFillGradientSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramShapeFillGradientSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramShapeFillGradientSettingsBuilder<TShapeModel, TConnectionModel> Type(
      string value)
    {
      this.Container.Type = value;
      return this;
    }

    public DiagramShapeFillGradientSettingsBuilder<TShapeModel, TConnectionModel> Radius(
      double value)
    {
      this.Container.Radius = new double?(value);
      return this;
    }

    public DiagramShapeFillGradientSettingsBuilder<TShapeModel, TConnectionModel> Stops(
      Action<DiagramShapeFillGradientSettingsStopFactory<TShapeModel, TConnectionModel>> configurator)
    {
      configurator(new DiagramShapeFillGradientSettingsStopFactory<TShapeModel, TConnectionModel>(this.Container.Stops)
      {
        Diagram = this.Container.Diagram
      });
      return this;
    }
  }
}
