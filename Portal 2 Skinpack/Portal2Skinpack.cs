using OWML.Common;
using OWML.ModHelper;
using UnityEngine;

namespace Portal2Skinpack;
public class Portal2Skinpack : ModBehaviour
{
    public interface ISkinChanger
    {
        void RegisterCustomSkin(ModBehaviour mod, string name, string assetName, string bundlePath, Vector3 cameraOffset, float colliderRadius, float colliderHeight, Vector3 colliderCenter);
    }



    public void Start()
    {
        var api = ModHelper.Interaction.TryGetModApi<ISkinChanger>("pikpik_carrot.SkinChanger");

        api.RegisterCustomSkin(this, "Chell", "Traveller_HEA_Player_Chell", "Assets/Traveller_HEA_Player_Chell", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
        api.RegisterCustomSkin(this, "ATLAS", "Traveller_HEA_Player_atlas", "Assets/Traveller_HEA_Player_atlas", new Vector3(0, 0.2f, 0.17f), 0.5f, 2f, Vector3.zero);
        api.RegisterCustomSkin(this, "P-body", "Traveller_HEA_Player_p-body", "Assets/Traveller_HEA_Player_p-body", new Vector3(0, 0.8f, 0.15f), 0.5f, 2f, Vector3.zero);
    }
}

