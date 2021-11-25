// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ColorPickerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ColorPickerBuilder : WidgetBuilderBase<ColorPicker, ColorPickerBuilder>
  {
    public ColorPickerBuilder(ColorPicker component)
      : base(component)
    {
    }

    public ColorPickerBuilder Palette(params string[] palette)
    {
      this.Component.PaletteColors = (IEnumerable<string>) palette;
      this.Component.Palette = new ColorPickerPalette?(ColorPickerPalette.None);
      return this;
    }

    public ColorPickerBuilder Enable(bool value)
    {
      this.Component.Enabled = value;
      return this;
    }

    public ColorPickerBuilder TileSize(int tileSize)
    {
      this.Component.TileSize.Width = new double?((double) tileSize);
      this.Component.TileSize.Height = new double?((double) tileSize);
      return this;
    }

    public ColorPickerBuilder Views(params string[] views)
    {
      this.Component.Views = (IEnumerable<string>) views;
      return this;
    }

    public ColorPickerBuilder Formats(params string[] formats)
    {
      this.Component.Formats = (IEnumerable<string>) formats;
      return this;
    }

    public ColorPickerBuilder Buttons(bool value)
    {
      this.Container.Buttons = new bool?(value);
      return this;
    }

    public ColorPickerBuilder ContrastTool(
      Action<ColorPickerContrastToolSettingsBuilder> configurator)
    {
      this.Container.ContrastTool.Enabled = new bool?(true);
      this.Container.ContrastTool.ColorPicker = this.Container;
      configurator(new ColorPickerContrastToolSettingsBuilder(this.Container.ContrastTool));
      return this;
    }

    public ColorPickerBuilder ContrastTool()
    {
      this.Container.ContrastTool.Enabled = new bool?(true);
      return this;
    }

    public ColorPickerBuilder ContrastTool(bool enabled)
    {
      this.Container.ContrastTool.Enabled = new bool?(enabled);
      return this;
    }

    public ColorPickerBuilder CloseOnSelect(bool value)
    {
      this.Container.CloseOnSelect = new bool?(value);
      return this;
    }

    public ColorPickerBuilder CloseOnSelect()
    {
      this.Container.CloseOnSelect = new bool?(true);
      return this;
    }

    public ColorPickerBuilder Columns(double value)
    {
      this.Container.Columns = new double?(value);
      return this;
    }

    public ColorPickerBuilder Input(bool value)
    {
      this.Container.Input = new bool?(value);
      return this;
    }

    public ColorPickerBuilder TileSize(
      Action<ColorPickerTileSizeSettingsBuilder> configurator)
    {
      this.Container.TileSize.ColorPicker = this.Container;
      configurator(new ColorPickerTileSizeSettingsBuilder(this.Container.TileSize));
      return this;
    }

    public ColorPickerBuilder Messages(
      Action<ColorPickerMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.ColorPicker = this.Container;
      configurator(new ColorPickerMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public ColorPickerBuilder Opacity(bool value)
    {
      this.Container.Opacity = new bool?(value);
      return this;
    }

    public ColorPickerBuilder Opacity()
    {
      this.Container.Opacity = new bool?(true);
      return this;
    }

    public ColorPickerBuilder Preview(bool value)
    {
      this.Container.Preview = new bool?(value);
      return this;
    }

    public ColorPickerBuilder ToolIcon(string value)
    {
      this.Container.ToolIcon = value;
      return this;
    }

    public ColorPickerBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public ColorPickerBuilder Palette(ColorPickerPalette value)
    {
      this.Container.Palette = new ColorPickerPalette?(value);
      return this;
    }

    public ColorPickerBuilder Format(ColorPickerFormat value)
    {
      this.Container.Format = new ColorPickerFormat?(value);
      return this;
    }

    public ColorPickerBuilder View(ColorPickerView value)
    {
      this.Container.View = new ColorPickerView?(value);
      return this;
    }

    public ColorPickerBuilder Events(Action<ColorPickerEventBuilder> configurator)
    {
      configurator(new ColorPickerEventBuilder(this.Container.Events));
      return this;
    }
  }
}
