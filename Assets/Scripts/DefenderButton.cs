using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    // Start is called before the first frame update

    private void Start()
    {
     //    LabelButtonWithCost();
    }

  /*  private void LabelButtonWithCost()
    {
        TextMeshProUGUI costText = GetComponentInChildren<Text>();
        if (!costText)
        {
            //Debug.LogError(name + " has no cost text, add some!");
        }
        else
        {
            costText.text = defenderPrefab.GetStarCost().ToString();
        }
    }
*/
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(87, 87, 87, 255);
        }

        GetComponent<SpriteRenderer>().color = Color.white;
       FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
}
