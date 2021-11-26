// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ButtonBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ButtonBuilder : WidgetBuilderBase<Button, ButtonBuilder>
  {
    public ButtonBuilder(Button component)
      : base(component)
    {
    }

    public ButtonBuilder Content(Action content)
    {
      this.Component.ContentAction = content;
      return this;
    }

    public ButtonBuilder Content(Func<object, object> content)
    {
      this.Component.Content = content;
      return this;
    }

    public ButtonBuilder Content(string content)
    {
      this.Component.Html = content;
      return this;
    }

    public ButtonBuilder Tag(string tag)
    {
      this.Component.Tag = tag;
      return this;
    }

    public ButtonBuilder Badge(string value)
    {
      this.Container.Badge.Text = value;
      return this;
    }

    public ButtonBuilder Badge(Action<ButtonBadgeSettingsBuilder> configurator)
    {
      this.Container.Badge.Enabled = new bool?(true);
      this.Container.Badge.Button = this.Container;
      configurator(new ButtonBadgeSettingsBuilder(this.Container.Badge));
      return this;
    }

    public ButtonBuilder Badge(bool enabled)
    {
      this.Container.Badge.Enabled = new bool?(enabled);
      return this;
    }

    public ButtonBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public ButtonBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public ButtonBuilder IconClass(string value)
    {
      this.Container.IconClass = value;
      return this;
    }

    public ButtonBuilder ImageUrl(string value)
    {
      this.Container.ImageUrl = value;
      return this;
    }

    public ButtonBuilder SpriteCssClass(string value)
    {
      this.Container.SpriteCssClass = value;
      return this;
    }

    public ButtonBuilder Events(Action<ButtonEventBuilder> configurator)
    {
      configurator(new ButtonEventBuilder(this.Container.Events));
      return this;
    }
  }
}
