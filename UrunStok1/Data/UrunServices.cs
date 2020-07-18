using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrunStok1.Data
{
    public class UrunServices
    {
        #region Private members
        private UrunDbContext dbContext;
        #endregion
        #region Constructor
        public UrunServices(UrunDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion
        #region Public methods
        
        public async Task<List<Urun>> GetUrunAsync()
        {
            return await dbContext.Urun.ToListAsync();
        }
        
        public async Task<Urun> AddUrunAsync(Urun urun)
        {
            try
            {
                dbContext.Urun.Add(urun);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return urun;
        }
        
        public async Task<Urun> UpdateUrunAsync(Urun urun)
        {
            try
            {
                var urunExist = dbContext.Urun.FirstOrDefault(p => p.Id == urun.Id);
                if (urunExist != null)
                {
                    dbContext.Update(urun);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return urun;
        }
       
        public async Task DeleteUrunAsync(Urun urun)
        {
            try
            {
                dbContext.Urun.Remove(urun);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
