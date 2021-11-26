// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ImageEditorBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ImageEditorBuilder : WidgetBuilderBase<ImageEditor, ImageEditorBuilder>
  {
    public ImageEditorBuilder(ImageEditor component)
      : base(component)
    {
    }

    public ImageEditorBuilder Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public ImageEditorBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public ImageEditorBuilder ImageUrl(string value)
    {
      this.Container.ImageUrl = value;
      return this;
    }

    public ImageEditorBuilder SaveAs(
      Action<ImageEditorSaveAsSettingsBuilder> configurator)
    {
      this.Container.SaveAs.ImageEditor = this.Container;
      configurator(new ImageEditorSaveAsSettingsBuilder(this.Container.SaveAs));
      return this;
    }

    public ImageEditorBuilder Toolbar(
      Action<ImageEditorToolbarSettingsBuilder> configurator)
    {
      this.Container.Toolbar.Enabled = new bool?(true);
      this.Container.Toolbar.ImageEditor = this.Container;
      configurator(new ImageEditorToolbarSettingsBuilder(this.Container.Toolbar));
      return this;
    }

    public ImageEditorBuilder Toolbar(bool enabled)
    {
      this.Container.Toolbar.Enabled = new bool?(enabled);
      return this;
    }

    public ImageEditorBuilder Messages(
      Action<ImageEditorMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.ImageEditor = this.Container;
      configurator(new ImageEditorMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public ImageEditorBuilder Events(Action<ImageEditorEventBuilder> configurator)
    {
      configurator(new ImageEditorEventBuilder(this.Container.Events));
      return this;
    }
  }
}
