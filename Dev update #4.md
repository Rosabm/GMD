This is the final dev update, and probably also one of the longests.

I have finished my game and a playable version is in the arcade machine. This are the improvements and additions since last time:

I have changed the look of the game, adding a sky with some clouds in the background, and changing as well the ground material. I have also change the material of the ice, to make it more clear that it is ice. In my opinion it now looks way better!

![image](https://github.com/Rosabm/GMD/assets/100294631/2e76d751-d1d2-4cc1-a414-43a274579006)
![image](https://github.com/Rosabm/GMD/assets/100294631/6e2b838b-c9ce-4210-abda-9865626dec6b)

I have added a new state for the player: air. He can use the joystick to fly. This state can be access by getting an item in the course, and pressing the white button in the arcade machine, and it will only last 10 seconds. To make it, I have store the time that the user enters the state and then compare it to the actual time in the update function. I have added a boolean variable in the health manager to know if the player has the item that will be set to true when the player gets the flying item box that I createdas a prefab, when he gets it it will also show a wing image in the canvas. I created as well the transitions in the fire and water states if the playerhas the item and presses the button (that is actually mapped as an axis in the input manager).
I have created the air boy by copying the water one, deleting the bubbles from head, changing the color and adding some wings I got from the assets store, I also created a new "flying" animation and added the corresponding transitions to make it work. You can see the final result in the gif below

![image](https://github.com/Rosabm/GMD/assets/100294631/2210eacc-169e-4c4d-9b0f-5450fd758533)

![image](https://github.com/Rosabm/GMD/assets/100294631/49a2f714-59bb-4a8f-b6c7-ca4e1990baa1)

![image](https://github.com/Rosabm/GMD/assets/100294631/b232b1c3-979a-4e3d-9745-a6ebf5d48ed8)

![image](https://github.com/Rosabm/GMD/assets/100294631/f1a0e2b8-f512-4d03-a1c6-66aaa50fd3e4)

![volar-ezgif com-video-to-gif-converter](https://github.com/Rosabm/GMD/assets/100294631/7b5555ee-fa42-4b7b-8da3-98c4df95d12b)

To increase the difficulty of the game, I have also adde some spikes obstacles, and 2 more different kind of enemies: a bat, that you need to fire the ball while jumping to kill, and a mushroom that grows bigger if you hit him with water and only dies if you hit him with fire. I made this just by changing the size if it is hit by a waterball and setting it to inactive it normally with a fireBall.

![image](https://github.com/Rosabm/GMD/assets/100294631/82bd035b-bef7-4d52-afb6-de842b8c50ea)

![image](https://github.com/Rosabm/GMD/assets/100294631/170cb3a4-d6c6-4063-a463-8b4549677402)

![bat-ezgif com-video-to-gif-converter](https://github.com/Rosabm/GMD/assets/100294631/1d4ff5ba-027f-49c8-b016-a45066209e7a)

![mushroom-ezgif com-video-to-gif-converter](https://github.com/Rosabm/GMD/assets/100294631/2dfa8ae3-f5a2-426b-b8bc-f5687c77912e)

I also changed that now when you kill a enemy instead of destroying it you set it to inactive, that's because I created a "dying controller" that makes sure to leave the game as it was in the begginning once you die, with the exception of the collectibles you have gotten. It has an array of "things to restore" and a die method that I call from the HealthController classes when they hit something hurtful for them. I also needed to create this script and add it to a health  game object in each of the "boys" because the player was losing sometimes two hearts intead of one when they died, so I fixed it like this..

![image](https://github.com/Rosabm/GMD/assets/100294631/7d4d0896-6c8d-4f5a-b08f-ea984cee8295)
![image](https://github.com/Rosabm/GMD/assets/100294631/385cc8bc-b0d9-4320-a48e-08fbf0d33805)

I changed the tutorial text to match the buttons of the arcade and test that all of the inputs were working correctly in the arcade

![WhatsAppVideo2024-06-06at13 38 05-ezgif com-optimize](https://github.com/Rosabm/GMD/assets/100294631/8e64efa4-8e6c-4bb4-9e19-8eae82ea10b1)
![flyarcade-ezgif com-video-to-gif-converter](https://github.com/Rosabm/GMD/assets/100294631/d474cdd0-e5ec-496b-9f65-d964b851f4b8)

Lastly, I removed the settings button from the main menu

![image](https://github.com/Rosabm/GMD/assets/100294631/f6238da5-0806-4647-9c89-d5a8a313042f)

I wanted to add a proper end to the game, but unfortunatelly I didn't have more time, still, I am really happy with the result, and I have had a lot of fun creating and playing my game. Now I'll record the video to hand in and see if I can upload a playable version to github pages so it can also be played online. This is the end of my GMD project!!
