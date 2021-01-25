using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        //birim fiyat
        public double UnitPrice { get; set; }
        //stok adedi
        public int UnitInStock { get; set; }

        //CRUD operasyonları create-uptade-delete islemlerinin yapıldığı classlar
    }
}
