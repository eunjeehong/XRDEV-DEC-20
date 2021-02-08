using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject shootingPrefab;
    public Transform spawnPoint;
    public float shootingForce;
    public ShotCounter shotCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject shot = Instantiate(shootingPrefab, spawnPoint.position, spawnPoint.rotation);
            shot.GetComponent<Rigidbody>().AddForce(shot.transform.forward*shootingForce);

            shotCounter.shotsFired++;
            shotCounter.ShotsFired();

            Destroy(shot, 3f);
        }
    }
}
