using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EstoqueProdutos.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}