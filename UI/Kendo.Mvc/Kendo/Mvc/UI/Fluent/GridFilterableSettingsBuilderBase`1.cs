// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridFilterableSettingsBuilderBase`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class GridFilterableSettingsBuilderBase<TDataSourceBuilder> : IHideObjectMembers
    where TDataSourceBuilder : GridFilterableSettingsBuilderBase<TDataSourceBuilder>
  {
    private readonly GridFilterableSettings settings;

    public GridFilterableSettingsBuilderBase(GridFilterableSettings settings) => this.settings = settings;

    public TDataSourceBuilder Enabled(bool value)
    {
      this.settings.Enabled = value;
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Operators(Action<FilterableOperatorsBuilder> configurator)
    {
      configurator(new FilterableOperatorsBuilder(this.settings.Operators));
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Messages(Action<FilterableMessagesBuilder> configurator)
    {
      configurator(new FilterableMessagesBuilder(this.settings.Messages));
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Extra(bool value)
    {
      this.settings.Extra = new bool?(value);
      this.settings.Enabled = true;
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Mode(GridFilterMode value)
    {
      this.settings.Mode = value;
      this.settings.Enabled = true;
      return (TDataSourceBuilder) this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
