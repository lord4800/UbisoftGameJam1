using UnityEngine;
using System.Collections;

public class ControllerCam: MonoBehaviour 
{
	/*public Rect Rectangle1
	{
		get;
		private set;
	}*/
	private GameObject player; //Переменна объекта персонажа с которым будем работать. 
	//public Texture2D player;
	//public ch
	bool PeopleTF = true;
	bool VampireTF = false;
	bool LowVampireTF = false;
	bool HightVampireTF = false;
    public static float speed = 25; //Скорость перемещения персонажа. Запись public static обозначает что мы сможем обращаться к этой переменной из любого скрипта 
	public static float _speed; //постоянная скорость перемещения персонажа 
	//public int rotation = 250; //Скорость пповорота персонажа 
	//change for exemplar day night
	public static bool IsDracula; //Двоичная переменная, которая будет отвечать В каком мы виде.   
	//public static float x = -90f; //угол поворота персонажа по оси x 
	private bool north = false;
	private bool east = false;
	private bool west = false;
	private bool south = false;
	// Use this for initialization
	void Start () 
	{ 
		IsDracula = false; //По умолчанию оружие у нас спрятано. 
		_speed = speed; //Задаем постоянное стандартное значение скорости персонажа 
		player = (GameObject)this.gameObject; //Задаем что наш персонаж это объект на котором расположен скрипт 
	} 
	
	// Update is called once per frame
	void Update () 
	{

		if(north)
		{
			speed = 25;
		}
		if(south)
		{
			speed = 25;
		}
		if (west)
		{
			speed = 25;
		}
		if (east)
		{
			speed = 25;
		}
		if(north && east)
		{
			speed = 12.5f;
		}
		if(south && west)
		{
			speed = 12.5f;
		}
		if (west && north)
		{
			speed = 12.5f;
		}
		if (east && south)
		{
			speed = 12.5f;
		}
		 //Создаем новую переменную типа Quaternion для задавания угла поворота 
		 //Поворачиваем персонаж 
		if(PeopleTF == true) //Персонаж вампир?
		{ 

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
				player.transform.position -= player.transform.right  * speed *0.5f * Time.deltaTime; //Перемещаем назад 
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
				player.transform.position += player.transform.up * speed *0.5f * Time.deltaTime; //перемещаем в лево 
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
				player.transform.position -= player.transform.up * speed *0.5f * Time.deltaTime; //перемещаем в право 
			} 
			if(Input.GetKeyUp (KeyCode.S))
			{
				north = false;
			} 
		}
		else if(VampireTF == false) 
		{

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
				player.transform.position += player.transform.right * speed * Time.deltaTime; //Перемещаем персонажа в перед. 
				
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
				player.transform.position += player.transform.right  * speed * Time.deltaTime; //Перемещаем назад 
			} 
			if(Input.GetKeyUp(KeyCode.A))
			{
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
				player.transform.position += player.transform.right * speed * Time.deltaTime; //перемещаем в право 
			} 
			if(Input.GetKeyUp (KeyCode.S))
			{
				north = false;
			} 
		}
		else if(LowVampireTF == false) 
		{

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
		else if(HightVampireTF == false) 
		{

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

	}
	/*void OnGUI()
	{
		GUI.DrawTexture(Rectangle, player);
	}*/
}
