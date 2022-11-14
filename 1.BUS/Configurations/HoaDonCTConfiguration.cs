﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.BUS.DomainClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.BUS.Configurations
{
    internal class HoaDonCTConfiguration:IEntityTypeConfiguration<HoaDonCT>
    {
        public void Configure(EntityTypeBuilder<HoaDonCT> builder)
        {
            builder.HasKey(c => new {c.MaSP,c.MaHD});
            builder.Property(c => c.MaHD).IsRequired();
            builder.Property(c => c.MaSP).IsRequired();
            builder.Property(c => c.SoLuong).HasColumnType("int").IsRequired();
            builder.Property(c => c.DonGia).HasColumnType("money").IsRequired();
            builder.Property(c => c.MaBan).IsRequired();
            builder.HasOne(c => c.HoaDon).WithMany().HasForeignKey(c => c.MaHD);
            builder.HasOne(c => c.SanPham).WithMany().HasForeignKey(c => c.MaSP);
            builder.HasOne(c => c.Ban).WithMany().HasForeignKey(c => c.MaBan);
        }
    }
}
