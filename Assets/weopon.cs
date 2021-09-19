using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class weopon : MonoBehaviour
{
	public Transform firePoint;
	public GameObject bulletPrefab;
	public int BulletLimit;
	public int currentbullet;
	public TMP_Text Score;
	public TMP_Text BulletText;
	public bool isReloading=false;
	public Transform Player;
	
	// Update is called once per frame
	void Start()
    {
		currentbullet = BulletLimit;
    }
	void Update()
	{
		if (isReloading)
			return;
		if (currentbullet <= 0)
		{
			StartCoroutine(Reload());
			BulletText.text = "Bullet:Reloading..";

			return;

		}

		Score.text = "Score: " + Player.position.y.ToString("0");
	
			BulletText.text = "Bullet:" + currentbullet;

		/*else
		{
			if (Input.touchCount > 0)
			{
				Touch touch = Input.GetTouch(0);

				shoot();
			}
			if (Input.GetKeyDown("space"))
			{
				shoot();
			}
			//Shoot();
		}
		*/
		TouchInput.ProcessTouches();

		if (TouchInput.Tap())
		{

			shoot();
			currentbullet -= 1;


		}
		if (Input.GetKeyDown("space"))
		{
			shoot();
			currentbullet-=1;
		}
	}

	public void shoot()
	{
	//	currentbullet--;

		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		
	}
	IEnumerator Reload()
    {
		isReloading = true;

		yield return new WaitForSeconds(3);
		currentbullet = BulletLimit;
				isReloading = false;

	}

}
