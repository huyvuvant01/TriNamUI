// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListToolbarBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListToolbarBuilder<T> where T : class
  {
    public TreeListToolbarBuilder(TreeListToolbar<T> container) => this.Container = container;

    protected TreeListToolbar<T> Container { get; private set; }

    public TreeListToolbarBuilder<T> Click(string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public TreeListToolbarBuilder<T> Click(Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public TreeListToolbarBuilder<T> ImageClass(string value)
    {
      this.Container.ImageClass = value;
      return this;
    }

    public TreeListToolbarBuilder<T> Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public TreeListToolbarBuilder<T> Text(string value)
    {
      this.Container.Text = value;
      return this;
    }
  }
}
