﻿// <auto-generated />
using System;
using Automatica.Core.HyperSeries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Automatica.Core.HyperSeries.Migrations
{
    [DbContext(typeof(HyperSeriesContext))]
    partial class HyperSeriesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Automatica.Core.HyperSeries.Model.HourByHourAggregatedRecordValue", b =>
                {
                    b.Property<double>("AverageValue")
                        .HasColumnType("double precision")
                        .HasColumnName("avgvalue");

                    b.Property<int>("Count")
                        .HasColumnType("integer")
                        .HasColumnName("countvalue");

                    b.Property<double>("DifferenceValue")
                        .HasColumnType("double precision")
                        .HasColumnName("diffvalue");

                    b.Property<double>("MaxValue")
                        .HasColumnType("double precision")
                        .HasColumnName("maxvalue");

                    b.Property<double>("MinValue")
                        .HasColumnType("double precision")
                        .HasColumnName("minvalue");

                    b.Property<Guid>("NodeInstanceId")
                        .HasColumnType("uuid")
                        .HasColumnName("nodeinstanceid");

                    b.Property<DateTimeOffset>("Timestamp")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("time");

                    b.ToTable("values_hour_by_hour");
                });

            modelBuilder.Entity("Automatica.Core.HyperSeries.Model.RecordValue", b =>
                {
                    b.Property<Guid>("NodeInstanceId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("TrendId")
                        .HasColumnType("uuid");

                    b.Property<double>("Value")
                        .HasColumnType("double precision");

                    b.ToTable("RecordValues");
                });
#pragma warning restore 612, 618
        }
    }
}
