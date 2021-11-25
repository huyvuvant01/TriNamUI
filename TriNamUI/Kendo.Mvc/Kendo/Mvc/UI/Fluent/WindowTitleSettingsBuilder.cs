// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WindowTitleSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class WindowTitleSettingsBuilder
  {
    public WindowTitleSettingsBuilder(WindowTitleSettings title) => this.Title = title;

    protected WindowTitleSettings Title { get; private set; }

    public WindowTitleSettingsBuilder Enabled(bool enable)
    {
      this.Title.Enabled = enable;
      return this;
    }

    public WindowTitleSettingsBuilder Text(string value)
    {
      this.Title.Text = value;
      return this;
    }

    public WindowTitleSettingsBuilder Encoded(bool value)
    {
      this.Title.Encoded = value;
      return this;
    }
  }
}
