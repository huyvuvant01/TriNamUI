// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ImageEditorMessagesPanesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ImageEditorMessagesPanesSettingsBuilder
  {
    public ImageEditorMessagesPanesSettingsBuilder(ImageEditorMessagesPanesSettings container) => this.Container = container;

    protected ImageEditorMessagesPanesSettings Container { get; private set; }

    public ImageEditorMessagesPanesSettingsBuilder Crop(
      Action<ImageEditorMessagesPanesCropSettingsBuilder> configurator)
    {
      this.Container.Crop.ImageEditor = this.Container.ImageEditor;
      configurator(new ImageEditorMessagesPanesCropSettingsBuilder(this.Container.Crop));
      return this;
    }

    public ImageEditorMessagesPanesSettingsBuilder Resize(
      Action<ImageEditorMessagesPanesResizeSettingsBuilder> configurator)
    {
      this.Container.Resize.ImageEditor = this.Container.ImageEditor;
      configurator(new ImageEditorMessagesPanesResizeSettingsBuilder(this.Container.Resize));
      return this;
    }
  }
}
