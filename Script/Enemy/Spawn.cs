public class Spawn: MonoBehaviour {
 
    public Transform[] spawnPoints;
    public GameObject enemy;
 
    public int spawnTime = 5;
    void Start () {
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }
 
    void Update () {
       
    }
 
    void Spawn () {
        int spawnPoints = Random.Range (0, spawnPoints.Length);
 
        Instantiate (enemy, spawnPoints[spawnPoints].position, spawnPoints[spawnPoints].rotation);
    }
}