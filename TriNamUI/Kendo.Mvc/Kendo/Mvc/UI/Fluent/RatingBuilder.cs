// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RatingBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class RatingBuilder : WidgetBuilderBase<Rating, RatingBuilder>
  {
    public RatingBuilder(Rating component)
      : base(component)
    {
    }

    public RatingBuilder Value(int? value)
    {
      Rating container = this.Container;
      int? nullable1 = value;
      double? nullable2 = nullable1.HasValue ? new double?((double) nullable1.GetValueOrDefault()) : new double?();
      container.Value = nullable2;
      return this;
    }

    public RatingBuilder Value(int value)
    {
      this.Container.Value = new double?((double) value);
      return this;
    }

    public RatingBuilder Value(double? value)
    {
      this.Container.Value = value;
      return this;
    }

    public RatingBuilder Min(double value)
    {
      this.Container.Min = new double?(value);
      return this;
    }

    public RatingBuilder Max(double value)
    {
      this.Container.Max = new double?(value);
      return this;
    }

    public RatingBuilder Selection(string value)
    {
      this.Container.Selection = value;
      return this;
    }

    public RatingBuilder Precision(string value)
    {
      this.Container.Precision = value;
      return this;
    }

    public RatingBuilder Tooltip(bool value)
    {
      this.Container.Tooltip = new bool?(value);
      return this;
    }

    public RatingBuilder Label(Action<RatingLabelSettingsBuilder> configurator)
    {
      this.Container.Label.Enabled = new bool?(true);
      this.Container.Label.Rating = this.Container;
      configurator(new RatingLabelSettingsBuilder(this.Container.Label));
      return this;
    }

    public RatingBuilder Label(bool enabled)
    {
      this.Container.Label.Enabled = new bool?(enabled);
      return this;
    }

    public RatingBuilder SelectValueOnFocus(double value)
    {
      this.Container.SelectValueOnFocus = new double?(value);
      return this;
    }

    public RatingBuilder ItemTemplate(string value)
    {
      this.Container.ItemTemplate = value;
      return this;
    }

    public RatingBuilder ItemTemplateId(string templateId)
    {
      this.Container.ItemTemplateId = templateId;
      return this;
    }

    public RatingBuilder SelectedTemplate(string value)
    {
      this.Container.SelectedTemplate = value;
      return this;
    }

    public RatingBuilder SelectedTemplateId(string templateId)
    {
      this.Container.SelectedTemplateId = templateId;
      return this;
    }

    public RatingBuilder HoveredTemplate(string value)
    {
      this.Container.HoveredTemplate = value;
      return this;
    }

    public RatingBuilder HoveredTemplateId(string templateId)
    {
      this.Container.HoveredTemplateId = templateId;
      return this;
    }

    public RatingBuilder Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public RatingBuilder Readonly(bool value)
    {
      this.Container.Readonly = new bool?(value);
      return this;
    }

    public RatingBuilder Readonly()
    {
      this.Container.Readonly = new bool?(true);
      return this;
    }

    public RatingBuilder Value(double value)
    {
      this.Container.Value = new double?(value);
      return this;
    }

    public RatingBuilder Events(Action<RatingEventBuilder> configurator)
    {
      configurator(new RatingEventBuilder(this.Container.Events));
      return this;
    }
  }
}
