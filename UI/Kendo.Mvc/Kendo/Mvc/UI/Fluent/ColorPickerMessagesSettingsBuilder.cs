// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ColorPickerMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ColorPickerMessagesSettingsBuilder
  {
    public ColorPickerMessagesSettingsBuilder(ColorPickerMessagesSettings container) => this.Container = container;

    protected ColorPickerMessagesSettings Container { get; private set; }

    public ColorPickerMessagesSettingsBuilder Apply(string value)
    {
      this.Container.Apply = value;
      return this;
    }

    public ColorPickerMessagesSettingsBuilder Cancel(string value)
    {
      this.Container.Cancel = value;
      return this;
    }

    public ColorPickerMessagesSettingsBuilder ClearColor(
      string value)
    {
      this.Container.ClearColor = value;
      return this;
    }

    public ColorPickerMessagesSettingsBuilder PreviewInput(
      string value)
    {
      this.Container.PreviewInput = value;
      return this;
    }

    public ColorPickerMessagesSettingsBuilder ContrastRatio(
      string value)
    {
      this.Container.ContrastRatio = value;
      return this;
    }

    public ColorPickerMessagesSettingsBuilder Fail(string value)
    {
      this.Container.Fail = value;
      return this;
    }

    public ColorPickerMessagesSettingsBuilder Pass(string value)
    {
      this.Container.Pass = value;
      return this;
    }

    public ColorPickerMessagesSettingsBuilder Gradient(
      string value)
    {
      this.Container.Gradient = value;
      return this;
    }

    public ColorPickerMessagesSettingsBuilder Palette(string value)
    {
      this.Container.Palette = value;
      return this;
    }

    public ColorPickerMessagesSettingsBuilder ToggleFormat(
      string value)
    {
      this.Container.ToggleFormat = value;
      return this;
    }

    public ColorPickerMessagesSettingsBuilder Red(string value)
    {
      this.Container.Red = value;
      return this;
    }

    public ColorPickerMessagesSettingsBuilder Green(string value)
    {
      this.Container.Green = value;
      return this;
    }

    public ColorPickerMessagesSettingsBuilder Blue(string value)
    {
      this.Container.Blue = value;
      return this;
    }

    public ColorPickerMessagesSettingsBuilder Hex(string value)
    {
      this.Container.Hex = value;
      return this;
    }
  }
}
