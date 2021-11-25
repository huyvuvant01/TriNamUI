// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeDefaultsFillGradientSettingsStopFactory`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeDefaultsFillGradientSettingsStopFactory<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeDefaultsFillGradientSettingsStopFactory(
      List<DiagramShapeDefaultsFillGradientSettingsStop<TShapeModel, TConnectionModel>> container)
    {
      this.Container = container;
    }

    protected List<DiagramShapeDefaultsFillGradientSettingsStop<TShapeModel, TConnectionModel>> Container { get; private set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    public virtual DiagramShapeDefaultsFillGradientSettingsStopBuilder<TShapeModel, TConnectionModel> Add()
    {
      DiagramShapeDefaultsFillGradientSettingsStop<TShapeModel, TConnectionModel> container = new DiagramShapeDefaultsFillGradientSettingsStop<TShapeModel, TConnectionModel>();
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramShapeDefaultsFillGradientSettingsStopBuilder<TShapeModel, TConnectionModel>(container);
    }
  }
}
