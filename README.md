# SNIP SNIP (Unity)

A simple Flappy Bird clone made in Unity, replicating the core mechanics of the original game. Control a pair of Scissors, avoid obstacles, and try to achieve the highest score!

<div style="text-align: center;">
  <img id="slideshow" src="image1.jpg" style="max-width: 80%; height: auto; border: 1px solid #ddd; border-radius: 4px;">
</div>

<script>
  let images = ["[image1.jpg](https://github.com/GHeart01/SnipSnip-/blob/main/img/s0.png)", "[image2.jpg](https://github.com/GHeart01/SnipSnip-/blob/main/img/s1.png)", "[image3.jpg](https://github.com/GHeart01/SnipSnip-/blob/main/img/s3.png)"];
  let current = 0;
  setInterval(() => {
    current = (current + 1) % images.length;
    document.getElementById("slideshow").src = images[current];
  }, 3000); // Change image every 3 seconds
</script>

## Features
- **Classic Flappy Bird gameplay** – Tap to make the scissors open and close to avoid obstacles.
- **Score system** – Earn points for every pipe you pass.
- **Game Over screen** – Restart the game instantly after failing.
- **Simple & clean design** – Easy to play, hard to master.

## Controls
- **Left Mouse Click** 

## How to Play
1. Press any key (or tap on mobile) to make the scissors jump.
2. Navigate through the gaps between pipes.
3. Don't hit the obstacles or the ground!
4. Try to beat your high score.



## Development (For Developers)
Built with **Unity 2024.X.X**.  
To modify or build from source:
1. Clone this repository.
2. Open the project in Unity Hub.
3. Make your changes and rebuild.

## Credits
- Developed by **Geralt Heart**.
- Inspired by the original **Flappy Bird** by Dong Nguyen.


## License
This project is open-source under the [MIT License](LICENSE).  

---
**Enjoy the game!** 🎮  
Feedback and contributions are welcome.  
