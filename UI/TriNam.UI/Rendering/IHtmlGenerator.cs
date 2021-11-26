using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;

namespace TriNamUI.Rendering
{
    public partial interface ITriNamHtmlGenerator
    {
        TagBuilder GenerateInput(ViewContext viewContext, ModelExplorer modelExplorer, string id, string name, object value, string format, string type, IDictionary<string, object> htmlAttributes);

        TagBuilder GenerateColorInput(ViewContext viewContext, ModelExplorer modelExplorer, string id, string name, object value, IDictionary<string, object> htmlAttributes);

        TagBuilder GenerateRangeInput(ViewContext viewContext, ModelExplorer modelExplorer, string id, string name, object value, IDictionary<string, object> htmlAttributes);

        TagBuilder GenerateDateInput(ViewContext viewContext, ModelExplorer modelExplorer, string id, string name, object value, string format, IDictionary<string, object> htmlAttributes);

        TagBuilder GenerateDateTimeInput(ViewContext viewContext, ModelExplorer modelExplorer, string id, string name, object value, string format, IDictionary<string, object> htmlAttributes);

        TagBuilder GenerateTimeInput(ViewContext viewContext, ModelExplorer modelExplorer, string id, string name, object value, string format, IDictionary<string, object> htmlAttributes);

        TagBuilder GenerateNumericInput(ViewContext viewContext, ModelExplorer modelExplorer, string id, string name, object value, string format, IDictionary<string, object> htmlAttributes);

        TagBuilder GenerateTextInput(ViewContext viewContext, ModelExplorer modelExplorer, string id, string name, object value, string format, IDictionary<string, object> htmlAttributes);

        TagBuilder GenerateRadioInput(ViewContext viewContext, ModelExplorer modelExplorer, string id, string name, object value, string format, IDictionary<string, object> htmlAttributes);

        TagBuilder GenerateMultiSelect(ViewContext viewContext, ModelExplorer modelExplorer, string id, string name, IDictionary<string, object> htmlAttributes);

        TagBuilder GenerateTextarea(ViewContext viewContext, ModelExplorer modelExplorer, string id, string name, IDictionary<string, object> htmlAttributes);

        TagBuilder GenerateTag(string tagName, ViewContext viewContext, string id, string name, IDictionary<string, object> htmlAttributes);

        TagBuilder GenerateHiddenForCheckbox(ViewContext viewContext, string name, IDictionary<string, object> htmlAttributes);

        TagBuilder GenerateTag(string tagName, IDictionary<string, object> htmlAttributes);

        TagBuilder GeneratePseudoBuilder(ViewContext viewContext, ModelExplorer explorer, string name);

        string SanitizeId(string id);

        TagBuilder GenerateBoundElement(string elementType, ViewContext viewContext, ModelExplorer modelExplorer, string id, string name, object value, string format, string type, IDictionary<string, object> htmlAttributes);
    }
}
