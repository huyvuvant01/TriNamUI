// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Form.Fluent.FormItemLabelSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Form.Fluent
{
  public class FormItemLabelSettingsBuilder<T>
  {
    private readonly FormItemLabelSettings container;

    public FormItemLabelSettingsBuilder(FormItemLabelSettings settings) => this.container = settings;

    public FormItemLabelSettingsBuilder<T> Text(string value)
    {
      this.container.Text = value;
      return this;
    }

    public FormItemLabelSettingsBuilder<T> Optional(bool value)
    {
      this.container.Optional = new bool?(value);
      return this;
    }

    public FormItemLabelSettingsBuilder<T> Encoded(bool value)
    {
      this.container.Encoded = new bool?(value);
      return this;
    }
  }
}
