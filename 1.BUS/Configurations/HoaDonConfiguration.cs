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
    internal class HoaDonConfiguration:IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.HasKey(c => c.Ma);
            builder.Property(c => c.Ma).HasColumnType("varchar(20)").IsRequired();
            builder.Property(c => c.MaKH).IsRequired();
            builder.Property(c => c.MaNV).IsRequired();
            builder.Property(c => c.MaNV).IsRequired();
            builder.Property(c => c.NgayTao).HasColumnType("date").IsRequired();
            builder.HasOne(c => c.KhachHang).WithMany().HasForeignKey(c => c.MaKH);
            builder.HasOne(c => c.NhanVien).WithMany().HasForeignKey(c => c.MaNV);
            builder.HasOne(c => c.Voucher).WithMany().HasForeignKey(c => c.MaVC);
        }
    }
}
