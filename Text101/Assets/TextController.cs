using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine;
using System.Collections;


	
public class TextController : MonoBehaviour {

	

	public Text text;
	private enum States {trapped,nothing,freedom,eat,freedom_0,look_0,storage,end,ocean, roam,stick, rope,bag,water,night,look,plane, food, knife ,knife_0,food_0,free,tent_0,knife_1,Run,Fight,Run_0,free_0, Tent, clothes, key};
	private States myState;
	// Use this for initialization
	
	void Start () {
	myState = States.trapped;
	
	
	}
	
	// Update is called once per frame
	void Update () {
	print (myState);
	if (myState == States.trapped) {
	state_trapped();
		} else if ((myState == States.food)) {
		state_food();
		} else if((myState == States.knife)) {
		state_knife();
		}
		else if((myState == States.night)) {
		state_night();
}
		else if((myState == States.knife_0)) {
			state_knife_0();
}
		else if((myState == States.food_0)) {
			state_food_0();
	}
		else if((myState == States.free)) {
			state_free();
		}
		else if((myState == States.Run)) {
			state_Run();
		}
		else if((myState == States.knife_1)) {
			state_knife_1();
		}
		else if((myState == States.Run_0)) {
			state_Run_0();
		}
		else if((myState == States.Fight)) {
			state_Fight();
		}
		else if((myState == States.free_0)) {
			state_free_0();
		}
		else if((myState == States.Tent)) {
			state_Tent();
		}
		else if((myState == States.clothes)) {
			state_clothes();
		}
		else if((myState == States.key)) {
			state_key();
		}
		else if((myState == States.tent_0)) {
			state_tent_0 ();
		}
		else if((myState == States.eat)) {
			state_eat();
		}
		else if((myState == States.freedom)) {
			state_freedom ();
		}
		else if((myState == States.look)) {
			state_look ();
		}
		else if((myState == States.plane)) {
			state_plane ();
		}
			else if((myState == States.eat)) {
			state_eat();
		}
		else if((myState == States.freedom)) {
			state_freedom ();
		}
		else if((myState == States.look)) {
			state_look ();
		}
		else if((myState == States.plane)) {
			state_plane ();
		}
		else if((myState == States.rope)) {
			state_rope ();
		}
		else if((myState == States.bag)) {
			state_bag ();
		}
		else if((myState == States.water)) {
			state_water ();
		}
		else if((myState == States.stick)) {
			state_stick ();
		}
		else if((myState == States.storage)) {
			state_storage ();
		}
		else if((myState == States.roam)) {
			state_roam ();
		}
		else if((myState == States.end)) {
			state_end ();
		}
		else if((myState == States.ocean)) {
			state_ocean ();
		}
		else if((myState == States.freedom_0)) {
			state_freedom_0 ();
		}
		else if((myState == States.nothing)) {
			state_nothing ();
		}
		else if((myState == States.look_0)) {
			state_look_0 ();
		}
	}
	
	void state_trapped () {
	
	
		text.text = "On an unkonwn Island you are tied with a rope. Prisoned by the pirates, and You wanna escape. There are some food infront of you, a Knife and its getting dark." +
			"You have to find a boat to escape \n\n" +
				"Press F to reach for Foods\nPress K to reach for knife\nPress W to wait for Dark";
			if(Input.GetKeyDown(KeyCode.F))				{myState = States.food;}
			 	else if (Input.GetKeyDown(KeyCode.K)) 	    {myState = States.knife;
		}
			else if (Input.GetKeyDown(KeyCode.W)) 		{myState = States.night ;}
		}
	void state_food (){
		
		text.text = "You can see coconuts, cheese, crabs. Looks delicious " +
			"But pirates are all over here. You can't have them. Maybe you can take a look at those when they are sleeping!!\n\n" +
			"Press R to Go back";
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.trapped;}
	}
	void state_knife (){
		
		text.text =  "The knife is too far away you can't reach that!! \n" +
			"I wish some how you could cut lose to get those foods. \n\n" +
				"Press R to Go back";
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.trapped;}
	}
	void state_night (){
			text.text = "Alright finally night came down and I think everyones asleep. \n\n" +
		
					"Press K to Reach for the knife again\nF to reach for the Foods\nR to Go back";
		if(Input.GetKeyDown(KeyCode.K))		{myState = States.knife_0;}
	else if(Input.GetKeyDown(KeyCode.F))	{myState = States.food_0;}
	else if(Input.GetKeyDown(KeyCode.R))	{myState = States.trapped;}
		
		}
	void state_knife_0 () {
			text.text =  "You still can't reach it!! Try something else \n\n" +
			
					"Press R to Go back";
			if(Input.GetKeyDown(KeyCode.R))		{myState = States.night;}
	
	}
		void state_food_0 () {
			text.text =  "Think ! Maybe the cheese could be in some use \n\n" +
				
				"Press T to Use those cheese\nPress R to Go back";
			if(Input.GetKeyDown(KeyCode.R))		{myState = States.night;}
		else if (Input.GetKeyDown(KeyCode.T))		{myState = States.free;}
			
		}
		void state_free() {
		text.text =  "Somehow you got some cheese on your hands. After sometimes a mouse came along and started eating the cheese. The mouse cut through your rope. Now you are Free!! But be careful, don't get spotted! \n\n"+
		"Press K to take the knife\nX to run for the pirates boat ";
		if(Input.GetKeyDown(KeyCode.K))		{myState = States.knife_1;}
		else if (Input.GetKeyDown(KeyCode.X))		{myState = States.Run;}
		else if (Input.GetKeyDown(KeyCode.R))		{myState = States.free;}

	}	void state_Run () {
		text.text = "You started running for your life ! Shit a pirate has spotted you and you got caught. \n" +
			"You have failed to Escape ! Game over! \n\n"+
			"Press R to start again";
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.trapped;}
	}

  		void state_knife_1 () {
  		text.text = "Finally you got the knife. Oh no ! a pirate has spoted you... \n\n" +
  		"Press F to fight with the enemy\nA to run away and Explore the island\nR to go back";
		if(Input.GetKeyDown(KeyCode.F))		{myState = States.Fight;}
		else if (Input.GetKeyDown(KeyCode.A))		{myState = States.Run_0;}
		else if (Input.GetKeyDown(KeyCode.R))		{myState = States.free;}
  		}
  		void state_Fight () {
		text.text = "You are now face to face with the enemy. You can't run away or go back. " +
			"The enemy is unarmed, You have the advantage! \n\n" +
			"Press SPACE use your knife";
		if(Input.GetKeyDown(KeyCode.Space))		{myState = States.free_0;}
  		}
  		void state_Run_0 () {
		text.text = "Well done ! You have ran away from your enemy. Now You can't go back \n\n" +
			"press L to look around the Island";
		if(Input.GetKeyDown(KeyCode.L))		{myState = States.look;}	
  		}
  		void state_look () {
  		text.text = "Now you got yourself deep in the Island. You see a crashed plane infront of you! \n\n" +
  		"S to search the plane\nR to go the otherway";
		if (Input.GetKeyDown(KeyCode.S))		{myState = States.plane;}
		else if (Input.GetKeyDown(KeyCode.R))		{myState = States.nothing;}
  		}
  		void state_nothing () {
  		text.text = "A dead end! \n\n" +
  		"Go back press R";
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.look;}
  		}
  		void state_plane () {
  		text.text = "It looks like the plane crashed here a long ago. There is nothing much here. You see some sticks, a rope a bag, and some drinking water. \n\n" +
  		"S to pick up sticks, G to get those ropes, T to take the bag, D to drink water\nR to go back";
		if(Input.GetKeyDown(KeyCode.S))		{myState = States.stick;}	
		else if (Input.GetKeyDown(KeyCode.G))		{myState = States.rope;}
		else if (Input.GetKeyDown(KeyCode.T))		{myState = States.bag;}
		else if (Input.GetKeyDown(KeyCode.D))		{myState = States.water;}
		else if (Input.GetKeyDown(KeyCode.R))		{myState = States.look;}
		
  		  		}
  		 void state_rope() {
  		 text.text = "You need something to carry the rope \n\n"+
  		 "Press R to go back";
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.plane;}	
  		  		}
  		 void state_stick() {
		text.text = "You need something to carry these Sticks \n\n"+
			"Press R to go back";
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.plane;}	
	}
  		 
  		  	
  		 void state_water (){
	text.text = "These water looks filthy. You can't drink  them! \n\n"+
		"Press R to go back";
	if(Input.GetKeyDown(KeyCode.R))		{myState = States.plane;}	
}
  		 
  		  		
  		 void state_bag () {
  		 
  		 text.text = "This old bag could be usefull. \n\n"+
  		 "Press T to pick up the bag\nR to go back";
		if(Input.GetKeyDown(KeyCode.T))		{myState = States.storage;}	
		else if (Input.GetKeyDown(KeyCode.R))		{myState = States.plane;}
  		 
  		  		}
  		 void state_storage () {
  		  		text.text = "Now you got a bag. maybe you can use it to carry those other items! \n\n" +
  		  "Press T to pick up the rope and sticks\nR to go back to crashed plane"	;
		if(Input.GetKeyDown(KeyCode.T))		{myState = States.roam;}	
		else if (Input.GetKeyDown(KeyCode.R))		{myState = States.plane;}	
  		 }
  		 void state_roam () {
  		 text.text = "Good job You can use these items to make a boat and escape. You just have to find the ocean. \n\n" +
  		 "Press E to got to the east\nW to go to west\nR to go back ";
		if(Input.GetKeyDown(KeyCode.E))		{myState = States.end;}	
		else if (Input.GetKeyDown(KeyCode.W))		{myState = States.ocean;}	
		
		else if (Input.GetKeyDown(KeyCode.R))		{myState = States.storage;}	
  		 }
  		 void state_end () {
  		 text.text = "There is a big mountain infront of you.It's a  dead end \n\n"+
  		 "Press R to go back";
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.roam;}	
  		 
  		 }
  		 void state_ocean (){
  		 text.text = "You have found the ocean ! You are very close to freedom. \n\n"+
  		 "press Space to make a boat out of those sticks and ropes\nR to go back" ; 
		if(Input.GetKeyDown(KeyCode.Space))		{myState = States.freedom_0;}	
		else if (Input.GetKeyDown(KeyCode.R))		{myState = States.roam;}	
  		 }
  		 
  		 void state_freedom_0 (){
		text.text = "It was full moon when you got on your boat. you looked back on the island and crused away. A fisherman ship rescued you. \n"+
		"You have escaped!! \n\n" +
		"Press R to play again";	
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.trapped;}
  		 
  		 }
  		
  		void state_free_0 () {
		text.text = "The enemy tried to punch you but you dodge and stabed him with your knife. I think he is dead. Be careful there are more pirates here!! \n\n" +
			"press T to take the pirate clothes\nPress G to go the Tent";
		if(Input.GetKeyDown(KeyCode.T))		{myState = States.clothes;}
		else if (Input.GetKeyDown(KeyCode.G))		{myState = States.Tent;}
 }
 void state_Tent () {
		text.text = "Now you are in the pirates tent. You find their key which tend to be their ships key. Maybe you can be free now !! \n\n" +
			"Press T to take the Key\nPress R to go back";
		if(Input.GetKeyDown(KeyCode.T))		{myState = States.key;}
		else if (Input.GetKeyDown(KeyCode.R))		{myState = States.free_0;}
 
 }
 void state_key () {
	text.text = "You got the key.Oh no ! the enemy has spotted you. Should have taken the clothes earlier.\n" +
		"You have failed to Escape ! Game over! \n\n"+
			"Press R to start again";
	if(Input.GetKeyDown(KeyCode.R))		{myState = States.trapped;}
}
	void state_clothes () {
		text.text = "Wow you look like a pirate now . It would be impossible to spot you now \n\n" +
				"Press T to go to pirates Tent\nPress S to search the Island";
		if(Input.GetKeyDown(KeyCode.T))				{myState = States.tent_0;}
		else if (Input.GetKeyDown(KeyCode.S))		{myState = States.look_0;}
	
}
void state_look_0 () {
		text.text = "Now you got yourself deep in the Island. You see a crashed plane infront of you! \n\n" +
			"S to search the plane\nR to go the otherway";
		if (Input.GetKeyDown(KeyCode.S))		{myState = States.plane;}
		else if (Input.GetKeyDown(KeyCode.R))		{myState = States.clothes;}


}

	void state_tent_0 () {
		text.text = "Now you are in the pirates tent. There you find the key for their speed boats and foods to eat !! \n\n" +
			"press T to take the Key\npress E to eat\nR to go back";
		if(Input.GetKeyDown(KeyCode.T))				{myState = States.freedom;}
		else if (Input.GetKeyDown(KeyCode.E))		{myState = States.eat;}
		else if (Input.GetKeyDown(KeyCode.R))		{myState = States.clothes;}
	}
	void state_eat () {
	text.text = "Yummm !! those crab fires tates heavnly. Now don't get carried way focus on your quest! \n\n"+
 "Press R to go back";	
	 if (Input.GetKeyDown(KeyCode.R))		{myState = States.tent_0;}
	}
	void state_freedom () {
		text.text = "You got the key of the speed boat. It was full moon when you got on to the speed board. You started it, looked back on the island and crused away to freedom, \n"+
			"You have successfully escaped ! \n\n" +
			"Press R to play again";	
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.trapped;}
	}
	
	
	
}

	

