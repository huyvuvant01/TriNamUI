// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeFillSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeFillSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeFillSettingsBuilder(
      DiagramShapeFillSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    public DiagramShapeFillSettingsBuilder<TShapeModel, TConnectionModel> Center(
      params double[] value)
    {
      this.Container.Center = value;
      return this;
    }

    public DiagramShapeFillSettingsBuilder<TShapeModel, TConnectionModel> Start(
      params double[] value)
    {
      this.Container.Start = value;
      return this;
    }

    public DiagramShapeFillSettingsBuilder<TShapeModel, TConnectionModel> End(
      params double[] value)
    {
      this.Container.End = value;
      return this;
    }

    protected DiagramShapeFillSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramShapeFillSettingsBuilder<TShapeModel, TConnectionModel> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public DiagramShapeFillSettingsBuilder<TShapeModel, TConnectionModel> Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public DiagramShapeFillSettingsBuilder<TShapeModel, TConnectionModel> Gradient(
      Action<DiagramShapeFillGradientSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Gradient.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeFillGradientSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Gradient));
      return this;
    }
  }
}
