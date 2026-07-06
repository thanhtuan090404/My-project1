using System;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Shooter : MonoBehaviour
{
    private Transform _player;
    [SerializeField] private GameObject bulletPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject player = GameObject.Find("player");

        if (player != null)
        {
            _player = player.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Vector3 pos = _player.position + new Vector3(0.7f, 0.57f, -0.07f);

        GameObject bullet = Instantiate(bulletPrefab, pos, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().linearVelocity = transform.forward * 40f;
        Destroy(bullet, 2f);

    }
}
