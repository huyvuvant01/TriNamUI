// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerToolbarSettingsItemFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerToolbarSettingsItemFactory
  {
    public FileManagerToolbarSettingsItemFactory(List<FileManagerToolbarSettingsItem> container) => this.Container = container;

    protected List<FileManagerToolbarSettingsItem> Container { get; private set; }

    public virtual FileManagerToolbarSettingsItemBuilder Add(
      string name)
    {
      FileManagerToolbarSettingsItem container = new FileManagerToolbarSettingsItem()
      {
        Name = name
      };
      container.FileManager = this.FileManager;
      this.Container.Add(container);
      return new FileManagerToolbarSettingsItemBuilder(container);
    }

    public FileManager FileManager { get; set; }

    public virtual FileManagerToolbarSettingsItemBuilder Add()
    {
      FileManagerToolbarSettingsItem container = new FileManagerToolbarSettingsItem();
      container.FileManager = this.FileManager;
      this.Container.Add(container);
      return new FileManagerToolbarSettingsItemBuilder(container);
    }
  }
}
