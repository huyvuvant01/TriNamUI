// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.WindowResizingSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  public class WindowResizingSettings
  {
    public WindowResizingSettings() => this.Enabled = false;

    public bool Enabled { get; set; }

    public string MinWidth { get; set; }

    public string MinHeight { get; set; }

    public string MaxWidth { get; set; }

    public string MaxHeight { get; set; }
  }
}
