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
    internal class LoaiSanPhamConfiguration:IEntityTypeConfiguration<LoaiSanPham>
    {
        public void Configure(EntityTypeBuilder<LoaiSanPham> builder)
        {
            builder.HasKey(k => k.Ma);
            builder.Property(p => p.Ma).HasColumnType("varchar(20)").IsRequired();
            builder.Property(p => p.Ten).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
