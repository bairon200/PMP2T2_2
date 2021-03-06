using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMP2T2_2.Models
{
    public class constructor
    {
        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }

        [MaxLength(250)]
        public string nombre { get; set; }

        [MaxLength(250)]
        public string descripcion { get; set; }

        public byte[] imgM { get; set; }
    }
}
