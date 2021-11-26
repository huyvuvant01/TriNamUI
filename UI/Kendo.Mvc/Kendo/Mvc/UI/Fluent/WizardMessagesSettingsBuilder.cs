// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WizardMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class WizardMessagesSettingsBuilder
  {
    public WizardMessagesSettingsBuilder(WizardMessagesSettings container) => this.Container = container;

    protected WizardMessagesSettings Container { get; private set; }

    public WizardMessagesSettingsBuilder Done(string value)
    {
      this.Container.Done = value;
      return this;
    }

    public WizardMessagesSettingsBuilder Next(string value)
    {
      this.Container.Next = value;
      return this;
    }

    public WizardMessagesSettingsBuilder Of(string value)
    {
      this.Container.Of = value;
      return this;
    }

    public WizardMessagesSettingsBuilder Previous(string value)
    {
      this.Container.Previous = value;
      return this;
    }

    public WizardMessagesSettingsBuilder Reset(string value)
    {
      this.Container.Reset = value;
      return this;
    }

    public WizardMessagesSettingsBuilder Step(string value)
    {
      this.Container.Step = value;
      return this;
    }
  }
}
