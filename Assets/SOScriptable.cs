using UnityEngine;

[CreateAssetMenu(menuName = "Collectable", fileName = "New Collectable")]

public class SOScriptable : ScriptableObject
{
    //[SerializeField] private Collectabletype collectableTypes;
    [SerializeField] private PowerUp powerupPickup;
    [SerializeField] private Sprite sprite;
    [SerializeField] private Sprite outlineSprite;
    [SerializeField] private bool respawnable;

    public Sprite GetSprite() => sprite;
    //public Collectabletype GetCollectableTypes() => collectableTypes;
    public Sprite GetOutlineSprite() => outlineSprite;
    public bool GetRespawn() => respawnable;
}
