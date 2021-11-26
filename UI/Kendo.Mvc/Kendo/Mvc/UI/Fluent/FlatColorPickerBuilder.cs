// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FlatColorPickerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class FlatColorPickerBuilder : WidgetBuilderBase<FlatColorPicker, FlatColorPickerBuilder>
  {
    public FlatColorPickerBuilder(FlatColorPicker component)
      : base(component)
    {
    }

    public FlatColorPickerBuilder Palette(params string[] palette)
    {
      this.Component.PaletteColors = (IEnumerable<string>) palette;
      this.Component.Palette = new ColorPickerPalette?(ColorPickerPalette.None);
      return this;
    }

    public FlatColorPickerBuilder Formats(params string[] formats)
    {
      this.Component.Formats = (IEnumerable<string>) formats;
      return this;
    }

    public FlatColorPickerBuilder Views(params string[] views)
    {
      this.Component.Views = (IEnumerable<string>) views;
      return this;
    }

    public FlatColorPickerBuilder Opacity(bool value)
    {
      this.Container.Opacity = new bool?(value);
      return this;
    }

    public FlatColorPickerBuilder Opacity()
    {
      this.Container.Opacity = new bool?(true);
      return this;
    }

    public FlatColorPickerBuilder Buttons(bool value)
    {
      this.Container.Buttons = new bool?(value);
      return this;
    }

    public FlatColorPickerBuilder Buttons()
    {
      this.Container.Buttons = new bool?(true);
      return this;
    }

    public FlatColorPickerBuilder Columns(double value)
    {
      this.Container.Columns = new double?(value);
      return this;
    }

    public FlatColorPickerBuilder ContrastTool(
      Action<FlatColorPickerContrastToolSettingsBuilder> configurator)
    {
      this.Container.ContrastTool.Enabled = new bool?(true);
      this.Container.ContrastTool.FlatColorPicker = this.Container;
      configurator(new FlatColorPickerContrastToolSettingsBuilder(this.Container.ContrastTool));
      return this;
    }

    public FlatColorPickerBuilder ContrastTool()
    {
      this.Container.ContrastTool.Enabled = new bool?(true);
      return this;
    }

    public FlatColorPickerBuilder ContrastTool(bool enabled)
    {
      this.Container.ContrastTool.Enabled = new bool?(enabled);
      return this;
    }

    public FlatColorPickerBuilder Input(bool value)
    {
      this.Container.Input = new bool?(value);
      return this;
    }

    public FlatColorPickerBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public FlatColorPickerBuilder Preview(bool value)
    {
      this.Container.Preview = new bool?(value);
      return this;
    }

    public FlatColorPickerBuilder Autoupdate(bool value)
    {
      this.Container.Autoupdate = new bool?(value);
      return this;
    }

    public FlatColorPickerBuilder Messages(
      Action<FlatColorPickerMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.FlatColorPicker = this.Container;
      configurator(new FlatColorPickerMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public FlatColorPickerBuilder Palette(ColorPickerPalette value)
    {
      this.Container.Palette = new ColorPickerPalette?(value);
      return this;
    }

    public FlatColorPickerBuilder Format(ColorPickerFormat value)
    {
      this.Container.Format = new ColorPickerFormat?(value);
      return this;
    }

    public FlatColorPickerBuilder Events(
      Action<FlatColorPickerEventBuilder> configurator)
    {
      configurator(new FlatColorPickerEventBuilder(this.Container.Events));
      return this;
    }
  }
}
