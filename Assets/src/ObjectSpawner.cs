using UnityEngine;

public class ObjectSpawner : MonoBehaviour {
    public GameObject cloud;
    int cloud_count;

    void Start() {
        cloud_count = 30;
        spawn_clouds();
    }

    void spawn_clouds() {

        for(int i = 0; i < cloud_count; i++) {
            Instantiate(cloud, new Vector2(Random.Range(-250f, 250f), Random.Range(8.5f, 13f)), Quaternion.identity);    
        }
    }
}
