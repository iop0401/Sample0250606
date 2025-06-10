using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppSample0250606.Models
{
    //public class EstateModels
    //{
    //}

    [Table("Asset")]
    public class Asset
    {
        public int AssetID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Desc { get; set; }
        public string Image {  get; set; }
    }

    [Table("User")]
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Priorty { get; set; }
    }

    //public class Log
    //{

    //}


    public class EstateDBContext : DbContext
    {
        public DbSet<Asset> Assets { get; set; }
        public DbSet<User> Users { get; set; }

    }
}