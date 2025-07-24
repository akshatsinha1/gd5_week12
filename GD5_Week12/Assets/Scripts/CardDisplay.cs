using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public GameObject statsCard;
    public TMP_Text npcName, npcCatchphrase, npcArmour, npcSpeed, npcFriendly;
    public Image artwork;

    public void showCharacterCard (npcInfo stats)
    {
        statsCard.SetActive(true);

        npcName.text = "My name is " + stats.npcName;
        npcCatchphrase.text = stats.catchphrase;
        npcArmour.text = "I have an armour level of " + stats.armourLevel;
        npcSpeed.text = "My speed is " + stats.npcSpeed;
        artwork.sprite = stats.npcSprite;

        if(stats.isFriendly)
        {
            npcFriendly.text = "Good Morning";
        }
        else
        {
            npcFriendly.text = "Get out of here!";
        }

    }
}
