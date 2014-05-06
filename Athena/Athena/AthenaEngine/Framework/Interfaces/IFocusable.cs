using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace AthenaEngine.Framework.Interfaces
{
	/// <summary>
	/// I focusable.
	/// </summary>
	public interface IFocusable
	{
		/// <summary>
		/// Gets the position.
		/// </summary>
		/// <value>
		/// The position.
		/// </value>
		Vector2 Position { get; }
	}
}

