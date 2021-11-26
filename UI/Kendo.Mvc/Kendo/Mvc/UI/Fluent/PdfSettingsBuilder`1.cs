// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PdfSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class PdfSettingsBuilder<TBuilder> where TBuilder : PdfSettingsBuilder<TBuilder>
  {
    private readonly PdfSettings pdf;

    public PdfSettingsBuilder(PdfSettings pdf) => this.pdf = pdf;

    public TBuilder PaperSize(string paperSize)
    {
      this.pdf.PaperSize = (object) paperSize;
      return (TBuilder) this;
    }

    public TBuilder PaperSize(double width, double height)
    {
      this.pdf.PaperSize = (object) new double[2]
      {
        width,
        height
      };
      return (TBuilder) this;
    }

    public TBuilder PaperSize(string width, string height)
    {
      this.pdf.PaperSize = (object) new string[2]
      {
        width,
        height
      };
      return (TBuilder) this;
    }

    public TBuilder Margin(double top, double right, double bottom, double left)
    {
      this.pdf.Margin = (IDictionary<string, object>) new Dictionary<string, object>()
      {
        {
          nameof (top),
          (object) top
        },
        {
          nameof (right),
          (object) right
        },
        {
          nameof (bottom),
          (object) bottom
        },
        {
          nameof (left),
          (object) left
        }
      };
      return (TBuilder) this;
    }

    public TBuilder Margin(string top, string right, string bottom, string left)
    {
      this.pdf.Margin = (IDictionary<string, object>) new Dictionary<string, object>()
      {
        {
          nameof (top),
          (object) top
        },
        {
          nameof (right),
          (object) right
        },
        {
          nameof (bottom),
          (object) bottom
        },
        {
          nameof (left),
          (object) left
        }
      };
      return (TBuilder) this;
    }
  }
}
