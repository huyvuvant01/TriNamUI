// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramConnectionFromSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramConnectionFromSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramConnectionFromSettingsBuilder(
      DiagramConnectionFromSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramConnectionFromSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramConnectionFromSettingsBuilder<TShapeModel, TConnectionModel> X(
      double value)
    {
      this.Container.X = new double?(value);
      return this;
    }

    public DiagramConnectionFromSettingsBuilder<TShapeModel, TConnectionModel> Y(
      double value)
    {
      this.Container.Y = new double?(value);
      return this;
    }
  }
}
