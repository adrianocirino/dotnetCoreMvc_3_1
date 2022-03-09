using DevIO.Business.Models;
using FluentValidation;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace DevIO.Business.Services
{
    public abstract class BaseService
    {

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }
        protected void Notificar(string mensagem)
        {
            //propagar erro até a camada de apresentação


        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : BaseModel
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);
            return false;
        }
    }
}
