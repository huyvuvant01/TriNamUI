// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListMessagesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListMessagesSettingsBuilder<T> where T : class
  {
    public TreeListMessagesSettingsBuilder(TreeListMessagesSettings<T> container) => this.Container = container;

    protected TreeListMessagesSettings<T> Container { get; private set; }

    public TreeListMessagesSettingsBuilder<T> Commands(
      Action<TreeListMessagesCommandsSettingsBuilder<T>> configurator)
    {
      this.Container.Commands.TreeList = this.Container.TreeList;
      configurator(new TreeListMessagesCommandsSettingsBuilder<T>(this.Container.Commands));
      return this;
    }

    public TreeListMessagesSettingsBuilder<T> Loading(string value)
    {
      this.Container.Loading = value;
      return this;
    }

    public TreeListMessagesSettingsBuilder<T> NoRows(string value)
    {
      this.Container.NoRows = value;
      return this;
    }

    public TreeListMessagesSettingsBuilder<T> RequestFailed(
      string value)
    {
      this.Container.RequestFailed = value;
      return this;
    }

    public TreeListMessagesSettingsBuilder<T> Retry(string value)
    {
      this.Container.Retry = value;
      return this;
    }
  }
}
