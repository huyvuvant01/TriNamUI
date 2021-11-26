// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorFileBrowserMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorFileBrowserMessagesSettingsBuilder
  {
    public EditorFileBrowserMessagesSettingsBuilder(EditorFileBrowserMessagesSettings container) => this.Container = container;

    protected EditorFileBrowserMessagesSettings Container { get; private set; }

    public EditorFileBrowserMessagesSettingsBuilder UploadFile(
      string value)
    {
      this.Container.UploadFile = value;
      return this;
    }

    public EditorFileBrowserMessagesSettingsBuilder OrderBy(
      string value)
    {
      this.Container.OrderBy = value;
      return this;
    }

    public EditorFileBrowserMessagesSettingsBuilder OrderByName(
      string value)
    {
      this.Container.OrderByName = value;
      return this;
    }

    public EditorFileBrowserMessagesSettingsBuilder OrderBySize(
      string value)
    {
      this.Container.OrderBySize = value;
      return this;
    }

    public EditorFileBrowserMessagesSettingsBuilder DirectoryNotFound(
      string value)
    {
      this.Container.DirectoryNotFound = value;
      return this;
    }

    public EditorFileBrowserMessagesSettingsBuilder EmptyFolder(
      string value)
    {
      this.Container.EmptyFolder = value;
      return this;
    }

    public EditorFileBrowserMessagesSettingsBuilder DeleteFile(
      string value)
    {
      this.Container.DeleteFile = value;
      return this;
    }

    public EditorFileBrowserMessagesSettingsBuilder InvalidFileType(
      string value)
    {
      this.Container.InvalidFileType = value;
      return this;
    }

    public EditorFileBrowserMessagesSettingsBuilder OverwriteFile(
      string value)
    {
      this.Container.OverwriteFile = value;
      return this;
    }

    public EditorFileBrowserMessagesSettingsBuilder Search(
      string value)
    {
      this.Container.Search = value;
      return this;
    }
  }
}
