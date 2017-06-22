﻿using DreamSale.Model.Forums;

namespace DreamSale.Data.Mapping.Forums
{
    public partial class ForumGroupMap : DreamSaleEntityTypeConfiguration<ForumGroup>
    {
        public ForumGroupMap()
        {
            this.ToTable("Forums_Group");
            this.HasKey(fg => fg.Id);
            this.Property(fg => fg.Name).IsRequired().HasMaxLength(200);
        }
    }
}
