﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramConnectionToSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramConnectionToSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramConnectionToSettingsBuilder(
      DiagramConnectionToSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramConnectionToSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramConnectionToSettingsBuilder<TShapeModel, TConnectionModel> X(
      double value)
    {
      this.Container.X = new double?(value);
      return this;
    }

    public DiagramConnectionToSettingsBuilder<TShapeModel, TConnectionModel> Y(
      double value)
    {
      this.Container.Y = new double?(value);
      return this;
    }
  }
}
