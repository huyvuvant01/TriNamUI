// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerMessagesSettingsBuilder
  {
    public FileManagerMessagesSettingsBuilder(FileManagerMessagesSettings container) => this.Container = container;

    protected FileManagerMessagesSettings Container { get; private set; }

    public FileManagerMessagesSettingsBuilder Toolbar(
      Action<FileManagerMessagesToolbarSettingsBuilder> configurator)
    {
      this.Container.Toolbar.FileManager = this.Container.FileManager;
      configurator(new FileManagerMessagesToolbarSettingsBuilder(this.Container.Toolbar));
      return this;
    }

    public FileManagerMessagesSettingsBuilder Views(
      Action<FileManagerMessagesViewsSettingsBuilder> configurator)
    {
      this.Container.Views.FileManager = this.Container.FileManager;
      configurator(new FileManagerMessagesViewsSettingsBuilder(this.Container.Views));
      return this;
    }

    public FileManagerMessagesSettingsBuilder Dialogs(
      Action<FileManagerMessagesDialogsSettingsBuilder> configurator)
    {
      this.Container.Dialogs.FileManager = this.Container.FileManager;
      configurator(new FileManagerMessagesDialogsSettingsBuilder(this.Container.Dialogs));
      return this;
    }

    public FileManagerMessagesSettingsBuilder PreviewPane(
      Action<FileManagerMessagesPreviewPaneSettingsBuilder> configurator)
    {
      this.Container.PreviewPane.FileManager = this.Container.FileManager;
      configurator(new FileManagerMessagesPreviewPaneSettingsBuilder(this.Container.PreviewPane));
      return this;
    }
  }
}
