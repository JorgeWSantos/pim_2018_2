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
    using System.ComponentModel.DataAnnotations;

    public partial class Funcionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcionario()
        {
            this.Chamadoes = new List<Chamado>();
            this.chamadoAtendimentoes = new List<chamadoAtendimento>();
            this.Loginns = new List<Loginn>();
        }
        [Display(Name = "Funcionario Id")]
        public int idFuncionario { get; set; }
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Display(Name = "Ramal")]
        public Nullable<int> ramal { get; set; }
        [Display(Name = "N� do computador")]
        public Nullable<int> nComputador { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Setor")]
        public string setor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Chamado> Chamadoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<chamadoAtendimento> chamadoAtendimentoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Loginn> Loginns { get; set; }
    }
}
