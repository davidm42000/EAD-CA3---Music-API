#pragma checksum "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "882e69e5ceeb439964465b68e12231da97e60d52"
// <auto-generated/>
#pragma warning disable 1591
namespace EAD_CA3___Music_API.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\david\Downloads\EAD CA3 - Music API\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\Downloads\EAD CA3 - Music API\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david\Downloads\EAD CA3 - Music API\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david\Downloads\EAD CA3 - Music API\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\david\Downloads\EAD CA3 - Music API\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\david\Downloads\EAD CA3 - Music API\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\david\Downloads\EAD CA3 - Music API\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\david\Downloads\EAD CA3 - Music API\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\david\Downloads\EAD CA3 - Music API\_Imports.razor"
using EAD_CA3___Music_API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\david\Downloads\EAD CA3 - Music API\_Imports.razor"
using EAD_CA3___Music_API.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/search_artist")]
    public partial class SearchArtist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search Artist</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "input-group rounded");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "id", "artist_search");
            __builder.AddAttribute(5, "type", "search");
            __builder.AddAttribute(6, "class", "form-control rounded");
            __builder.AddAttribute(7, "placeholder", "Search");
            __builder.AddAttribute(8, "aria-label", "Search");
            __builder.AddAttribute(9, "aria-describedby", "search-addon");
            __builder.AddAttribute(10, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
                                                                             (e) => { CurrentValue=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
                                                   CurrentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentValue = __value, CurrentValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "id", "search-button");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "class", "btn btn-primary");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
                                                                               SearchClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "<i class=\"oi oi-magnifying-glass\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.OpenElement(21, "h1");
#nullable restore
#line 22 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
__builder.AddContent(22, CurrentValue);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenElement(24, "h2");
#nullable restore
#line 23 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
__builder.AddContent(25, errorMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
 if (allArtists2 == null)
{
}
else
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
     try
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
         for (int i = 0; i < allArtists2.Artists.Count(); i++)
        {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "img");
            __builder.AddAttribute(27, "style", "height: 10em");
            __builder.AddAttribute(28, "src", 
#nullable restore
#line 36 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
                                            allArtists2.Artists[i].strArtistWideThumb

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            <br>\r\n            ");
            __builder.OpenElement(30, "h3");
#nullable restore
#line 38 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
__builder.AddContent(31, allArtists2.Artists[i].strArtist);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
         

    }
    catch (Exception e)
    {
        developerErrorMessage = e.Message;
        Console.WriteLine(developerErrorMessage);
        errorMessage = "There is no Artist in our Database with that name, Please spell the artist correctly";

    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "input-group rounded");
            __builder.AddAttribute(34, "style", "width: 30em");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "id", "lyrics_search");
            __builder.AddAttribute(37, "type", "search");
            __builder.AddAttribute(38, "class", "form-control rounded");
            __builder.AddAttribute(39, "placeholder", "Search");
            __builder.AddAttribute(40, "aria-label", "Search");
            __builder.AddAttribute(41, "aria-describedby", "search-addon");
            __builder.AddAttribute(42, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
                                                                              (e) => { SongValue = (string)e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
                                                       SongValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SongValue = __value, SongValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "id", "search-button");
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "class", "btn btn-primary");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
                                                                                   SearchLyrics

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(51, "<i class=\"oi oi-magnifying-glass\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
     if (lyrics == null)
    {
    }
    else
    {
        try
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "p");
#nullable restore
#line 65 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
__builder.AddContent(53, lyrics);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"

        }
        catch (Exception e)
        {
            developerErrorMessage = e.Message;
            Console.WriteLine(developerErrorMessage);

        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\david\Downloads\EAD CA3 - Music API\Pages\SearchArtist.razor"
           
        private string developerErrorMessage = "Nothing";
        private string errorMessage = "Nothing";
        private string CurrentValue { get; set; } = "blazor";
        private string SongValue { get; set; } 


        public string? lyrics { get; set; }
        public string? artistName2 { get; set; } = "NO yo";


        public class Artist
        {
            public string idArtist { get; set; }
            public string strArtist { get; set; }
            public object strArtistStripped { get; set; }
            public string strArtistAlternate { get; set; }
            public string strLabel { get; set; }
            public string idLabel { get; set; }
            public string intFormedYear { get; set; }
            public string intBornYear { get; set; }
            public object intDiedYear { get; set; }
            public object strDisbanded { get; set; }
            public string strStyle { get; set; }
            public string strGenre { get; set; }
            public string strMood { get; set; }
            public string strWebsite { get; set; }
            public string strFacebook { get; set; }
            public string strTwitter { get; set; }
            public string strBiographyEN { get; set; }
            public string strBiographyDE { get; set; }
            public string strBiographyFR { get; set; }
            public string strBiographyCN { get; set; }
            public string strBiographyIT { get; set; }
            public string strBiographyJP { get; set; }
            public string strBiographyRU { get; set; }
            public string strBiographyES { get; set; }
            public string strBiographyPT { get; set; }
            public string strBiographySE { get; set; }
            public string strBiographyNL { get; set; }
            public string strBiographyHU { get; set; }
            public string strBiographyNO { get; set; }
            public string strBiographyIL { get; set; }
            public string strBiographyPL { get; set; }
            public string strGender { get; set; }
            public string intMembers { get; set; }
            public string strCountry { get; set; }
            public string strCountryCode { get; set; }
            public string strArtistThumb { get; set; }
            public string strArtistLogo { get; set; }
            public string strArtistClearart { get; set; }
            public string strArtistWideThumb { get; set; }
            public string strArtistFanart { get; set; }
            public string strArtistFanart2 { get; set; }
            public string strArtistFanart3 { get; set; }
            public string strArtistFanart4 { get; set; }
            public string strArtistBanner { get; set; }
            public string strMusicBrainzID { get; set; }
            public object strISNIcode { get; set; }
            public string strLastFMChart { get; set; }
            public string intCharted { get; set; }
            public string strLocked { get; set; }
        }

        public class AllArtists
        {
            public List<Artist> Artists { get; set; }
        }

        private AllArtists allArtists2;


        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Lyrics
        {
            public string? lyrics { get; set; }
        }

        public Lyrics? l1;

        // lifecycle method
        protected async Task SearchLyrics()
        {

            try
            {
                using var httpResponse = await Http.GetAsync("https://api.lyrics.ovh/v1/" + CurrentValue + "/" + SongValue);
                l1 = await httpResponse.Content.ReadFromJsonAsync<Lyrics>();
                lyrics = l1.lyrics;
            }
            catch (Exception e)
            {
                developerErrorMessage = e.Message;
            }

        }

        protected async Task SearchClick()
        {
            try
            {

                HttpResponseMessage response = await Http.GetAsync("https://theaudiodb.com/api/v1/json/2/search.php?s=" + CurrentValue);
                string dtls = await response.Content.ReadAsStringAsync();

                AllArtists allArtists = JsonConvert.DeserializeObject<AllArtists>(dtls);

                allArtists2 = allArtists;

                artistName2 = allArtists2.Artists[0].strArtist;




            }
            catch (Exception e)
            {
                developerErrorMessage = e.Message;
                Console.WriteLine(developerErrorMessage);
                errorMessage = "There is no Artist in our Database with that name, Please spell the artist correctly";

            }

        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
