// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerMessagesDialogsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerMessagesDialogsSettingsBuilder
  {
    public FileManagerMessagesDialogsSettingsBuilder(FileManagerMessagesDialogsSettings container) => this.Container = container;

    protected FileManagerMessagesDialogsSettings Container { get; private set; }

    public FileManagerMessagesDialogsSettingsBuilder Upload(
      Action<FileManagerMessagesDialogsUploadSettingsBuilder> configurator)
    {
      this.Container.Upload.FileManager = this.Container.FileManager;
      configurator(new FileManagerMessagesDialogsUploadSettingsBuilder(this.Container.Upload));
      return this;
    }

    public FileManagerMessagesDialogsSettingsBuilder MoveConfirm(
      Action<FileManagerMessagesDialogsMoveConfirmSettingsBuilder> configurator)
    {
      this.Container.MoveConfirm.FileManager = this.Container.FileManager;
      configurator(new FileManagerMessagesDialogsMoveConfirmSettingsBuilder(this.Container.MoveConfirm));
      return this;
    }

    public FileManagerMessagesDialogsSettingsBuilder DeleteConfirm(
      Action<FileManagerMessagesDialogsDeleteConfirmSettingsBuilder> configurator)
    {
      this.Container.DeleteConfirm.FileManager = this.Container.FileManager;
      configurator(new FileManagerMessagesDialogsDeleteConfirmSettingsBuilder(this.Container.DeleteConfirm));
      return this;
    }

    public FileManagerMessagesDialogsSettingsBuilder RenamePrompt(
      Action<FileManagerMessagesDialogsRenamePromptSettingsBuilder> configurator)
    {
      this.Container.RenamePrompt.FileManager = this.Container.FileManager;
      configurator(new FileManagerMessagesDialogsRenamePromptSettingsBuilder(this.Container.RenamePrompt));
      return this;
    }
  }
}
