// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MaskedTextBoxBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class MaskedTextBoxBuilder : WidgetBuilderBase<MaskedTextBox, MaskedTextBoxBuilder>
  {
    public MaskedTextBoxBuilder(MaskedTextBox component)
      : base(component)
    {
    }

    public MaskedTextBoxBuilder Rules(
      Action<MaskedTextBoxRulesBuilder> RulesAction)
    {
      this.Component.Rules.Clear();
      RulesAction(new MaskedTextBoxRulesBuilder((IDictionary<string, object>) this.Component.Rules));
      return this;
    }

    public MaskedTextBoxBuilder ClearPromptChar(bool value)
    {
      this.Container.ClearPromptChar = new bool?(value);
      return this;
    }

    public MaskedTextBoxBuilder ClearPromptChar()
    {
      this.Container.ClearPromptChar = new bool?(true);
      return this;
    }

    public MaskedTextBoxBuilder Culture(string value)
    {
      this.Container.Culture = value;
      return this;
    }

    public MaskedTextBoxBuilder Label(
      Action<MaskedTextBoxLabelSettingsBuilder> configurator)
    {
      this.Container.Label.MaskedTextBox = this.Container;
      configurator(new MaskedTextBoxLabelSettingsBuilder(this.Container.Label));
      return this;
    }

    public MaskedTextBoxBuilder Mask(string value)
    {
      this.Container.Mask = value;
      return this;
    }

    public MaskedTextBoxBuilder PromptChar(string value)
    {
      this.Container.PromptChar = value;
      return this;
    }

    public MaskedTextBoxBuilder UnmaskOnPost(bool value)
    {
      this.Container.UnmaskOnPost = new bool?(value);
      return this;
    }

    public MaskedTextBoxBuilder UnmaskOnPost()
    {
      this.Container.UnmaskOnPost = new bool?(true);
      return this;
    }

    public MaskedTextBoxBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public MaskedTextBoxBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public MaskedTextBoxBuilder Events(
      Action<MaskedTextBoxEventBuilder> configurator)
    {
      configurator(new MaskedTextBoxEventBuilder(this.Container.Events));
      return this;
    }
  }
}
