using GazaHealthCenter.Components.Mvc;

namespace GazaHealthCenter.Objects;

public class ProfileDeleteView : AView
{
    [NotTrimmed]
    [StringLength(32)]
    public String Password { get; set; }
}
