// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TextAreaBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TextAreaBuilder : WidgetBuilderBase<TextArea, TextAreaBuilder>
  {
    public TextAreaBuilder(TextArea component)
      : base(component)
    {
    }

    public TextAreaBuilder Cols(double value)
    {
      this.Container.Cols = new double?(value);
      return this;
    }

    public TextAreaBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public TextAreaBuilder Label(Action<TextAreaLabelSettingsBuilder> configurator)
    {
      this.Container.Label.TextArea = this.Container;
      configurator(new TextAreaLabelSettingsBuilder(this.Container.Label));
      return this;
    }

    public TextAreaBuilder MaxLength(double value)
    {
      this.Container.MaxLength = new double?(value);
      return this;
    }

    public TextAreaBuilder Placeholder(string value)
    {
      this.Container.Placeholder = value;
      return this;
    }

    public TextAreaBuilder Readonly(bool value)
    {
      this.Container.Readonly = new bool?(value);
      return this;
    }

    public TextAreaBuilder Readonly()
    {
      this.Container.Readonly = new bool?(true);
      return this;
    }

    public TextAreaBuilder Resizable(string value)
    {
      this.Container.Resizable = value;
      return this;
    }

    public TextAreaBuilder Rows(double value)
    {
      this.Container.Rows = new double?(value);
      return this;
    }

    public TextAreaBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public TextAreaBuilder Events(Action<TextAreaEventBuilder> configurator)
    {
      configurator(new TextAreaEventBuilder(this.Container.Events));
      return this;
    }
  }
}
