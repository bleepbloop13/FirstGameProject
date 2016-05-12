using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using FirstGameProject.View;

namespace FirstGameProject.Model
{
	public class Player
	{
		private int score;
		private bool active;
		private int health;
		private Animation playerAnimation;
		// Animation representing the player
		public Texture2D PlayerTexture;

		// Position of the Player relative to the upper left side of the screen
		public Vector2 Position;

		// Animation representing the player
		public Animation PlayerAnimation
		{
			get {return playerAnimation; }
			set {playerAnimation = value; }
		}


		// State of the player
		public bool Active 
		{
			get { return active; }
			set { active = value; }
		}
		
		// Amount of hit points that player has
		public int Health
		{
			get {return health;}
			set {health = value;}
		}
		// Get the width of the player ship
		public int Width
		{
			get { return playerAnimation.FrameWidth; }
		}

		// Get the height of the player ship
		public int Height
		{
			get { return playerAnimation.FrameHeight; }
		}

		public int Score
		{
			get{ return score; }
			set{ score = value; }

		}
		public void Initialize(Animation animation, Vector2 position)
		{
			this.playerAnimation = animation;

			// Set the starting position of the player around the middle of the screen and to the back
			Position = position;

			// Set the player to be active
			this.Active = true;

			// Set the player health
			this.Health = 100;

			// Set the player score
			this.Score = 0;
		}
		public void Draw(SpriteBatch spriteBatch)
		{ 
			playerAnimation.Draw(spriteBatch);
		}
		public void Update(GameTime gameTime)
		{
			playerAnimation.Position = Position;
			playerAnimation.Update(gameTime);
		}
	}
}

