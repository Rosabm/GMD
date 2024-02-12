In this project, I followed unity tutorial in order to create a simple (yet fun!) game in which the player controls a ball on a platform and has to collect a number of small diamonds. I extended the tutorial to add a second level in which the player can jump and the collectibles are on top of small platforms.

I created a 3D unity project and added a new scene to it. In this scene, I added the playing fields for the two levels, one on top of another: a plane 3D object acting as the ground with some cubes as walls, a sphere as the player, cilinders for the platforms and I created a prefab of a small cube that works as a collectible item so I can place 13 of them and change all at the same time. I used the Transform properties to scale the ground, cubes and walls, to tilt the small cubes, and to place everything where it needed to go. I also adjusted the properties of the Directional Light and added some text for keeping track of the score and displaying when the user changes levels or has won the game.

To change the color of the playing objects, I did it with materials, which I saved in a new folder to keep everything organized. By changing properties like color, metallic map and smoothness I can have different types of material that fit better to each object, for example, the player ball has a higher smoothness value which gives it the shiny appearance.

Level 1:
![image](https://github.com/Rosabm/GMD/assets/100294631/373fdb5f-b104-49b8-ad19-5acf4c3a41dc)

Level 2: 
![image](https://github.com/Rosabm/GMD/assets/100294631/ed107d6e-8da2-483c-889a-82282f2a2108)


Regarding the scripts, I added one to control the player and all of the functionality, one for making the camera follow the ball, and a last one to make the collectibles turn.
The player script controls the movement with the help of the Input system package. I also needed to add a rigidBody to the gameObject, in order for it to respond to the laws of physics. I created a speed variable, and I made it public so I could change it from the unity inspector. That way, I can use it to add forces to the ball in the FixedUpdate() function, multiplying it by a vector3 movement I created based on two movement x and y variables that are updated in the onMove variable (given by the input system). In this method I also check for when the user press the spacebar and if the player is in the second level (its y position = -9.5) then the ball jumps, so the result is that the the ball moves with the user input at the desired speed, and is able to jump in the second level.

![image](https://github.com/Rosabm/GMD/assets/100294631/4fe1f111-907e-4871-8d8b-2f871729dd14)

To make the collectibles disappear when the ball touches them, I made them into triggers so I could use the OnTriggerEnter() function, and I gave them a unity tag to check in this method that the collider will only disappear if it haves it (so the walls or the ground don’t accidentally disappear). The player script also has references to the win and count texts so it can update the count every time it hits a collectible (in the onTriggerEnter function) and when the count gets to 13 it destroys the level1 field so the player falls into the level 2, and it displays the level 2 text for two seconds, when the count gets to 20 it displays the winning message, which concludes the game!

![image](https://github.com/Rosabm/GMD/assets/100294631/99d083f7-7900-4943-b432-b39f780fe148)

I created a build for playing the game in windows, and this is the final result: 

![image](https://github.com/Rosabm/GMD/assets/100294631/cdb29f0b-9197-4184-bfeb-8666bd4af350)
![image](https://github.com/Rosabm/GMD/assets/100294631/db6dce7f-2479-4901-a125-f4700bad0dfc)


