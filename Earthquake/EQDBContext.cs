using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earthquake
{
    public class EQDBContext : DbContext
    {
        public DbSet<eq2000> eq2000 { get; set; }
        public DbSet<eq2001> eq2001 { get; set; }
        public DbSet<eq2002> eq2002 { get; set; }
        public DbSet<eq2003> eq2003 { get; set; }
        public DbSet<eq2004> eq2004 { get; set; }
        public DbSet<eq2005> eq2005 { get; set; }
        public DbSet<eq2006> eq2006 { get; set; }
        public DbSet<eq2007> eq2007 { get; set; }
        public DbSet<eq2008> eq2008 { get; set; }
        public DbSet<eq2009> eq2009 { get; set; }
        public DbSet<eq2010> eq2010 { get; set; }
        public DbSet<eq2011> eq2011 { get; set; }
        public DbSet<eq2012> eq2012 { get; set; }
        public DbSet<eq2013> eq2013 { get; set; }
        public DbSet<eq2014> eq2014 { get; set; }
        public DbSet<eq2015> eq2015 { get; set; }
        public DbSet<eq2016> eq2016 { get; set; }
        public DbSet<eq2017> eq2017 { get; set; }
        public DbSet<eq2018> eq2018 { get; set; }
        public DbSet<eq2019> eq2019 { get; set; }
        public DbSet<eq2020> eq2020 { get; set; }
        public DbSet<eq2021> eq2021 { get; set; }
        public DbSet<eq2022> eq2022 { get; set; }
        public DbSet<eq2023> eq2023 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=1891999Spicy;Port=5432;");
        }
    }

    public class EntityBase
    {
        public DateTime Time { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal Depth { get; set; }
        public decimal Mag { get; set; }
        public string MagType { get; set; }
        public int Nst { get; set; }
        public decimal Gap { get; set; }
        public decimal Dmin { get; set; }
        public decimal Rms { get; set; }
        public string Net { get; set; }
        public string Id { get; set; }
        public string Updated { get; set; }
        public string Place { get; set; }
        public string Type { get; set; }
        public decimal? HorizontalError { get; set; }
        public decimal DepthError { get; set; }
        public decimal? MagError { get; set; }
        public int? MagNst { get; set; }
        public string Status { get; set; }
        public string LocationSource { get; set; }
        public string MagSource { get; set; }
    }

    public class eq2000 : EntityBase { }
    public class eq2001 : EntityBase { }
    public class eq2002 : EntityBase { }
    public class eq2003 : EntityBase { }
    public class eq2004 : EntityBase { }
    public class eq2005 : EntityBase { }
    public class eq2006 : EntityBase { }
    public class eq2007 : EntityBase { }
    public class eq2008 : EntityBase { }
    public class eq2009 : EntityBase { }
    public class eq2010 : EntityBase { }
    public class eq2011 : EntityBase { }
    public class eq2012 : EntityBase { }
    public class eq2013 : EntityBase { }
    public class eq2014 : EntityBase { }
    public class eq2015 : EntityBase { }
    public class eq2016 : EntityBase { }
    public class eq2017 : EntityBase { }
    public class eq2018 : EntityBase { }
    public class eq2019 : EntityBase { }
    public class eq2020 : EntityBase { }
    public class eq2021 : EntityBase { }
    public class eq2022 : EntityBase { }
    public class eq2023 : EntityBase { }
}
