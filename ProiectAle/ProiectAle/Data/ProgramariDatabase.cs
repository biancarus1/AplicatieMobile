using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProiectAle.Models;
using SQLite;


namespace ProiectAle.Data
{
    public class ProgramariDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public ProgramariDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Programari>().Wait();
        }
        public Task<List<Programari>> GetProgramariAsync()
        {
            return _database.Table<Programari>().ToListAsync();
        }
        public Task<Programari> GetProgramariAsync (int id)
        {
            return _database.Table<Programari>()
            .Where(i => i.ID == id)
            .FirstOrDefaultAsync();
        }
        public Task<int> SaveProgramariAsync(Programari plist)
        {
            if (plist.ID != 0)
            {
                return _database.UpdateAsync(plist);
            }
            else
            {
                return _database.InsertAsync(plist);
            }
        }
        public Task<int> DeleteProgramariAsync(Programari plist)
        {
            return _database.DeleteAsync(plist);
        }
    }
}
