// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeDefaultsFillSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeDefaultsFillSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeDefaultsFillSettingsBuilder(
      DiagramShapeDefaultsFillSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramShapeDefaultsFillSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramShapeDefaultsFillSettingsBuilder<TShapeModel, TConnectionModel> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public DiagramShapeDefaultsFillSettingsBuilder<TShapeModel, TConnectionModel> Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public DiagramShapeDefaultsFillSettingsBuilder<TShapeModel, TConnectionModel> Gradient(
      Action<DiagramShapeDefaultsFillGradientSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Gradient.Diagram = this.Container.Diagram;
      configurator(new DiagramShapeDefaultsFillGradientSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Gradient));
      return this;
    }
  }
}
