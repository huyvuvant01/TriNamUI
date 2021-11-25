// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TextBoxBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TextBoxBuilder<T> : WidgetBuilderBase<TextBox<T>, TextBoxBuilder<T>>
  {
    public TextBoxBuilder(TextBox<T> component)
      : base(component)
    {
    }

    public TextBoxBuilder<T> Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public TextBoxBuilder<T> Label(
      Action<TextBoxLabelSettingsBuilder<T>> configurator)
    {
      this.Container.Label.TextBox = this.Container;
      configurator(new TextBoxLabelSettingsBuilder<T>(this.Container.Label));
      return this;
    }

    public TextBoxBuilder<T> Placeholder(string value)
    {
      this.Container.Placeholder = value;
      return this;
    }

    public TextBoxBuilder<T> Readonly(bool value)
    {
      this.Container.Readonly = new bool?(value);
      return this;
    }

    public TextBoxBuilder<T> Readonly()
    {
      this.Container.Readonly = new bool?(true);
      return this;
    }

    public TextBoxBuilder<T> Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public TextBoxBuilder<T> Events(Action<TextBoxEventBuilder> configurator)
    {
      configurator(new TextBoxEventBuilder(this.Container.Events));
      return this;
    }
  }
}
