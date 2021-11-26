// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ProgressBarBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ProgressBarBuilder : WidgetBuilderBase<ProgressBar, ProgressBarBuilder>
  {
    public ProgressBarBuilder(ProgressBar component)
      : base(component)
    {
    }

    public ProgressBarBuilder Value(double value)
    {
      this.Container.Value = (object) value;
      return this;
    }

    public ProgressBarBuilder Value(bool value)
    {
      this.Container.Value = (object) value;
      return this;
    }

    public ProgressBarBuilder Animation(
      Action<ProgressBarAnimationSettingsBuilder> configurator)
    {
      this.Container.Animation.Enabled = new bool?(true);
      this.Container.Animation.ProgressBar = this.Container;
      configurator(new ProgressBarAnimationSettingsBuilder(this.Container.Animation));
      return this;
    }

    public ProgressBarBuilder Animation(bool enabled)
    {
      this.Container.Animation.Enabled = new bool?(enabled);
      return this;
    }

    public ProgressBarBuilder AriaRole(bool value)
    {
      this.Container.AriaRole = new bool?(value);
      return this;
    }

    public ProgressBarBuilder AriaRole()
    {
      this.Container.AriaRole = new bool?(true);
      return this;
    }

    public ProgressBarBuilder ChunkCount(double value)
    {
      this.Container.ChunkCount = new double?(value);
      return this;
    }

    public ProgressBarBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public ProgressBarBuilder Label(string value)
    {
      this.Container.Label = value;
      return this;
    }

    public ProgressBarBuilder LabelId(string value)
    {
      this.Container.LabelId = value;
      return this;
    }

    public ProgressBarBuilder Max(double value)
    {
      this.Container.Max = new double?(value);
      return this;
    }

    public ProgressBarBuilder Min(double value)
    {
      this.Container.Min = new double?(value);
      return this;
    }

    public ProgressBarBuilder Reverse(bool value)
    {
      this.Container.Reverse = new bool?(value);
      return this;
    }

    public ProgressBarBuilder Reverse()
    {
      this.Container.Reverse = new bool?(true);
      return this;
    }

    public ProgressBarBuilder ShowStatus(bool value)
    {
      this.Container.ShowStatus = new bool?(value);
      return this;
    }

    public ProgressBarBuilder Orientation(ProgressBarOrientation value)
    {
      this.Container.Orientation = new ProgressBarOrientation?(value);
      return this;
    }

    public ProgressBarBuilder Type(ProgressBarType value)
    {
      this.Container.Type = new ProgressBarType?(value);
      return this;
    }

    public ProgressBarBuilder Events(Action<ProgressBarEventBuilder> configurator)
    {
      configurator(new ProgressBarEventBuilder(this.Container.Events));
      return this;
    }
  }
}
