// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ListBoxToolFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ListBoxToolFactory
  {
    protected IList<string> Container { get; private set; }

    public ListBoxToolFactory(IList<string> container) => this.Container = container;

    public virtual ListBoxToolFactory MoveUp()
    {
      this.Container.Add("moveUp");
      return this;
    }

    public virtual ListBoxToolFactory MoveDown()
    {
      this.Container.Add("moveDown");
      return this;
    }

    public virtual ListBoxToolFactory Remove()
    {
      this.Container.Add("remove");
      return this;
    }

    public virtual ListBoxToolFactory TransferAllFrom()
    {
      this.Container.Add("transferAllFrom");
      return this;
    }

    public virtual ListBoxToolFactory TransferAllTo()
    {
      this.Container.Add("transferAllTo");
      return this;
    }

    public virtual ListBoxToolFactory TransferFrom()
    {
      this.Container.Add("transferFrom");
      return this;
    }

    public virtual ListBoxToolFactory TransferTo()
    {
      this.Container.Add("transferTo");
      return this;
    }
  }
}
