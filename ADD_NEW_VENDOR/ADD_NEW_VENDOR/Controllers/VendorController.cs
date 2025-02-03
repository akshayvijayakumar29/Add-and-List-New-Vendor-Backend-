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

        // GET: api/vendors
        [HttpGet]
        public async Task<ActionResult<List<Vendor>>> GetVendors()
        {
            return await _vendorService.GetAllVendorsAsync();
        }

        // POST: api/vendors
        [HttpPost]
        public async Task<ActionResult<Vendor>> AddVendor([FromBody] Vendor vendor)
        {
            var createdVendor = await _vendorService.AddVendorAsync(vendor);
            return CreatedAtAction(nameof(GetVendors), new { id = createdVendor.Id }, createdVendor);
        }
    }
}
