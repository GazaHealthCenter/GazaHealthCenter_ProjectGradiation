using GazaHealthCenter.Components.Mvc;

namespace GazaHealthCenter.Objects;

public class AccountLoginView : AView
{
    [StringLength(32)]
    public String Username { get; set; }

    [NotTrimmed]
    [StringLength(32)]
    public String Password { get; set; }

    public String? ReturnUrl { get; set; }
}
