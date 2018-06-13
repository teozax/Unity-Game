using UnityEngine;

public class EndPointTrigger : MonoBehaviour {

    public Transform roadprefab;
    public Transform pl;
    public int k;

    void Start()
    {
        k = 1;
    }

    void OnTriggerEnter(Collider obj)
    {
        if ((obj.tag == "Player" || obj.tag == "Opponent") && (k==1))
        {
            k++;
            float i = pl.position.z;
            Instantiate(roadprefab, new Vector3(0, 0, i+4990f), Quaternion.identity);
        }
    }
    
}
