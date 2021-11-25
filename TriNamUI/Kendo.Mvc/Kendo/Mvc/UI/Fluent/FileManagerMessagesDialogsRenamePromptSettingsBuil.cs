// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerMessagesDialogsRenamePromptSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerMessagesDialogsRenamePromptSettingsBuilder
  {
    public FileManagerMessagesDialogsRenamePromptSettingsBuilder(
      FileManagerMessagesDialogsRenamePromptSettings container)
    {
      this.Container = container;
    }

    protected FileManagerMessagesDialogsRenamePromptSettings Container { get; private set; }

    public FileManagerMessagesDialogsRenamePromptSettingsBuilder Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }

    public FileManagerMessagesDialogsRenamePromptSettingsBuilder Content(
      string value)
    {
      this.Container.Content = value;
      return this;
    }

    public FileManagerMessagesDialogsRenamePromptSettingsBuilder OkText(
      string value)
    {
      this.Container.OkText = value;
      return this;
    }

    public FileManagerMessagesDialogsRenamePromptSettingsBuilder Cancel(
      string value)
    {
      this.Container.Cancel = value;
      return this;
    }

    public FileManagerMessagesDialogsRenamePromptSettingsBuilder Close(
      string value)
    {
      this.Container.Close = value;
      return this;
    }
  }
}
