// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.NotificationBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class NotificationBuilder : WidgetBuilderBase<Notification, NotificationBuilder>
  {
    public NotificationBuilder(Notification component)
      : base(component)
    {
    }

    public NotificationBuilder Tag(string tag)
    {
      this.Component.Tag = tag;
      return this;
    }

    public NotificationBuilder Width(int value)
    {
      this.Component.Width = value.ToString() + "px";
      return this;
    }

    public NotificationBuilder Height(int value)
    {
      this.Component.Height = value.ToString() + "px";
      return this;
    }

    public NotificationBuilder Templates(
      Action<NotificationTemplateFactory> configurator)
    {
      NotificationTemplateFactory notificationTemplateFactory = new NotificationTemplateFactory(this.Component);
      configurator(notificationTemplateFactory);
      return this;
    }

    public NotificationBuilder Animation(
      Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public NotificationBuilder AllowHideAfter(double value)
    {
      this.Container.AllowHideAfter = new double?(value);
      return this;
    }

    public NotificationBuilder AppendTo(string value)
    {
      this.Container.AppendTo = value;
      return this;
    }

    public NotificationBuilder AutoHideAfter(double value)
    {
      this.Container.AutoHideAfter = new double?(value);
      return this;
    }

    public NotificationBuilder Button(bool value)
    {
      this.Container.Button = new bool?(value);
      return this;
    }

    public NotificationBuilder Button()
    {
      this.Container.Button = new bool?(true);
      return this;
    }

    public NotificationBuilder Height(string value)
    {
      this.Container.Height = value;
      return this;
    }

    public NotificationBuilder HideOnClick(bool value)
    {
      this.Container.HideOnClick = new bool?(value);
      return this;
    }

    public NotificationBuilder Position(
      Action<NotificationPositionSettingsBuilder> configurator)
    {
      this.Container.Position.Notification = this.Container;
      configurator(new NotificationPositionSettingsBuilder(this.Container.Position));
      return this;
    }

    public NotificationBuilder Title(string value)
    {
      this.Container.Title = value;
      return this;
    }

    public NotificationBuilder Width(string value)
    {
      this.Container.Width = value;
      return this;
    }

    public NotificationBuilder Stacking(NotificationStackingSettings value)
    {
      this.Container.Stacking = new NotificationStackingSettings?(value);
      return this;
    }

    public NotificationBuilder Events(
      Action<NotificationEventBuilder> configurator)
    {
      configurator(new NotificationEventBuilder(this.Container.Events));
      return this;
    }
  }
}
