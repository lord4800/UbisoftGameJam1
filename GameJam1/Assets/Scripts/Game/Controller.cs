using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour 
{
	/*public Rect Rectangle1
	{
		get;
		private set;
	}*/
	private GameObject player; //Переменна объекта персонажа с которым будем работать. 
	public Sprite[] spritesPeople = new Sprite[5];
	public Sprite[] spritesVampire = new Sprite[5];
	public Sprite[] spritesLowVampire = new Sprite[5];
	public Sprite[] spritesHightVampire = new Sprite[10];
	public Collider Trigger1;
	public Collider Trigger2;
	public Collider Trigger3;
	public Collider Trigger4;
	public Collider Trigger5;
	public Collider Trigger6;
	public Collider Trigger7;
	public Collider Trigger8;
	public Collider Trigger9;

	public float Hungry = 120;
	public Texture2D [] Lines;
	public Texture2D [] Stat;
	public bool FTS = false;
	public bool Day = false;
	bool PeopleTF = false;
	bool VampireTF = false;
	bool LowVampireTF = false;
	bool HightVampireTF = false;
	bool FTS02_3 = true;
	bool FTS03_3 = true;
	bool FTS04_2 = true;
	bool FTS01_5 = true;
	bool FTS01_4 = true;
	bool FTS03_0 = true;
	bool FTS04_3 = true;
	bool FTS01_0 = true;
	bool FTS04_0 = true;

	int Counter11 = 0;
	float Counter21 = 0;
	int Counter11Hight= 0;
	//public Texture2D player;
	//public ch
    public static float speed = 25; //Скорость перемещения персонажа. Запись public static обозначает что мы сможем обращаться к этой переменной из любого скрипта 
	public static float _speed; //постоянная скорость перемещения персонажа 
	public int rotation = 250; //Скорость пповорота персонажа 
	//change for exemplar day night
	public static bool IsDracula; //Двоичная переменная, которая будет отвечать В каком мы виде.   
	public static float x = 90f; //угол поворота персонажа по оси x 
	private bool north = false;
	private bool east = false;
	private bool west = false;
	private bool south = false;
	int numberOfSprite = 0;
	int numberOfSpriteHight = 0;

	// Use this for initialization
	
	void OnTriggerStay1(Collider Trigger1) 
	{
		if (Trigger1.gameObject.name == "Double_Bed_2_3")
			//if (myTrigger.tag = player)
		{
			FTS = true;
			Debug.Log("Box went through!10");
		}
		
	}
	void  OnTriggerExit1 (Collider Trigger1) 
	{
		if (Trigger1.gameObject.name == "Double_Bed_2_3" && FTS02_3)
			//if (myTrigger.tag = player)
		{
			FTS = false;
			FTS02_3 = false;
			Hungry += 20;
			Debug.Log("Box went through!1");
		}
		
	}

	
	void OnTriggerStay2(Collider Trigger2) 
	{
		if (Trigger2.gameObject.name == "Double_Bed_3_3")
			//if (myTrigger.tag = player)
		{
			FTS = true;
			Debug.Log("Box went through!10");
		}
		
	}
	void  OnTriggerExit2 (Collider Trigger2) 
	{
		if (Trigger2.gameObject.name == "Double_Bed_3_3" && FTS03_3)
			//if (myTrigger.tag = player)
		{
			FTS = false;
			FTS03_3 = false;
			Hungry += 20;
			Debug.Log("Box went through!1");
		}
		
	}
	
	void OnTriggerStay3(Collider Trigger3) 
	{
		if (Trigger3.gameObject.name == "Double_Bed_4_2")
			//if (myTrigger.tag = player)
		{
			FTS = true;
			Debug.Log("Box went through!10");
		}
		
	}
	void  OnTriggerExit3 (Collider Trigger3) 
	{
		if (Trigger3.gameObject.name == "Double_Bed_4_2" && FTS04_2)
			//if (myTrigger.tag = player)
		{
			FTS = false;
			FTS04_2 = false;
			Hungry += 20;
			Debug.Log("Box went through!1");
		}
		
	}
	
	void OnTriggerStay4(Collider Trigger4) 
	{
		if (Trigger4.gameObject.name == "Double_Bed_1_5")
			//if (myTrigger.tag = player)
		{
			FTS = true;
			Debug.Log("Box went through!10");
		}
		
	}
	void  OnTriggerExit4 (Collider Trigger4) 
	{
		if (Trigger4.gameObject.name == "Double_Bed_1_5" && FTS01_5)
			//if (myTrigger.tag = player)
		{
			FTS = false;
			FTS01_5 = false;
			Hungry += 20;
			Debug.Log("Box went through!1");
		}
		
	}
	
	void OnTriggerStay5(Collider Trigger5) 
	{
		if (Trigger5.gameObject.name == "Double_Bed_1_4")
			//if (myTrigger.tag = player)
		{
			FTS = true;
			Debug.Log("Box went through!10");
		}
		
	}
	void  OnTriggerExit5 (Collider Trigger5) 
	{
		if (Trigger5.gameObject.name == "Double_Bed_1_4" && FTS01_4)
			//if (myTrigger.tag = player)
		{
			FTS = false;
			FTS01_4 = false;
			Hungry += 20;
			Debug.Log("Box went through!1");
		}
		
	}
	
	void OnTriggerStay6(Collider Trigger6) 
	{
		if (Trigger6.gameObject.name == "Double_Bed_3_0")
			//if (myTrigger.tag = player)
		{
			FTS = true;
			Debug.Log("Box went through!10");
		}
		
	}
	void  OnTriggerExit6 (Collider Trigger6) 
	{
		if (Trigger6.gameObject.name == "Double_Bed_3_0" && FTS03_0)
			//if (myTrigger.tag = player)
		{
			FTS = false;
			FTS03_0 = false;
			Hungry += 20;
			Debug.Log("Box went through!1");
		}
		
	}
	
	void OnTriggerStay7(Collider Trigger7) 
	{
		if (Trigger7.gameObject.name == "Double_Bed_4_3")
			//if (myTrigger.tag = player)
		{
			FTS = true;
			Debug.Log("Box went through!10");
		}
		
	}
	void  OnTriggerExit7 (Collider Trigger7) 
	{
		if (Trigger7.gameObject.name == "Double_Bed_4_3" && FTS04_3)
			//if (myTrigger.tag = player)
		{
			FTS = false;
			FTS04_3 = false;
			Hungry += 20;
			Debug.Log("Box went through!1");
		}
		
	}
	
	void OnTriggerStay8(Collider Trigger8) 
	{
		if (Trigger8.gameObject.name == "Double_Bed_1_0")
			//if (myTrigger.tag = player)
		{
			FTS = true;
			Debug.Log("Box went through!10");
		}
		
	}
	void  OnTriggerExit8 (Collider Trigger8) 
	{
		if (Trigger8.gameObject.name == "Double_Bed_1_0" && FTS01_0)
			//if (myTrigger.tag = player)
		{
			FTS = false;
			FTS01_0 = false;
			Hungry += 20;
			Debug.Log("Box went through!1");
		}
		
	}
	
	void OnTriggerStay9(Collider Trigger9) 
	{
		if (Trigger9.gameObject.name == "Double_Bed_4_0")
			//if (myTrigger.tag = player)
		{
			FTS = true;
			Debug.Log("Box went through!10");
		}
		
	}
	void  OnTriggerExit9 (Collider Trigger9) 
	{
		if (Trigger9.gameObject.name == "Double_Bed_4_0" && FTS04_0)
			//if (myTrigger.tag = player)
		{
			FTS = false;
			FTS04_0 = false;
			Hungry += 20;
			Debug.Log("Box went through!1");
		}
		
	}
	void Start () 
	{ 
		if(Day)
		{
			bool PeopleTF = true;
			bool VampireTF = false;
			bool LowVampireTF = false;
			bool HightVampireTF = false;
		}
		else
		{
			bool VampireTF = true;
		}
		Counter11Hight= 0;
		Hungry = 120;
		IsDracula = false; //По умолчанию оружие у нас спрятано. 
		_speed = speed; //Задаем постоянное стандартное значение скорости персонажа 
		player = (GameObject)this.gameObject; //Задаем что наш персонаж это объект на котором расположен скрипт 
	} 
	//-370.60 183.3 -500
	// Update is called once per frame
	void Update () 
	{
		if (Hungry > 160)
		{
			PeopleTF = false;
			VampireTF = false;
			LowVampireTF = false;
			HightVampireTF = true;
		}
		if (Hungry <= 100)
		{
			PeopleTF = false;
			VampireTF = false;
			LowVampireTF = true;
			HightVampireTF = false;
		}


		if (Hungry > 100 && Hungry <= 160)
		{
			PeopleTF = false;
			VampireTF = true;
			LowVampireTF = false;
			HightVampireTF = false;
		}
		if (Hungry == 100)
		{
			Counter21 = 15;
			PeopleTF = false;
			VampireTF = false;
			LowVampireTF = false;
			HightVampireTF = true;
		}
		if (HightVampireTF && Counter21 > 0)
		{
			Hungry = 199;
			Counter21 -= Time.deltaTime;
			PeopleTF = false;
			VampireTF = false;
			LowVampireTF = false;
			HightVampireTF = true;
		}
		if (Hungry >= 198 && Counter21 <= 100)
		{
			Hungry = 160;

		}
		OnTriggerStay1(Trigger1) ;
		OnTriggerStay2(Trigger2) ;
		OnTriggerStay3(Trigger3) ;
		OnTriggerStay4(Trigger4) ;
		OnTriggerStay5(Trigger5) ;
		OnTriggerStay6(Trigger6) ;
		OnTriggerStay7(Trigger7) ;
		OnTriggerStay8(Trigger8) ;
		OnTriggerStay9(Trigger9) ;
		/*if (FTS)
		{

		}*/

		Quaternion rotate = Quaternion.Euler (0,0,x);
		if(north)
		{
			rotate = Quaternion.Euler (0,0,0 - 90); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 0 - 90;
			player.transform.rotation = rotate;
			speed = 25;
		}
		if(south)
		{
			rotate = Quaternion.Euler (0,0,180 - 90); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 180 - 90;
			player.transform.rotation = rotate;
			speed = 25;
		}
		if (west)
		{
			rotate = Quaternion.Euler (0 ,0,270 - 90); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 270 - 90;
			player.transform.rotation = rotate;
			speed = 25;
		}
		if (east)
		{
			rotate = Quaternion.Euler (0 ,0,90 - 90); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 90 - 90;
			player.transform.rotation = rotate;
			speed = 25;
		}
		if(north && east)
		{
			rotate = Quaternion.Euler (0,0,45 - 90); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 45 - 90;
			player.transform.rotation = rotate;
			speed = 12.5f;
		}
		if(south && west)
		{
			rotate = Quaternion.Euler (0,0,180 - 90  + 45); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 180 - 90 + 45;
			player.transform.rotation = rotate;
			speed = 12.5f;
		}
		if (west && north)
		{
			rotate = Quaternion.Euler (0,0,270 - 90 + 45); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 270 - 90 + 45;
			player.transform.rotation = rotate;
			speed = 12.5f;
		}
		if (east && south)
		{
			rotate = Quaternion.Euler (0,0,90 - 90 + 45); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 90 - 90 + 45;
			player.transform.rotation = rotate;
			speed = 12.5f;
		}
		 //Создаем новую переменную типа Quaternion для задавания угла поворота 
		 //Поворачиваем персонаж 
		if(PeopleTF == true) //Персонаж вампир?
		{ 
			numberOfSprite = (int)Mathf.Round((Counter11 % 45) / 9);
			gameObject.GetComponent<SpriteRenderer>().sprite = spritesPeople[numberOfSprite];
			/**/
			Counter11++;
			//CurentTexture = People;
			speed = _speed;
			if(Input.GetKey(KeyCode.D)) //Если нажать W 
			{ 
				east = true;
				if(north || south || west)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				//x+=3;
				//player.transform.rotation = rotate;
				//player.transform.rotation += (float)(x * Time.deltaTime); //Перемещаем персонажа в перед. 
				player.transform.position += player.transform.right * speed *0.5f * Time.deltaTime; //Перемещаем персонажа в перед. 
				
			}
			if(Input.GetKeyUp(KeyCode.D)) 
			{
				east = false;
			}//Если нажать W 
			if(Input.GetKey(KeyCode.A))
			{ 
				west = true;
				if(north || south || east)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25;
				}
				//x-=3;
				//player.transform.rotation = rotate;
				//speed = _speed / 2; 
				//player.transform.rotation -= (float)(x * Time.deltaTime);
				player.transform.position += player.transform.right  * speed *0.5f * Time.deltaTime; //Перемещаем назад 
			} 
			if(Input.GetKeyUp(KeyCode.A))
			{
				west = false;
			} 
			if(Input.GetKey(KeyCode.UpArrow)) //Если нажать W 
			{ 
				player.transform.position += player.transform.right * speed *0.5f * Time.deltaTime; //Перемещаем персонажа в перед. 
			} 
			if(Input.GetKey(KeyCode.DownArrow)) 
			{ 
				//speed = _speed / 2; 
				player.transform.position -= player.transform.right * speed *0.5f * Time.deltaTime; //Перемещаем назад 
			} 
			/*if(Input.GetKeyUp (KeyCode.S)) 
			{ 
				speed = _speed; //Возвращаем cтандартное значение 
			} */
			if(Input.GetKey (KeyCode.W)) 
			{ 
				if(east || west || north)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				south = true;
				player.transform.position += player.transform.right * speed *0.5f * Time.deltaTime; //перемещаем в лево 
			} 
			if(Input.GetKeyUp (KeyCode.W))
			{
				south = false;
			}
			if(Input.GetKey (KeyCode.S)) 
			{ 
				if(east || west || east)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				north = true;
				player.transform.position += player.transform.right * speed *0.5f * Time.deltaTime; //перемещаем в право 
			} 
			if(Input.GetKeyUp (KeyCode.S))
			{
				north = false;
			} 
		}
		else if(VampireTF == true) 
		{
			Hungry -= Time.deltaTime;

			//CurentTexture = Vampire;
			/*if((int)Mathf.Round((Counter11 % 8000) / 25 ) == 30)
			{
				Hungry--;
			}*/
			speed = _speed;
			if(Input.GetKey(KeyCode.D)) //Если нажать W 
			{ 
				numberOfSprite = (int)Mathf.Round((Counter11 % 45) / 9);
				gameObject.GetComponent<SpriteRenderer>().sprite = spritesVampire[numberOfSprite];
				Counter11++;
				east = true;
				if(north || south || west)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				//x+=3;
				//player.transform.rotation = rotate;
				//player.transform.rotation += (float)(x * Time.deltaTime); //Перемещаем персонажа в перед. 
				player.transform.position += player.transform.right * speed * Time.deltaTime; //Перемещаем персонажа в перед. 

			}
			if(Input.GetKeyUp(KeyCode.D)) 
			{
				Counter11 = 0;
				east = false;
			}//Если нажать W 
			if(Input.GetKey(KeyCode.A))
			{ 
				numberOfSprite = (int)Mathf.Round((Counter11 % 45) / 9);
				gameObject.GetComponent<SpriteRenderer>().sprite = spritesVampire[numberOfSprite];
				Counter11++;
				west = true;
				if(north || south || east)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				//x-=3;
				//player.transform.rotation = rotate;
				//speed = _speed / 2; 
				//player.transform.rotation -= (float)(x * Time.deltaTime);
				player.transform.position += player.transform.right  * speed * Time.deltaTime; //Перемещаем назад 
			} 
			if(Input.GetKeyUp(KeyCode.A))
			{
				Counter11 = 0;
				west = false;
			} 
			if(Input.GetKey(KeyCode.UpArrow)) //Если нажать W 
			{ 
				player.transform.position += player.transform.right * speed * Time.deltaTime; //Перемещаем персонажа в перед. 
			} 
			if(Input.GetKey(KeyCode.DownArrow)) 
			{ 
				//speed = _speed / 2; 
				player.transform.position -= player.transform.right * speed * Time.deltaTime; //Перемещаем назад 
			} 
			/*if(Input.GetKeyUp (KeyCode.S)) 
			{ 
				speed = _speed; //Возвращаем cтандартное значение 
			} */
			if(Input.GetKey (KeyCode.W)) 
			{ 
				numberOfSprite = (int)Mathf.Round((Counter11 % 45) / 9);
				gameObject.GetComponent<SpriteRenderer>().sprite = spritesVampire[numberOfSprite];
				Counter11++;
				if(east || west || north)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				south = true;
				player.transform.position += player.transform.right * speed * Time.deltaTime; //перемещаем в лево 
			} 
			if(Input.GetKeyUp (KeyCode.W))
			{
				Counter11 = 0;
				south = false;
			}
			if(Input.GetKey (KeyCode.S)) 
			{ 
				numberOfSprite = (int)Mathf.Round((Counter11 % 45) / 9);
				gameObject.GetComponent<SpriteRenderer>().sprite = spritesVampire[numberOfSprite];
				Counter11++;
				if(east || west || east)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				north = true;
				player.transform.position += player.transform.right * speed * Time.deltaTime; //перемещаем в право 
			} 
			if(Input.GetKeyUp (KeyCode.S))
			{
				Counter11 = 0;
				north = false;
			} 
		}
		else if(LowVampireTF == true)
		{
			numberOfSprite = (int)Mathf.Round((Counter11 % 45) / 9);
			Counter11++;
			gameObject.GetComponent<SpriteRenderer>().sprite = spritesLowVampire[numberOfSprite];

			//CurentTexture = LowVampire;
			speed = _speed;
			if(Input.GetKey(KeyCode.D)) //Если нажать W 
			{ 
				east = true;
				if(north || south || west)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				//x+=3;
				//player.transform.rotation = rotate;
				//player.transform.rotation += (float)(x * Time.deltaTime); //Перемещаем персонажа в перед. 
				player.transform.position += player.transform.right * speed *0.5f * Time.deltaTime; //Перемещаем персонажа в перед. 
				
			}
			if(Input.GetKeyUp(KeyCode.D)) 
			{
				east = false;
			}//Если нажать W 
			if(Input.GetKey(KeyCode.A))
			{ 
				west = true;
				if(north || south || east)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				//x-=3;
				//player.transform.rotation = rotate;
				//speed = _speed / 2; 
				//player.transform.rotation -= (float)(x * Time.deltaTime);
				player.transform.position += player.transform.right  * speed *0.5f * Time.deltaTime; //Перемещаем назад 
			} 
			if(Input.GetKeyUp(KeyCode.A))
			{
				west = false;
			} 
			if(Input.GetKey(KeyCode.UpArrow)) //Если нажать W 
			{ 
				player.transform.position += player.transform.right * speed *0.5f * Time.deltaTime; //Перемещаем персонажа в перед. 
			} 
			if(Input.GetKey(KeyCode.DownArrow)) 
			{ 
				//speed = _speed / 2; 
				player.transform.position -= player.transform.right * speed *0.5f * Time.deltaTime; //Перемещаем назад 
			} 
			/*if(Input.GetKeyUp (KeyCode.S)) 
			{ 
				speed = _speed; //Возвращаем cтандартное значение 
			} */
			if(Input.GetKey (KeyCode.W)) 
			{ 
				if(east || west || north)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				south = true;
				player.transform.position += player.transform.right * speed *0.5f * Time.deltaTime; //перемещаем в лево 
			} 
			if(Input.GetKeyUp (KeyCode.W))
			{
				south = false;
			}
			if(Input.GetKey (KeyCode.S)) 
			{ 
				if(east || west || east)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				north = true;
				player.transform.position += player.transform.right * speed *0.5f * Time.deltaTime; //перемещаем в право 
			} 
			if(Input.GetKeyUp (KeyCode.S))
			{
				north = false;
			} 
		}
		else if(HightVampireTF == true) 
		{
			Counter11++;
			numberOfSprite = (int)Mathf.Round((Counter11 % 40) / 4);
			gameObject.GetComponent<SpriteRenderer>().sprite = spritesHightVampire[numberOfSprite];
			//CurentTexture = HightVampire;
			speed = _speed;
			if(Input.GetKey(KeyCode.D)) //Если нажать W 
			{ 
				east = true;
				if(north || south || west)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				//x+=3;
				//player.transform.rotation = rotate;
				//player.transform.rotation += (float)(x * Time.deltaTime); //Перемещаем персонажа в перед. 
				player.transform.position += player.transform.right * speed *1.5f * Time.deltaTime; //Перемещаем персонажа в перед. 
				
			}
			if(Input.GetKeyUp(KeyCode.D)) 
			{
				east = false;
			}//Если нажать W 
			if(Input.GetKey(KeyCode.A))
			{ 
				west = true;
				if(north || south || east)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				//x-=3;
				//player.transform.rotation = rotate;
				//speed = _speed / 2; 
				//player.transform.rotation -= (float)(x * Time.deltaTime);
				player.transform.position += player.transform.right  * speed *1.5f * Time.deltaTime; //Перемещаем назад 
			} 
			if(Input.GetKeyUp(KeyCode.A))
			{
				west = false;
			} 
			if(Input.GetKey(KeyCode.UpArrow)) //Если нажать W 
			{ 
				player.transform.position += player.transform.right * speed *1.5f * Time.deltaTime; //Перемещаем персонажа в перед. 
			} 
			if(Input.GetKey(KeyCode.DownArrow)) 
			{ 
				//speed = _speed / 2; 
				player.transform.position -= player.transform.right * speed *1.5f * Time.deltaTime; //Перемещаем назад 
			} 
			/*if(Input.GetKeyUp (KeyCode.S)) 
			{ 
				speed = _speed; //Возвращаем cтандартное значение 
			} */
			if(Input.GetKey (KeyCode.W)) 
			{ 
				if(east || west || north)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				south = true;
				player.transform.position += player.transform.right * speed *1.5f * Time.deltaTime; //перемещаем в лево 
			} 
			if(Input.GetKeyUp (KeyCode.W))
			{
				south = false;
			}
			if(Input.GetKey (KeyCode.S)) 
			{ 
				if(east || west || east)
				{
					speed = 12.5f;
				}
				else
				{
					speed = 25f;
				}
				north = true;
				player.transform.position += player.transform.right * speed *1.5f * Time.deltaTime; //перемещаем в право 
			} 
			if(Input.GetKeyUp (KeyCode.S))
			{
				north = false;
			} 
		}
		if(north)
		{
			rotate = Quaternion.Euler (0,0,0 - 90); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 0 - 90;
			player.transform.rotation = rotate;
			speed = 25;
		}
		if(south)
		{
			rotate = Quaternion.Euler (0,0,180 - 90); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 180 - 90;
			player.transform.rotation = rotate;
			speed = 25;
		}
		if (west)
		{
			rotate = Quaternion.Euler (0 ,0,270 - 90); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 270 - 90;
			player.transform.rotation = rotate;
			speed = 25;
		}
		if (east)
		{
			rotate = Quaternion.Euler (0 ,0,90 - 90); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 90 - 90;
			player.transform.rotation = rotate;
			speed = 25;
		}
		if(north && east)
		{
			rotate = Quaternion.Euler (0,0,45 - 90); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 45 - 90;
			player.transform.rotation = rotate;
			speed = 12.5f;
		}
		if(south && west)
		{
			rotate = Quaternion.Euler (0,0,180 - 90  + 45); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 180 - 90 + 45;
			player.transform.rotation = rotate;
			speed = 12.5f;
		}
		if (west && north)
		{
			rotate = Quaternion.Euler (0,0,270 - 90 + 45); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 270 - 90 + 45;
			player.transform.rotation = rotate;
			speed = 12.5f;
		}
		if (east && south)
		{
			rotate = Quaternion.Euler (0,0,90 - 90 + 45); //Создаем новую переменную типа Quaternion для задавания угла поворота 
			x = 90 - 90 + 45;
			player.transform.rotation = rotate;
			speed = 12.5f;
		}
		//rotate = Quaternion.Euler (x,270,90); //Создаем новую переменную типа Quaternion для задавания угла поворота 
		player.transform.rotation = rotate; //Поворачиваем персонаж 
	}
	void OnGUI()
	{
		if(Hungry > 100)
		{
			//Rect Rectangle00 = new Rect(Screen.width - 10 - 100 - Hungry,Screen.height - 10,Hungry ,20);
			Rect Rectangle01 = new Rect(Screen.width - 10 - 200, 10,(Hungry-100)*2 ,20);
			Rect Rectangle02 = new Rect(Screen.width - 10 - 120, 10,Counter21*2 ,20);
			//GUI.DrawTexture(Rectangle00, Lines[0]);
			GUI.DrawTexture(Rectangle01, Lines[1]);
			GUI.DrawTexture(Rectangle02, Lines[2]);
		}
		else 
		{
			Rect Rectangle00 = new Rect(Screen.width - 10 - 200 - (Hungry-100)*2, 10,(Hungry-100) ,20);
			//Rect Rectangle01 = new Rect(Screen.width - 10 - 100,Screen.height - 10,Hungry ,20);
			//Rect Rectangle02 = new Rect(Screen.width - 10 - 60,Screen.height - 10,Counter21 ,20);
			GUI.DrawTexture(Rectangle00, Lines[0]);
			//GUI.DrawTexture(Rectangle01, Lines[1]);
			//GUI.DrawTexture(Rectangle02, Lines[2]);
		}
		Rect Rectangle10 = new Rect( 310,-30,100,100);
		//GUI.DrawTexture(Rectangle10, Stat[1]);
		if (PeopleTF == true)
		{
			GUI.DrawTexture(Rectangle10, Stat[0]);
		}
		else if (VampireTF == true)
		{
			GUI.DrawTexture(Rectangle10, Stat[1]);
		}
		else if (LowVampireTF == true)
		{
			GUI.DrawTexture(Rectangle10, Stat[2]);
		}
		else if (HightVampireTF == true)
		{
			GUI.DrawTexture(Rectangle10, Stat[3]);
		}

	}
}
