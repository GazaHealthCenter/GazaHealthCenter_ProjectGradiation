using GazaHealthCenter.Data;
using GazaHealthCenter.Objects;

namespace GazaHealthCenter.Validators;

public class AValidatorProxy : AValidator
{
    public AValidatorProxy(IUnitOfWork unitOfWork)
        : base(unitOfWork)
    {
    }

    public Boolean BaseIsSpecified<TView>(TView view, Expression<Func<TView, Object?>> property) where TView : AView
    {
        return IsSpecified(view, property);
    }
}
