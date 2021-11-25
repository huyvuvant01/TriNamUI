// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WizardStepButtonBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class WizardStepButtonBuilder
  {
    public WizardStepButtonBuilder(WizardStepButton container) => this.Container = container;

    protected WizardStepButton Container { get; private set; }

    public WizardStepButtonBuilder Click(string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public WizardStepButtonBuilder Click(Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public WizardStepButtonBuilder Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public WizardStepButtonBuilder Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public WizardStepButtonBuilder Primary(bool value)
    {
      this.Container.Primary = new bool?(value);
      return this;
    }

    public WizardStepButtonBuilder Primary()
    {
      this.Container.Primary = new bool?(true);
      return this;
    }

    public WizardStepButtonBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }
  }
}
