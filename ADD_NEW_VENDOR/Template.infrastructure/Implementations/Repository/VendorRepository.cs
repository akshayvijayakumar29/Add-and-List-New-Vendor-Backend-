using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Template.Domain.Model;
using Template.infrastructure.Implementations.Data;

namespace Template.infrastructure.Implementations.Repository
{
    public class VendorRepository
    {
        private readonly ApplicationDbContext _context;

        public VendorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Vendor>> GetAllVendorsAsync()
        {
            try
            {
                return await _context.Vendors.ToListAsync();
            }
            catch (Exception ex)
            {
              
                Console.WriteLine($"Error retrieving vendors: {ex.Message}");
                return new List<Vendor>();
            }
        }

        public async Task<Vendor> AddVendorAsync(Vendor vendor)
        {
            try
            {
                _context.Vendors.Add(vendor);
                await _context.SaveChangesAsync();
                return vendor;
            }
            catch (Exception ex)
            {
                // exception
                Console.WriteLine($"Error adding vendor: {ex.Message}");
                return null;
            }
        }
    }
}
