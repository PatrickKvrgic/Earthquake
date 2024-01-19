using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using Earthquake;
using Microsoft.EntityFrameworkCore;

partial class Program
{
    static void Main()
    {
        // Ask the user to input filter criteria
        Console.Write("Enter the filter criteria (year, month, place; comma-separated): ");
        string userInput = Console.ReadLine();

        // Parse the input and extract filter values
        string[] filterCriteria = userInput.Split(',');

        // Use filter values to construct the query
        using (var dbContext = new EQDBContext())
        {
            var allTablesQuery = ConcatTables(dbContext, dbContext.eq2000)
                .Concat(ConcatTables(dbContext, dbContext.eq2001))
                .Concat(ConcatTables(dbContext, dbContext.eq2002))
                .Concat(ConcatTables(dbContext, dbContext.eq2003))
                .Concat(ConcatTables(dbContext, dbContext.eq2004))
                .Concat(ConcatTables(dbContext, dbContext.eq2005))
                .Concat(ConcatTables(dbContext, dbContext.eq2006))
                .Concat(ConcatTables(dbContext, dbContext.eq2007))
                .Concat(ConcatTables(dbContext, dbContext.eq2008))
                .Concat(ConcatTables(dbContext, dbContext.eq2009))
                .Concat(ConcatTables(dbContext, dbContext.eq2010))
                .Concat(ConcatTables(dbContext, dbContext.eq2011))
                .Concat(ConcatTables(dbContext, dbContext.eq2012))
                .Concat(ConcatTables(dbContext, dbContext.eq2013))
                .Concat(ConcatTables(dbContext, dbContext.eq2014))
                .Concat(ConcatTables(dbContext, dbContext.eq2015))
                .Concat(ConcatTables(dbContext, dbContext.eq2016))
                .Concat(ConcatTables(dbContext, dbContext.eq2017))
                .Concat(ConcatTables(dbContext, dbContext.eq2018))
                .Concat(ConcatTables(dbContext, dbContext.eq2019))
                .Concat(ConcatTables(dbContext, dbContext.eq2020))
                .Concat(ConcatTables(dbContext, dbContext.eq2021))
                .Concat(ConcatTables(dbContext, dbContext.eq2022))
                .Concat(ConcatTables(dbContext, dbContext.eq2023))
                .AsQueryable();

            // Apply filters based on user input
            if (filterCriteria.Length > 0 && !string.IsNullOrWhiteSpace(filterCriteria[0]))
            {
                int? selectedYear = TryParseInt(filterCriteria.ElementAtOrDefault(0));
                if (selectedYear.HasValue)
                {
                    allTablesQuery = allTablesQuery.Where(e => e.Time.Year == selectedYear);
                }
            }

            if (filterCriteria.Length > 1 && !string.IsNullOrWhiteSpace(filterCriteria[1]))
            {
                int? selectedMonth = TryParseInt(filterCriteria.ElementAtOrDefault(1));
                if (selectedMonth.HasValue)
                {
                    allTablesQuery = allTablesQuery.Where(e => e.Time.Month == selectedMonth);
                }
            }

            if (filterCriteria.Length > 2 && !string.IsNullOrWhiteSpace(filterCriteria[2]))
            {
                string selectedLocation = filterCriteria.ElementAtOrDefault(2)?.Trim();
                if (!string.IsNullOrEmpty(selectedLocation))
                {
                    allTablesQuery = allTablesQuery.Where(e => e.LocationSource.Contains(selectedLocation));
                }
            }

            // Execute the query and display results
            var result = allTablesQuery.ToList();
            DisplayResults(result);
        }
    }

    static IQueryable<EntityBase> ConcatTables<T>(EQDBContext dbContext, DbSet<T> table) where T : EntityBase
    {
        var entityProperties = typeof(T).GetProperties();

        return table
        .AsQueryable()
        .Select(entity => new EntityBase
        {
            Time = entity.Time,
            Latitude = entity.Latitude,
            Longitude = entity.Longitude,
            Depth = entity.Depth,
            Mag = entity.Mag,
            MagType = entity.MagType,
            Nst = entity.Nst,
            Gap = entity.Gap,
            Dmin = entity.Dmin,
            Rms = entity.Rms,
            Net = entity.Net,
            Id = entity.Id,
            Updated = entity.Updated,
            Place = entity.Place,
            Type = entity.Type,
            HorizontalError = entity.HorizontalError,
            DepthError = entity.DepthError,
            MagError = entity.MagError,
            MagNst = entity.MagNst,
            Status = entity.Status,
            LocationSource = entity.LocationSource,
            MagSource = entity.MagSource
        });
    }

    private static EntityBase CreateEntityBase<T>(T entity, PropertyInfo[] entityProperties) where T : EntityBase
    {
        var newEntity = new EntityBase();
        foreach (var property in entityProperties)
        {
            var value = property.GetValue(entity);
            typeof(EntityBase).GetProperty(property.Name)?.SetValue(newEntity, value);
        }
        return newEntity;
    }

    static void DisplayResults(List<EntityBase> results)
    {
        // Display results to the console
        foreach (var result in results)
        {
            Console.WriteLine($"{result.Time}, {result.Depth}, {result.Mag}, {result.Place}, {result.Type}, {result.LocationSource}\n");
            // Display other properties as needed
        }
    }
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

static int? TryParseInt(string value)
    {
        if (int.TryParse(value, out int result))
        {
            return result;
        }
        return null;
    }
}