using arcadeScore.api.Domain;
using arcadeScore.api.ViewModel;
using FluentValidation;

namespace arcadeScore.api.Validators;

public class RegistrarPontuacaoValidator : AbstractValidator<RegistrarPontuacao>
{
    public RegistrarPontuacaoValidator()
    {
        RuleLevelCascadeMode = CascadeMode.Stop;

        RuleFor(p => p.JogadorId).NotEmpty().Length(3);

        RuleFor(p => p.Pontuacao).NotEmpty().GreaterThanOrEqualTo(100);

        RuleFor(p => p.DataPartida).NotEmpty().LessThanOrEqualTo(DateTime.Now);
    }
}