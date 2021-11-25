﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SliderTooltipSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SliderTooltipSettingsBuilder<T> where T : struct, IComparable
  {
    public SliderTooltipSettingsBuilder(SliderTooltipSettings<T> container) => this.Container = container;

    protected SliderTooltipSettings<T> Container { get; private set; }

    public SliderTooltipSettingsBuilder<T> Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public SliderTooltipSettingsBuilder<T> Format(string value)
    {
      this.Container.Format = value;
      return this;
    }

    public SliderTooltipSettingsBuilder<T> Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public SliderTooltipSettingsBuilder<T> TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }
  }
}
