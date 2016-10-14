using UnityEngine;
using System.Collections;

public class ItemDestroy : MonoBehaviour {

    private GameObject Unitychan;

	// Use this for initialization
	void Start () {
        Unitychan = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {

        float unitychanZ = Unitychan.transform.position.z;
        float ItemZ = gameObject.transform.position.z;

        if(unitychanZ - ItemZ > 5)
        {
            Destroy(gameObject);
        }

	}
}
