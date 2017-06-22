using DreamSale.Model.Catalog;

namespace DreamSale.Data.Mapping.Catalog
{
    public partial class CrossSellProductMap : DreamSaleEntityTypeConfiguration<CrossSellProduct>
    {
        public CrossSellProductMap()
        {
            this.ToTable("CrossSellProduct");
            this.HasKey(c => c.Id);
        }
    }
}