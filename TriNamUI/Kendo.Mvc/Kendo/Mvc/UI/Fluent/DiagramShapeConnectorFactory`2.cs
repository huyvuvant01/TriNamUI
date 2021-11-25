// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramShapeConnectorFactory`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramShapeConnectorFactory<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramShapeConnectorFactory(
      List<DiagramShapeConnector<TShapeModel, TConnectionModel>> container)
    {
      this.Container = container;
    }

    protected List<DiagramShapeConnector<TShapeModel, TConnectionModel>> Container { get; private set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    public virtual DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Custom()
    {
      DiagramShapeConnector<TShapeModel, TConnectionModel> container = new DiagramShapeConnector<TShapeModel, TConnectionModel>();
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Top()
    {
      DiagramShapeConnector<TShapeModel, TConnectionModel> container = new DiagramShapeConnector<TShapeModel, TConnectionModel>()
      {
        Name = "top"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Right()
    {
      DiagramShapeConnector<TShapeModel, TConnectionModel> container = new DiagramShapeConnector<TShapeModel, TConnectionModel>()
      {
        Name = "right"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Bottom()
    {
      DiagramShapeConnector<TShapeModel, TConnectionModel> container = new DiagramShapeConnector<TShapeModel, TConnectionModel>()
      {
        Name = "bottom"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> BottomRight()
    {
      DiagramShapeConnector<TShapeModel, TConnectionModel> container = new DiagramShapeConnector<TShapeModel, TConnectionModel>()
      {
        Name = "bottomRight"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Left()
    {
      DiagramShapeConnector<TShapeModel, TConnectionModel> container = new DiagramShapeConnector<TShapeModel, TConnectionModel>()
      {
        Name = "left"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Auto()
    {
      DiagramShapeConnector<TShapeModel, TConnectionModel> container = new DiagramShapeConnector<TShapeModel, TConnectionModel>()
      {
        Name = "auto"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel>(container);
    }
  }
}
