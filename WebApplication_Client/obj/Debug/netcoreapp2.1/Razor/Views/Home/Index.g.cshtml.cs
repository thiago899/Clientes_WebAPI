#pragma checksum "C:\Users\thiag\source\repos\Clientes_WebAPI\WebApplication_Client\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "291871956204b0c8119e0c9dae018d63b70bacf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\thiag\source\repos\Clientes_WebAPI\WebApplication_Client\Views\_ViewImports.cshtml"
using WebApplication_Client;

#line default
#line hidden
#line 2 "C:\Users\thiag\source\repos\Clientes_WebAPI\WebApplication_Client\Views\_ViewImports.cshtml"
using WebApplication_Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"291871956204b0c8119e0c9dae018d63b70bacf7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ecb8546341d61e52c5231162e6ab63a059ca74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClientModelCon>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 222, true);
            WriteLiteral("\r\n<br/>\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <td>#</td>\r\n            <td>#</td>\r\n            <td>ID</td>\r\n            <td>NOME</td>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n\r\n");
            EndContext();
#line 17 "C:\Users\thiag\source\repos\Clientes_WebAPI\WebApplication_Client\Views\Home\Index.cshtml"
         foreach (var item in (List<ClientModelCon>)ViewBag.ListClients)
        {

#line default
#line hidden
            BeginContext(330, 89, true);
            WriteLiteral("            <tr>\r\n                <td style=\"width:80px;\"><button class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 419, "\"", 458, 3);
            WriteAttributeValue("", 429, "register(", 429, 9, true);
#line 20 "C:\Users\thiag\source\repos\Clientes_WebAPI\WebApplication_Client\Views\Home\Index.cshtml"
WriteAttributeValue("", 438, item.Id.ToString(), 438, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 457, ")", 457, 1, true);
            EndWriteAttribute();
            BeginContext(459, 93, true);
            WriteLiteral(">Editar</button></td>\r\n                <td style=\"width:80px;\"><button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 552, "\"", 589, 3);
            WriteAttributeValue("", 562, "delete(", 562, 7, true);
#line 21 "C:\Users\thiag\source\repos\Clientes_WebAPI\WebApplication_Client\Views\Home\Index.cshtml"
WriteAttributeValue("", 569, item.Id.ToString(), 569, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 588, ")", 588, 1, true);
            EndWriteAttribute();
            BeginContext(590, 44, true);
            WriteLiteral(">Excluir</button></td>\r\n                <td>");
            EndContext();
            BeginContext(635, 18, false);
#line 22 "C:\Users\thiag\source\repos\Clientes_WebAPI\WebApplication_Client\Views\Home\Index.cshtml"
               Write(item.Id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(653, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(681, 20, false);
#line 23 "C:\Users\thiag\source\repos\Clientes_WebAPI\WebApplication_Client\Views\Home\Index.cshtml"
               Write(item.Nome.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(701, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 25 "C:\Users\thiag\source\repos\Clientes_WebAPI\WebApplication_Client\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(738, 495, true);
            WriteLiteral(@"
    </tbody>

</table>

<button class=""btn btn-block btn-primary"" onclick=""register()"">Criar cliente</button>

<script>
    function register(id) {
        if (id == null) {
            id = """";
        }
        else {
            id = ""/"" + id;
        }
        window.location.href = window.location.origin + ""/Home/Register"" + id;
    }
        function delete(id) {
            window.location.href = window.location.origin + ""/Home/Delete"" + id;
        }
</script>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClientModelCon> Html { get; private set; }
    }
}
#pragma warning restore 1591
