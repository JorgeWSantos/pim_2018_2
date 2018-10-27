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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Chamado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chamado()
        {
            this.chamadoAtendimentoes = new List<chamadoAtendimento>();
        }

        [Display(Name = "Chamado Id")]
        public int idChamado { get; set; }

        [DisplayName("Id Funcionario")]
        public int idFuncionario { get; set; }

        [Display(Name = "Id Problema")]
        public int idProblema { get; set; }

        [Display(Name = "Descri��o")]
        public string descricao { get; set; }

        [Display(Name = "Data")]
        public System.DateTime dataChamado { get; set; }

        [Display(Name = "Status")]
        public string statusAtendimento { get; set; }
    
        public virtual Funcionario Funcionario { get; set; }
        public virtual Problema Problema { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<chamadoAtendimento> chamadoAtendimentoes { get; set; }
    }
}
