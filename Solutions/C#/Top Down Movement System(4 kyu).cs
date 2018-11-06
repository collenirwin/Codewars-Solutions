using System;
using System.Collections.Generic;
using System.Linq;

namespace TopDownMovement
{
    public class PlayerMovement
    {
        public Tile Position { get; private set; }
        public Direction Direction { get; private set; }
        List<Direction> directions = new List<Direction>();
        
        public PlayerMovement(int x, int y)
        {
            Position = new Tile(x, y);
        }
        
        public void Update()
        {
            var currentDirections = new List<Direction>();
        
            if (Input.GetState(Direction.Up))
            {
                currentDirections.Add(Direction.Up);
            }
            
            if (Input.GetState(Direction.Down))
            {
                currentDirections.Add(Direction.Down);
            }
            
            if (Input.GetState(Direction.Left))
            {
                currentDirections.Add(Direction.Left);
            }
        
            if (Input.GetState(Direction.Right))
            {
                currentDirections.Add(Direction.Right);
            }
            
            // order the directions as they were pressed
            currentDirections = directions
              .Where(x => currentDirections.Contains(x))
              .Union(currentDirections)
              .ToList();
            
            var direction = Direction;
            
            // atleast 1 button pressed
            if (currentDirections.Any())
            {
                // direction not set yet or direction no longer pressed
                if (!currentDirections.Contains(direction))
                {
                    // most significant pressed direction
                    direction = currentDirections.First();
                }
                
                var newDirections = currentDirections.Where(x => !directions.Contains(x));

                // new direction pressed
                if (newDirections.Any())
                {
                    direction = newDirections.First();
                    currentDirections = newDirections.Union(currentDirections).ToList();
                }
                else if (Input.GetState(Direction)) // last direction still pressed
                {
                    if (Direction == Direction.Up)
                    {
                        Position = new Tile(Position.X, Position.Y + 1);
                    }
                    else if (Direction == Direction.Down)
                    {
                        Position = new Tile(Position.X, Position.Y - 1);
                    }
                    else if (Direction == Direction.Left)
                    {
                        Position = new Tile(Position.X - 1, Position.Y);
                    }
                    else // Right
                    {
                        Position = new Tile(Position.X + 1, Position.Y);
                    }
                }
            }
            
            Console.WriteLine(direction.ToString());
            
            Direction = direction;
            directions = currentDirections;
        }
    }
}