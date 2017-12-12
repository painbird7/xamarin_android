using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using SQLite;
using System.Threading.Tasks;

namespace InclassOne
{
    public class ContactDatabase
    {
        readonly SQLiteAsyncConnection database;

        public ContactDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Contact>().Wait();
        }

        public Task<List<Contact>> GetContactsAsync()
        {
            //return database.Table<Contact>().ToListAsync();
            return database.QueryAsync<Contact>("SELECT * FROM ContactDB ORDER BY LastName");
               
        }

        public Task<Contact> GetContactAsync(int id)
        {
            return database.Table<Contact>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveContactAsync(Contact contact)
        {
            return database.InsertAsync(contact);   
        }

        public Task<int> DeleteContactAsync(Contact contact)
        {
            return database.DeleteAsync(contact);
        }

        public Task<int> UpdateContactAsync(Contact contact)
        {
            return database.UpdateAsync(contact);
        }

        public Task<int> UpdateContact(int id, string firstname, string lastname, string contacttype)
        {
            return database.ExecuteAsync("UPDATE ContactDB SET FirstName = ?, LastName = ?, ContactType = ? WHERE ID = ?", firstname, lastname, contacttype, id);                  
        }

    }
}
