// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerMessagesDialogsMoveConfirmSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerMessagesDialogsMoveConfirmSettingsBuilder
  {
    public FileManagerMessagesDialogsMoveConfirmSettingsBuilder(
      FileManagerMessagesDialogsMoveConfirmSettings container)
    {
      this.Container = container;
    }

    protected FileManagerMessagesDialogsMoveConfirmSettings Container { get; private set; }

    public FileManagerMessagesDialogsMoveConfirmSettingsBuilder Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }

    public FileManagerMessagesDialogsMoveConfirmSettingsBuilder Content(
      string value)
    {
      this.Container.Content = value;
      return this;
    }

    public FileManagerMessagesDialogsMoveConfirmSettingsBuilder OkText(
      string value)
    {
      this.Container.OkText = value;
      return this;
    }

    public FileManagerMessagesDialogsMoveConfirmSettingsBuilder Cancel(
      string value)
    {
      this.Container.Cancel = value;
      return this;
    }

    public FileManagerMessagesDialogsMoveConfirmSettingsBuilder Close(
      string value)
    {
      this.Container.Close = value;
      return this;
    }
  }
}
