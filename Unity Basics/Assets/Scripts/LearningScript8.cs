using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningScript8 : MonoBehaviour
{
    public List<string> familyMembers = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        familyMembers.Add("Greg");
        familyMembers.Add("Kate");
        familyMembers.Add("Adam");
        familyMembers.Add("Mia");

        for (int i = 0; i < familyMembers.Count; i++){
            print("familyMembers[" + i + "]" + familyMembers[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
