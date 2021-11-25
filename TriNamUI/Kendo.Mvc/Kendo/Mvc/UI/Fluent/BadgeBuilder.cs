// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.BadgeBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class BadgeBuilder : WidgetBuilderBase<Badge, BadgeBuilder>
  {
    public BadgeBuilder(Badge component)
      : base(component)
    {
    }

    public BadgeBuilder Text(float value)
    {
      this.Container.FloatText = new float?(value);
      return this;
    }

    public BadgeBuilder CutoutBorder(bool value)
    {
      this.Container.CutoutBorder = new bool?(value);
      return this;
    }

    public BadgeBuilder CutoutBorder()
    {
      this.Container.CutoutBorder = new bool?(true);
      return this;
    }

    public BadgeBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public BadgeBuilder Max(double value)
    {
      this.Container.Max = new double?(value);
      return this;
    }

    public BadgeBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public BadgeBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public BadgeBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public BadgeBuilder Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public BadgeBuilder Size(BadgeSize value)
    {
      this.Container.Size = new BadgeSize?(value);
      return this;
    }

    public BadgeBuilder Align(BadgeAlign value)
    {
      this.Container.Align = new BadgeAlign?(value);
      return this;
    }

    public BadgeBuilder Position(BadgePosition value)
    {
      this.Container.Position = new BadgePosition?(value);
      return this;
    }

    public BadgeBuilder Shape(BadgeShape value)
    {
      this.Container.Shape = new BadgeShape?(value);
      return this;
    }

    public BadgeBuilder ThemeColor(BadgeColor value)
    {
      this.Container.ThemeColor = new BadgeColor?(value);
      return this;
    }

    public BadgeBuilder Fill(BadgeFill value)
    {
      this.Container.Fill = new BadgeFill?(value);
      return this;
    }
  }
}
