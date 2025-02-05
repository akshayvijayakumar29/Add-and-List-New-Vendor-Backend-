using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Model;
using Template.infrastructure.Implementations.Repository;

namespace Template.Application.Services
{
    /// <summary>
    /// handles creation of new vendor
    /// </summary>
    public class VendorService : IVendorService
    {
        public  VendorRepository _vendorRepository;

        public VendorService(VendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        public async Task<List<Vendor>> GetAllVendorsAsync()
        {
            return await _vendorRepository.GetAllVendorsAsync();
        }

        public async Task<Vendor> AddVendorAsync(Vendor vendor)
        {
            try
            {
                return await _vendorRepository.AddVendorAsync(vendor);
            }
            catch (Exception ex)
            {
                // Log the exception if needed
                return null;
            }
        }
    }
}
