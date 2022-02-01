#pragma checksum "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d078cd5a505567abfeb2507bad2cd5c7be9ac923"
// <auto-generated/>
#pragma warning disable 1591
namespace BrBadApi.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\_Imports.razor"
using BrBadApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\_Imports.razor"
using BrBadApi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\_Imports.razor"
using BrBadApi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "header");
            __builder.AddMarkupContent(3, "<h1>Breaking Bad API</h1>\r\n        ");
            __builder.AddMarkupContent(4, "<h5>Search for a character: </h5>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\Pages\Index.razor"
                                  searchString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchString = __value, searchString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.OpenElement(10, "main");
#nullable restore
#line 13 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\Pages\Index.razor"
         if (characters != null)
        {
            foreach (var character in displayCharacters)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card");
            __builder.OpenElement(13, "h1");
            __builder.AddContent(14, 
#nullable restore
#line 18 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\Pages\Index.razor"
                         character.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "h2");
            __builder.AddContent(17, 
#nullable restore
#line 19 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\Pages\Index.razor"
                         character.status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "src", 
#nullable restore
#line 20 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\Pages\Index.razor"
                               character.img

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\Pages\Index.razor"
                     foreach (var occupation in character.occupation)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "h3");
            __builder.AddContent(22, 
#nullable restore
#line 23 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\Pages\Index.razor"
                             occupation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\Pages\Index.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Tatyana\source\repos\BrBadApi\BrBadApi\Pages\Index.razor"
       
    string searchString = string.Empty;
    HttpRequestMessage requestMessage;
    HttpResponseMessage responseMessage;
    HttpClient htp;
    List<Character> displayCharacters => characters.Where(c => c.name.ToUpper().Contains(searchString.ToUpper())).ToList();
    List<Character> characters;

    protected override async Task OnInitializedAsync()
    {
        htp = new HttpClient();
        requestMessage = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(@"https://breakingbadapi.com/api/characters")
        };

        responseMessage = await htp.SendAsync(requestMessage);
        characters = JsonSerializer.Deserialize<List<Character>>(await responseMessage.Content.ReadAsStringAsync());
    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591