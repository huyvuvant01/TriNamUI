// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CheckBoxBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class CheckBoxBuilder : WidgetBuilderBase<CheckBox, CheckBoxBuilder>
  {
    public CheckBoxBuilder(CheckBox component)
      : base(component)
    {
    }

    public CheckBoxBuilder Checked(bool value)
    {
      this.Container.Checked = new bool?(value);
      return this;
    }

    public CheckBoxBuilder Enable(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public CheckBoxBuilder Label(string value)
    {
      this.Container.Label = value;
      return this;
    }
  }
}
