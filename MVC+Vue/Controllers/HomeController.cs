using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Vue.Models;
using SqlSugar;

namespace MVC_Vue.Controllers
{
    public class HomeController : Controller
    {
        private static SqlSugarClient db { get; set; }
        public HomeController()
        {

            db = new SqlSugarClient(
              new ConnectionConfig()
              {
                  ConnectionString = "DataSource=" + Path.Combine(Environment.CurrentDirectory, "WMBlog.db"),
                  DbType = DbType.Sqlite,
                  IsAutoCloseConnection = true,
                  InitKeyType = InitKeyType.Attribute
              }
          );

            //db.DbMaintenance.CreateDatabase();

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        [Route("/list")]
        public List<Question> Questions() => db.Queryable<Question>().ToList().OrderByDescending(d => d.CreateDate).ToList();

        [HttpPost]
        [Route("/add")]
        public MessageModel<string> Post([FromBody] Question question)
        {
            var data = new MessageModel<string>();

            question.CreateDate = DateTime.Now;

            var id = db.Insertable(question).ExecuteCommand();
            data.success = id > 0;
            if (data.success)
            {
                data.response = id.ObjToString();
                data.msg = "添加成功";
            }

            return data;
        }
    }
}
