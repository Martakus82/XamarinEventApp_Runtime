using System.Collections.Generic;
using XamarinEventAppService.DataObjects;

namespace XamarinEventAppService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<XamarinEventAppService.Models.XamarinEventAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(XamarinEventAppService.Models.XamarinEventAppContext context)
        {
            //List<TodoItem> todoItems = new List<TodoItem>
            //{
            //    new TodoItem { Id = Guid.NewGuid().ToString(), Text = "First item", Complete = false },
            //    new TodoItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Complete = false },
            //};

            //foreach (TodoItem todoItem in todoItems)
            //{
            //    context.Set<TodoItem>().Add(todoItem);
            //}

            //base.Seed(context);
        }
    }
}
