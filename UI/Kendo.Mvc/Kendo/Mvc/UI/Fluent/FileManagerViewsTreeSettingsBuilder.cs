// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerViewsTreeSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerViewsTreeSettingsBuilder
  {
    public FileManagerViewsTreeSettingsBuilder(FileManagerViewsTreeSettings container) => this.Container = container;

    protected FileManagerViewsTreeSettings Container { get; private set; }

    public FileManagerViewsTreeSettingsBuilder Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public FileManagerViewsTreeSettingsBuilder TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }
  }
}
