// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListColumnCommandFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListColumnCommandFactory<T> where T : class
  {
    public TreeListColumnCommandFactory(List<TreeListColumnCommand<T>> container) => this.Container = container;

    protected List<TreeListColumnCommand<T>> Container { get; private set; }

    public Kendo.Mvc.UI.TreeList<T> TreeList { get; set; }

    public virtual TreeListColumnCommandBuilder<T> Custom()
    {
      TreeListColumnCommand<T> container = new TreeListColumnCommand<T>();
      container.TreeList = this.TreeList;
      this.Container.Add(container);
      return new TreeListColumnCommandBuilder<T>(container);
    }

    public virtual TreeListColumnCommandBuilder<T> Edit()
    {
      TreeListColumnCommand<T> container = new TreeListColumnCommand<T>()
      {
        Name = "edit"
      };
      container.TreeList = this.TreeList;
      this.Container.Add(container);
      return new TreeListColumnCommandBuilder<T>(container);
    }

    public virtual TreeListColumnCommandBuilder<T> CreateChild()
    {
      TreeListColumnCommand<T> container = new TreeListColumnCommand<T>()
      {
        Name = "createChild"
      };
      container.TreeList = this.TreeList;
      this.Container.Add(container);
      return new TreeListColumnCommandBuilder<T>(container);
    }

    public virtual TreeListColumnCommandBuilder<T> Destroy()
    {
      TreeListColumnCommand<T> container = new TreeListColumnCommand<T>()
      {
        Name = "destroy"
      };
      container.TreeList = this.TreeList;
      this.Container.Add(container);
      return new TreeListColumnCommandBuilder<T>(container);
    }
  }
}
