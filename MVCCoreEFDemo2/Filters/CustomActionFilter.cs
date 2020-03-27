using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCoreEFDemo2.Models;

namespace MVCCoreEFDemo2.Filters
{
    public class CustomActionFilter : IActionFilter
    {
        private readonly BusinessDBContext _context;

        public CustomActionFilter(BusinessDBContext dbContext)
        {
            _context = dbContext;
        }

        private void ActionLogWriter(string methodName, Microsoft.AspNetCore.Routing.RouteData routeData)
        {
            var controller = routeData.Values["controller"];
            var action = routeData.Values["action"];
            var description = $"{methodName}- controller:{controller} action:{action}";

            ActionFilterEntry newEntry = new ActionFilterEntry();
            newEntry.Description = description + " -> " + DateTime.Now.ToString();

            _context.ActionFilterEntry.Add(newEntry);
            _context.SaveChanges(); 
            
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //throw new NotImplementedException();

            ActionLogWriter("OnActionExecuted ", context.RouteData);
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //throw new NotImplementedException();

            ActionLogWriter("OnActionExecuting ", context.RouteData);
            
        }

        /*ActionFilterEntry newEntry = new ActionFilterEntry();
        newEntry.Description = context.ActionDescriptor.ToString() + " OnActionExecuted "
                + DateTime.Now.ToString() + " - " //+ context.Controller.ToString() 
                + " : " + context.ActionDescriptor.DisplayName;
                //+ (context.ActionDescriptor.AttributeRouteInfo == null ?
                //"" : " Action Value ");
                //routeData.Values["controller"] + " : " + routeData.Values["action"];
            
            _context.ActionFilterEntry.Add(newEntry);
            _context.SaveChanges();*/

    }
}
