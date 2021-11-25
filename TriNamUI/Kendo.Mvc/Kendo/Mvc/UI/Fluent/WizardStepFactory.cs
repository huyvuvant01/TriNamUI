// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WizardStepFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class WizardStepFactory
  {
    private readonly ViewContext ViewContext;

    public WizardStepFactory(List<WizardStep> container, ViewContext viewContext)
    {
      this.Container = container;
      this.ViewContext = viewContext;
    }

    protected List<WizardStep> Container { get; private set; }

    public virtual WizardStepBuilder Add()
    {
      WizardStep container = new WizardStep();
      container.Wizard = this.Wizard;
      this.Container.Add(container);
      return new WizardStepBuilder(container, this.ViewContext);
    }

    public WizardStepBuilderGeneric<T> Add<T>() where T : class
    {
      WizardStepGeneric<T> container = new WizardStepGeneric<T>();
      container.Wizard = this.Wizard;
      this.Container.Add((WizardStep) container);
      return new WizardStepBuilderGeneric<T>(container, this.ViewContext);
    }

    public Wizard Wizard { get; set; }
  }
}
