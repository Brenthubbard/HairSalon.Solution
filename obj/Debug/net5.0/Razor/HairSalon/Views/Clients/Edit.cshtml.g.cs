#pragma checksum "C:\users\hubba\desktop\HairSalon.Solution\HairSalon\Views\Clients\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e4f4eec29e3a2f048adb47fd714bf6973c25269"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.HairSalon_Views_Clients_Edit), @"mvc.1.0.view", @"/HairSalon/Views/Clients/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e4f4eec29e3a2f048adb47fd714bf6973c25269", @"/HairSalon/Views/Clients/Edit.cshtml")]
    public class HairSalon_Views_Clients_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\users\hubba\desktop\HairSalon.Solution\HairSalon\Views\Clients\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Edit this Client: ");
#nullable restore
#line 9 "C:\users\hubba\desktop\HairSalon.Solution\HairSalon\Views\Clients\Edit.cshtml"
                 Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 11 "C:\users\hubba\desktop\HairSalon.Solution\HairSalon\Views\Clients\Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\users\hubba\desktop\HairSalon.Solution\HairSalon\Views\Clients\Edit.cshtml"
Write(Html.HiddenFor(model => model.ClientId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\users\hubba\desktop\HairSalon.Solution\HairSalon\Views\Clients\Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\users\hubba\desktop\HairSalon.Solution\HairSalon\Views\Clients\Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\users\hubba\desktop\HairSalon.Solution\HairSalon\Views\Clients\Edit.cshtml"
Write(Html.LabelFor(model => model.StylistId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\users\hubba\desktop\HairSalon.Solution\HairSalon\Views\Clients\Edit.cshtml"
Write(Html.DropDownList("StylistId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\r\n");
#nullable restore
#line 22 "C:\users\hubba\desktop\HairSalon.Solution\HairSalon\Views\Clients\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 24 "C:\users\hubba\desktop\HairSalon.Solution\HairSalon\Views\Clients\Edit.cshtml"
Write(Html.ActionLink("Back to Client list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
