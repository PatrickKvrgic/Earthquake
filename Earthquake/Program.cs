﻿using System;
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
            optionsBuilder.UseNpgsql("Host=localhost;Database=earthquakes;Username=postgres;Password=1891999Spicy;Port=5432;");
        }
    }
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
                    allTablesQuery = allTablesQuery.Where(e => e.time.Year == selectedYear);
                }
            }

            if (filterCriteria.Length > 1 && !string.IsNullOrWhiteSpace(filterCriteria[1]))
            {
                int? selectedMonth = TryParseInt(filterCriteria.ElementAtOrDefault(1));
                if (selectedMonth.HasValue)
                {
                    allTablesQuery = allTablesQuery.Where(e => e.time.Month == selectedMonth);
                }
            }

            if (filterCriteria.Length > 2 && !string.IsNullOrWhiteSpace(filterCriteria[2]))
            {
                string selectedLocation = filterCriteria.ElementAtOrDefault(2)?.Trim();
                if (!string.IsNullOrEmpty(selectedLocation))
                {
                    allTablesQuery = allTablesQuery.Where(e => e.locationsource.Contains(selectedLocation));
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
            time = entity.time,
            latitude = entity.latitude,
            longitude = entity.longitude,
            depth = entity.depth,
            mag = entity.mag,
            magtype = entity.magtype,
            nst = entity.nst,
            gap = entity.gap,
            dmin = entity.dmin,
            rms = entity.rms,
            net = entity.net,
            id = entity.id,
            updated = entity.updated,
            place = entity.place,
            type = entity.type,
            horizontalerror = entity.horizontalerror,
            deptherror = entity.deptherror,
            magerror = entity.magerror,
            magnst = entity.magnst,
            status = entity.status,
            locationsource = entity.locationsource,
            magsource = entity.magsource
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
            Console.WriteLine($"Time: {result.time}; Depth: {result.depth}; Magnitude:{result.mag}; Location: {result.place}; Type: {result.type}; Source: {result.locationsource}\n");
            // Display other properties as needed
        }
    }

    public class EntityBase
    {
        public DateTime time { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public decimal depth { get; set; }
        public decimal mag { get; set; }
        public string magtype { get; set; }
        public int? nst { get; set; }
        public decimal gap { get; set; }
        public decimal dmin { get; set; }
        public decimal rms { get; set; }
        public string net { get; set; }
        public string id { get; set; }
        public string updated { get; set; }
        public string place { get; set; }
        public string type { get; set; }
        public decimal horizontalerror { get; set; }
        public decimal deptherror { get; set; }
        public decimal? magerror { get; set; }
        public int? magnst { get; set; }
        public string status { get; set; }
        public string locationsource { get; set; }
        public string magsource { get; set; }
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