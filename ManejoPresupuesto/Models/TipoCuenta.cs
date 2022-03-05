using ManejoPresupuesto.Validaciones;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta //: IValidatableObject
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [PrimeraLetraMayuscula]
        [Remote(action: "VerificarExisteTipoCuenta", controller: "TiposCuentas")]

        //[StringLength(maximumLength: 50,MinimumLength = 3, ErrorMessage ="La longitud del campo {0} debe estar entre {2} y {1} caracteres")]
        //[Display(Name = "Nombre del tipo de la cuenta")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Nombre != null && Nombre.Length > 0)
        //    {
        //        var primeraLetra = Nombre[0].ToString();

        //        if (primeraLetra != primeraLetra.ToUpper())
        //        {
        //            yield return new ValidationResult("La primera letra debe ser mayúscula", new[] { nameof(Nombre) });
        //        }
        //    }
        //}

        /*Pruebas de otras validaciones por defecto
         * 
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [EmailAddress(ErrorMessage = "El campo debe ser un correo electronico válido.")]
        public string Email { get; set;}
        [Range(minimum: 18, maximum: 130, ErrorMessage ="El valor de estar entre {1} y {2}.")]
        public int Edad { get; set;}
        [Url(ErrorMessage = "El campo debe ser una URL válida.")]
        public string URL { get; set;}
        [CreditCard(ErrorMessage = "La tarjeta de crédito no es válida.")]
        [Display(Name ="Tarjeta de Credito")]
        public string TarjetaDeCredito { get; set; }    */
    }
}
