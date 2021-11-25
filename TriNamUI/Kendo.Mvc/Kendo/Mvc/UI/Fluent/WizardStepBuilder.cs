// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WizardStepBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class WizardStepBuilder
  {
    private readonly ViewContext ViewContext;

    public WizardStepBuilder(WizardStep container, ViewContext viewContext)
    {
      this.Container = container;
      this.ViewContext = viewContext;
    }

    protected WizardStep Container { get; private set; }

    public WizardStepBuilder Form(Action<FormBuilder<object>> configurator)
    {
      this.Container.Form = new Kendo.Mvc.UI.Form<object>(this.ViewContext);
      configurator(new FormBuilder<object>(this.Container.Form));
      return this;
    }

    public WizardStepBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public WizardStepBuilder IconTemplate(string value)
    {
      this.Container.IconTemplate = value;
      return this;
    }

    public WizardStepBuilder IconTemplateId(string value)
    {
      this.Container.IconTemplateId = value;
      return this;
    }

    public WizardStepBuilder Buttons(Action<WizardStepButtonFactory> configurator)
    {
      configurator(new WizardStepButtonFactory(this.Container.Buttons)
      {
        Wizard = this.Container.Wizard
      });
      return this;
    }

    public WizardStepBuilder Content(string value)
    {
      this.Container.Content = value;
      return this;
    }

    public WizardStepBuilder ContentId(string value)
    {
      this.Container.ContentId = value;
      return this;
    }

    public WizardStepBuilder ContentUrl(string value)
    {
      this.Container.ContentUrl = value;
      return this;
    }

    public WizardStepBuilder ClassName(string value)
    {
      this.Container.ClassName = value;
      return this;
    }

    public WizardStepBuilder Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public WizardStepBuilder Pager(bool value)
    {
      this.Container.Pager = new bool?(value);
      return this;
    }

    public WizardStepBuilder Title(string value)
    {
      this.Container.Title = value;
      return this;
    }
  }
}
