// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ListBoxToolbarSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ListBoxToolbarSettingsBuilder
  {
    public ListBoxToolbarSettingsBuilder(ListBoxToolbarSettings container) => this.Container = container;

    protected ListBoxToolbarSettings Container { get; private set; }

    public ListBoxToolbarSettingsBuilder Tools(
      Action<ListBoxToolFactory> configurator)
    {
      configurator(new ListBoxToolFactory((IList<string>) this.Container.Tools));
      return this;
    }

    public ListBoxToolbarSettingsBuilder Position(
      ListBoxToolbarPosition value)
    {
      this.Container.Position = new ListBoxToolbarPosition?(value);
      return this;
    }
  }
}
