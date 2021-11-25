// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListEditableMoveSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListEditableMoveSettingsBuilder<T> where T : class
  {
    public TreeListEditableMoveSettingsBuilder(TreeListEditableMoveSettings<T> container) => this.Container = container;

    protected TreeListEditableMoveSettings<T> Container { get; private set; }

    public TreeListEditableMoveSettingsBuilder<T> Reorderable(
      bool value)
    {
      this.Container.Reorderable = new bool?(value);
      return this;
    }

    public TreeListEditableMoveSettingsBuilder<T> Reorderable()
    {
      this.Container.Reorderable = new bool?(true);
      return this;
    }
  }
}
