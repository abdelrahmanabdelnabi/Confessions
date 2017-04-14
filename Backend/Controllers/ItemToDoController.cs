using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using Backend.DataObjects;
using Backend.Models;

namespace Backend.Controllers
{
    public class ExampleController : TableController<ItemTodo>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<ItemTodo>(context, Request, enableSoftDelete: true);
        }

        // GET tables/Example
        public IQueryable<ItemTodo> GetAllExample()
        {
            return Query();
        }

        // GET tables/Example/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ItemTodo> GetExample(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Example/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ItemTodo> PatchExample(string id, Delta<ItemTodo> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Example
        public async Task<IHttpActionResult> PostExample(ItemTodo item)
        {
            ItemTodo current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Example/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteExample(string id)
        {
            return DeleteAsync(id);
        }
    }
}