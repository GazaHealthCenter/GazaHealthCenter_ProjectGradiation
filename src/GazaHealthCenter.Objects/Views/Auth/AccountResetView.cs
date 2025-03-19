using GazaHealthCenter.Components.Mvc;

namespace GazaHealthCenter.Objects;

public class AccountResetView : AView
{
    [StringLength(36)]
    public String? Token { get; set; }

    [NotTrimmed]
    [StringLength(32)]
    public String NewPassword { get; set; }
}
