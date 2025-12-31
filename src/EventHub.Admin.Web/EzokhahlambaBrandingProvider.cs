using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

[Dependency(ReplaceServices = true)]
public class EzokhahlambaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Ezokhahlamba Ent.";
}
