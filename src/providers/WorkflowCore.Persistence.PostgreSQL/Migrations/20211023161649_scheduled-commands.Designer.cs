﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WorkflowCore.Persistence.PostgreSQL;

namespace WorkflowCore.Persistence.PostgreSQL.Migrations
{
    [DbContext(typeof(PostgresContext))]
    [Migration("20211023161649_scheduled-commands")]
    partial class scheduledcommands
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WorkflowCore.Persistence.EntityFramework.Models.PersistedEvent", b =>
                {
                    b.Property<long>("PersistenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("EventData")
                        .HasColumnType("text");

                    b.Property<Guid>("EventId")
                        .HasColumnType("uuid");

                    b.Property<string>("EventKey")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("EventName")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime>("EventTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsProcessed")
                        .HasColumnType("boolean");

                    b.HasKey("PersistenceId");

                    b.HasIndex("EventId")
                        .IsUnique();

                    b.HasIndex("EventTime");

                    b.HasIndex("IsProcessed");

                    b.HasIndex("EventName", "EventKey");

                    b.ToTable("Event", "wfc");
                });

            modelBuilder.Entity("WorkflowCore.Persistence.EntityFramework.Models.PersistedExecutionError", b =>
                {
                    b.Property<long>("PersistenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("ErrorTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ExecutionPointerId")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("WorkflowId")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("PersistenceId");

                    b.ToTable("ExecutionError", "wfc");
                });

            modelBuilder.Entity("WorkflowCore.Persistence.EntityFramework.Models.PersistedExecutionPointer", b =>
                {
                    b.Property<long>("PersistenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Children")
                        .HasColumnType("text");

                    b.Property<string>("ContextItem")
                        .HasColumnType("text");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("EventData")
                        .HasColumnType("text");

                    b.Property<string>("EventKey")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("EventName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("EventPublished")
                        .HasColumnType("boolean");

                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Outcome")
                        .HasColumnType("text");

                    b.Property<string>("PersistenceData")
                        .HasColumnType("text");

                    b.Property<string>("PredecessorId")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("RetryCount")
                        .HasColumnType("integer");

                    b.Property<string>("Scope")
                        .HasColumnType("text");

                    b.Property<DateTime?>("SleepUntil")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("StepId")
                        .HasColumnType("integer");

                    b.Property<string>("StepName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<long>("WorkflowId")
                        .HasColumnType("bigint");

                    b.HasKey("PersistenceId");

                    b.HasIndex("WorkflowId");

                    b.ToTable("ExecutionPointer", "wfc");
                });

            modelBuilder.Entity("WorkflowCore.Persistence.EntityFramework.Models.PersistedExtensionAttribute", b =>
                {
                    b.Property<long>("PersistenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AttributeKey")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("AttributeValue")
                        .HasColumnType("text");

                    b.Property<long>("ExecutionPointerId")
                        .HasColumnType("bigint");

                    b.HasKey("PersistenceId");

                    b.HasIndex("ExecutionPointerId");

                    b.ToTable("ExtensionAttribute", "wfc");
                });

            modelBuilder.Entity("WorkflowCore.Persistence.EntityFramework.Models.PersistedScheduledCommand", b =>
                {
                    b.Property<long>("PersistenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CommandName")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Data")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<long>("ExecuteTime")
                        .HasColumnType("bigint");

                    b.HasKey("PersistenceId");

                    b.HasIndex("ExecuteTime");

                    b.HasIndex("CommandName", "Data")
                        .IsUnique();

                    b.ToTable("ScheduledCommand", "wfc");
                });

            modelBuilder.Entity("WorkflowCore.Persistence.EntityFramework.Models.PersistedSubscription", b =>
                {
                    b.Property<long>("PersistenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("EventKey")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("EventName")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("ExecutionPointerId")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("ExternalToken")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime?>("ExternalTokenExpiry")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ExternalWorkerId")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("StepId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SubscribeAsOf")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SubscriptionData")
                        .HasColumnType("text");

                    b.Property<Guid>("SubscriptionId")
                        .HasMaxLength(200)
                        .HasColumnType("uuid");

                    b.Property<string>("WorkflowId")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("PersistenceId");

                    b.HasIndex("EventKey");

                    b.HasIndex("EventName");

                    b.HasIndex("SubscriptionId")
                        .IsUnique();

                    b.ToTable("Subscription", "wfc");
                });

            modelBuilder.Entity("WorkflowCore.Persistence.EntityFramework.Models.PersistedWorkflow", b =>
                {
                    b.Property<long>("PersistenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CompleteTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Data")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<Guid>("InstanceId")
                        .HasMaxLength(200)
                        .HasColumnType("uuid");

                    b.Property<long?>("NextExecution")
                        .HasColumnType("bigint");

                    b.Property<string>("Reference")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("Version")
                        .HasColumnType("integer");

                    b.Property<string>("WorkflowDefinitionId")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("PersistenceId");

                    b.HasIndex("InstanceId")
                        .IsUnique();

                    b.HasIndex("NextExecution");

                    b.ToTable("Workflow", "wfc");
                });

            modelBuilder.Entity("WorkflowCore.Persistence.EntityFramework.Models.PersistedExecutionPointer", b =>
                {
                    b.HasOne("WorkflowCore.Persistence.EntityFramework.Models.PersistedWorkflow", "Workflow")
                        .WithMany("ExecutionPointers")
                        .HasForeignKey("WorkflowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workflow");
                });

            modelBuilder.Entity("WorkflowCore.Persistence.EntityFramework.Models.PersistedExtensionAttribute", b =>
                {
                    b.HasOne("WorkflowCore.Persistence.EntityFramework.Models.PersistedExecutionPointer", "ExecutionPointer")
                        .WithMany("ExtensionAttributes")
                        .HasForeignKey("ExecutionPointerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExecutionPointer");
                });

            modelBuilder.Entity("WorkflowCore.Persistence.EntityFramework.Models.PersistedExecutionPointer", b =>
                {
                    b.Navigation("ExtensionAttributes");
                });

            modelBuilder.Entity("WorkflowCore.Persistence.EntityFramework.Models.PersistedWorkflow", b =>
                {
                    b.Navigation("ExecutionPointers");
                });
#pragma warning restore 612, 618
        }
    }
}
