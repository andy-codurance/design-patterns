namespace Memento
{
    class Graphic
    {
        public void Move(Point delta)
        {
        }
    }

    class Point
    {
        public static Point operator -(Point other)
        {
            return new Point();
        }
    }

    class MoveCommand
    {
        private readonly Graphic target;
        private readonly Point delta;
        private ConstraintSolverMemento state;

        public MoveCommand(Graphic target, Point delta)
        {
            this.target = target;
            this.delta = delta;
        }

        public void Execute()
        {
            var solver = ConstraintSolver.Instance;
            state = solver.CreateMemento();
            target.Move(delta);
            solver.Solve();
        }

        public void Unexecute()
        {
            var solver = ConstraintSolver.Instance;
            target.Move(-delta);
            solver.SetMemento(state);
            solver.Solve();
        }
    }

    class ConstraintSolver
    {
        public static ConstraintSolver Instance { get; } = new ConstraintSolver();

        public void Solve() { }
        public void AddConstraint() { }
        public void RemoveConstraint() { }
        public ConstraintSolverMemento CreateMemento() => new ConstraintSolverMemento();
        public void SetMemento(ConstraintSolverMemento memento) { }
    }

    class ConstraintSolverMemento
    {
        // state of ConstraintSolver
    }
}