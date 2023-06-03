using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Entities
{
    public class Aluno : Pessoa
    {
        public string Matricula { get; set; }
        public string Curso { get; set; }
        //public virtual ICollection<Nota> Notas { get; set; }
    }

    /*
    public class Nota
    {
        public long Id { get; set; }
        public double AV1 { get; set; }
        public double AV2 { get; set; }
        public double AV3 { get; set; }
        public double AV4 { get; set; }
        public double MediaN1 { get; set; }
        public double MediaN2 { get; set; }
        public double MediaFinal { get; set; }
        public double AF { get; set; }
        public double MediaFinalAF { get; set; }

        public Aluno Aluno { get; set; }
        public long AlunoId { get; set; }
    }
    */
}
