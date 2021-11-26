// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListColumnCommandBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListColumnCommandBuilder<T> where T : class
  {
    public TreeListColumnCommandBuilder(TreeListColumnCommand<T> container) => this.Container = container;

    protected TreeListColumnCommand<T> Container { get; private set; }

    public TreeListColumnCommandBuilder<T> ClassName(string value)
    {
      this.Container.ClassName = value;
      return this;
    }

    public TreeListColumnCommandBuilder<T> ImageClass(string value)
    {
      this.Container.ImageClass = value;
      return this;
    }

    public TreeListColumnCommandBuilder<T> Click(string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public TreeListColumnCommandBuilder<T> Click(
      Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public TreeListColumnCommandBuilder<T> Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public TreeListColumnCommandBuilder<T> Text(string value)
    {
      this.Container.Text = value;
      return this;
    }
  }
}
