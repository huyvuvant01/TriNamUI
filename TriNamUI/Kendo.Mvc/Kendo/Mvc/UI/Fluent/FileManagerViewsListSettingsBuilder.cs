// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerViewsListSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerViewsListSettingsBuilder
  {
    public FileManagerViewsListSettingsBuilder(FileManagerViewsListSettings container) => this.Container = container;

    protected FileManagerViewsListSettings Container { get; private set; }

    public FileManagerViewsListSettingsBuilder EditTemplate(
      string value)
    {
      this.Container.EditTemplate = value;
      return this;
    }

    public FileManagerViewsListSettingsBuilder EditTemplateId(
      string templateId)
    {
      this.Container.EditTemplateId = templateId;
      return this;
    }

    public FileManagerViewsListSettingsBuilder Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public FileManagerViewsListSettingsBuilder TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public FileManagerViewsListSettingsBuilder AltTemplate(
      string value)
    {
      this.Container.AltTemplate = value;
      return this;
    }

    public FileManagerViewsListSettingsBuilder AltTemplateId(
      string templateId)
    {
      this.Container.AltTemplateId = templateId;
      return this;
    }
  }
}
