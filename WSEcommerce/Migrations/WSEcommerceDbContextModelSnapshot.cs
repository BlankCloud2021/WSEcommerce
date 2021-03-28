﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WSEcommerce.Data;

namespace WSEcommerce.Migrations
{
    [DbContext(typeof(WSEcommerceDbContext))]
    partial class WSEcommerceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.2.21154.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WSEcommerce.Models.Categories", b =>
                {
                    b.Property<int>("Categories_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Categories_Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WSEcommerce.Models.Customers", b =>
                {
                    b.Property<int>("Customer_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefaultShippingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Customer_Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WSEcommerce.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetails_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Order_Id")
                        .HasColumnType("int");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.HasKey("OrderDetails_Id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("WSEcommerce.Models.Orders", b =>
                {
                    b.Property<int>("Order_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Customer_Id")
                        .HasColumnType("int");

                    b.Property<int?>("CustomersCustomer_Id")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfItemsOrdered")
                        .HasColumnType("int");

                    b.Property<bool>("OrderCompleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Order_Id");

                    b.HasIndex("CustomersCustomer_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WSEcommerce.Models.Products", b =>
                {
                    b.Property<int>("Product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<int?>("CatergoryCategories_Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("OnSale")
                        .HasColumnType("bit");

                    b.Property<int?>("OrderDetails_Id")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Product_Id");

                    b.HasIndex("CatergoryCategories_Id");

                    b.HasIndex("OrderDetails_Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WSEcommerce.Models.ProjectRequest", b =>
                {
                    b.Property<int>("ProjectRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ImageURl")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectRequestId");

                    b.ToTable("ProjectRequests");
                });

            modelBuilder.Entity("WSEcommerce.Models.Orders", b =>
                {
                    b.HasOne("WSEcommerce.Models.Customers", "Customers")
                        .WithMany()
                        .HasForeignKey("CustomersCustomer_Id");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("WSEcommerce.Models.Products", b =>
                {
                    b.HasOne("WSEcommerce.Models.Categories", "Catergory")
                        .WithMany("Products")
                        .HasForeignKey("CatergoryCategories_Id");

                    b.HasOne("WSEcommerce.Models.OrderDetails", null)
                        .WithMany("Products")
                        .HasForeignKey("OrderDetails_Id");

                    b.Navigation("Catergory");
                });

            modelBuilder.Entity("WSEcommerce.Models.Categories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("WSEcommerce.Models.OrderDetails", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}