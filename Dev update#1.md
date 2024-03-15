At this point, the game includes the main title menu, and the tutorial of the game.
I created the main player that can, currently, move (with its corresponding animations), jump, chnage between wate and fire powers and fire balls (water and fire). I also added a hearts system for when the player dies. As for the course, I created the small diamonds collectibles, that the player can only get with the corresponding element, fire, water and venom pools, that kills water, fire and both respectively, and I added enemies (small spiders that I got from unity assets store). All of this is included in the tutorial:

![image](https://github.com/Rosabm/GMD/assets/100294631/ef048912-78f7-4bdf-af56-afe389534265)
![image](https://github.com/Rosabm/GMD/assets/100294631/856fae65-dcb3-4b6c-83c8-f8631e9301bd)
![image](https://github.com/Rosabm/GMD/assets/100294631/de78824b-6358-4812-98e5-6f3bf21184f7)
![image](https://github.com/Rosabm/GMD/assets/100294631/e601890d-feff-4b10-b0c7-11da441c9c7c)

The title page have animated buttons (gets bigger when hover) to go to the tutorial, to the game, to settings and to exit the game. Of course, right now, only the tutorial one is working.

![image](https://github.com/Rosabm/GMD/assets/100294631/9729aa77-5adb-497e-8afd-f2ca1b1a80b7)

So that's how all looks right now.. but how was it made?
Starting with the player, it is a game object made with two game objects so that they move at the exact same time, but only one is active, and they change between them when the user press the button that I assigned to "change" in the input manager.

![image](https://github.com/Rosabm/GMD/assets/100294631/440a4379-6ce4-4e44-9754-efc9de184cab)

For collecting the diamonds or dying, I simply gave tags to the objects, pools and diamonds, to indicate to which of the elements (fire/water) they should react, and in the onTrigger enter function in the player script I check for those tags according to a private variable I have define "fireActive"

![image](https://github.com/Rosabm/GMD/assets/100294631/d43805ad-f92a-4695-8a52-af74712fdbb6)

The movement of the player was easy, but I had troubles because it was jumping as much as it wanted, so I also defined another private variable "isJumping" and I only allow it to jump if is false, this is how I control said variable:

![image](https://github.com/Rosabm/GMD/assets/100294631/97043e82-88d2-434a-a967-7f7e05fe2411)

I also needed that the camera followed the player, so I created a camera controller and I also added logic to it to not show the start and end of my scene (ill add it for the game as well)

![image](https://github.com/Rosabm/GMD/assets/100294631/89524ac6-a154-4f03-8599-280e7eae2b6e)

In the scene, it actually looks like this:

![image](https://github.com/Rosabm/GMD/assets/100294631/a2e86f2a-8f06-4db0-86e6-b732b54b5241)

The plane below the ground is also setting a trigger that kills the player if he falls.
As for the spiders, well, then just kinda move: 

![image](https://github.com/Rosabm/GMD/assets/100294631/2a817355-13b4-4292-8d1f-a5380f6f57fd)

The code to kills them is actually in the fire and water projectiles, I decided to do it like this so I can later decide which enemies dies with water and which with fire.
Through the course, I place a number of cube triggers to control the text of the tutorial, and the last one also actiavtes the spiders, so no matter how long the player takes to complete the first time, the spiders will always appear when he arrives to that point. 

![image](https://github.com/Rosabm/GMD/assets/100294631/7c2eaa90-a5a0-4d57-90df-14a1af71bf5c)

Right now the only animations I added are for the player and for the buttons on the menu (the spiders had their own already), the player has animations for standing, running and firing a ball, and the button grow bigger and change color when hovering and change color once more when selecting them.

![image](https://github.com/Rosabm/GMD/assets/100294631/bcf9e3ee-1fbb-4a03-bc55-de274cd29a9c)

As I said, the manu buttons now don't really do much:

![image](https://github.com/Rosabm/GMD/assets/100294631/b6f2b8e5-7a8b-4ed4-8c96-ce720940c61b)

This is the current state of my game: Super Element Bros!


