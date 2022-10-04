using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogicaNegocio.Dominio
{
    public class Eliminatoria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
    }
}
