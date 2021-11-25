// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DropDownPopupAnimationCloseSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("close", ParentTag = "popup-animation", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class DropDownPopupAnimationCloseSettingsTagHelper : PopupAnimationCloseSettingsTagHelper
  {
    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DropDownPopupAnimationSettingsTagHelper);
      foreach (object obj in (IEnumerable<object>) context.Items.Values)
      {
        if (type.IsAssignableFrom(obj.GetType()))
          (context.Items[(object) obj.GetType()] as DropDownPopupAnimationSettingsTagHelper).Close = (PopupAnimationCloseSettingsTagHelper) this;
      }
    }
  }
}
