using SMS_Sender.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Repository
{
    public class UnitOfWork : IDisposable
    {
        //public DatabaseContext context = new DatabaseContext();
        public SMSDBEntities context = new SMSDBEntities();

        private GenericRepository<User> User;
        //private GenericRepository<Course> Course;
        private GenericRepository<Customer> Customer;
        private GenericRepository<Category> Category;
        //private GenericRepository<CourseStudent> CourseStudent;

        //======================custom repository====================//
        private SPRepository spRepository;
        public SPRepository SPRepository
        {
            get
            {

                if (this.spRepository == null)
                {
                    this.spRepository = new SPRepository(context);
                }
                return spRepository;
            }
        }
        //====================end of custom repository==================//


        //======================custom repository====================//
        private CustomRepository customRepository;
        public CustomRepository CustomRepository
        {
            get
            {

                if (this.customRepository == null)
                {
                    this.customRepository = new CustomRepository(context);
                }
                return customRepository;
            }
        }
        //====================end of custom repository==================//


        //=====================Generic Repositories =====================//

        public GenericRepository<User> UserRepository
        {
            get
            {

                if (this.User == null)
                {
                    this.User = new GenericRepository<User>(context);
                }
                return User;
            }
        }

        public GenericRepository<Customer> CustomerRepository
        {
            get
            {

                if (this.Customer == null)
                {
                    this.Customer = new GenericRepository<Customer>(context);
                }
                return Customer;
            }
        }

        public GenericRepository<Category> CategoryRepository
        {
            get
            {

                if (this.Category == null)
                {
                    this.Category = new GenericRepository<Category>(context);
                }
                return Category;
            }
        }
        //==============================end===============================//



        public void Save()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable GetDataTable(string sqlSyntex)
        {
            try
            {
                DataTable dt = new DataTable();
                using (var conn = new SqlConnection(context.Database.Connection.ConnectionString))
                using (var cmd = new SqlCommand(sqlSyntex, conn))
                {
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }



    public static class Tools
    {
        public static void CopyClass(this Object Destination, object Source)
        {
            var srcT = Source.GetType();
            var dstT = Destination.GetType();
            foreach (var f in srcT.GetFields())
            {
                var dstF = dstT.GetField(f.Name);
                if (dstF == null)
                    continue;
                dstF.SetValue(Destination, f.GetValue(Source));
            }

            foreach (var f in srcT.GetProperties())
            {
                var dstF = dstT.GetProperty(f.Name);
                if (dstF == null)
                    continue;

                dstF.SetValue(Destination, f.GetValue(Source, null), null);
            }
        }

        public static List<Dictionary<string, object>> GetTableRows(this DataTable dtData)
        {
            List<Dictionary<string, object>>
            lstRows = new List<Dictionary<string, object>>();
            Dictionary<string, object> dictRow = null;

            foreach (DataRow dr in dtData.Rows)
            {
                dictRow = new Dictionary<string, object>();
                foreach (DataColumn col in dtData.Columns)
                {
                    dictRow.Add(col.ColumnName, dr[col]);
                }
                lstRows.Add(dictRow);
            }
            return lstRows;
        }

        //public static object DataTableToJSON(this DataTable table)
        //{
        //    string JSONresult;
        //    JSONresult = JsonConvert.SerializeObject(table);
        //    return JSONresult;
        //}
    }
}