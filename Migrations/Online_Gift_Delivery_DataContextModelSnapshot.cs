// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_Gift_Delivery_Core_Web.Models;

namespace Online_Gift_Delivery_Core_Web.Migrations
{
    [DbContext(typeof(Online_Gift_Delivery_DataContext))]
    partial class Online_Gift_Delivery_DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Online_Gift_Delivery_Core_Web.BusinessLayer.Gift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ItemPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Gift");
                });

            modelBuilder.Entity("Online_Gift_Delivery_Core_Web.BusinessLayer.GiftPurchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GiftId")
                        .HasColumnType("int");

                    b.Property<int>("GiftSenderId")
                        .HasColumnType("int");

                    b.Property<string>("Reciever")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecieverAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShippingMethodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GiftId");

                    b.HasIndex("GiftSenderId");

                    b.HasIndex("ShippingMethodId");

                    b.ToTable("GiftPurchase");
                });

            modelBuilder.Entity("Online_Gift_Delivery_Core_Web.BusinessLayer.GiftSender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GiftSender");
                });

            modelBuilder.Entity("Online_Gift_Delivery_Core_Web.BusinessLayer.ShippingMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Charge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShippingMethod");
                });

            modelBuilder.Entity("Online_Gift_Delivery_Core_Web.BusinessLayer.GiftPurchase", b =>
                {
                    b.HasOne("Online_Gift_Delivery_Core_Web.BusinessLayer.Gift", "Gift")
                        .WithMany()
                        .HasForeignKey("GiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Gift_Delivery_Core_Web.BusinessLayer.GiftSender", "GiftSender")
                        .WithMany()
                        .HasForeignKey("GiftSenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Gift_Delivery_Core_Web.BusinessLayer.ShippingMethod", "ShippingMethod")
                        .WithMany()
                        .HasForeignKey("ShippingMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
