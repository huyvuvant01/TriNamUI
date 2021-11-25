﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PanelBarMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class PanelBarMessagesSettingsBuilder
  {
    public PanelBarMessagesSettingsBuilder(PanelBarMessagesSettings container) => this.Container = container;

    protected PanelBarMessagesSettings Container { get; private set; }

    public PanelBarMessagesSettingsBuilder Loading(string value)
    {
      this.Container.Loading = value;
      return this;
    }

    public PanelBarMessagesSettingsBuilder RequestFailed(string value)
    {
      this.Container.RequestFailed = value;
      return this;
    }

    public PanelBarMessagesSettingsBuilder Retry(string value)
    {
      this.Container.Retry = value;
      return this;
    }
  }
}
