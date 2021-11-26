// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StepperStepBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class StepperStepBuilder
  {
    public StepperStepBuilder(StepperStep container) => this.Container = container;

    protected StepperStep Container { get; private set; }

    public StepperStepBuilder Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public StepperStepBuilder Error(bool value)
    {
      this.Container.Error = new bool?(value);
      return this;
    }

    public StepperStepBuilder Error()
    {
      this.Container.Error = new bool?(true);
      return this;
    }

    public StepperStepBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public StepperStepBuilder IconTemplate(string value)
    {
      this.Container.IconTemplate = value;
      return this;
    }

    public StepperStepBuilder IconTemplateId(string templateId)
    {
      this.Container.IconTemplateId = templateId;
      return this;
    }

    public StepperStepBuilder Label(string value)
    {
      this.Container.Label = value;
      return this;
    }

    public StepperStepBuilder Selected(bool value)
    {
      this.Container.Selected = new bool?(value);
      return this;
    }

    public StepperStepBuilder Selected()
    {
      this.Container.Selected = new bool?(true);
      return this;
    }

    public StepperStepBuilder SuccessIcon(string value)
    {
      this.Container.SuccessIcon = value;
      return this;
    }
  }
}
