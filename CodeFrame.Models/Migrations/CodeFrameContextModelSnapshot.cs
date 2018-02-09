﻿// <auto-generated />
using CodeFrame.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CodeFrame.Models.Migrations
{
    [DbContext(typeof(CodeFrameContext))]
    partial class CodeFrameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("CodeFrame.Models.DbModel.Button", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BtnClass")
                        .HasMaxLength(50);

                    b.Property<string>("BtnIcon")
                        .HasMaxLength(50);

                    b.Property<string>("BtnName")
                        .HasMaxLength(20);

                    b.Property<string>("BtnScript")
                        .HasMaxLength(50);

                    b.Property<string>("BtnTip")
                        .HasMaxLength(50);

                    b.Property<string>("BtnUrl")
                        .HasMaxLength(300);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser");

                    b.Property<int?>("CreateUserId");

                    b.Property<string>("DisplayCondition")
                        .HasMaxLength(500);

                    b.Property<int>("EditType");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsSpecial");

                    b.Property<int>("OrderBy");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<string>("SpName")
                        .HasMaxLength(50);

                    b.Property<int>("TableId");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<string>("UpdateUser");

                    b.Property<int?>("UpdateUserId");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("t_sys_Button");
                });

            modelBuilder.Entity("CodeFrame.Models.DbModel.Column", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ColumnName")
                        .HasMaxLength(30);

                    b.Property<int?>("ColumnType");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser");

                    b.Property<int?>("CreateUserId");

                    b.Property<string>("DataOptions")
                        .HasMaxLength(300);

                    b.Property<int?>("DisplayType");

                    b.Property<int?>("FkTableId");

                    b.Property<bool>("IsIndexed");

                    b.Property<bool>("IsShow");

                    b.Property<int>("OrderBy");

                    b.Property<string>("ReMark");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<string>("ShowName")
                        .HasMaxLength(20);

                    b.Property<int?>("TableId");

                    b.Property<string>("Tip")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<string>("UpdateUser");

                    b.Property<int?>("UpdateUserId");

                    b.Property<int?>("Width");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("t_sys_Column");
                });

            modelBuilder.Entity("CodeFrame.Models.DbModel.DepartMent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser");

                    b.Property<int?>("CreateUserId");

                    b.Property<string>("DptName")
                        .HasMaxLength(20);

                    b.Property<bool>("IsActive");

                    b.Property<int>("OrderBy");

                    b.Property<int>("ParentId");

                    b.Property<string>("ReMark");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<string>("UpdateUser");

                    b.Property<int?>("UpdateUserId");

                    b.HasKey("Id");

                    b.ToTable("t_sys_DepartMent");
                });

            modelBuilder.Entity("CodeFrame.Models.DbModel.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser");

                    b.Property<int?>("CreateUserId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("MenuName")
                        .HasMaxLength(20);

                    b.Property<string>("MenuUrl")
                        .HasMaxLength(500);

                    b.Property<int>("OrderBy");

                    b.Property<int?>("ParentMenuId");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<int?>("SubSystemId");

                    b.Property<int?>("SysTableId");

                    b.Property<int?>("TableId");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<string>("UpdateUser");

                    b.Property<int?>("UpdateUserId");

                    b.HasKey("Id");

                    b.HasIndex("SubSystemId");

                    b.HasIndex("TableId");

                    b.ToTable("t_sys_MenuInfo");
                });

            modelBuilder.Entity("CodeFrame.Models.DbModel.RoleInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser");

                    b.Property<int?>("CreateUserId");

                    b.Property<string>("Describe")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("IsActive");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<string>("UpdateUser");

                    b.Property<int?>("UpdateUserId");

                    b.HasKey("Id");

                    b.ToTable("t_sys_RoleInfo");
                });

            modelBuilder.Entity("CodeFrame.Models.DbModel.RolePower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ButtonId");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser");

                    b.Property<int?>("CreateUserId");

                    b.Property<int>("MentId");

                    b.Property<int>("RoleId");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<int>("Type");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<string>("UpdateUser");

                    b.Property<int?>("UpdateUserId");

                    b.HasKey("Id");

                    b.ToTable("t_sys_RolePower");
                });

            modelBuilder.Entity("CodeFrame.Models.DbModel.SubSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser");

                    b.Property<int?>("CreateUserId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Link");

                    b.Property<int>("OrderBy");

                    b.Property<string>("ReMark");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<string>("SystemIcon");

                    b.Property<string>("SystemName");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<string>("UpdateUser");

                    b.Property<int?>("UpdateUserId");

                    b.HasKey("Id");

                    b.ToTable("t_sys_SubSystem");
                });

            modelBuilder.Entity("CodeFrame.Models.DbModel.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser");

                    b.Property<int?>("CreateUserId");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsMultiple");

                    b.Property<bool>("IsPaging");

                    b.Property<int>("OrderBy");

                    b.Property<string>("ReMark");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<string>("ShowName");

                    b.Property<string>("TableName");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<string>("UpdateUser");

                    b.Property<int?>("UpdateUserId");

                    b.HasKey("Id");

                    b.ToTable("t_sys_Table");
                });

            modelBuilder.Entity("CodeFrame.Models.DbModel.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser");

                    b.Property<int?>("CreateUserId");

                    b.Property<int?>("DepartMentId");

                    b.Property<string>("Describe")
                        .HasMaxLength(500);

                    b.Property<int?>("Gender");

                    b.Property<string>("Group")
                        .HasMaxLength(100);

                    b.Property<string>("GroupNum")
                        .HasMaxLength(100);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("PhoneNo")
                        .HasMaxLength(11);

                    b.Property<string>("Picture")
                        .HasMaxLength(300);

                    b.Property<string>("Post")
                        .HasMaxLength(300);

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken();

                    b.Property<string>("Skill")
                        .HasMaxLength(100);

                    b.Property<string>("TrueName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<string>("UpdateUser");

                    b.Property<int?>("UpdateUserId");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("DepartMentId");

                    b.ToTable("t_sys_UserInfo");
                });

            modelBuilder.Entity("CodeFrame.Models.DbModel.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("t_sys_UserRole");
                });

            modelBuilder.Entity("Microsoft.EntityFrameworkCore.AutoHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Changed")
                        .HasMaxLength(2147483647);

                    b.Property<DateTime>("Created");

                    b.Property<int>("Kind");

                    b.Property<string>("RowId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("AutoHistory");
                });

            modelBuilder.Entity("CodeFrame.Models.DbModel.Button", b =>
                {
                    b.HasOne("CodeFrame.Models.DbModel.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CodeFrame.Models.DbModel.Column", b =>
                {
                    b.HasOne("CodeFrame.Models.DbModel.Table", "Table")
                        .WithMany("Columns")
                        .HasForeignKey("TableId");
                });

            modelBuilder.Entity("CodeFrame.Models.DbModel.Menu", b =>
                {
                    b.HasOne("CodeFrame.Models.DbModel.SubSystem", "SubSystem")
                        .WithMany("MenuInfo")
                        .HasForeignKey("SubSystemId");

                    b.HasOne("CodeFrame.Models.DbModel.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId");
                });

            modelBuilder.Entity("CodeFrame.Models.DbModel.UserInfo", b =>
                {
                    b.HasOne("CodeFrame.Models.DbModel.DepartMent", "DepartMent")
                        .WithMany("UserInfos")
                        .HasForeignKey("DepartMentId");
                });

            modelBuilder.Entity("CodeFrame.Models.DbModel.UserRole", b =>
                {
                    b.HasOne("CodeFrame.Models.DbModel.RoleInfo", "RoleInfo")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeFrame.Models.DbModel.UserInfo", "UserInfo")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
