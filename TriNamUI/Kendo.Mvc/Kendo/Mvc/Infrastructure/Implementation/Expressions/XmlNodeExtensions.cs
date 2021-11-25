﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.XmlNodeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Globalization;
using System.Xml;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  public static class XmlNodeExtensions
  {
    public static string ChildElementInnerText(this XmlNode node, string childName)
    {
      XmlElement xmlElement = node[childName];
      if (xmlElement != null)
        return xmlElement.InnerText;
      string.Format((IFormatProvider) CultureInfo.CurrentCulture, "Child element with specified name: {0} cannot be found.", (object) childName);
      return (string) null;
    }
  }
}
