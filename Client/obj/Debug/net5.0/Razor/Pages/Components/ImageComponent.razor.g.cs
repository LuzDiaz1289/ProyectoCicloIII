#pragma checksum "C:\ProyCicloIII\ProyPeliculasHD\Client\Pages\Components\ImageComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ce540ae69548a25f9036e53cfb5209467763047"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyPeliculasHD.Client.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProyCicloIII\ProyPeliculasHD\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProyCicloIII\ProyPeliculasHD\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProyCicloIII\ProyPeliculasHD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProyCicloIII\ProyPeliculasHD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProyCicloIII\ProyPeliculasHD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProyCicloIII\ProyPeliculasHD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProyCicloIII\ProyPeliculasHD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProyCicloIII\ProyPeliculasHD\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProyCicloIII\ProyPeliculasHD\Client\_Imports.razor"
using ProyPeliculasHD.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProyCicloIII\ProyPeliculasHD\Client\_Imports.razor"
using ProyPeliculasHD.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProyCicloIII\ProyPeliculasHD\Client\_Imports.razor"
using ProyPeliculasHD.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ProyCicloIII\ProyPeliculasHD\Client\_Imports.razor"
using ProyPeliculasHD.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\ProyCicloIII\ProyPeliculasHD\Client\_Imports.razor"
using ProyPeliculasHD.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    public partial class ImageComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "label");
            __builder.AddAttribute(2, "class", "form-label");
            __builder.AddContent(3, 
#nullable restore
#line 2 "C:\ProyCicloIII\ProyPeliculasHD\Client\Pages\Components\ImageComponent.razor"
                               Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(6);
            __builder.AddAttribute(7, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 5 "C:\ProyCicloIII\ProyPeliculasHD\Client\Pages\Components\ImageComponent.razor"
                             OnChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "accept", ".jpg,.png,.jpeg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
#nullable restore
#line 11 "C:\ProyCicloIII\ProyPeliculasHD\Client\Pages\Components\ImageComponent.razor"
         if (imageT !=  null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "style", "margin:10px");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", "data:image/jpeg;base64," + (
#nullable restore
#line 15 "C:\ProyCicloIII\ProyPeliculasHD\Client\Pages\Components\ImageComponent.razor"
                                                      imageT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "width", "300px");
            __builder.AddAttribute(17, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\ProyCicloIII\ProyPeliculasHD\Client\Pages\Components\ImageComponent.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\ProyCicloIII\ProyPeliculasHD\Client\Pages\Components\ImageComponent.razor"
         if (ImageURL !=  null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "margin:10px");
            __builder.OpenElement(21, "img");
            __builder.AddAttribute(22, "src", 
#nullable restore
#line 24 "C:\ProyCicloIII\ProyPeliculasHD\Client\Pages\Components\ImageComponent.razor"
                               ImageURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "width", "300px");
            __builder.AddAttribute(24, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\ProyCicloIII\ProyPeliculasHD\Client\Pages\Components\ImageComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\ProyCicloIII\ProyPeliculasHD\Client\Pages\Components\ImageComponent.razor"
       
    [Parameter] public string Label { get;set;} = "Imagen";
    [Parameter] public string ImageURL {get;set;}
    [Parameter] public EventCallback<string> ImageSelected {get;set;}


    private string imageT;
    async Task OnChange(InputFileChangeEventArgs e)
    {
        var images = e.GetMultipleFiles();
        foreach (var image in images)
        {
            var tamaño = new byte[image.Size];
            await image.OpenReadStream().ReadAsync(tamaño);
            imageT =Convert.ToBase64String(tamaño);
            ImageURL = null;
            await ImageSelected.InvokeAsync(imageT);
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
