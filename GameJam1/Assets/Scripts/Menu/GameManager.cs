using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	/*public Texture2D[] Facebook;
	public Texture2D[] Twitter;*/
	public Texture2D[] Settings;
	public Texture2D[] Play;
	//public Texture2D[] Record;
	public Texture2D[] Vk;
	//public Texture2D[] Home;
	//public Texture2D Traengl;
		//,t2,t3,t4,t5;

	//25.09.2015 For centry position of subject

	private Vector2 butt1, butt2, butt3, butt4, butt5, butt6, butt7;
	private Vector2 buttEnd1, buttEnd2, buttEnd3, buttEnd4, buttEnd5, buttEnd6, buttEnd7;
	//public Texture2D[] t1;
	//private FbButton FacebookButton;
	//private FbButton TwitterButton;
	private FbButton SettingsButton;
	private FbButton PlayButton;
	//private FbButton RecordButton;
	private FbButton VkButton;
	//private FbButton HomeButton;
	//private FbButton Traengl;
	private Vector2 localCentr1, localCentr2 , localCentr3 , localCentr4 , localCentr5 , localCentr6 , localCentr7  ;

		//, TwitterButton, SettingsButton, PlayButton, RecordButton;

	// Use this for initialization
	void Start () 
	{
		Time.timeScale = 0;
		Vector2 CentralPoint, leftUp1, leftUp2;
        // prepeir Sings

        CentralPoint.x = Screen.width / 2;
        CentralPoint.y = Screen.height / 2;
		int MinX = Screen.width / 64;
		int MinY = Screen.height / 36;

			leftUp1.x = 0 - 8*MinX;
			leftUp1.y = 0 - 8*MinY;
			leftUp2.x = 0 - 5*MinX;
			leftUp2.y = 0 - 5*MinY;
		/*//facebook button
			butt1.x = leftUp2.x + CentralPoint.x + 18 * MinX;
			butt1.y = leftUp2.y + CentralPoint.y - 11 * MinY;
			buttEnd1.x = 2 * leftUp2.x * (-1);
			buttEnd1.y = 2 * leftUp2.y * (-1);
			localCentr1.x = butt1.x - leftUp2.x; 
			localCentr1.y = butt1.y - leftUp2.y;
		//twitter button
			butt2.x = leftUp2.x + CentralPoint.x + 23 * MinX;
			butt2.y = leftUp2.y + CentralPoint.y;
			buttEnd2.x = 2 * leftUp2.x * (-1);
			buttEnd2.y = 2 * leftUp2.y * (-1);
			localCentr2.x = butt2.x - leftUp2.x; 
			localCentr2.y = butt2.y - leftUp2.y;*/
		//settings button
			butt3.x = leftUp2.x + CentralPoint.x - 18 * MinX;
			butt3.y = leftUp2.y + CentralPoint.y + 11 * MinY;
			buttEnd3.x = 2 * leftUp2.x * (-1);
			buttEnd3.y = 2 * leftUp2.y * (-1);
			localCentr3.x = butt3.x - leftUp2.x; 
			localCentr3.y = butt3.y - leftUp2.y;
		//play button
			butt4.x = leftUp1.x + CentralPoint.x;
			butt4.y = leftUp1.y + CentralPoint.y;
			buttEnd4.x = 2 * leftUp1.x * (-1);
			buttEnd4.y = 2 * leftUp1.y * (-1);
			localCentr4.x = butt4.x - leftUp1.x; 
			localCentr4.y = butt4.y - leftUp1.y;
		/*//record button
			butt5.x = leftUp2.x + CentralPoint.x - 18 * MinX;
			butt5.y = leftUp2.y + CentralPoint.y - 11 * MinY;
			buttEnd5.x = 2 * leftUp2.x * (-1);
			buttEnd5.y = 2 * leftUp2.y * (-1);
			localCentr5.x = butt5.x - leftUp2.x; 
			localCentr5.y = butt5.y - leftUp2.y;*/
		//vk button
			butt6.x = leftUp2.x + CentralPoint.x + 18 * MinX;
			butt6.y = leftUp2.y + CentralPoint.y + 11 * MinY;
			buttEnd6.x = 2 * leftUp2.x * (-1);
			buttEnd6.y = 2 * leftUp2.y * (-1);
			localCentr6.x = butt6.x - leftUp2.x; 
			localCentr6.y = butt6.y - leftUp2.y;
		/*//home button
			butt7.x = leftUp2.x + CentralPoint.x - 23 * MinX;
			butt7.y = leftUp2.y + CentralPoint.y;
			buttEnd7.x = 2 * leftUp2.x * (-1);
			buttEnd7.y = 2 * leftUp2.y * (-1);
			localCentr7.x = butt7.x - leftUp2.x; 
			localCentr7.y = butt7.y - leftUp2.y;*/
		/*

		if (Screen.width == 1360)
		{
			leftUp1.x = 0 - 8*MinX;
			leftUp1.y = 0 - 8*MinY;
			leftUp2.x = 0 - 5*MinX;
			leftUp2.y = 0 - 5*MinY;
		//facebook button
			butt1.x = leftUp2.x + CentralPoint.x + 18 * MinX;
			butt1.y = leftUp2.y + CentralPoint.y - 11 * MinY;
			buttEnd1.x = 2 * leftUp2.x * (-1);
			buttEnd1.y = 2 * leftUp2.y * (-1);
			localCentr1.x = butt1.x - leftUp2.x; 
			localCentr1.y = butt1.y - leftUp2.y;
		//twitter button
			butt2.x = leftUp2.x + CentralPoint.x + 23 * MinX;
			butt2.y = leftUp2.y + CentralPoint.y;
			buttEnd2.x = 2 * leftUp2.x * (-1);
			buttEnd2.y = 2 * leftUp2.y * (-1);
			localCentr2.x = butt2.x - leftUp2.x; 
			localCentr2.y = butt2.y - leftUp2.y;
		//settings button
			butt3.x = leftUp2.x + CentralPoint.x - 18 * MinX;
			butt3.y = leftUp2.y + CentralPoint.y + 11 * MinY;
			buttEnd3.x = 2 * leftUp2.x * (-1);
			buttEnd3.y = 2 * leftUp2.y * (-1);
			localCentr3.x = butt3.x - leftUp2.x; 
			localCentr3.y = butt3.y - leftUp2.y;
		//play button
			butt4.x = leftUp1.x + CentralPoint.x;
			butt4.y = leftUp1.y + CentralPoint.y;
			buttEnd4.x = 2 * leftUp1.x * (-1);
			buttEnd4.y = 2 * leftUp1.y * (-1);
			localCentr4.x = butt4.x - leftUp1.x; 
			localCentr4.y = butt4.y - leftUp1.y;
		//record button
			butt5.x = leftUp2.x + CentralPoint.x - 18 * MinX;
			butt5.y = leftUp2.y + CentralPoint.y - 11 * MinY;
			buttEnd5.x = 2 * leftUp2.x * (-1);
			buttEnd5.y = 2 * leftUp2.y * (-1);
			localCentr5.x = butt5.x - leftUp2.x; 
			localCentr5.y = butt5.y - leftUp2.y;
		//vk button
			butt6.x = leftUp2.x + CentralPoint.x + 18 * MinX;
			butt6.y = leftUp2.y + CentralPoint.y + 11 * MinY;
			buttEnd6.x = 2 * leftUp2.x * (-1);
			buttEnd6.y = 2 * leftUp2.y * (-1);
			localCentr6.x = butt6.x - leftUp2.x; 
			localCentr6.y = butt6.y - leftUp2.y;
		//home button
			butt7.x = leftUp2.x + CentralPoint.x - 23 * MinX;
			butt7.y = leftUp2.y + CentralPoint.y;
			buttEnd7.x = 2 * leftUp2.x * (-1);
			buttEnd7.y = 2 * leftUp2.y * (-1);
			localCentr7.x = butt7.x - leftUp2.x; 
			localCentr7.y = butt7.y - leftUp2.y;
//			GUI.Button( new Rect(butt4.x,butt4.y,buttEnd4.x,buttEnd4.x),Traengl);
		}*/
		if (Screen.width == 1024)
		{
			CentralPoint.x = Screen.width / 2;
			CentralPoint.y = Screen.height / 2;
			MinX = Screen.width / 56 ;
			MinY = Screen.height / 42;
			leftUp1.x = 0 - 9*MinX;
			leftUp1.y = 0 - 9*MinY;
			leftUp2.x = 0 - 6*MinX;
			leftUp2.y = 0 - 6*MinY;
			//facebook button
			butt1.x = leftUp2.x + CentralPoint.x + 14 * MinX;
			butt1.y = leftUp2.y + CentralPoint.y - 13 * MinY;
			buttEnd1.x = 2 * leftUp2.x * (-1);
			buttEnd1.y = 2 * leftUp2.y * (-1);
			localCentr1.x = butt1.x - leftUp2.x; 
			localCentr1.y = butt1.y - leftUp2.y;
			//twitter button
			butt2.x = leftUp2.x + CentralPoint.x + 20 * MinX;
			butt2.y = leftUp2.y + CentralPoint.y;
			buttEnd2.x = 2 * leftUp2.x * (-1);
			buttEnd2.y = 2 * leftUp2.y * (-1);
			localCentr2.x = butt2.x - leftUp2.x; 
			localCentr2.y = butt2.y - leftUp2.y;
			//settings button
			butt3.x = leftUp2.x + CentralPoint.x - 14 * MinX;
			butt3.y = leftUp2.y + CentralPoint.y + 13 * MinY;
			buttEnd3.x = 2 * leftUp2.x * (-1);
			buttEnd3.y = 2 * leftUp2.y * (-1);
			localCentr3.x = butt3.x - leftUp2.x; 
			localCentr3.y = butt3.y - leftUp2.y;
			//play button
			butt4.x = leftUp1.x + CentralPoint.x;
			butt4.y = leftUp1.y + CentralPoint.y;
			buttEnd4.x = 2 * leftUp1.x * (-1);
			buttEnd4.y = 2 * leftUp1.y * (-1);
			localCentr4.x = butt4.x - leftUp1.x; 
			localCentr4.y = butt4.y - leftUp1.y;
			//record button
			butt5.x = leftUp2.x + CentralPoint.x - 14 * MinX;
			butt5.y = leftUp2.y + CentralPoint.y - 13 * MinY;
			buttEnd5.x = 2 * leftUp2.x * (-1);
			buttEnd5.y = 2 * leftUp2.y * (-1);
			localCentr5.x = butt5.x - leftUp2.x; 
			localCentr5.y = butt5.y - leftUp2.y;
			//vk button
			butt6.x = leftUp2.x + CentralPoint.x + 14 * MinX;
			butt6.y = leftUp2.y + CentralPoint.y + 13 * MinY;
			buttEnd6.x = 2 * leftUp2.x * (-1);
			buttEnd6.y = 2 * leftUp2.y * (-1);
			localCentr6.x = butt6.x - leftUp2.x; 
			localCentr6.y = butt6.y - leftUp2.y;
			//home button
			butt7.x = leftUp2.x + CentralPoint.x - 20 * MinX;
			butt7.y = leftUp2.y + CentralPoint.y;
			buttEnd7.x = 2 * leftUp2.x * (-1);
			buttEnd7.y = 2 * leftUp2.y * (-1);
			localCentr7.x = butt7.x - leftUp2.x; 
			localCentr7.y = butt7.y - leftUp2.y;
//			GUI.Button( new Rect(butt4.x,butt4.y,buttEnd4.x,buttEnd4.x),Traengl);
		}
		/*localCentr1.x = butt1.x - leftUp2.x; 
		localCentr1.y = butt1.y - leftUp2.y;*/

		//FacebookButton = new FbButton(butt1,buttEnd1, Facebook[0], Facebook[1], Facebook[2], localCentr1, leftUp2);
		//TwitterButton = new FbButton(butt2, buttEnd2, Twitter[0], Twitter[1], Twitter[2], localCentr2, leftUp2);
		SettingsButton = new FbButton(butt3, buttEnd3, Settings[0], Settings[1], Settings[2], localCentr3, leftUp2);
		PlayButton = new FbButton(butt4, buttEnd4, Play[0], Play[1], Play[2], localCentr4, leftUp1);
		//RecordButton = new FbButton(butt5, buttEnd5, Record[0], Record[1], Record[2], localCentr5, leftUp2);
		VkButton = new FbButton(butt6, buttEnd6, Vk[0], Vk[1], Vk[2], localCentr6, leftUp2);
		//HomeButton = new FbButton(butt7, buttEnd7, Home[0], Home[1], Home[2], localCentr7, leftUp2);
		/*FacebookButton = new FbButton(butt1,buttEnd1, Facebook[0], Facebook[1], Facebook[2], localCentr4, leftUp2);
		TwitterButton = new FbButton(butt2, buttEnd2, Twitter[0], Twitter[1], Twitter[2], localCentr4, leftUp2);
		SettingsButton = new FbButton(butt3, buttEnd3, Settings[0], Settings[1], Settings[2], localCentr4, leftUp2);
		PlayButton = new FbButton(butt4, buttEnd4, Play[0], Play[1], Play[2], localCentr4, leftUp1);
		RecordButton = new FbButton(butt5, buttEnd5, Record[0], Record[1], Record[2], localCentr4, leftUp2);
		VkButton = new FbButton(butt6, buttEnd6, Vk[0], Vk[1], Vk[2], localCentr4, leftUp2);
		HomeButton = new FbButton(butt7, buttEnd7, Home[0], Home[1], Home[2], localCentr4, leftUp2);*/
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (SettingsButton != null && PlayButton != null && VkButton != null)
		{
			if(SettingsButton.Update(Input.mousePosition, Input.GetMouseButton(0)))
			{
				if (SettingsButton._state == ButtonState.Active)
				{
					Application.Quit();
				}
				//Log("SettingsButton click");
			}

			if(PlayButton.Update(Input.mousePosition, Input.GetMouseButton(0)))
			{
				//Application.LoadLevel("Scene1");
				//Log("PlayButton click");
				if (PlayButton._state == ButtonState.Active)
				{
					Time.timeScale = 1;
					//Application.LoadLevel("Scene1");
				}
			}

			
			if(VkButton.Update(Input.mousePosition, Input.GetMouseButton(0)))
			{
				//Log("VkButton click");
			}
			
		}
		/*if(myBut1 != null && myBut2 != null)
		{
			if(myBut1.Update(Input.mousePosition, Input.GetMouseButton(0)))
			{
				//Log("myBut1 click");
			}
			if(myBut2.Update(Input.mousePosition, Input.GetMouseButton(0)))
			{
				//Log("myBut2 click");
			}
		}*/
	}

	void OnGUI()
	{

		if (SettingsButton != null && PlayButton != null && VkButton != null)
		{
			//FacebookButton.Draw();
			//TwitterButton.Draw();
			SettingsButton.Draw();
			PlayButton.Draw();
			//RecordButton.Draw();
			VkButton.Draw();
			//HomeButton.Draw();
			//somesing do
		}
		//GUI.Button( new Rect(butt4.x,butt4.y,buttEnd4.x,buttEnd4.x),Traengl);
	}
}
