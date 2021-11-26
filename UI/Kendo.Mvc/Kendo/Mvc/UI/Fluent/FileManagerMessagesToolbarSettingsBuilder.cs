// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerMessagesToolbarSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerMessagesToolbarSettingsBuilder
  {
    public FileManagerMessagesToolbarSettingsBuilder(FileManagerMessagesToolbarSettings container) => this.Container = container;

    protected FileManagerMessagesToolbarSettings Container { get; private set; }

    public FileManagerMessagesToolbarSettingsBuilder CreateFolder(
      string value)
    {
      this.Container.CreateFolder = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder Upload(
      string value)
    {
      this.Container.Upload = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder SortDirection(
      string value)
    {
      this.Container.SortDirection = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder SortDirectionAsc(
      string value)
    {
      this.Container.SortDirectionAsc = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder SortDirectionDesc(
      string value)
    {
      this.Container.SortDirectionDesc = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder SortField(
      string value)
    {
      this.Container.SortField = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder NameField(
      string value)
    {
      this.Container.NameField = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder SizeField(
      string value)
    {
      this.Container.SizeField = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder TypeField(
      string value)
    {
      this.Container.TypeField = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder DateModifiedField(
      string value)
    {
      this.Container.DateModifiedField = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder DateCreatedField(
      string value)
    {
      this.Container.DateCreatedField = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder Search(
      string value)
    {
      this.Container.Search = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder Details(
      string value)
    {
      this.Container.Details = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder DetailsChecked(
      string value)
    {
      this.Container.DetailsChecked = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder DetailsUnchecked(
      string value)
    {
      this.Container.DetailsUnchecked = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder Delete(
      string value)
    {
      this.Container.Delete = value;
      return this;
    }

    public FileManagerMessagesToolbarSettingsBuilder Rename(
      string value)
    {
      this.Container.Rename = value;
      return this;
    }
  }
}
