#pragma checksum "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51b8d81bbd6e9663eee77309fa3439f8c6f75ae4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_File_Index2), @"mvc.1.0.view", @"/Views/File/Index2.cshtml")]
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
#line 1 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\_ViewImports.cshtml"
using Gerenciador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\_ViewImports.cshtml"
using Gerenciador.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51b8d81bbd6e9663eee77309fa3439f8c6f75ae4", @"/Views/File/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7002d95b50b7ca68f55530e22221ac0918a563a9", @"/Views/_ViewImports.cshtml")]
    public class Views_File_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GERENCIADOR_TESTE_TEMPLANTE.Models.FileUploadViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "File", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadToDatabase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFileFromDatabase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Acceptcontent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""col-md-12"">
    <!-- jquery validation -->
    <div class=""card card-primary"">
        <div class=""card-header"">
            <h3 class=""card-title"">Envio de Arquivos Academicos</h3>
        </div>
        <!-- /.card-header -->
        <!-- form start -->
");
#nullable restore
#line 14 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
         if (TempData["Message1"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger alert-dismissible\" style=\"margin-top:20px\">\n        ");
#nullable restore
#line 17 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
   Write(TempData["Message1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>");
#nullable restore
#line 18 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 20 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
         if (TempData["Message"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible\" style=\"margin-top:20px\">\n        ");
#nullable restore
#line 23 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
   Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>");
#nullable restore
#line 24 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <hr />\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51b8d81bbd6e9663eee77309fa3439f8c6f75ae49807", async() => {
                WriteLiteral("\n\n            <div class=\"card card-primary\">\n                <div class=\"card-header\">\n                    <h3 class=\"card-title\">Envio de Arquivo</h3>\n                </div>\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51b8d81bbd6e9663eee77309fa3439f8c6f75ae410265", async() => {
                    WriteLiteral(@"
                    <div class=""card-body"">
                        <div class=""form-group"">
                            <label for=""exampleInputEmail1"">Integrantes do trabalho</label>
                            <input type=""text"" autocomplete=""off"" class=""form-control"" id=""description"" name=""description"" placeholder=""Separe por virgula exemplo: estevao, gabriel, jordhan"" required>
                        </div>

                        <div class=""form-group"">
                            <label for=""exampleInputFile"">Selecione o Arquivo</label>
                            <div class=""input-group"">
                                <div class=""custom-file"">
                                    <input type=""file"" name=""files"" multiple class=""custom-file-input"" required />
                                    <label class=""custom-file-label"" for=""exampleInputFile"">Escolher arquivo</label>
                                </div>
                                <div class=""input-group-append"">
                      ");
                    WriteLiteral("              <span class=\"input-group-text\">Upload</span>\n                                </div>\n                            </div>\n                        </div>\n\n                        <div class=\"card-footer\">\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51b8d81bbd6e9663eee77309fa3439f8c6f75ae411883", async() => {
                        WriteLiteral("Enviar Publico");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                        </div>\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 61 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
         if (SignInManager.IsSignedIn(User))
        {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
     if (User.IsInRole("Administrador"))
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
     if (Model.FilesOnDatabase.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <caption>No Records Found</caption> ");
#nullable restore
#line 67 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
                                        }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <caption>List of Files on Database</caption>
                            <table  id=""example1"" class=""table table-bordered table-striped"">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Arquivo</th>
                                        <th>Integrantes</th>
                                        <th>Tipo Arquivo</th>
                                        <th>Criado</th>
                                        <th>Ações</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 83 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
                                     foreach (var file in Model.FilesOnDatabase)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th>");
#nullable restore
#line 86 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
               Write(file.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <td>");
#nullable restore
#line 87 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
               Write(file.NomeArquivo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 88 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
               Write(file.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 89 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
               Write(file.TipoArquivo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 90 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
               Write(file.DataCriacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51b8d81bbd6e9663eee77309fa3439f8c6f75ae419183", async() => {
                WriteLiteral("Download");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
                                                                                                           WriteLiteral(file.Id);

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
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51b8d81bbd6e9663eee77309fa3439f8c6f75ae421784", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
                                                                                                                        WriteLiteral(file.Id);

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
            WriteLiteral("\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51b8d81bbd6e9663eee77309fa3439f8c6f75ae424396", async() => {
                WriteLiteral("\n                        <span");
                BeginWriteAttribute("id", " id=\"", 4189, "\"", 4221, 2);
                WriteAttributeValue("", 4194, "confirmaDeleteSpan_", 4194, 19, true);
#nullable restore
#line 95 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
WriteAttributeValue("", 4213, file.Id, 4213, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display:none\">\n                            <span>Confirma a aprovação deste arquivo ?</span>\n                            <button type=\"submit\" class=\"btn btn-success\">Sim</button>\n                            <a href=\"#\" class=\"btn btn-primary\"");
                BeginWriteAttribute("onclick", "\n                               onclick=\"", 4473, "\"", 4547, 4);
                WriteAttributeValue("", 4514, "confirmaDelete(\'", 4514, 16, true);
#nullable restore
#line 99 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
WriteAttributeValue("", 4530, file.Id, 4530, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4538, "\',", 4538, 2, true);
                WriteAttributeValue(" ", 4540, "false)", 4541, 7, true);
                EndWriteAttribute();
                WriteLiteral(">Não</a>\n                        </span>\n                        <span");
                BeginWriteAttribute("id", " id=\"", 4618, "\"", 4642, 2);
                WriteAttributeValue("", 4623, "deleteSpan_", 4623, 11, true);
#nullable restore
#line 101 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
WriteAttributeValue("", 4634, file.Id, 4634, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                            <a href=\"#\" class=\"btn btn-warning\"");
                BeginWriteAttribute("onclick", "\n                               onclick=\"", 4708, "\"", 4781, 4);
                WriteAttributeValue("", 4749, "confirmaDelete(\'", 4749, 16, true);
#nullable restore
#line 103 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
WriteAttributeValue("", 4765, file.Id, 4765, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4773, "\',", 4773, 2, true);
                WriteAttributeValue(" ", 4775, "true)", 4776, 6, true);
                EndWriteAttribute();
                WriteLiteral(">Aprovar</a>\n                        </span>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
                                                                     WriteLiteral(file.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n            </tr>");
#nullable restore
#line 107 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\n                            </table>");
#nullable restore
#line 109 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
                                     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\estev\Desktop\TCC\TCC_BASE_TESTE_WEB\Views\File\Index2.cshtml"
                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n        <!-- /.card -->\n    </div>\n\n\n\n\n\n\n\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51b8d81bbd6e9663eee77309fa3439f8c6f75ae430765", async() => {
                    WriteLiteral("$(function () {\n  bsCustomFileInput.init();\n});");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <script>\n        $(document).ready(function () {\n            $(\'#table_id\').DataTable();\n        });\n    </script>\n\n\n");
            }
            );
            WriteLiteral("\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GERENCIADOR_TESTE_TEMPLANTE.Models.FileUploadViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
