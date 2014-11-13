namespace ElevatorDemo
{
  class Elevator
  {
    public int PersonCapacity { get; set; }
    public bool IsWorking { get; set; }
    public bool IsMoving { get; set; }
    public int NumberPersonCarried { get; set; }
    public bool IsFull { get; set; }
    public int Position { get; set; }
    public ElevatorMovingDirection MovingDirection { get; set; }
    public decimal Mileage { get; set; }
    

    public Elevator(int personCapacity = 1, bool isWorking = true, bool isMoving = false, int numberOfPersonCarried = 0, bool isFull = false, 
      int position = 0, ElevatorMovingDirection movingDirection = ElevatorMovingDirection.NotMoving)
    {
      PersonCapacity = personCapacity;
      IsWorking = isWorking;
      IsMoving = isMoving;
      NumberPersonCarried = numberOfPersonCarried;
      IsFull = isFull;
      Position = position; // what floor the elevator is at?
      MovingDirection = movingDirection;
      Mileage = 0;
    }

  }
}