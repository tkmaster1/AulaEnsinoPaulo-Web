using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TKMaster.AulaEnsinoJogos.Web.UI.ViewModels
{
    public class EquipeViewModel
    {
        public int? Codigo { get; set; }

        [DisplayName("Nome:")]
        [Required(ErrorMessage = "* O campo {0} é obrigatório")]
        [StringLength(255, ErrorMessage = "O campo {0} precisa ter {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        public int? CodigoCidade { get; set; }
    }
}
