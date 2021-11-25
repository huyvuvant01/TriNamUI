// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramLayoutSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramLayoutSettingsBuilder(
      DiagramLayoutSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramLayoutSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> EndRadialAngle(
      double value)
    {
      this.Container.EndRadialAngle = new double?(value);
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> Grid(
      Action<DiagramLayoutGridSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Grid.Diagram = this.Container.Diagram;
      configurator(new DiagramLayoutGridSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Grid));
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> HorizontalSeparation(
      double value)
    {
      this.Container.HorizontalSeparation = new double?(value);
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> Iterations(
      double value)
    {
      this.Container.Iterations = new double?(value);
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> LayerSeparation(
      double value)
    {
      this.Container.LayerSeparation = new double?(value);
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> NodeDistance(
      double value)
    {
      this.Container.NodeDistance = new double?(value);
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> RadialFirstLevelSeparation(
      double value)
    {
      this.Container.RadialFirstLevelSeparation = new double?(value);
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> RadialSeparation(
      double value)
    {
      this.Container.RadialSeparation = new double?(value);
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> StartRadialAngle(
      double value)
    {
      this.Container.StartRadialAngle = new double?(value);
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> TipOverTreeStartLevel(
      double value)
    {
      this.Container.TipOverTreeStartLevel = new double?(value);
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> UnderneathHorizontalOffset(
      double value)
    {
      this.Container.UnderneathHorizontalOffset = new double?(value);
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> UnderneathVerticalSeparation(
      double value)
    {
      this.Container.UnderneathVerticalSeparation = new double?(value);
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> UnderneathVerticalTopOffset(
      double value)
    {
      this.Container.UnderneathVerticalTopOffset = new double?(value);
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> VerticalSeparation(
      double value)
    {
      this.Container.VerticalSeparation = new double?(value);
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> Type(
      DiagramLayoutType value)
    {
      this.Container.Type = new DiagramLayoutType?(value);
      return this;
    }

    public DiagramLayoutSettingsBuilder<TShapeModel, TConnectionModel> Subtype(
      DiagramLayoutSubtype value)
    {
      this.Container.Subtype = new DiagramLayoutSubtype?(value);
      return this;
    }
  }
}
