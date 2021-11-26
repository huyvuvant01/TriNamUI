// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramConnectionPointFactory`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramConnectionPointFactory<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramConnectionPointFactory(
      List<DiagramConnectionPoint<TShapeModel, TConnectionModel>> container)
    {
      this.Container = container;
    }

    protected List<DiagramConnectionPoint<TShapeModel, TConnectionModel>> Container { get; private set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    public virtual DiagramConnectionPointBuilder<TShapeModel, TConnectionModel> Add()
    {
      DiagramConnectionPoint<TShapeModel, TConnectionModel> container = new DiagramConnectionPoint<TShapeModel, TConnectionModel>();
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramConnectionPointBuilder<TShapeModel, TConnectionModel>(container);
    }
  }
}
