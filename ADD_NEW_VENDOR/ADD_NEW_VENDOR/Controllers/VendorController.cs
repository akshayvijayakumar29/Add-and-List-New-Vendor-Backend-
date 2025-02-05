using Microsoft.AspNetCore.Mvc;
using Template.Application.Services;
using Template.Domain.Model;

namespace ADD_NEW_VENDOR.Controllers
{
    [ApiController]
    [Route("api/vendors")]
    public class VendorController : ControllerBase
    {
        public IVendorService _vendorService;

        public VendorController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }
        /// <summary>
        /// Api for GET vendors from databse
        /// </summary>
        /// <returns></returns>
        // GET: api/vendors
        [HttpGet]
        public async Task<ActionResult<List<Vendor>>> GetVendors()
        {
            return await _vendorService.GetAllVendorsAsync();
        }

        // POST: api/vendors
        /// <summary>
        ///  Specifies that the endpoint consumes JSON-formatted data for the request body.
        /// </summary>
        /// <remarks>
        /// for indicate the expected contend is in json format
        /// </remarks>
        /// <param name="vendor"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        public async Task<ActionResult<Vendor>> AddVendor([FromBody] Vendor vendor)
        {
            try
            {
                if (vendor == null)
                {
                    Console.WriteLine("Received null vendor");
                    return BadRequest("Vendor data is required");
                }

                Console.WriteLine($"Received Vendor: {vendor.VendorName}");

                var createdVendor = await _vendorService.AddVendorAsync(vendor);
                if (createdVendor == null)
                {
                    return StatusCode(500, "An error occurred while creating the vendor");
                }

                return CreatedAtAction(nameof(GetVendors), new { id = createdVendor.Id }, createdVendor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An unexpected error occurred.");
            }
        }

    }
}
