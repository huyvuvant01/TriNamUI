// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ImageEditorMessagesToolbarSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ImageEditorMessagesToolbarSettingsBuilder
  {
    public ImageEditorMessagesToolbarSettingsBuilder(ImageEditorMessagesToolbarSettings container) => this.Container = container;

    protected ImageEditorMessagesToolbarSettings Container { get; private set; }

    public ImageEditorMessagesToolbarSettingsBuilder Open(
      string value)
    {
      this.Container.Open = value;
      return this;
    }

    public ImageEditorMessagesToolbarSettingsBuilder Save(
      string value)
    {
      this.Container.Save = value;
      return this;
    }

    public ImageEditorMessagesToolbarSettingsBuilder Undo(
      string value)
    {
      this.Container.Undo = value;
      return this;
    }

    public ImageEditorMessagesToolbarSettingsBuilder Redo(
      string value)
    {
      this.Container.Redo = value;
      return this;
    }

    public ImageEditorMessagesToolbarSettingsBuilder Crop(
      string value)
    {
      this.Container.Crop = value;
      return this;
    }

    public ImageEditorMessagesToolbarSettingsBuilder Resize(
      string value)
    {
      this.Container.Resize = value;
      return this;
    }

    public ImageEditorMessagesToolbarSettingsBuilder ZoomIn(
      string value)
    {
      this.Container.ZoomIn = value;
      return this;
    }

    public ImageEditorMessagesToolbarSettingsBuilder ZoomOut(
      string value)
    {
      this.Container.ZoomOut = value;
      return this;
    }

    public ImageEditorMessagesToolbarSettingsBuilder ZoomDropdown(
      string value)
    {
      this.Container.ZoomDropdown = value;
      return this;
    }

    public ImageEditorMessagesToolbarSettingsBuilder ZoomActualSize(
      string value)
    {
      this.Container.ZoomActualSize = value;
      return this;
    }

    public ImageEditorMessagesToolbarSettingsBuilder ZoomFitToScreen(
      string value)
    {
      this.Container.ZoomFitToScreen = value;
      return this;
    }
  }
}
