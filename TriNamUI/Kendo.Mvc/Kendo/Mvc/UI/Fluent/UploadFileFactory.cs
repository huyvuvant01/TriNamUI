// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.UploadFileFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class UploadFileFactory
  {
    public UploadFileFactory(List<UploadFile> container) => this.Container = container;

    protected List<UploadFile> Container { get; private set; }

    public Upload Upload { get; set; }

    public virtual UploadFileBuilder Add()
    {
      UploadFile container = new UploadFile();
      container.Upload = this.Upload;
      this.Container.Add(container);
      return new UploadFileBuilder(container);
    }
  }
}
