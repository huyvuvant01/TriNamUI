// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WizardEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class WizardEventBuilder : EventBuilder
  {
    public WizardEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public WizardEventBuilder Activate(string handler)
    {
      this.Handler("activate", handler);
      return this;
    }

    public WizardEventBuilder Activate(Func<object, object> handler)
    {
      this.Handler("activate", handler);
      return this;
    }

    public WizardEventBuilder ContentLoad(string handler)
    {
      this.Handler("contentLoad", handler);
      return this;
    }

    public WizardEventBuilder ContentLoad(Func<object, object> handler)
    {
      this.Handler("contentLoad", handler);
      return this;
    }

    public WizardEventBuilder Done(string handler)
    {
      this.Handler("done", handler);
      return this;
    }

    public WizardEventBuilder Done(Func<object, object> handler)
    {
      this.Handler("done", handler);
      return this;
    }

    public WizardEventBuilder Error(string handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public WizardEventBuilder Error(Func<object, object> handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public WizardEventBuilder Reset(string handler)
    {
      this.Handler("reset", handler);
      return this;
    }

    public WizardEventBuilder Reset(Func<object, object> handler)
    {
      this.Handler("reset", handler);
      return this;
    }

    public WizardEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public WizardEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public WizardEventBuilder FormValidateFailed(string handler)
    {
      this.Handler("formValidateFailed", handler);
      return this;
    }

    public WizardEventBuilder FormValidateFailed(Func<object, object> handler)
    {
      this.Handler("formValidateFailed", handler);
      return this;
    }
  }
}
