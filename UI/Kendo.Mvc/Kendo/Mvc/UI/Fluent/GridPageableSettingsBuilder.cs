// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridPageableSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridPageableSettingsBuilder
  {
    private readonly GridPageableSettings pager;

    public GridPageableSettingsBuilder(GridPageableSettings pager) => this.pager = pager;

    public GridPageableSettingsBuilder ARIATemplate(string template)
    {
      this.pager.ARIATemplate = template;
      return this;
    }

    public GridPageableSettingsBuilder ARIATemplateId(string templateId)
    {
      this.pager.ARIATemplateId = templateId;
      return this;
    }

    public GridPageableSettingsBuilder AlwaysVisible(bool enabled)
    {
      this.pager.AlwaysVisible = enabled;
      return this;
    }

    public GridPageableSettingsBuilder Navigatable(bool enabled)
    {
      this.pager.Navigatable = new bool?(enabled);
      return this;
    }

    public GridPageableSettingsBuilder Position(
      GridPagerPosition position)
    {
      this.pager.Position = new GridPagerPosition?(position);
      return this;
    }

    public GridPageableSettingsBuilder PageSizes(int[] pageSizes)
    {
      this.pager.PageSizes = (IEnumerable) pageSizes;
      return this;
    }

    public GridPageableSettingsBuilder PageSizes(IEnumerable pageSizes)
    {
      this.pager.PageSizes = pageSizes;
      return this;
    }

    public GridPageableSettingsBuilder PageSizes(bool enabled)
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

    public GridPageableSettingsBuilder ButtonCount(int value)
    {
      this.pager.ButtonCount = new int?(value);
      return this;
    }

    public GridPageableSettingsBuilder Numeric(bool enabled)
    {
      this.pager.Numeric = enabled;
      return this;
    }

    public GridPageableSettingsBuilder Info(bool enabled)
    {
      this.pager.Info = enabled;
      return this;
    }

    public GridPageableSettingsBuilder Input(bool enabled)
    {
      this.pager.Input = enabled;
      return this;
    }

    public GridPageableSettingsBuilder Refresh(bool enabled)
    {
      this.pager.Refresh = enabled;
      return this;
    }

    public GridPageableSettingsBuilder Responsive(bool enabled)
    {
      this.pager.Responsive = new bool?(enabled);
      return this;
    }

    public GridPageableSettingsBuilder Messages(
      Action<PageableMessagesBuilder> configurator)
    {
      configurator(new PageableMessagesBuilder(this.pager.Messages));
      return this;
    }

    public GridPageableSettingsBuilder PreviousNext(bool enabled)
    {
      this.pager.PreviousNext = enabled;
      return this;
    }

    public GridPageableSettingsBuilder Enabled(bool value)
    {
      this.pager.Enabled = value;
      return this;
    }
  }
}
