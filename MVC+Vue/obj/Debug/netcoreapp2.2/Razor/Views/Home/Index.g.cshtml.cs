#pragma checksum "C:\Users\v-anzha\Documents\Tencent Files\3143422472\FileRecv\MVC+Vue\MVC+Vue\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f4cfaf33a5af3d89e800601c82763560e41f747"
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
#line 1 "C:\Users\v-anzha\Documents\Tencent Files\3143422472\FileRecv\MVC+Vue\MVC+Vue\Views\_ViewImports.cshtml"
using MVC_Vue;

#line default
#line hidden
#line 2 "C:\Users\v-anzha\Documents\Tencent Files\3143422472\FileRecv\MVC+Vue\MVC+Vue\Views\_ViewImports.cshtml"
using MVC_Vue.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f4cfaf33a5af3d89e800601c82763560e41f747", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d8ab2d29fa05a835dd49a6d331fde5b52fa98db", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\v-anzha\Documents\Tencent Files\3143422472\FileRecv\MVC+Vue\MVC+Vue\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = null;

#line default
#line hidden
            BeginContext(65, 264, true);
            WriteLiteral(@"

<section class=""todoapp"">
    <header class=""header"">
        <h1>todos</h1>
        <input class=""new-todo""
               autofocus autocomplete=""off""
               placeholder=""What needs to be done?""
               v-model=""newTodo""
               ");
            EndContext();
            BeginContext(330, 120, true);
            WriteLiteral("@keyup.enter=\"addTodo\">\r\n        <script src=\"http://static.runoob.com/assets/vue/1.0.11/vue.min.js\"></script>\r\n        ");
            EndContext();
            BeginContext(450, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f4cfaf33a5af3d89e800601c82763560e41f7474667", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(498, 578, true);
            WriteLiteral(@"
    </header>
    <section class=""main"" v-show=""todos.length"" v-cloak>
        <input id=""toggle-all"" class=""toggle-all"" type=""checkbox"" v-model=""allDone"">
        <label for=""toggle-all""></label>
        <ul class=""todo-list"">
            <li v-for=""todo in filteredTodos""
                class=""todo""
                :key=""todo.id""
                :class=""{ completed: todo.completed, editing: todo == editedTodo }"">
                <div class=""view"">
                    <input class=""toggle"" type=""checkbox"" v-model=""todo.completed"">
                    <label ");
            EndContext();
            BeginContext(1077, 97, true);
            WriteLiteral("@dblclick=\"editTodo(todo)\">{{ todo.title }}</label>\r\n                    <button class=\"destroy\" ");
            EndContext();
            BeginContext(1175, 178, true);
            WriteLiteral("@click=\"removeTodo(todo)\"></button>\r\n                </div>\r\n                <input class=\"edit\" type=\"text\"\r\n                       v-model=\"todo.title\"\r\n                       ");
            EndContext();
            BeginContext(1354, 47, true);
            WriteLiteral("@blur=\"doneEdit(todo)\"\r\n                       ");
            EndContext();
            BeginContext(1402, 54, true);
            WriteLiteral("@keyup.enter=\"doneEdit(todo)\"\r\n                       ");
            EndContext();
            BeginContext(1457, 651, true);
            WriteLiteral(@"@keyup.esc=""cancelEdit(todo)"">
            </li>
        </ul>
    </section>
    <footer class=""footer"" v-show=""todos.length"" v-cloak>
        <span class=""todo-count"">
            <strong>{{ remaining }}</strong> {{ remaining | pluralize }} left
        </span>
        <ul class=""filters"">
            <li><a href=""#/all"" :class=""{ selected: visibility == 'all' }"">All</a></li>
            <li><a href=""#/active"" :class=""{ selected: visibility == 'active' }"">Active</a></li>
            <li><a href=""#/completed"" :class=""{ selected: visibility == 'completed' }"">Completed</a></li>
        </ul>
        <button class=""clear-completed"" ");
            EndContext();
            BeginContext(2109, 4880, true);
            WriteLiteral(@"@click=""removeCompleted"" v-show=""todos.length > remaining"">
            Clear completed
        </button>
    </footer>
</section>
<footer class=""info"">
    <p>Double-click to edit a todo</p>
   
</footer>
<script>

    // Full spec-compliant TodoMVC with localStorage persistence
    // and hash-based routing in ~120 effective lines of JavaScript.

    // localStorage persistence
    var STORAGE_KEY = 'todos-vuejs-2.0'
    var todoStorage = {
        fetch: function () {
            var todos = JSON.parse(localStorage.getItem(STORAGE_KEY) || '[]')
            todos.forEach(function (todo, index) {
                todo.id = index
            })
            todoStorage.uid = todos.length
            return todos
        },
        save: function (todos) {
            localStorage.setItem(STORAGE_KEY, JSON.stringify(todos))
        }
    }

    // visibility filters
    var filters = {
        all: function (todos) {
            return todos
        },
        active: function ");
            WriteLiteral(@"(todos) {
            return todos.filter(function (todo) {
                return !todo.completed
            })
        },
        completed: function (todos) {
            return todos.filter(function (todo) {
                return todo.completed
            })
        }
    }

    // app Vue instance
    var app = new Vue({
        // app initial state
        data: {
            todos: todoStorage.fetch(),
            newTodo: '',
            editedTodo: null,
            visibility: 'all'
        },

        // watch todos change for localStorage persistence
        watch: {
            todos: {
                handler: function (todos) {
                    todoStorage.save(todos)
                },
                deep: true
            }
        },

        // computed properties
        // http://vuejs.org/guide/computed.html
        computed: {
            filteredTodos: function () {
                return filters[this.visibility](this.todos)
            },
 ");
            WriteLiteral(@"           remaining: function () {
                return filters.active(this.todos).length
            },
            allDone: {
                get: function () {
                    return this.remaining === 0
                },
                set: function (value) {
                    this.todos.forEach(function (todo) {
                        todo.completed = value
                    })
                }
            }
        },

        filters: {
            pluralize: function (n) {
                return n === 1 ? 'item' : 'items'
            }
        },

        // methods that implement data logic.
        // note there's no DOM manipulation here at all.
        methods: {
            addTodo: function () {
                var value = this.newTodo && this.newTodo.trim()
                if (!value) {
                    return
                }
                this.todos.push({
                    id: todoStorage.uid++,
                    title: value,
        ");
            WriteLiteral(@"            completed: false
                })
                this.newTodo = ''
            },

            removeTodo: function (todo) {
                this.todos.splice(this.todos.indexOf(todo), 1)
            },

            editTodo: function (todo) {
                this.beforeEditCache = todo.title
                this.editedTodo = todo
            },

            doneEdit: function (todo) {
                if (!this.editedTodo) {
                    return
                }
                this.editedTodo = null
                todo.title = todo.title.trim()
                if (!todo.title) {
                    this.removeTodo(todo)
                }
            },

            cancelEdit: function (todo) {
                this.editedTodo = null
                todo.title = this.beforeEditCache
            },

            removeCompleted: function () {
                this.todos = filters.active(this.todos)
            }
        },

        // a custom directive t");
            WriteLiteral(@"o wait for the DOM to be updated
        // before focusing on the input field.
        // http://vuejs.org/guide/custom-directive.html
        directives: {
            'todo-focus': function (el, binding) {
                if (binding.value) {
                    el.focus()
                }
            }
        }
    })

    // handle routing
    function onHashChange() {
        var visibility = window.location.hash.replace(/#\/?/, '')
        if (filters[visibility]) {
            app.visibility = visibility
        } else {
            window.location.hash = ''
            app.visibility = 'all'
        }
    }

    window.addEventListener('hashchange', onHashChange)
    onHashChange()

    // mount
    app.$mount('.todoapp')


</script>");
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
