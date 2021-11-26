// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RadioButtonBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class RadioButtonBuilder : WidgetBuilderBase<RadioButton, RadioButtonBuilder>
  {
    public RadioButtonBuilder(RadioButton component)
      : base(component)
    {
    }

    public RadioButtonBuilder Checked(bool value)
    {
      this.Container.Checked = new bool?(value);
      return this;
    }

    public RadioButtonBuilder Enable(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public RadioButtonBuilder Label(string value)
    {
      this.Container.Label = value;
      return this;
    }

    public RadioButtonBuilder Value(object value)
    {
      this.Component.Value = value;
      return this;
    }
  }
}
