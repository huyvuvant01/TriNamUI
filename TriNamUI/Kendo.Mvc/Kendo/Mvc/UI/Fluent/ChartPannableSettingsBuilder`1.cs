// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartPannableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartPannableSettingsBuilder<T> where T : class
  {
    public ChartPannableSettingsBuilder(ChartPannableSettings<T> container) => this.Container = container;

    protected ChartPannableSettings<T> Container { get; private set; }

    public ChartPannableSettingsBuilder<T> Key(ChartActivationKey value)
    {
      this.Container.Key = new ChartActivationKey?(value);
      return this;
    }

    public ChartPannableSettingsBuilder<T> Lock(ChartAxisLock value)
    {
      this.Container.Lock = new ChartAxisLock?(value);
      return this;
    }
  }
}
