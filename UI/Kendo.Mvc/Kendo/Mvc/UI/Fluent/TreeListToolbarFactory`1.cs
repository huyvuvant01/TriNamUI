// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListToolbarFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListToolbarFactory<T> where T : class
  {
    public TreeListToolbarFactory(List<TreeListToolbar<T>> container) => this.Container = container;

    protected List<TreeListToolbar<T>> Container { get; private set; }

    public virtual TreeListToolbarBuilder<T> Cancel()
    {
      TreeListToolbar<T> container = new TreeListToolbar<T>()
      {
        Name = "cancel"
      };
      container.TreeList = this.TreeList;
      this.Container.Add(container);
      return new TreeListToolbarBuilder<T>(container);
    }

    public virtual TreeListToolbarBuilder<T> Save()
    {
      TreeListToolbar<T> container = new TreeListToolbar<T>()
      {
        Name = "save"
      };
      container.TreeList = this.TreeList;
      this.Container.Add(container);
      return new TreeListToolbarBuilder<T>(container);
    }

    public virtual TreeListToolbarBuilder<T> Search()
    {
      TreeListToolbar<T> container = new TreeListToolbar<T>()
      {
        Name = "search"
      };
      container.TreeList = this.TreeList;
      this.Container.Add(container);
      return new TreeListToolbarBuilder<T>(container);
    }

    public Kendo.Mvc.UI.TreeList<T> TreeList { get; set; }

    public virtual TreeListToolbarBuilder<T> Custom()
    {
      TreeListToolbar<T> container = new TreeListToolbar<T>();
      container.TreeList = this.TreeList;
      this.Container.Add(container);
      return new TreeListToolbarBuilder<T>(container);
    }

    public virtual TreeListToolbarBuilder<T> Create()
    {
      TreeListToolbar<T> container = new TreeListToolbar<T>()
      {
        Name = "create"
      };
      container.TreeList = this.TreeList;
      this.Container.Add(container);
      return new TreeListToolbarBuilder<T>(container);
    }

    public virtual TreeListToolbarBuilder<T> Excel()
    {
      TreeListToolbar<T> container = new TreeListToolbar<T>()
      {
        Name = "excel"
      };
      container.TreeList = this.TreeList;
      this.Container.Add(container);
      return new TreeListToolbarBuilder<T>(container);
    }

    public virtual TreeListToolbarBuilder<T> Pdf()
    {
      TreeListToolbar<T> container = new TreeListToolbar<T>()
      {
        Name = "pdf"
      };
      container.TreeList = this.TreeList;
      this.Container.Add(container);
      return new TreeListToolbarBuilder<T>(container);
    }
  }
}
