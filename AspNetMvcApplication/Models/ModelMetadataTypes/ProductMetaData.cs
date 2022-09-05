using System.ComponentModel.DataAnnotations;

namespace AspNetMvcApplication.Models.ModelMetadataTypes
{
    public class ProductMetaData
    {
        [Required(ErrorMessage = "Lütfen Product Name Giriniz")]
        [StringLength(100, ErrorMessage = "Lutfen 100 karakter üstünü gırınız.")]
        public string ProductName { get; set; }
        [EmailAddress(ErrorMessage = "Lütfen doğru bir email adresi giriniz.")]
        public string Email { get; set; }
    }
}
