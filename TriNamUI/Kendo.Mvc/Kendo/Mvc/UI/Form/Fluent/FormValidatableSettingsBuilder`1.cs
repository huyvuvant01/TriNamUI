// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Form.Fluent.FormValidatableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Form.Fluent
{
  public class FormValidatableSettingsBuilder<T>
  {
    private readonly FormValidatableSettings<T> container;

    public FormValidatableSettingsBuilder(FormValidatableSettings<T> settings) => this.container = settings;

    public FormValidatableSettingsBuilder<T> ValidateOnBlur(bool value)
    {
      this.container.ValidateOnBlur = new bool?(value);
      return this;
    }

    public FormValidatableSettingsBuilder<T> ValidationSummary(
      bool value)
    {
      this.container.ValidationSummary.Enabled = value;
      return this;
    }

    public FormValidatableSettingsBuilder<T> ValidationSummary(
      Action<FormValidationSummarySettingsBuilder> validationSummaryAction)
    {
      validationSummaryAction(new FormValidationSummarySettingsBuilder(this.container.ValidationSummary));
      return this;
    }

    public FormValidatableSettingsBuilder<T> ErrorTemplate(
      string value)
    {
      this.container.ErrorTemplate = value;
      return this;
    }

    public FormValidatableSettingsBuilder<T> ErrorTemplateId(
      string value)
    {
      this.container.ErrorTemplateId = value;
      return this;
    }
  }
}
