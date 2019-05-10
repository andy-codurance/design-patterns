using System;
using Core;

namespace Singleton
{
    class TheMazeFactory : MazeFactory
    {
        static TheMazeFactory instance;

        TheMazeFactory() { }
        
        public static TheMazeFactory Instance => instance;
    
        public Maze MakeMaze() => throw new NotImplementedException();
        
        public Room MakeRoom(int roomNumber) => throw new NotImplementedException();
        
        public Door MakeDoor(Room adjoiningRoom1, Room adjoiningRoom2) => throw new NotImplementedException();
        
        public Wall MakeWall() => throw new NotImplementedException();
    }
}