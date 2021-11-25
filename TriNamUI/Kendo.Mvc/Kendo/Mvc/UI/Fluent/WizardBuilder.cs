// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WizardBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class WizardBuilder : WidgetBuilderBase<Wizard, WizardBuilder>
  {
    public WizardBuilder(Wizard component)
      : base(component)
    {
    }

    public WizardBuilder Steps(Action<WizardStepFactory> configurator)
    {
      configurator(new WizardStepFactory(this.Container.Steps, this.Container.ViewContext)
      {
        Wizard = this.Container
      });
      return this;
    }

    public WizardBuilder Tag(string value)
    {
      this.Container.Tag = value;
      return this;
    }

    public WizardBuilder ActionBar(bool value)
    {
      this.Container.ActionBar = new bool?(value);
      return this;
    }

    public WizardBuilder LoadOnDemand(bool value)
    {
      this.Container.LoadOnDemand = new bool?(value);
      return this;
    }

    public WizardBuilder LoadOnDemand()
    {
      this.Container.LoadOnDemand = new bool?(true);
      return this;
    }

    public WizardBuilder Messages(Action<WizardMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.Wizard = this.Container;
      configurator(new WizardMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public WizardBuilder Pager(bool value)
    {
      this.Container.Pager = new bool?(value);
      return this;
    }

    public WizardBuilder ReloadOnSelect(bool value)
    {
      this.Container.ReloadOnSelect = new bool?(value);
      return this;
    }

    public WizardBuilder Stepper(Action<WizardStepperSettingsBuilder> configurator)
    {
      this.Container.Stepper.Wizard = this.Container;
      configurator(new WizardStepperSettingsBuilder(this.Container.Stepper));
      return this;
    }

    public WizardBuilder ValidateForms(
      Action<WizardValidateFormsSettingsBuilder> configurator)
    {
      this.Container.ValidateForms.Enabled = new bool?(true);
      this.Container.ValidateForms.Wizard = this.Container;
      configurator(new WizardValidateFormsSettingsBuilder(this.Container.ValidateForms));
      return this;
    }

    public WizardBuilder ValidateForms(bool enabled)
    {
      this.Container.ValidateForms.Enabled = new bool?(enabled);
      return this;
    }

    public WizardBuilder ContentPosition(WizardContentPosition value)
    {
      this.Container.ContentPosition = new WizardContentPosition?(value);
      return this;
    }

    public WizardBuilder Events(Action<WizardEventBuilder> configurator)
    {
      configurator(new WizardEventBuilder(this.Container.Events));
      return this;
    }
  }
}
