#pragma checksum "C:\Users\thiag\source\repos\Clientes_WebAPI\WebApplication_Client\Views\Home\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b58613ed2e8842b4e249c8b20d5f47fa17341596"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Delete), @"mvc.1.0.view", @"/Views/Home/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Delete.cshtml", typeof(AspNetCore.Views_Home_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b58613ed2e8842b4e249c8b20d5f47fa17341596", @"/Views/Home/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ecb8546341d61e52c5231162e6ab63a059ca74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 498, true);
            WriteLiteral(@"<h2>Excluir cliente</h2>

<h3>Deseja realmente excluir o cliente selecionado?</h3>

<button class=""btn btn-danger"" onclick=""Delete(1);"">Sim</button>
<button class=""btn btn-primary"" onclick=""Delete(0);"">Não</button>

<script>
    function Delete(id)
    {
        if (id == 0)
        {
            window.location.href = window.location.origin + ""/Home/Index"" + id;
        }
        else
        {
            window.location.href = window.location.origin + ""/Home/DelCustomer"" + '");
            EndContext();
            BeginContext(499, 21, false);
#line 17 "C:\Users\thiag\source\repos\Clientes_WebAPI\WebApplication_Client\Views\Home\Delete.cshtml"
                                                                              Write(ViewData["ClienteID"]);

#line default
#line hidden
            EndContext();
            BeginContext(520, 31, true);
            WriteLiteral("\';\r\n        }\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
