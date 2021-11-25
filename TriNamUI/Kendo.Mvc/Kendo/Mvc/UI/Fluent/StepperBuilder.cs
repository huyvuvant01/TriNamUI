// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StepperBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StepperBuilder : WidgetBuilderBase<Stepper, StepperBuilder>
  {
    public StepperBuilder(Stepper component)
      : base(component)
    {
    }

    public StepperBuilder Indicator(bool value)
    {
      this.Container.Indicator = new bool?(value);
      return this;
    }

    public StepperBuilder Label(bool value)
    {
      this.Container.Label = new bool?(value);
      return this;
    }

    public StepperBuilder Linear(bool value)
    {
      this.Container.Linear = new bool?(value);
      return this;
    }

    public StepperBuilder SelectOnFocus(bool value)
    {
      this.Container.SelectOnFocus = new bool?(value);
      return this;
    }

    public StepperBuilder SelectOnFocus()
    {
      this.Container.SelectOnFocus = new bool?(true);
      return this;
    }

    public StepperBuilder Steps(Action<StepperStepFactory> configurator)
    {
      configurator(new StepperStepFactory(this.Container.Steps)
      {
        Stepper = this.Container
      });
      return this;
    }

    public StepperBuilder Orientation(StepperOrientationType value)
    {
      this.Container.Orientation = new StepperOrientationType?(value);
      return this;
    }

    public StepperBuilder Events(Action<StepperEventBuilder> configurator)
    {
      configurator(new StepperEventBuilder(this.Container.Events));
      return this;
    }
  }
}
