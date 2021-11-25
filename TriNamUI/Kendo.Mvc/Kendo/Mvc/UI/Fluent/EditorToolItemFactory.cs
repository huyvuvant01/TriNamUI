// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorToolItemFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorToolItemFactory
  {
    public EditorToolItemFactory(List<EditorToolItem> container) => this.Container = container;

    protected List<EditorToolItem> Container { get; private set; }

    public EditorToolItemFactory Add(string text, string value)
    {
      this.Container.Add(new EditorToolItem()
      {
        Text = text,
        Value = value
      });
      return this;
    }

    public Editor Editor { get; set; }

    public virtual EditorToolItemBuilder Add()
    {
      EditorToolItem container = new EditorToolItem();
      container.Editor = this.Editor;
      this.Container.Add(container);
      return new EditorToolItemBuilder(container);
    }
  }
}
