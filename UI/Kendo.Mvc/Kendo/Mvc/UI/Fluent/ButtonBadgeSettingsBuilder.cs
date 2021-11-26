// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ButtonBadgeSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ButtonBadgeSettingsBuilder
  {
    public ButtonBadgeSettingsBuilder(ButtonBadgeSettings container) => this.Container = container;

    protected ButtonBadgeSettings Container { get; private set; }

    public ButtonBadgeSettingsBuilder CutoutBorder(bool value)
    {
      this.Container.CutoutBorder = new bool?(value);
      return this;
    }

    public ButtonBadgeSettingsBuilder CutoutBorder()
    {
      this.Container.CutoutBorder = new bool?(true);
      return this;
    }

    public ButtonBadgeSettingsBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public ButtonBadgeSettingsBuilder Max(double value)
    {
      this.Container.Max = new double?(value);
      return this;
    }

    public ButtonBadgeSettingsBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ButtonBadgeSettingsBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ButtonBadgeSettingsBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ButtonBadgeSettingsBuilder Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ButtonBadgeSettingsBuilder Size(BadgeSize value)
    {
      this.Container.Size = new BadgeSize?(value);
      return this;
    }

    public ButtonBadgeSettingsBuilder Align(BadgeAlign value)
    {
      this.Container.Align = new BadgeAlign?(value);
      return this;
    }

    public ButtonBadgeSettingsBuilder Position(BadgePosition value)
    {
      this.Container.Position = new BadgePosition?(value);
      return this;
    }

    public ButtonBadgeSettingsBuilder Shape(BadgeShape value)
    {
      this.Container.Shape = new BadgeShape?(value);
      return this;
    }

    public ButtonBadgeSettingsBuilder ThemeColor(BadgeColor value)
    {
      this.Container.ThemeColor = new BadgeColor?(value);
      return this;
    }

    public ButtonBadgeSettingsBuilder Fill(BadgeFill value)
    {
      this.Container.Fill = new BadgeFill?(value);
      return this;
    }
  }
}
