// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PagerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;

namespace Kendo.Mvc.UI.Fluent
{
  public class PagerBuilder : WidgetBuilderBase<Pager, PagerBuilder>
  {
    public PagerBuilder(Pager component)
      : base(component)
    {
    }

    public PagerBuilder DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public PagerBuilder PageSizes(bool enabled)
    {
      if (enabled)
        this.Component.PageSizes = (IEnumerable) new int[3]
        {
          5,
          10,
          20
        };
      else
        this.Component.PageSizes = (IEnumerable) null;
      return this;
    }

    public PagerBuilder PageSizes()
    {
      this.Component.PageSizes = (IEnumerable) new int[3]
      {
        5,
        10,
        20
      };
      return this;
    }

    public PagerBuilder PageSizes(IEnumerable pageSizes)
    {
      this.Component.PageSizes = pageSizes;
      return this;
    }

    public PagerBuilder ARIATemplate(string value)
    {
      this.Container.ARIATemplate = value;
      return this;
    }

    public PagerBuilder ARIATemplateId(string templateId)
    {
      this.Container.ARIATemplateId = templateId;
      return this;
    }

    public PagerBuilder AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public PagerBuilder ButtonCount(double value)
    {
      this.Container.ButtonCount = new double?(value);
      return this;
    }

    public PagerBuilder SelectTemplate(string value)
    {
      this.Container.SelectTemplate = value;
      return this;
    }

    public PagerBuilder SelectTemplateId(string templateId)
    {
      this.Container.SelectTemplateId = templateId;
      return this;
    }

    public PagerBuilder LinkTemplate(string value)
    {
      this.Container.LinkTemplate = value;
      return this;
    }

    public PagerBuilder LinkTemplateId(string templateId)
    {
      this.Container.LinkTemplateId = templateId;
      return this;
    }

    public PagerBuilder Info(bool value)
    {
      this.Container.Info = new bool?(value);
      return this;
    }

    public PagerBuilder Input(bool value)
    {
      this.Container.Input = new bool?(value);
      return this;
    }

    public PagerBuilder Input()
    {
      this.Container.Input = new bool?(true);
      return this;
    }

    public PagerBuilder Numeric(bool value)
    {
      this.Container.Numeric = new bool?(value);
      return this;
    }

    public PagerBuilder PreviousNext(bool value)
    {
      this.Container.PreviousNext = new bool?(value);
      return this;
    }

    public PagerBuilder Refresh(bool value)
    {
      this.Container.Refresh = new bool?(value);
      return this;
    }

    public PagerBuilder Refresh()
    {
      this.Container.Refresh = new bool?(true);
      return this;
    }

    public PagerBuilder Responsive(bool value)
    {
      this.Container.Responsive = new bool?(value);
      return this;
    }

    public PagerBuilder Messages(Action<PagerMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.Pager = this.Container;
      configurator(new PagerMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public PagerBuilder Navigatable(bool value)
    {
      this.Container.Navigatable = new bool?(value);
      return this;
    }

    public PagerBuilder Navigatable()
    {
      this.Container.Navigatable = new bool?(true);
      return this;
    }

    public PagerBuilder Events(Action<PagerEventBuilder> configurator)
    {
      configurator(new PagerEventBuilder(this.Container.Events));
      return this;
    }
  }
}
