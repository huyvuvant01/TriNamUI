// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ImageEditorMessagesPanesResizeSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ImageEditorMessagesPanesResizeSettingsBuilder
  {
    public ImageEditorMessagesPanesResizeSettingsBuilder(
      ImageEditorMessagesPanesResizeSettings container)
    {
      this.Container = container;
    }

    protected ImageEditorMessagesPanesResizeSettings Container { get; private set; }

    public ImageEditorMessagesPanesResizeSettingsBuilder Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }

    public ImageEditorMessagesPanesResizeSettingsBuilder Pixels(
      string value)
    {
      this.Container.Pixels = value;
      return this;
    }

    public ImageEditorMessagesPanesResizeSettingsBuilder Percents(
      string value)
    {
      this.Container.Percents = value;
      return this;
    }
  }
}
