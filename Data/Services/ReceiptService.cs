using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QReceipts.Data.Services
{
    public class ReceiptService
    {
        private ApplicationContext _context;

        public ReceiptService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Receipt>> GetReceipts()
        {
            return await _context.Receipts.Include(x=>x.ReceiptItems).ToListAsync();
        }

        public async Task<Receipt> GetReceiptById(int id)
        {
            return await _context.Receipts
                .Include(x=>x.ReceiptItems)
                .SingleOrDefaultAsync(x=>x.Id == id);
        }

        public async Task<(int code,string message)> CreateReceipt(Receipt receipt)
        {
            await _context.Receipts.AddAsync(receipt);
            var res = await _context.SaveChangesAsync();
            if (res > 0)
                return (0, "Save Successful");

            return (499, "Save failded");
        }

        public async Task<(int code,string message)> UpdateReceipt(Receipt receipt)
        {
            _context .Receipts.Update(receipt);
            var res = await _context.SaveChangesAsync();

            if (res > 0)
                return (0, "Update Successful");

            return (499,"Update failded");
        }
        
        public async Task<(int code, string message)> DeleteReceipt(Receipt receipt)
        {
            _context .Receipts.Remove(receipt);
            var res = await _context.SaveChangesAsync();
            if (res > 0)
                return (0,"Delete Successful");

            return (499, "Delete failed");
        }


    }
}
