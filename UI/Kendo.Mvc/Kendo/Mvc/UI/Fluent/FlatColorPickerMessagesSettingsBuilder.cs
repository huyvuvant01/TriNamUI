// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FlatColorPickerMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FlatColorPickerMessagesSettingsBuilder
  {
    public FlatColorPickerMessagesSettingsBuilder(FlatColorPickerMessagesSettings container) => this.Container = container;

    protected FlatColorPickerMessagesSettings Container { get; private set; }

    public FlatColorPickerMessagesSettingsBuilder Apply(
      string value)
    {
      this.Container.Apply = value;
      return this;
    }

    public FlatColorPickerMessagesSettingsBuilder Cancel(
      string value)
    {
      this.Container.Cancel = value;
      return this;
    }

    public FlatColorPickerMessagesSettingsBuilder ClearColor(
      string value)
    {
      this.Container.ClearColor = value;
      return this;
    }

    public FlatColorPickerMessagesSettingsBuilder ContrastRatio(
      string value)
    {
      this.Container.ContrastRatio = value;
      return this;
    }

    public FlatColorPickerMessagesSettingsBuilder Fail(
      string value)
    {
      this.Container.Fail = value;
      return this;
    }

    public FlatColorPickerMessagesSettingsBuilder Pass(
      string value)
    {
      this.Container.Pass = value;
      return this;
    }

    public FlatColorPickerMessagesSettingsBuilder Gradient(
      string value)
    {
      this.Container.Gradient = value;
      return this;
    }

    public FlatColorPickerMessagesSettingsBuilder Palette(
      string value)
    {
      this.Container.Palette = value;
      return this;
    }

    public FlatColorPickerMessagesSettingsBuilder ToggleFormat(
      string value)
    {
      this.Container.ToggleFormat = value;
      return this;
    }

    public FlatColorPickerMessagesSettingsBuilder Red(
      string value)
    {
      this.Container.Red = value;
      return this;
    }

    public FlatColorPickerMessagesSettingsBuilder Green(
      string value)
    {
      this.Container.Green = value;
      return this;
    }

    public FlatColorPickerMessagesSettingsBuilder Blue(
      string value)
    {
      this.Container.Blue = value;
      return this;
    }

    public FlatColorPickerMessagesSettingsBuilder Hex(
      string value)
    {
      this.Container.Hex = value;
      return this;
    }
  }
}
