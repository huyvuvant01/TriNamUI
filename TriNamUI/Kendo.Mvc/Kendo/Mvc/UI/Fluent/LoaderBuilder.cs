// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.LoaderBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class LoaderBuilder : WidgetBuilderBase<Loader, LoaderBuilder>
  {
    public LoaderBuilder(Loader component)
      : base(component)
    {
    }

    public LoaderBuilder Messages(Action<LoaderMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.Loader = this.Container;
      configurator(new LoaderMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public LoaderBuilder Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public LoaderBuilder Size(LoaderSize value)
    {
      this.Container.Size = new LoaderSize?(value);
      return this;
    }

    public LoaderBuilder ThemeColor(LoaderThemeColor value)
    {
      this.Container.ThemeColor = new LoaderThemeColor?(value);
      return this;
    }

    public LoaderBuilder Type(LoaderType value)
    {
      this.Container.Type = new LoaderType?(value);
      return this;
    }
  }
}
