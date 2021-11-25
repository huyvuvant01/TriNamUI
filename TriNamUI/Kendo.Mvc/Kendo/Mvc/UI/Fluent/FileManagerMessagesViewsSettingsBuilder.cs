// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerMessagesViewsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerMessagesViewsSettingsBuilder
  {
    public FileManagerMessagesViewsSettingsBuilder(FileManagerMessagesViewsSettings container) => this.Container = container;

    protected FileManagerMessagesViewsSettings Container { get; private set; }

    public FileManagerMessagesViewsSettingsBuilder NameField(
      string value)
    {
      this.Container.NameField = value;
      return this;
    }

    public FileManagerMessagesViewsSettingsBuilder SizeField(
      string value)
    {
      this.Container.SizeField = value;
      return this;
    }

    public FileManagerMessagesViewsSettingsBuilder TypeField(
      string value)
    {
      this.Container.TypeField = value;
      return this;
    }

    public FileManagerMessagesViewsSettingsBuilder DateModifiedField(
      string value)
    {
      this.Container.DateModifiedField = value;
      return this;
    }

    public FileManagerMessagesViewsSettingsBuilder DateCreatedField(
      string value)
    {
      this.Container.DateCreatedField = value;
      return this;
    }

    public FileManagerMessagesViewsSettingsBuilder Items(
      string value)
    {
      this.Container.Items = value;
      return this;
    }
  }
}
