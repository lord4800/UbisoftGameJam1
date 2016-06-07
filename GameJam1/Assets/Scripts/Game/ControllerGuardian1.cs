using UnityEngine;
using System.Collections;

public class ControllerGuardian1 : MonoBehaviour 
{
	/*public Rect Rectangle1
	{
		get;
		private set;
	}*/
	private GameObject player; //Переменна объекта персонажа с которым будем работать. 
	public Sprite[] spritesGuardian = new Sprite[3];
	public GameObject playerTarg;
	bool IsSee = true;
	int Counter = 0;
	int CounterHight= 0;
	public bool gameOver = false;
	//public Texture2D player;
	//public ch
    public static float speed = 25; //Скорость перемещения персонажа. Запись public static обозначает что мы сможем обращаться к этой переменной из любого скрипта 
	public static float _speed; //постоянная скорость перемещения персонажа 
	public int rotation = 250; //Скорость пповорота персонажа 
	//change for exemplar day night
	public static bool IsDracula; //Двоичная переменная, которая будет отвечать В каком мы виде.   
	public static float x = 90f;//угол поворота персонажа по оси x 
	public Vector2 start;
	public Vector2 end;
	public bool XFirst;
	private bool north = false;
	private bool east = false;
	private bool west = false;
	private bool south = false;
	Vector2 z = new Vector2();
	int numberOfSprite = 0;
	int numberOfSpriteHight = 0;

	// Use this for initialization
	
	

	void Start () 
	{ 
		IsDracula = false; //По умолчанию оружие у нас спрятано. 
		_speed = speed; //Задаем постоянное стандартное значение скорости персонажа 
		player = (GameObject)this.gameObject; //Задаем что наш персонаж это объект на котором расположен скрипт 
		end.x  = playerTarg.gameObject.GetComponent<Transform>().position.x;
		end.y  = playerTarg.gameObject.GetComponent<Transform>().position.y;
		start.x = player.transform.position.x;
		start.y = player.transform.position.y;
		z.x = start.x;
		z.y = start.y;
	} 
	
	// Update is called once per frame
	void Update () 
	{
		end.x  = playerTarg.transform.position.x;
		end.y  = playerTarg.transform.position.y;
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
		if(IsSee == true) //Персонаж вампир?
		{ 
			//numberOfSprite = (int)Mathf.Round((Counter % 45) / 9);
			//gameObject.GetComponent<SpriteRenderer>().sprite = spritesPeople[numberOfSprite];
			numberOfSprite = (int)Mathf.Round((Counter % 36) / 12);
			gameObject.GetComponent<SpriteRenderer>().sprite = spritesGuardian[numberOfSprite];
			Counter++;
			speed = _speed;
			//z.x = player.transform.position.x;

			if (XFirst)
			{
				if (player.transform.position.x > playerTarg.transform.position.x)
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
					player.transform.position += player.transform.right  * speed *0.5f * Time.deltaTime;
					z.x = player.transform.position.x;
				}
				if (player.transform.position.x < playerTarg.transform.position.x)
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
					player.transform.position -= player.transform.right * speed *0.5f * Time.deltaTime;
					z.x = player.transform.position.x;
				}

				if (player.transform.position.y < playerTarg.transform.position.y)
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
					player.transform.position += player.transform.right * speed *0.5f * Time.deltaTime; 
					z.y = player.transform.position.y;
				}
				if (player.transform.position.y > playerTarg.transform.position.y)
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
					player.transform.position -= player.transform.right * speed *0.5f * Time.deltaTime;
					z.y = player.transform.position.y;
				}
				/*if (player.transform.position - playerTarg.transform.position < Vector3(10,10,10))
				{

					/*east = false;
					west = false;
					north = false;
					south = false;
					z = start;
					start = end;
					end = z;*/
					/*	gameOver = true;
				}*/

			}
			/*else
			{

				if (z.y > end.y)
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
					player.transform.position += player.transform.right * speed *0.5f * Time.deltaTime; 
					z.y = player.transform.position.y;
				}
				if (z.y > end.y)
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
					player.transform.position -= player.transform.right * speed *0.5f * Time.deltaTime;
					z.y = player.transform.position.y;
				}

				if (z.x > end.x)
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
					player.transform.position += player.transform.right  * speed *0.5f * Time.deltaTime;
					z.x = player.transform.position.x;
				}
				if (start.x < end.x)
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
					player.transform.position -= player.transform.right * speed *0.5f * Time.deltaTime;
					z.x = player.transform.position.x;
				} 
				if (z.x - end.x > 100 || end.x - z.x > 100 )
				{

					/*east = false;
					west = false;
					north = false;
					south = false;
					z = start;
					start = end;
					end = z;*/
					/*gameOver = true;
				}

			}*/

		}
		/*if(north)
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
		}*/
		//rotate = Quaternion.Euler (x,270,90); //Создаем новую переменную типа Quaternion для задавания угла поворота 
		player.transform.rotation = rotate; //Поворачиваем персонаж 
	}
}