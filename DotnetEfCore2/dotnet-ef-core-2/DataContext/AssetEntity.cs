using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotnet_ef_core_2.DataContext
{
    [Table("tbl_asset")]
    public class AssetEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("asset_name")]
        public string AssetName { get; set; }

        [Column("specification")]
        public string Specification { get; set; }

        [Column("serial_number")]
        public string SerialNumber { get; set; }

        [Column("purchase_year")]
        public string PurchaseYear { get; set; }

        [Column("id_pic")]
        public int IdPic { get; set; }

        public AssetEntity()
        {
        }
    }
}

