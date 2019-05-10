namespace Core
{
    public interface MazeFactory
    {
        Maze MakeMaze();
        Room MakeRoom(int roomNumber);
        Door MakeDoor(Room adjoiningRoom1, Room adjoiningRoom2);
        Wall MakeWall();
    }
}