// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WindowPositionSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class WindowPositionSettingsBuilder
  {
    public WindowPositionSettingsBuilder(WindowPositionSettings container) => this.Container = container;

    protected WindowPositionSettings Container { get; private set; }

    public WindowPositionSettingsBuilder Top(double value)
    {
      this.Container.Top = value.ToString() + "px";
      return this;
    }

    public WindowPositionSettingsBuilder Left(double value)
    {
      this.Container.Left = value.ToString() + "px";
      return this;
    }

    public WindowPositionSettingsBuilder Top(string value)
    {
      this.Container.Top = value;
      return this;
    }

    public WindowPositionSettingsBuilder Left(string value)
    {
      this.Container.Left = value;
      return this;
    }
  }
}
