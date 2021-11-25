// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.NumericTextBoxBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class NumericTextBoxBuilder<T> : 
    WidgetBuilderBase<NumericTextBox<T>, NumericTextBoxBuilder<T>>
    where T : struct
  {
    public NumericTextBoxBuilder(NumericTextBox<T> component)
      : base(component)
    {
    }

    public NumericTextBoxBuilder<T> Culture(string value)
    {
      this.Container.Culture = value;
      return this;
    }

    public NumericTextBoxBuilder<T> Decimals(int value)
    {
      this.Container.Decimals = new int?(value);
      return this;
    }

    public NumericTextBoxBuilder<T> DownArrowText(string value)
    {
      this.Container.DownArrowText = value;
      return this;
    }

    public NumericTextBoxBuilder<T> Factor(double value)
    {
      this.Container.Factor = new double?(value);
      return this;
    }

    public NumericTextBoxBuilder<T> Format(string value)
    {
      this.Container.Format = value;
      return this;
    }

    public NumericTextBoxBuilder<T> Label(
      Action<NumericTextBoxLabelSettingsBuilder<T>> configurator)
    {
      this.Container.Label.NumericTextBox = this.Container;
      configurator(new NumericTextBoxLabelSettingsBuilder<T>(this.Container.Label));
      return this;
    }

    public NumericTextBoxBuilder<T> Max(T? value)
    {
      this.Container.Max = value;
      return this;
    }

    public NumericTextBoxBuilder<T> Min(T? value)
    {
      this.Container.Min = value;
      return this;
    }

    public NumericTextBoxBuilder<T> Placeholder(string value)
    {
      this.Container.Placeholder = value;
      return this;
    }

    public NumericTextBoxBuilder<T> RestrictDecimals(bool value)
    {
      this.Container.RestrictDecimals = new bool?(value);
      return this;
    }

    public NumericTextBoxBuilder<T> RestrictDecimals()
    {
      this.Container.RestrictDecimals = new bool?(true);
      return this;
    }

    public NumericTextBoxBuilder<T> Round(bool value)
    {
      this.Container.Round = new bool?(value);
      return this;
    }

    public NumericTextBoxBuilder<T> SelectOnFocus(bool value)
    {
      this.Container.SelectOnFocus = new bool?(value);
      return this;
    }

    public NumericTextBoxBuilder<T> SelectOnFocus()
    {
      this.Container.SelectOnFocus = new bool?(true);
      return this;
    }

    public NumericTextBoxBuilder<T> Spinners(bool value)
    {
      this.Container.Spinners = new bool?(value);
      return this;
    }

    public NumericTextBoxBuilder<T> Step(T? value)
    {
      this.Container.Step = value;
      return this;
    }

    public NumericTextBoxBuilder<T> UpArrowText(string value)
    {
      this.Container.UpArrowText = value;
      return this;
    }

    public NumericTextBoxBuilder<T> Value(T? value)
    {
      this.Container.Value = value;
      return this;
    }

    public NumericTextBoxBuilder<T> Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public NumericTextBoxBuilder<T> Events(
      Action<NumericTextBoxEventBuilder> configurator)
    {
      configurator(new NumericTextBoxEventBuilder(this.Container.Events));
      return this;
    }
  }
}
