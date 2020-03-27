using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using MVCCoreEFDemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreEFDemo2.Filters
{
    public class CustomeFilterAttribute : ActionFilterAttribute
    {
        private readonly BusinessDBContext _context;

        public CustomeFilterAttribute()//BusinessDBContext dbContext)
        {
            _context = new BusinessDBContext();
                //= dbContext;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            ActionLogWriter("OnActionExecuted", context.RouteData);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ActionLogWriter("OnActionExecuting", context.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            ActionLogWriter("OnResultExecuted", context.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            ActionLogWriter("OnResultExecuting ", context.RouteData);
        }

        private void ActionLogWriter(string methodName, RouteData routeData)
        {
            var controller = routeData.Values["controller"];
            var action = routeData.Values["action"];
            var description = $"{methodName}- controller:{controller} action:{action}";

            ActionFilterEntry newEntry = new ActionFilterEntry();
            newEntry.Description = description + " -> " + DateTime.Now.ToString() + " from " + this.ToString();

            _context.ActionFilterEntry.Add(newEntry);
            _context.SaveChanges();
        }
    }
}
