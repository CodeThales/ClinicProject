#pragma checksum "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c1b97cdba873c1222e4758a8292843acc9f6cdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paciente_Index), @"mvc.1.0.view", @"/Views/Paciente/Index.cshtml")]
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
#nullable restore
#line 1 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\_ViewImports.cshtml"
using Consultorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\_ViewImports.cshtml"
using Consultorio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c1b97cdba873c1222e4758a8292843acc9f6cdd", @"/Views/Paciente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e61303434de2871114bc9584fe1dcbe96b867c11", @"/Views/_ViewImports.cshtml")]
    public class Views_Paciente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Paciente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "sql", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "static", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Paciente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Read", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Confirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
  
    var service = ViewBag.selectedService;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"mb-4 mt-2\">Lista de pacientes</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c1b97cdba873c1222e4758a8292843acc9f6cdd7784", async() => {
                WriteLiteral("\r\n    <div class=\"col col-md-4\">\r\n        <input type=\"text\" class=\"form-control mt-2 mb-3\" name=\"busca\" placeholder=\"Pesquisar...\" />\r\n\r\n        <select name=\"service\" class=\"form-control\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c1b97cdba873c1222e4758a8292843acc9f6cdd8266", async() => {
                    WriteLiteral("Dados SQL");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c1b97cdba873c1222e4758a8292843acc9f6cdd9827", async() => {
                    WriteLiteral("Dados Estáticos");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </select>\r\n        <br />\r\n        <button type=\"submit\" class=\"btn btn-info mb-4\">Buscar!</button>\r\n");
#nullable restore
#line 21 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
         if (ViewBag.ordenar == true)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c1b97cdba873c1222e4758a8292843acc9f6cdd11501", async() => {
                    WriteLiteral("Remover ordenação!");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 24 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\"", 850, "\"", 887, 2);
                WriteAttributeValue("", 857, "?ordenar=true&service=", 857, 22, true);
#nullable restore
#line 27 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
WriteAttributeValue("", 879, service, 879, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info mr-0 mb-4\">Ordenar!</a>\r\n");
#nullable restore
#line 28 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
         if (SignInManager.IsSignedIn(User))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c1b97cdba873c1222e4758a8292843acc9f6cdd14267", async() => {
                    WriteLiteral("Adicionar Paciente!");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 32 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 36 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
 if (TempData["Adicionado"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        <p>");
#nullable restore
#line 39 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
      Write(TempData["Adicionado"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 41 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 43 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
 if (TempData["Excluido"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        <p>");
#nullable restore
#line 46 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
      Write(TempData["Excluido"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 48 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 50 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
 if (TempData["Atualizado"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info\" role=\"alert\">\r\n        <p>");
#nullable restore
#line 53 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
      Write(TempData["Atualizado"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 55 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 59 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.First().Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 60 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.First().Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 61 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.First().Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>Ações</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 66 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
         foreach (Paciente paciente in Model)
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
             if (ViewBag.source == "static")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td> ");
#nullable restore
#line 70 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
                    Write(Html.DisplayFor(Model => paciente.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 71 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
                    Write(Html.DisplayFor(Model => paciente.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 72 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
                    Write(Html.DisplayFor(Model => paciente.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>\r\n                        <p>Ações INDISPONÍVEIS para o método estático</p>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 77 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
            }
            else if (ViewBag.source == "sql")
            {
                var classe = paciente.Consultas.Count > 0 ? "text-info" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=\"", 2607, "\"", 2622, 1);
#nullable restore
#line 81 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
WriteAttributeValue("", 2615, classe, 2615, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td> ");
#nullable restore
#line 82 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
                    Write(Html.DisplayFor(Model => paciente.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 83 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
                    Write(Html.DisplayFor(Model => paciente.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 84 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
                    Write(Html.DisplayFor(Model => paciente.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c1b97cdba873c1222e4758a8292843acc9f6cdd25047", async() => {
                WriteLiteral("Visualizar |");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
                                                                         WriteLiteral(paciente.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c1b97cdba873c1222e4758a8292843acc9f6cdd27536", async() => {
                WriteLiteral(" Atualizar |");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
                                                                           WriteLiteral(paciente.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c1b97cdba873c1222e4758a8292843acc9f6cdd30027", async() => {
                WriteLiteral(" Deletar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
                                                                            WriteLiteral(paciente.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 91 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 03 - BackEnd\ClinicProject\Consultorio\Views\Paciente\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <br />\r\n    <span>***Pacientes marcados em azul possuem consultas agendadas***</span>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Paciente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
