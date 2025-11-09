using UnityEngine;

public class AreaEntrance : MonoBehaviour{
    [Header("The Transition Name should line up with the 'Target Area Transition' of \nthe Area Exit targetting this. By default, the position of the point is \ninside the Area Transition Collider, be sure to adjust its position.")]
    public string transitonName;
    void Start(){
        if(transitonName == GameManager.instance.targetAreaTransition)
        {
            PlayerController.instance.transform.position = transform.position;
        } 
    }
}