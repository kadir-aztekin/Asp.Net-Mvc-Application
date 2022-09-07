using AspNetMvcApplication.Mıddlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetMvcApplication.Extensions
{
    static public class Extensions
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<HelloMiddleware>();
        }


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
