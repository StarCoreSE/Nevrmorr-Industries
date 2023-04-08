
namespace Scripts
{
    partial class Parts
    {
        internal Parts()
        {
            // naming convention: WeaponDefinition Name
            //
            // Enable your definitions using the follow syntax:
            // PartDefinitions(Your1stDefinition, Your2ndDefinition, Your3rdDefinition);
            // PartDefinitions includes both weapons and phantoms
            PartDefinitions(ProtonBeam, PhysBlink, Cannon105mm, Cannon250mm, Cannon500mm, Cannon750mm,
                Cannon1000mm, Cannon1500mm, Cannon2000mm, Cannon2500mm);


            //ArmorDefinitions(Armor1, Armor2);
            //SupportDefinitions(ArmorEnhancer1A);
            //UpgradeDefinitions(Upgrade75a, Upgrade75b);
        }
    }
}
