At the last dev update, the game included the tutorial and the main menu. Since then, I have started the actual game, and included several improvements:

I changed the player script to use an state pattern. Now water and fire are states and each of them inlcude their own behaviour, rather than having all the player behavior toguether in the same script and changing the "fire active" variable. This choice is also going to support adding new states in the future, as I'm intending to add also air and rock states (for when the player gets the powerups). In terms of implementation, the state pattern includes an IState interface, a State machine script and scripts for each f the states:

State machine, to controll transitions between states: 

![image](https://github.com/Rosabm/GMD/assets/100294631/4f2a9c63-01f2-4b84-bc50-d274c8804642)

IState interface, which all states implement: 

![image](https://github.com/Rosabm/GMD/assets/100294631/f697eb83-a413-4571-aba9-a54570e9328b)

Fire state script:

![image](https://github.com/Rosabm/GMD/assets/100294631/8f71ba39-df50-4f37-899e-b957594dc1a5)

![image](https://github.com/Rosabm/GMD/assets/100294631/2fcbabbb-3efb-4088-93c6-37f706b4435e)

This also means that the PlayerController script is now smaller, including only the code that is neccesary independently of the state, which is mainly movement and keeping track of the save points, which were also added since last time. They look like this: 

![image](https://github.com/Rosabm/GMD/assets/100294631/4463bb78-f74d-4bff-9edc-983604e09999)

And when the player gets to them, their position is saved for respawning there when they die, and the save point color changes to green.

Now lets look at the game itself: 

![image](https://github.com/Rosabm/GMD/assets/100294631/f6cc81d4-b9e1-4687-b754-c9740f91b881)

One of the first things the player finds is a new element I added: blocks of ice. They can be pushed by the player and they "melt" (shrink) when the fire player comes close. The code to controll it is in the fire state:

![image](https://github.com/Rosabm/GMD/assets/100294631/7d434504-a70a-48bd-868b-92ad0f332edf)
![image](https://github.com/Rosabm/GMD/assets/100294631/285cec33-d5b3-4291-8ec9-0552261f0874)

Another new feauture is regarding enemies movement. In the last update, they constantly moved to the front. Now, they still have that option as a default, but I also added the patrolling option, so the can move between a number of points.


