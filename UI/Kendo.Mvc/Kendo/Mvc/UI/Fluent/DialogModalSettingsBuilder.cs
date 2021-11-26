﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DialogModalSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class DialogModalSettingsBuilder
  {
    public DialogModalSettingsBuilder(DialogModalSettings container) => this.Container = container;

    protected DialogModalSettings Container { get; private set; }

    public DialogModalSettingsBuilder PreventScroll(bool value)
    {
      this.Container.PreventScroll = new bool?(value);
      return this;
    }

    public DialogModalSettingsBuilder PreventScroll()
    {
      this.Container.PreventScroll = new bool?(true);
      return this;
    }
  }
}