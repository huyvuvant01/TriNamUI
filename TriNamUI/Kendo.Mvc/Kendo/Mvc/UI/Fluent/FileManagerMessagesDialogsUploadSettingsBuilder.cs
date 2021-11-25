// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerMessagesDialogsUploadSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerMessagesDialogsUploadSettingsBuilder
  {
    public FileManagerMessagesDialogsUploadSettingsBuilder(
      FileManagerMessagesDialogsUploadSettings container)
    {
      this.Container = container;
    }

    protected FileManagerMessagesDialogsUploadSettings Container { get; private set; }

    public FileManagerMessagesDialogsUploadSettingsBuilder Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }

    public FileManagerMessagesDialogsUploadSettingsBuilder Clear(
      string value)
    {
      this.Container.Clear = value;
      return this;
    }

    public FileManagerMessagesDialogsUploadSettingsBuilder Done(
      string value)
    {
      this.Container.Done = value;
      return this;
    }
  }
}
