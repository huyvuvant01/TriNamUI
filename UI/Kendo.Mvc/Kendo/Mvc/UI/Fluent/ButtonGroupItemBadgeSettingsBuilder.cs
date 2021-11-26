// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ButtonGroupItemBadgeSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ButtonGroupItemBadgeSettingsBuilder
  {
    public ButtonGroupItemBadgeSettingsBuilder(ButtonGroupItemBadgeSettings container) => this.Container = container;

    protected ButtonGroupItemBadgeSettings Container { get; private set; }

    public ButtonGroupItemBadgeSettingsBuilder CutoutBorder(
      bool value)
    {
      this.Container.CutoutBorder = new bool?(value);
      return this;
    }

    public ButtonGroupItemBadgeSettingsBuilder CutoutBorder()
    {
      this.Container.CutoutBorder = new bool?(true);
      return this;
    }

    public ButtonGroupItemBadgeSettingsBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public ButtonGroupItemBadgeSettingsBuilder Max(double value)
    {
      this.Container.Max = new double?(value);
      return this;
    }

    public ButtonGroupItemBadgeSettingsBuilder Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ButtonGroupItemBadgeSettingsBuilder TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ButtonGroupItemBadgeSettingsBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ButtonGroupItemBadgeSettingsBuilder Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ButtonGroupItemBadgeSettingsBuilder Size(
      BadgeSize value)
    {
      this.Container.Size = new BadgeSize?(value);
      return this;
    }

    public ButtonGroupItemBadgeSettingsBuilder Align(
      BadgeAlign value)
    {
      this.Container.Align = new BadgeAlign?(value);
      return this;
    }

    public ButtonGroupItemBadgeSettingsBuilder Position(
      BadgePosition value)
    {
      this.Container.Position = new BadgePosition?(value);
      return this;
    }

    public ButtonGroupItemBadgeSettingsBuilder Shape(
      BadgeShape value)
    {
      this.Container.Shape = new BadgeShape?(value);
      return this;
    }

    public ButtonGroupItemBadgeSettingsBuilder ThemeColor(
      BadgeColor value)
    {
      this.Container.ThemeColor = new BadgeColor?(value);
      return this;
    }

    public ButtonGroupItemBadgeSettingsBuilder Fill(
      BadgeFill value)
    {
      this.Container.Fill = new BadgeFill?(value);
      return this;
    }
  }
}
