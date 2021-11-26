// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WindowResizingSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class WindowResizingSettingsBuilder
  {
    private readonly WindowResizingSettings settings;

    public WindowResizingSettingsBuilder(WindowResizingSettings settings) => this.settings = settings;

    public WindowResizingSettingsBuilder Enabled(bool enable)
    {
      this.settings.Enabled = enable;
      return this;
    }

    public WindowResizingSettingsBuilder MinWidth(int minWidth)
    {
      this.settings.MinWidth = minWidth.ToString() + "px";
      return this;
    }

    public WindowResizingSettingsBuilder MaxWidth(int maxWidth)
    {
      this.settings.MaxWidth = maxWidth.ToString() + "px";
      return this;
    }

    public WindowResizingSettingsBuilder MinHeight(int minHeight)
    {
      this.settings.MinHeight = minHeight.ToString() + "px";
      return this;
    }

    public WindowResizingSettingsBuilder MaxHeight(int maxHeight)
    {
      this.settings.MaxHeight = maxHeight.ToString() + "px";
      return this;
    }

    public WindowResizingSettingsBuilder MinWidth(string minWidth)
    {
      this.settings.MinWidth = minWidth;
      return this;
    }

    public WindowResizingSettingsBuilder MaxWidth(string maxWidth)
    {
      this.settings.MaxWidth = maxWidth;
      return this;
    }

    public WindowResizingSettingsBuilder MinHeight(string minHeight)
    {
      this.settings.MinHeight = minHeight;
      return this;
    }

    public WindowResizingSettingsBuilder MaxHeight(string maxHeight)
    {
      this.settings.MaxHeight = maxHeight;
      return this;
    }
  }
}
