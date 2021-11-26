// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DropDownTreePopupSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("popup", ParentTag = "kendo-dropdowntree", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("popup", ParentTag = "dropdowntree-editor", TagStructure = TagStructure.NormalOrSelfClosing)]
  public class DropDownTreePopupSettingsTagHelper : DropDownPopupSettingsTagHelper
  {
    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DropDownTreeTagHelper);
      foreach (object obj in (IEnumerable<object>) context.Items.Values)
      {
        if (type.IsAssignableFrom(obj.GetType()))
          (context.Items[(object) obj.GetType()] as DropDownTreeTagHelper).Popup = (DropDownPopupSettingsTagHelper) this;
      }
    }
  }
}
