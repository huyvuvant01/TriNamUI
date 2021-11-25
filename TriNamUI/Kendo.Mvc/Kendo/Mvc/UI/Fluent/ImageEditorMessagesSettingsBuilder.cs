// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ImageEditorMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ImageEditorMessagesSettingsBuilder
  {
    public ImageEditorMessagesSettingsBuilder(ImageEditorMessagesSettings container) => this.Container = container;

    protected ImageEditorMessagesSettings Container { get; private set; }

    public ImageEditorMessagesSettingsBuilder Toolbar(
      Action<ImageEditorMessagesToolbarSettingsBuilder> configurator)
    {
      this.Container.Toolbar.ImageEditor = this.Container.ImageEditor;
      configurator(new ImageEditorMessagesToolbarSettingsBuilder(this.Container.Toolbar));
      return this;
    }

    public ImageEditorMessagesSettingsBuilder Panes(
      Action<ImageEditorMessagesPanesSettingsBuilder> configurator)
    {
      this.Container.Panes.ImageEditor = this.Container.ImageEditor;
      configurator(new ImageEditorMessagesPanesSettingsBuilder(this.Container.Panes));
      return this;
    }

    public ImageEditorMessagesSettingsBuilder Common(
      Action<ImageEditorMessagesCommonSettingsBuilder> configurator)
    {
      this.Container.Common.ImageEditor = this.Container.ImageEditor;
      configurator(new ImageEditorMessagesCommonSettingsBuilder(this.Container.Common));
      return this;
    }
  }
}
