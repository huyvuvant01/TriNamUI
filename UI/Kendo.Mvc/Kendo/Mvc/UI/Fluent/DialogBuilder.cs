// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DialogBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DialogBuilder : WidgetBuilderBase<Dialog, DialogBuilder>
  {
    public DialogBuilder(Dialog component)
      : base(component)
    {
    }

    public DialogBuilder Animation(Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public DialogBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public DialogBuilder Title(bool show)
    {
      this.Component.Title = (object) show;
      return this;
    }

    public DialogBuilder Title(string title)
    {
      this.Component.Title = (object) title;
      return this;
    }

    public DialogBuilder Modal(Action<DialogModalSettingsBuilder> configurator)
    {
      this.Container.ModalSettings.Enabled = new bool?(true);
      this.Container.ModalSettings.Dialog = this.Container;
      configurator(new DialogModalSettingsBuilder(this.Container.ModalSettings));
      return this;
    }

    public DialogBuilder Modal(bool enabled)
    {
      this.Container.Modal = enabled;
      return this;
    }

    public DialogBuilder Height(double value)
    {
      this.Container.Height = value.ToString() + "px";
      return this;
    }

    public DialogBuilder MaxHeight(double value)
    {
      this.Container.MaxHeight = value.ToString() + "px";
      return this;
    }

    public DialogBuilder MaxWidth(double value)
    {
      this.Container.MaxWidth = value.ToString() + "px";
      return this;
    }

    public DialogBuilder MinHeight(double value)
    {
      this.Container.MinHeight = value.ToString() + "px";
      return this;
    }

    public DialogBuilder MinWidth(double value)
    {
      this.Container.MinWidth = value.ToString() + "px";
      return this;
    }

    public DialogBuilder Width(double value)
    {
      this.Container.Width = value.ToString() + "px";
      return this;
    }

    public DialogBuilder Height(string value)
    {
      this.Container.Height = value;
      return this;
    }

    public DialogBuilder MaxHeight(string value)
    {
      this.Container.MaxHeight = value;
      return this;
    }

    public DialogBuilder MaxWidth(string value)
    {
      this.Container.MaxWidth = value;
      return this;
    }

    public DialogBuilder MinHeight(string value)
    {
      this.Container.MinHeight = value;
      return this;
    }

    public DialogBuilder MinWidth(string value)
    {
      this.Container.MinWidth = value;
      return this;
    }

    public DialogBuilder Width(string value)
    {
      this.Container.Width = value;
      return this;
    }

    public DialogBuilder Actions(Action<DialogActionFactory> configurator)
    {
      configurator(new DialogActionFactory(this.Container.Actions)
      {
        Dialog = this.Container
      });
      return this;
    }

    public DialogBuilder ButtonLayout(string value)
    {
      this.Container.ButtonLayout = value;
      return this;
    }

    public DialogBuilder Closable(bool value)
    {
      this.Container.Closable = new bool?(value);
      return this;
    }

    public DialogBuilder Messages(Action<DialogMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.Dialog = this.Container;
      configurator(new DialogMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public DialogBuilder Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public DialogBuilder Size(string value)
    {
      this.Container.Size = value;
      return this;
    }

    public DialogBuilder Content(string value)
    {
      this.Container.Content = value;
      return this;
    }

    public DialogBuilder Events(Action<DialogEventBuilder> configurator)
    {
      configurator(new DialogEventBuilder(this.Container.Events));
      return this;
    }
  }
}
