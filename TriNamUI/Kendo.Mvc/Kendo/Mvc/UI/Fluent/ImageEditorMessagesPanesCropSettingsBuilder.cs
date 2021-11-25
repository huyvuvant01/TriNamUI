// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ImageEditorMessagesPanesCropSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ImageEditorMessagesPanesCropSettingsBuilder
  {
    public ImageEditorMessagesPanesCropSettingsBuilder(
      ImageEditorMessagesPanesCropSettings container)
    {
      this.Container = container;
    }

    protected ImageEditorMessagesPanesCropSettings Container { get; private set; }

    public ImageEditorMessagesPanesCropSettingsBuilder Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }

    public ImageEditorMessagesPanesCropSettingsBuilder AspectRatio(
      string value)
    {
      this.Container.AspectRatio = value;
      return this;
    }

    public ImageEditorMessagesPanesCropSettingsBuilder AspectRatioItems(
      Action<ImageEditorMessagesPanesCropAspectRatioItemsSettingsBuilder> configurator)
    {
      this.Container.AspectRatioItems.ImageEditor = this.Container.ImageEditor;
      configurator(new ImageEditorMessagesPanesCropAspectRatioItemsSettingsBuilder(this.Container.AspectRatioItems));
      return this;
    }

    public ImageEditorMessagesPanesCropSettingsBuilder Orientation(
      string value)
    {
      this.Container.Orientation = value;
      return this;
    }

    public ImageEditorMessagesPanesCropSettingsBuilder Portrait(
      string value)
    {
      this.Container.Portrait = value;
      return this;
    }

    public ImageEditorMessagesPanesCropSettingsBuilder Landscape(
      string value)
    {
      this.Container.Landscape = value;
      return this;
    }
  }
}
