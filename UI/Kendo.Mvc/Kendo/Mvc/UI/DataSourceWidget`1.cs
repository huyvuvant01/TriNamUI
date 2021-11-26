// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DataSourceWidget`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;

namespace Kendo.Mvc.UI
{
  public class DataSourceWidget<T> : WidgetBase where T : class
  {
    public DataSource DataSource { get; private set; }

    public PivotDataSource PivotDataSource { get; internal set; }

    public DataSourceWidget(ViewContext context)
      : base(context)
    {
      this.DataSource = new DataSource(context.GetService<IModelMetadataProvider>());
      this.DataSource.ModelType(typeof (T));
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      this.SerializeSettings();
      DataSourceType? type = this.DataSource.Type;
      DataSourceType dataSourceType = DataSourceType.Custom;
      if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue) || this.DataSource.CustomType == "aspnetmvc-ajax")
        this.ProcessDataSource();
      if (this.PivotDataSource != null)
        writer.Write(this.Name + " = new kendo.data." + this.ClassName + "(" + this.Initializer.Serialize(this.PivotDataSource.ToJson()) + ");");
      else
        writer.Write(this.Name + " = new kendo.data." + this.ClassName + "(" + this.Initializer.Serialize(this.DataSource.ToJson()) + ");");
    }

    internal string ClassName { get; set; } = nameof (DataSource);

    private void ProcessDataSource() => this.DataSource.Process(DataSourceRequestModelBinder.CreateDataSourceRequest(this.ModelMetadataProvider.GetMetadataForType(typeof (T)), this.ValueProvider, string.Empty), true);
  }
}
