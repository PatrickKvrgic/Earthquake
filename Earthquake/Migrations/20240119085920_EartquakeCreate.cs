using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Earthquake.Migrations
{
    /// <inheritdoc />
    public partial class EartquakeCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "eq2000",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2000", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2001",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2001", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2002",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2002", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2003",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2003", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2004",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2004", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2005",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2005", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2006",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2006", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2007",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2007", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2008",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2008", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2009",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2009", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2010",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2010", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2011",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2011", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2012",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2012", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2013",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2013", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2014",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2014", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2015",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2015", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2016",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2016", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2017",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2017", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2018",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2018", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2019",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2019", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2020",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2020", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2021",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2021", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2022",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2022", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "eq2023",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Depth = table.Column<decimal>(type: "numeric", nullable: false),
                    Mag = table.Column<decimal>(type: "numeric", nullable: false),
                    MagType = table.Column<string>(type: "text", nullable: false),
                    Nst = table.Column<int>(type: "integer", nullable: false),
                    Gap = table.Column<decimal>(type: "numeric", nullable: false),
                    Dmin = table.Column<decimal>(type: "numeric", nullable: false),
                    Rms = table.Column<decimal>(type: "numeric", nullable: false),
                    Net = table.Column<string>(type: "text", nullable: false),
                    Updated = table.Column<string>(type: "text", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HorizontalError = table.Column<decimal>(type: "numeric", nullable: true),
                    DepthError = table.Column<decimal>(type: "numeric", nullable: false),
                    MagError = table.Column<decimal>(type: "numeric", nullable: true),
                    MagNst = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    LocationSource = table.Column<string>(type: "text", nullable: false),
                    MagSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eq2023", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eq2000");

            migrationBuilder.DropTable(
                name: "eq2001");

            migrationBuilder.DropTable(
                name: "eq2002");

            migrationBuilder.DropTable(
                name: "eq2003");

            migrationBuilder.DropTable(
                name: "eq2004");

            migrationBuilder.DropTable(
                name: "eq2005");

            migrationBuilder.DropTable(
                name: "eq2006");

            migrationBuilder.DropTable(
                name: "eq2007");

            migrationBuilder.DropTable(
                name: "eq2008");

            migrationBuilder.DropTable(
                name: "eq2009");

            migrationBuilder.DropTable(
                name: "eq2010");

            migrationBuilder.DropTable(
                name: "eq2011");

            migrationBuilder.DropTable(
                name: "eq2012");

            migrationBuilder.DropTable(
                name: "eq2013");

            migrationBuilder.DropTable(
                name: "eq2014");

            migrationBuilder.DropTable(
                name: "eq2015");

            migrationBuilder.DropTable(
                name: "eq2016");

            migrationBuilder.DropTable(
                name: "eq2017");

            migrationBuilder.DropTable(
                name: "eq2018");

            migrationBuilder.DropTable(
                name: "eq2019");

            migrationBuilder.DropTable(
                name: "eq2020");

            migrationBuilder.DropTable(
                name: "eq2021");

            migrationBuilder.DropTable(
                name: "eq2022");

            migrationBuilder.DropTable(
                name: "eq2023");
        }
    }
}
