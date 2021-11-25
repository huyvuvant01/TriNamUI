// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListSearchSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListSearchSettingsBuilder<T> where T : class
  {
    public TreeListSearchSettingsBuilder(TreeListSearchSettings<T> container) => this.Container = container;

    protected TreeListSearchSettings<T> Container { get; private set; }

    public TreeListSearchSettingsBuilder<T> Field<TValue>(
      Expression<Func<T, TValue>> expression)
    {
      this.Container.Fields.Add(expression.MemberWithoutInstance());
      return this;
    }

    public TreeListSearchSettingsBuilder<T> Field(string memberName)
    {
      this.Container.Fields.Add(memberName);
      return this;
    }
  }
}
