// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WizardStepButtonFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class WizardStepButtonFactory
  {
    public WizardStepButtonFactory(List<WizardStepButton> container) => this.Container = container;

    protected List<WizardStepButton> Container { get; private set; }

    public Wizard Wizard { get; set; }

    public virtual WizardStepButtonBuilder Custom()
    {
      WizardStepButton container = new WizardStepButton();
      this.Container.Add(container);
      return new WizardStepButtonBuilder(container);
    }

    public virtual WizardStepButtonBuilder Previous()
    {
      WizardStepButton container = new WizardStepButton()
      {
        Name = "previous"
      };
      this.Container.Add(container);
      return new WizardStepButtonBuilder(container);
    }

    public virtual WizardStepButtonBuilder Next()
    {
      WizardStepButton container = new WizardStepButton()
      {
        Name = "next"
      };
      this.Container.Add(container);
      return new WizardStepButtonBuilder(container);
    }

    public virtual WizardStepButtonBuilder Done()
    {
      WizardStepButton container = new WizardStepButton()
      {
        Name = "done"
      };
      this.Container.Add(container);
      return new WizardStepButtonBuilder(container);
    }

    public virtual WizardStepButtonBuilder Reset()
    {
      WizardStepButton container = new WizardStepButton()
      {
        Name = "reset"
      };
      this.Container.Add(container);
      return new WizardStepButtonBuilder(container);
    }
  }
}
