// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramEditableSettingsToolFactory`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramEditableSettingsToolFactory<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramEditableSettingsToolFactory(
      List<DiagramEditableSettingsTool<TShapeModel, TConnectionModel>> container)
    {
      this.Container = container;
    }

    protected List<DiagramEditableSettingsTool<TShapeModel, TConnectionModel>> Container { get; private set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    public virtual DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Custom()
    {
      DiagramEditableSettingsTool<TShapeModel, TConnectionModel> container = new DiagramEditableSettingsTool<TShapeModel, TConnectionModel>();
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Edit()
    {
      DiagramEditableSettingsTool<TShapeModel, TConnectionModel> container = new DiagramEditableSettingsTool<TShapeModel, TConnectionModel>()
      {
        Name = "edit"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> CreateShape()
    {
      DiagramEditableSettingsTool<TShapeModel, TConnectionModel> container = new DiagramEditableSettingsTool<TShapeModel, TConnectionModel>()
      {
        Name = "createShape"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> CreateConnection()
    {
      DiagramEditableSettingsTool<TShapeModel, TConnectionModel> container = new DiagramEditableSettingsTool<TShapeModel, TConnectionModel>()
      {
        Name = "createConnection"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Undo()
    {
      DiagramEditableSettingsTool<TShapeModel, TConnectionModel> container = new DiagramEditableSettingsTool<TShapeModel, TConnectionModel>()
      {
        Name = "undo"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Redo()
    {
      DiagramEditableSettingsTool<TShapeModel, TConnectionModel> container = new DiagramEditableSettingsTool<TShapeModel, TConnectionModel>()
      {
        Name = "redo"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> RotateClockwise()
    {
      DiagramEditableSettingsTool<TShapeModel, TConnectionModel> container = new DiagramEditableSettingsTool<TShapeModel, TConnectionModel>()
      {
        Name = "rotateClockwise"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel> RotateAnticlockwise()
    {
      DiagramEditableSettingsTool<TShapeModel, TConnectionModel> container = new DiagramEditableSettingsTool<TShapeModel, TConnectionModel>()
      {
        Name = "rotateAnticlockwise"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramEditableSettingsToolBuilder<TShapeModel, TConnectionModel>(container);
    }
  }
}
