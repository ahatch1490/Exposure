using Markdig;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ExposureAPI.Models
{
    public static class HtmlHelperExtensions
    {
        public static string MarkDownToHtml(this IHtmlHelper helper, string str)
        {
            return Markdown.ToHtml(str);
        }
    }
}