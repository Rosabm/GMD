Since last update, I haven't have that much time to spend in the game, so there aren't that many improvements. I hope to be able to dedicate more time now that clases are over and have a great game by the time of the hand in.
These are the improvements I made:

I added sound to the game. Not only background music (a happy melody), but also several sound effects, for exampe when the player jumps, gets a colectibe, fires a ball or dies. I added an audio source in loop for the music and play the effects through the player controller

![image](https://github.com/Rosabm/GMD/assets/100294631/0e0c1825-14ea-4b34-b179-24a304366bfa)
![image](https://github.com/Rosabm/GMD/assets/100294631/4928bbcf-817e-4dd2-a1f2-9904cf5f7c00)
![image](https://github.com/Rosabm/GMD/assets/100294631/28a0a335-3c00-4500-898f-150bee9f5a07)

I also noticed that the game had a weird behaviour when jumping. Specifically, because im checking collisions to the ground and ice to make sure that the player doesn't doube jump, he could technically jump towards a wall or block of ice, that counts as a collision, and then be abe to double jump. I wanted to avoid this, so I moved the checks to a new game object in the feet of the player with a small sphere collider. I created a new script for these checks and moved the jumping behaviour in the player from the update to a new function, to be abe to call it. These changes improved the quality of the game a ot i think.

![image](https://github.com/Rosabm/GMD/assets/100294631/93d5d1db-5e8f-4d79-8f70-a8dd1de321ae)
![image](https://github.com/Rosabm/GMD/assets/100294631/3fa65d26-9cee-4f1e-805b-48865cda4033)

At one point of the game, I have a block of ice that the player must push to the water and stand on it to get a fire collectible. Therefore, to make the game a bit more realistic, I made the ice foat on the water. In order to do that, I simply applied an upwards force to the ice when is in contact to the water to mimic the floating behaviour.

https://github.com/Rosabm/GMD/assets/100294631/40074c14-0f53-49b7-81f5-5eb9df0533a2
![image](https://github.com/Rosabm/GMD/assets/100294631/e2af400f-e6bd-4ffe-9347-fd2b406ee43f)

I also added a text next to the hearts to display the player score, and I made it so that killing enemies also increases the score, not only getting collectibles.

![image](https://github.com/Rosabm/GMD/assets/100294631/50babdff-3b4e-4a21-9896-b2cfd391d328)

I also changed the main menu, so you could select the different options with the joystick and without the mouse. To do that I needed to select a button to be selected by default and then add the connection betweeen them.

![image](https://github.com/Rosabm/GMD/assets/100294631/06a69856-dafe-4469-b49f-5c12d396448a)


Lastly, I changed the input manager to work with the arcade machine. I haven't tested it yet, but it should work now.

And that's how my game is going!!
