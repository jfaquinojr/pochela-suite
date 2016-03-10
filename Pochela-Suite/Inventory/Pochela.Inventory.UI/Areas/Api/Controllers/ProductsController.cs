using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using Pochela.Inventory.Entities;
using Microsoft.Data.OData;
using Pochela.Inventory.Facade;

namespace Pochela.Inventory.UI.Areas.Api.Controllers
{

	public class ProductsController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/Products
        public IHttpActionResult GetProducts(ODataQueryOptions<Product> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);

				// Get a list of products from a database.
				IEnumerable<Product> products = new InventoryService().SearchProducts("");

				// Write the list to the response body.
				//HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, products);
				return Ok(products);

			}
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<IEnumerable<Product>>(products);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // GET: odata/Products(5)
        public IHttpActionResult GetProduct([FromODataUri] string key, ODataQueryOptions<Product> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<Product>(product);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/Products(5)
        public IHttpActionResult Put([FromODataUri] string key, Delta<Product> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(product);

            // TODO: Save the patched entity.

            // return Updated(product);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/Products
        public IHttpActionResult Post(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(product);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/Products(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] string key, Delta<Product> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(product);

            // TODO: Save the patched entity.

            // return Updated(product);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/Products(5)
        public IHttpActionResult Delete([FromODataUri] string key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}
