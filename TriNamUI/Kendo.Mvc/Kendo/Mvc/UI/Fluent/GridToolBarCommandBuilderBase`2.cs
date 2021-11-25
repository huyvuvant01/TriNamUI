// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridToolBarCommandBuilderBase`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class GridToolBarCommandBuilderBase<TCommand, TBuilder> : IHideObjectMembers
    where TCommand : GridActionCommandBase
    where TBuilder : GridToolBarCommandBuilderBase<TCommand, TBuilder>
  {
    protected GridToolBarCommandBuilderBase(TCommand command) => this.Command = command;

    public TBuilder Text(string text)
    {
      this.Command.Text = text;
      return this as TBuilder;
    }

    public TBuilder IconClass(string iconClass)
    {
      this.Command.IconClass = iconClass;
      return this as TBuilder;
    }

    public TBuilder HtmlAttributes(object attributes) => this.HtmlAttributes(attributes.ToDictionary());

    public TBuilder HtmlAttributes(IDictionary<string, object> attributes)
    {
      DictionaryExtensions.Merge(this.Command.HtmlAttributes, attributes);
      return this as TBuilder;
    }

    protected TCommand Command { get; private set; }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
