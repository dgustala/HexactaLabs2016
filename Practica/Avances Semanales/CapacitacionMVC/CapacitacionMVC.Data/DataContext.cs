﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CapacitacionMVC.Data.Migrations;
using CapacitacionMVC.Entities;

namespace CapacitacionMVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {
            Database.SetInitializer<DataContext>(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }

        public IDbSet<Genre> Genres { get; set; }
        public IDbSet<Movie> Movies { get; set; }

    }
}
