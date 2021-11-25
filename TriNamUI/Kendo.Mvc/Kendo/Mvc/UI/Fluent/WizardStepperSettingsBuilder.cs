// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WizardStepperSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class WizardStepperSettingsBuilder
  {
    public WizardStepperSettingsBuilder(WizardStepperSettings container) => this.Container = container;

    protected WizardStepperSettings Container { get; private set; }

    public WizardStepperSettingsBuilder Indicator(bool value)
    {
      this.Container.Indicator = new bool?(value);
      return this;
    }

    public WizardStepperSettingsBuilder Label(bool value)
    {
      this.Container.Label = new bool?(value);
      return this;
    }

    public WizardStepperSettingsBuilder Linear(bool value)
    {
      this.Container.Linear = new bool?(value);
      return this;
    }
  }
}
