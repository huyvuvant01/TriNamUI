// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerViewsGridSettingsColumnBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerViewsGridSettingsColumnBuilder
  {
    public FileManagerViewsGridSettingsColumnBuilder(FileManagerViewsGridSettingsColumn container) => this.Container = container;

    protected FileManagerViewsGridSettingsColumn Container { get; private set; }

    public FileManagerViewsGridSettingsColumnBuilder Field(
      string value)
    {
      this.Container.Field = value;
      return this;
    }

    public FileManagerViewsGridSettingsColumnBuilder Encoded(
      bool value)
    {
      this.Container.Encoded = new bool?(value);
      return this;
    }

    public FileManagerViewsGridSettingsColumnBuilder HeaderTemplate(
      string value)
    {
      this.Container.HeaderTemplate = value;
      return this;
    }

    public FileManagerViewsGridSettingsColumnBuilder HeaderTemplateId(
      string templateId)
    {
      this.Container.HeaderTemplateId = templateId;
      return this;
    }

    public FileManagerViewsGridSettingsColumnBuilder Sortable(
      bool value)
    {
      this.Container.Sortable = new bool?(value);
      return this;
    }

    public FileManagerViewsGridSettingsColumnBuilder Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public FileManagerViewsGridSettingsColumnBuilder TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public FileManagerViewsGridSettingsColumnBuilder Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }

    public FileManagerViewsGridSettingsColumnBuilder Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
