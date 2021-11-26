// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerPreviewPaneSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerPreviewPaneSettingsBuilder
  {
    public FileManagerPreviewPaneSettingsBuilder(FileManagerPreviewPaneSettings container) => this.Container = container;

    protected FileManagerPreviewPaneSettings Container { get; private set; }

    public FileManagerPreviewPaneSettingsBuilder MetaFields(
      params string[] value)
    {
      this.Container.MetaFields = value;
      return this;
    }

    public FileManagerPreviewPaneSettingsBuilder NoFileTemplate(
      string value)
    {
      this.Container.NoFileTemplate = value;
      return this;
    }

    public FileManagerPreviewPaneSettingsBuilder NoFileTemplateId(
      string templateId)
    {
      this.Container.NoFileTemplateId = templateId;
      return this;
    }

    public FileManagerPreviewPaneSettingsBuilder SingleFileTemplate(
      string value)
    {
      this.Container.SingleFileTemplate = value;
      return this;
    }

    public FileManagerPreviewPaneSettingsBuilder SingleFileTemplateId(
      string templateId)
    {
      this.Container.SingleFileTemplateId = templateId;
      return this;
    }

    public FileManagerPreviewPaneSettingsBuilder MultipleFilesTemplate(
      string value)
    {
      this.Container.MultipleFilesTemplate = value;
      return this;
    }

    public FileManagerPreviewPaneSettingsBuilder MultipleFilesTemplateId(
      string templateId)
    {
      this.Container.MultipleFilesTemplateId = templateId;
      return this;
    }
  }
}
