// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WizardStepBuilderGeneric`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class WizardStepBuilderGeneric<T> where T : class
  {
    private readonly ViewContext ViewContext;

    public WizardStepBuilderGeneric(WizardStepGeneric<T> container, ViewContext viewContext)
    {
      this.Container = container;
      this.ViewContext = viewContext;
    }

    public WizardStepGeneric<T> Container { get; private set; }

    public WizardStepBuilderGeneric<T> Buttons(
      Action<WizardStepButtonFactory> configurator)
    {
      configurator(new WizardStepButtonFactory(this.Container.Buttons)
      {
        Wizard = this.Container.Wizard
      });
      return this;
    }

    public WizardStepBuilderGeneric<T> Content(string value)
    {
      this.Container.Content = value;
      return this;
    }

    public WizardStepBuilderGeneric<T> ContentId(string value)
    {
      this.Container.ContentId = value;
      return this;
    }

    public WizardStepBuilderGeneric<T> ContentUrl(string value)
    {
      this.Container.ContentUrl = value;
      return this;
    }

    public WizardStepBuilderGeneric<T> ClassName(string value)
    {
      this.Container.ClassName = value;
      return this;
    }

    public WizardStepBuilderGeneric<T> Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public WizardStepBuilderGeneric<T> Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public WizardStepBuilderGeneric<T> IconTemplate(string value)
    {
      this.Container.IconTemplate = value;
      return this;
    }

    public WizardStepBuilderGeneric<T> IconTemplateId(string value)
    {
      this.Container.IconTemplateId = value;
      return this;
    }

    public WizardStepBuilderGeneric<T> Pager(bool value)
    {
      this.Container.Pager = new bool?(value);
      return this;
    }

    public WizardStepBuilderGeneric<T> Title(string value)
    {
      this.Container.Title = value;
      return this;
    }

    public WizardStepBuilderGeneric<T> Form(
      Action<FormBuilder<T>> configurator)
    {
      this.Container.Form = new Kendo.Mvc.UI.Form<T>(this.ViewContext);
      configurator(new FormBuilder<T>(this.Container.Form));
      return this;
    }
  }
}
