using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OrnekUygulama1.Extensions
{
    static public class Extensions
    {
        public static IHtmlContent CustomTextBox( this IHtmlHelper htmlHelper,string name,string value,string placeHolder)
        {
            return htmlHelper.TextBox(name, value, new
            {
                style="background-color:green; color:white",
                @class="form-input",
                a="a",
                b="b",
                placeHolder=placeHolder
            });
        }
    }
}
