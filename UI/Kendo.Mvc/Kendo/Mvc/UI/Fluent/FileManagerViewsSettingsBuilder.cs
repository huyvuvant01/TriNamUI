// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerViewsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerViewsSettingsBuilder
  {
    public FileManagerViewsSettingsBuilder(FileManagerViewsSettings container) => this.Container = container;

    protected FileManagerViewsSettings Container { get; private set; }

    public FileManagerViewsSettingsBuilder Grid(
      Action<FileManagerViewsGridSettingsBuilder> configurator)
    {
      this.Container.Grid.FileManager = this.Container.FileManager;
      configurator(new FileManagerViewsGridSettingsBuilder(this.Container.Grid));
      return this;
    }

    public FileManagerViewsSettingsBuilder Tree(
      Action<FileManagerViewsTreeSettingsBuilder> configurator)
    {
      this.Container.Tree.FileManager = this.Container.FileManager;
      configurator(new FileManagerViewsTreeSettingsBuilder(this.Container.Tree));
      return this;
    }

    public FileManagerViewsSettingsBuilder List(
      Action<FileManagerViewsListSettingsBuilder> configurator)
    {
      this.Container.List.FileManager = this.Container.FileManager;
      configurator(new FileManagerViewsListSettingsBuilder(this.Container.List));
      return this;
    }
  }
}
