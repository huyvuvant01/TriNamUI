// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Form.Fluent.FormGridSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Form.Fluent
{
  public class FormGridSettingsBuilder<T>
  {
    private readonly FormGridSettings container;

    public FormGridSettingsBuilder(FormGridSettings settings) => this.container = settings;

    public FormGridSettingsBuilder<T> Cols(double value)
    {
      this.container.Cols = new double?(value);
      return this;
    }

    public FormGridSettingsBuilder<T> Gutter(double value)
    {
      this.container.Gutter = new double?(value);
      return this;
    }
  }
}
