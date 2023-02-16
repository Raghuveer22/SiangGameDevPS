using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class ButtonSystem : MonoBehaviour
{
    [SerializeField] private GameObject MovingPlatform;
    private int index = 0;
    Color hitted = new Color32(19, 255, 246,255);
    Color unhitted = new Color32(253,0, 0,255);
    // Start is called before the first frame update
    void Start()
    {
        MovingPlatform = transform.parent.GetChild(1).gameObject;
        MovingPlatform = MovingPlatform.transform.GetChild(1).gameObject;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
     
        if(index==0)
        {
            index = 1;
            gameObject.GetComponent<SpriteRenderer?>().color = hitted;
        }
        else if(index==1)
        {
            index = 0;
            gameObject.GetComponent<SpriteRenderer?>().color = unhitted;
        }
        if (MovingPlatform?.GetComponent<ButtonPlatform?>().currentWayPointIndex != null)
        {
            MovingPlatform?.GetComponent<ButtonPlatform?>().SetState(index);
        }


    }

  
}
