﻿namespace Lab13C.Model
{
    public class Detail
    {
        public int DetailId { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public float SubTotal { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }


        public int InvoiceId { get; set; }
        public InvoiceContext Invoice { get; set; }
    }
}
