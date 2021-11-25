// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PageableBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;

namespace Kendo.Mvc.UI.Fluent
{
  public class PageableBuilder : IHideObjectMembers
  {
    private readonly PageableSettings pager;

    public PageableBuilder(PageableSettings pager) => this.pager = pager;

    public PageableBuilder ARIATemplate(string template)
    {
      this.pager.ARIATemplate = template;
      return this;
    }

    public PageableBuilder ARIATemplateId(string templateId)
    {
      this.pager.ARIATemplateId = templateId;
      return this;
    }

    public PageableBuilder PageSizes(int[] pageSizes)
    {
      this.pager.PageSizes = (IEnumerable) pageSizes;
      return this;
    }

    public PageableBuilder PageSizes(bool enabled)
    {
      if (enabled)
        this.pager.PageSizes = (IEnumerable) new int[3]
        {
          5,
          10,
          20
        };
      else
        this.pager.PageSizes = (IEnumerable) null;
      return this;
    }

    public PageableBuilder ButtonCount(int value)
    {
      this.pager.ButtonCount = new int?(value);
      return this;
    }

    public PageableBuilder Navigatable(bool enabled)
    {
      this.pager.Navigatable = new bool?(enabled);
      return this;
    }

    public PageableBuilder Numeric(bool enabled)
    {
      this.pager.Numeric = enabled;
      return this;
    }

    public PageableBuilder Info(bool enabled)
    {
      this.pager.Info = enabled;
      return this;
    }

    public PageableBuilder Input(bool enabled)
    {
      this.pager.Input = enabled;
      return this;
    }

    public PageableBuilder Refresh(bool enabled)
    {
      this.pager.Refresh = enabled;
      return this;
    }

    public PageableBuilder Responsive(bool enabled)
    {
      this.pager.Responsive = new bool?(enabled);
      return this;
    }

    public PageableBuilder Messages(Action<PageableMessagesBuilder> configurator)
    {
      configurator(new PageableMessagesBuilder(this.pager.Messages));
      return this;
    }

    public PageableBuilder PreviousNext(bool enabled)
    {
      this.pager.PreviousNext = enabled;
      return this;
    }

    public PageableBuilder Enabled(bool value)
    {
      this.pager.Enabled = value;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
