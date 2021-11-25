// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DropDownTreePopupSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class DropDownTreePopupSettingsBuilder
  {
    public DropDownTreePopupSettingsBuilder(DropDownTreePopupSettings container) => this.Container = container;

    protected DropDownTreePopupSettings Container { get; private set; }

    public DropDownTreePopupSettingsBuilder AppendTo(string value)
    {
      this.Container.AppendTo = value;
      return this;
    }

    public DropDownTreePopupSettingsBuilder Origin(string value)
    {
      this.Container.Origin = value;
      return this;
    }

    public DropDownTreePopupSettingsBuilder Position(string value)
    {
      this.Container.Position = value;
      return this;
    }
  }
}
