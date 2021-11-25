// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MaskedTextBoxLabelSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class MaskedTextBoxLabelSettingsBuilder
  {
    public MaskedTextBoxLabelSettingsBuilder(MaskedTextBoxLabelSettings container) => this.Container = container;

    protected MaskedTextBoxLabelSettings Container { get; private set; }

    public MaskedTextBoxLabelSettingsBuilder Content(string value)
    {
      this.Container.ContentHandler = (ClientHandlerDescriptor) null;
      this.Container.Content = value;
      return this;
    }

    public MaskedTextBoxLabelSettingsBuilder ContentHandler(
      string handler)
    {
      this.Container.Content = (string) null;
      this.Container.ContentHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public MaskedTextBoxLabelSettingsBuilder ContentHandler(
      Func<object, object> handler)
    {
      this.Container.Content = (string) null;
      this.Container.ContentHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public MaskedTextBoxLabelSettingsBuilder Floating(bool value)
    {
      this.Container.Floating = new bool?(value);
      return this;
    }

    public MaskedTextBoxLabelSettingsBuilder Floating()
    {
      this.Container.Floating = new bool?(true);
      return this;
    }
  }
}
