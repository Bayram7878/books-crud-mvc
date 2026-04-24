using books_crud_mvc.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace books_crud_mvc.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Kategori adı boş olamaz")]
        public string Name { get; set; }


        public List<Book> Books { get; set; }
    }
}