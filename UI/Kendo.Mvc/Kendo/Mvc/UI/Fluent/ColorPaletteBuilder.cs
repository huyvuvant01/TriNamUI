// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ColorPaletteBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ColorPaletteBuilder : WidgetBuilderBase<ColorPalette, ColorPaletteBuilder>
  {
    public ColorPaletteBuilder(ColorPalette component)
      : base(component)
    {
    }

    public ColorPaletteBuilder TileSize(double tileSize)
    {
      this.Component.TileSize.Width = new double?(tileSize);
      this.Component.TileSize.Height = new double?(tileSize);
      return this;
    }

    public ColorPaletteBuilder Palette(params string[] palette)
    {
      this.Component.PaletteColors = (IEnumerable<string>) palette;
      this.Component.Palette = new ColorPickerPalette?(ColorPickerPalette.None);
      return this;
    }

    public ColorPaletteBuilder Palette(ColorPickerPalette palette)
    {
      this.Component.PaletteColors = (IEnumerable<string>) null;
      this.Component.Palette = new ColorPickerPalette?(palette);
      return this;
    }

    public ColorPaletteBuilder Columns(int value)
    {
      this.Container.Columns = new int?(value);
      return this;
    }

    public ColorPaletteBuilder TileSize(
      Action<ColorPaletteTileSizeSettingsBuilder> configurator)
    {
      this.Container.TileSize.ColorPalette = this.Container;
      configurator(new ColorPaletteTileSizeSettingsBuilder(this.Container.TileSize));
      return this;
    }

    public ColorPaletteBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public ColorPaletteBuilder Events(
      Action<ColorPaletteEventBuilder> configurator)
    {
      configurator(new ColorPaletteEventBuilder(this.Container.Events));
      return this;
    }
  }
}
