//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniinfoAsp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chamado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chamado()
        {
            this.chamadoAtendimentoes = new List<chamadoAtendimento>();
        }
    
        public int idChamado { get; set; }
        public int idFuncionario { get; set; }
        public int idProblema { get; set; }
        public string descricao { get; set; }
        public DateTime dataChamado { get; set; }
        public string statusAtendimento { get; set; }
    
        public virtual Funcionario Funcionario { get; set; }
        public virtual Problema Problema { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<chamadoAtendimento> chamadoAtendimentoes { get; set; }
    }
}
