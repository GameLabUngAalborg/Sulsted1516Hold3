using UnityEngine;
using System.Collections;

public class SetStateOnTrigger : MonoBehaviour
{
    public enum SetState {  EnableObject, DisableObject }

    public string TagThatTriggersMe = "Player";
    public SetState SetObject;
    public GameObject ObjectToSet;


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == TagThatTriggersMe)
        {
            if(SetObject == SetState.EnableObject)
            {
                ObjectToSet.SetActive(true);
            }
            else
            {
                ObjectToSet.SetActive(false);
            }

            Destroy(gameObject);
        }
    }
}
