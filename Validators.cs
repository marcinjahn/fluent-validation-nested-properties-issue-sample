using FluentValidation;

namespace fluentnestedtest;

public class CharacteristicsValidator : AbstractValidator<Characteristics>
{
    public CharacteristicsValidator()
    {
        RuleFor(n => n.Color).NotEmpty();
        RuleFor(n => n.Count).GreaterThanOrEqualTo(1);
    }
}

public class ThingValidator : AbstractValidator<Thing>
{
    public ThingValidator()
    {
        RuleFor(n => n.Name).NotEmpty();
        RuleFor(n => n.Characteristics).NotNull();

        // The CharacteristicsValidator is created twice with the line below
        // RuleFor(n => n.Characteristics).SetValidator(new CharacteristicsValidator());
    }
}