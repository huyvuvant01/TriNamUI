// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SkeletonContainerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SkeletonContainerBuilder : 
    WidgetBuilderBase<SkeletonContainer, SkeletonContainerBuilder>
  {
    public SkeletonContainerBuilder(SkeletonContainer component)
      : base(component)
    {
    }

    public SkeletonContainerBuilder Grid(
      Action<SkeletonContainerGridSettingsBuilder> configurator)
    {
      this.Container.Grid.SkeletonContainer = this.Container;
      configurator(new SkeletonContainerGridSettingsBuilder(this.Container.Grid));
      return this;
    }

    public SkeletonContainerBuilder Height(string value)
    {
      this.Container.Height = value;
      return this;
    }

    public SkeletonContainerBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public SkeletonContainerBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public SkeletonContainerBuilder Width(string value)
    {
      this.Container.Width = value;
      return this;
    }

    public SkeletonContainerBuilder Animation(
      SkeletonContainerAnimation value)
    {
      this.Container.Animation = new SkeletonContainerAnimation?(value);
      return this;
    }
  }
}
