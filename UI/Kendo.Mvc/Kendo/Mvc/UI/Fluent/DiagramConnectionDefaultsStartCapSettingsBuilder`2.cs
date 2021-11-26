// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramConnectionDefaultsStartCapSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramConnectionDefaultsStartCapSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramConnectionDefaultsStartCapSettingsBuilder(
      DiagramConnectionDefaultsStartCapSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramConnectionDefaultsStartCapSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramConnectionDefaultsStartCapSettingsBuilder<TShapeModel, TConnectionModel> Fill(
      Action<DiagramConnectionDefaultsStartCapFillSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Fill.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionDefaultsStartCapFillSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Fill));
      return this;
    }

    public DiagramConnectionDefaultsStartCapSettingsBuilder<TShapeModel, TConnectionModel> Stroke(
      Action<DiagramConnectionDefaultsStartCapStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Stroke.Diagram = this.Container.Diagram;
      configurator(new DiagramConnectionDefaultsStartCapStrokeSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Stroke));
      return this;
    }

    public DiagramConnectionDefaultsStartCapSettingsBuilder<TShapeModel, TConnectionModel> Type(
      string value)
    {
      this.Container.Type = value;
      return this;
    }
  }
}
