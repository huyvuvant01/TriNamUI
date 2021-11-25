// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorImageBrowserMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorImageBrowserMessagesSettingsBuilder
  {
    public EditorImageBrowserMessagesSettingsBuilder(EditorImageBrowserMessagesSettings container) => this.Container = container;

    protected EditorImageBrowserMessagesSettings Container { get; private set; }

    public EditorImageBrowserMessagesSettingsBuilder UploadFile(
      string value)
    {
      this.Container.UploadFile = value;
      return this;
    }

    public EditorImageBrowserMessagesSettingsBuilder OrderBy(
      string value)
    {
      this.Container.OrderBy = value;
      return this;
    }

    public EditorImageBrowserMessagesSettingsBuilder OrderByName(
      string value)
    {
      this.Container.OrderByName = value;
      return this;
    }

    public EditorImageBrowserMessagesSettingsBuilder OrderBySize(
      string value)
    {
      this.Container.OrderBySize = value;
      return this;
    }

    public EditorImageBrowserMessagesSettingsBuilder DirectoryNotFound(
      string value)
    {
      this.Container.DirectoryNotFound = value;
      return this;
    }

    public EditorImageBrowserMessagesSettingsBuilder EmptyFolder(
      string value)
    {
      this.Container.EmptyFolder = value;
      return this;
    }

    public EditorImageBrowserMessagesSettingsBuilder DeleteFile(
      string value)
    {
      this.Container.DeleteFile = value;
      return this;
    }

    public EditorImageBrowserMessagesSettingsBuilder InvalidFileType(
      string value)
    {
      this.Container.InvalidFileType = value;
      return this;
    }

    public EditorImageBrowserMessagesSettingsBuilder OverwriteFile(
      string value)
    {
      this.Container.OverwriteFile = value;
      return this;
    }

    public EditorImageBrowserMessagesSettingsBuilder Search(
      string value)
    {
      this.Container.Search = value;
      return this;
    }
  }
}
