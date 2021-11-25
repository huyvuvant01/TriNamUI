// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerDialogsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerDialogsSettingsBuilder
  {
    public FileManagerDialogsSettingsBuilder(FileManagerDialogsSettings container) => this.Container = container;

    protected FileManagerDialogsSettings Container { get; private set; }

    public FileManagerDialogsSettingsBuilder Upload(
      Action<FileManagerDialogsUploadSettingsBuilder> configurator)
    {
      this.Container.Upload.FileManager = this.Container.FileManager;
      configurator(new FileManagerDialogsUploadSettingsBuilder(this.Container.Upload));
      return this;
    }

    public FileManagerDialogsSettingsBuilder MoveConfirm(
      Action<FileManagerDialogsMoveConfirmSettingsBuilder> configurator)
    {
      this.Container.MoveConfirm.FileManager = this.Container.FileManager;
      configurator(new FileManagerDialogsMoveConfirmSettingsBuilder(this.Container.MoveConfirm));
      return this;
    }

    public FileManagerDialogsSettingsBuilder DeleteConfirm(
      Action<FileManagerDialogsDeleteConfirmSettingsBuilder> configurator)
    {
      this.Container.DeleteConfirm.FileManager = this.Container.FileManager;
      configurator(new FileManagerDialogsDeleteConfirmSettingsBuilder(this.Container.DeleteConfirm));
      return this;
    }

    public FileManagerDialogsSettingsBuilder RenamePrompt(
      Action<FileManagerDialogsRenamePromptSettingsBuilder> configurator)
    {
      this.Container.RenamePrompt.FileManager = this.Container.FileManager;
      configurator(new FileManagerDialogsRenamePromptSettingsBuilder(this.Container.RenamePrompt));
      return this;
    }
  }
}
