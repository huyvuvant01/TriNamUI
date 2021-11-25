// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramConnectionDefaultsEditableSettingsToolFactory`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramConnectionDefaultsEditableSettingsToolFactory<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramConnectionDefaultsEditableSettingsToolFactory(
      List<DiagramConnectionDefaultsEditableSettingsTool<TShapeModel, TConnectionModel>> container)
    {
      this.Container = container;
    }

    protected List<DiagramConnectionDefaultsEditableSettingsTool<TShapeModel, TConnectionModel>> Container { get; private set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    public virtual DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Custom()
    {
      DiagramConnectionDefaultsEditableSettingsTool<TShapeModel, TConnectionModel> container = new DiagramConnectionDefaultsEditableSettingsTool<TShapeModel, TConnectionModel>();
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Edit()
    {
      DiagramConnectionDefaultsEditableSettingsTool<TShapeModel, TConnectionModel> container = new DiagramConnectionDefaultsEditableSettingsTool<TShapeModel, TConnectionModel>()
      {
        Name = "edit"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel, TConnectionModel>(container);
    }

    public virtual DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel, TConnectionModel> Delete()
    {
      DiagramConnectionDefaultsEditableSettingsTool<TShapeModel, TConnectionModel> container = new DiagramConnectionDefaultsEditableSettingsTool<TShapeModel, TConnectionModel>()
      {
        Name = "delete"
      };
      container.Diagram = this.Diagram;
      this.Container.Add(container);
      return new DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel, TConnectionModel>(container);
    }
  }
}
