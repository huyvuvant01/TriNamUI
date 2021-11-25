// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerMessagesPreviewPaneSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerMessagesPreviewPaneSettingsBuilder
  {
    public FileManagerMessagesPreviewPaneSettingsBuilder(
      FileManagerMessagesPreviewPaneSettings container)
    {
      this.Container = container;
    }

    protected FileManagerMessagesPreviewPaneSettings Container { get; private set; }

    public FileManagerMessagesPreviewPaneSettingsBuilder NoFileSelected(
      string value)
    {
      this.Container.NoFileSelected = value;
      return this;
    }

    public FileManagerMessagesPreviewPaneSettingsBuilder Extension(
      string value)
    {
      this.Container.Extension = value;
      return this;
    }

    public FileManagerMessagesPreviewPaneSettingsBuilder Size(
      string value)
    {
      this.Container.Size = value;
      return this;
    }

    public FileManagerMessagesPreviewPaneSettingsBuilder Created(
      string value)
    {
      this.Container.Created = value;
      return this;
    }

    public FileManagerMessagesPreviewPaneSettingsBuilder Modified(
      string value)
    {
      this.Container.Modified = value;
      return this;
    }

    public FileManagerMessagesPreviewPaneSettingsBuilder Items(
      string value)
    {
      this.Container.Items = value;
      return this;
    }
  }
}
