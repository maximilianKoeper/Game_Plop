﻿using System;

namespace Game_Plop
{
	public abstract class Creature
	{
		// Declare the event using EventHandler<T>
		public event EventHandler<CustomEventArgs> RaiseCustomEvent;


		public int health;
		public int[] position = new int[2];
		public string texture;
		public string id;

		public Creature ()
		{
			
		}



		public void die() {
			plop();
			/*if(Quest.id()==id){
			Quest.completed(id);
			}*/
		}

		public void plop() {
			OnRaiseCustomEvent(new CustomEventArgs("Did something"));
			Console.WriteLine ("PLOP!");
		}







		protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
		{
			// Make a temporary copy of the event to avoid possibility of
			// a race condition if the last subscriber unsubscribes
			// immediately after the null check and before the event is raised.
			EventHandler<CustomEventArgs> handler = RaiseCustomEvent;

			// Event will be null if there are no subscribers
			if (handler != null)
			{
				// Format the string to send inside the CustomEventArgs parameter
				//e.Message += String.Format(" at {0}", DateTime.Now.ToString());

				// Use the () operator to raise the event.
				handler(this, e);
			}
		}
	}
}

