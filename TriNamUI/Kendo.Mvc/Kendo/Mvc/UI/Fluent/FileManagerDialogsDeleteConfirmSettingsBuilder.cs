// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerDialogsDeleteConfirmSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerDialogsDeleteConfirmSettingsBuilder
  {
    public FileManagerDialogsDeleteConfirmSettingsBuilder(
      FileManagerDialogsDeleteConfirmSettings container)
    {
      this.Container = container;
    }

    protected FileManagerDialogsDeleteConfirmSettings Container { get; private set; }

    public FileManagerDialogsDeleteConfirmSettingsBuilder Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public FileManagerDialogsDeleteConfirmSettingsBuilder Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }

    public FileManagerDialogsDeleteConfirmSettingsBuilder Closable(
      bool value)
    {
      this.Container.Closable = new bool?(value);
      return this;
    }

    public FileManagerDialogsDeleteConfirmSettingsBuilder Content(
      string value)
    {
      this.Container.Content = value;
      return this;
    }

    public FileManagerDialogsDeleteConfirmSettingsBuilder Actions(
      Action<FileManagerDialogsDeleteConfirmSettingsActionFactory> configurator)
    {
      configurator(new FileManagerDialogsDeleteConfirmSettingsActionFactory(this.Container.Actions)
      {
        FileManager = this.Container.FileManager
      });
      return this;
    }
  }
}
