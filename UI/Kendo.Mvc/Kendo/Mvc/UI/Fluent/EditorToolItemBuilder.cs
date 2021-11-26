// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorToolItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorToolItemBuilder
  {
    public EditorToolItemBuilder(EditorToolItem container) => this.Container = container;

    protected EditorToolItem Container { get; private set; }

    public EditorToolItemBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public EditorToolItemBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public EditorToolItemBuilder Context(string value)
    {
      this.Container.Context = value;
      return this;
    }
  }
}
