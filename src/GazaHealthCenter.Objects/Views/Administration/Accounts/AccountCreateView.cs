using GazaHealthCenter.Components.Mvc;

namespace GazaHealthCenter.Objects;

public class AccountCreateView : AView<Account>
{
    [StringLength(32)]
    public String Username { get; set; }

    [NotTrimmed]
    [StringLength(32)]
    public String Password { get; set; }

    [EmailAddress]
    [StringLength(256)]
    public String Email { get; set; }

    public Int64? RoleId { get; set; }
}
