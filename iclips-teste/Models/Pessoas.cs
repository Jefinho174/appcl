using iclips_teste.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iclips_teste.Models
{
    public class Pessoas
    {
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public Situacao Situacao { get; set; }
    }
}