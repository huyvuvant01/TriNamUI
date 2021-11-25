// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramConnectionEditableSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramConnectionEditableSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramConnectionEditableSettingsBuilder(
      DiagramConnectionEditableSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramConnectionEditableSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramConnectionEditableSettingsBuilder<TShapeModel, TConnectionModel> Tools(
      Action<DiagramConnectionEditableSettingsToolFactory<TShapeModel, TConnectionModel>> configurator)
    {
      configurator(new DiagramConnectionEditableSettingsToolFactory<TShapeModel, TConnectionModel>(this.Container.Tools)
      {
        Diagram = this.Container.Diagram
      });
      return this;
    }
  }
}
