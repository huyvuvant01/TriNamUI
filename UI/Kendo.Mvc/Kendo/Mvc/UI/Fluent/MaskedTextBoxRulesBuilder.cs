// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MaskedTextBoxRulesBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class MaskedTextBoxRulesBuilder : IHideObjectMembers
  {
    protected IDictionary<string, object> Rules { get; private set; }

    public MaskedTextBoxRulesBuilder(IDictionary<string, object> rules) => this.Rules = rules;

    public MaskedTextBoxRulesBuilder Add(char name, string regexp)
    {
      this.Rules[name.ToString()] = (object) new ClientHandlerDescriptor()
      {
        HandlerName = regexp
      };
      return this;
    }

    public MaskedTextBoxRulesBuilder Add(
      char name,
      Func<object, object> handler)
    {
      this.Rules[name.ToString()] = (object) new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
