namespace aernauticaimperialis {
    public abstract class ACommand : ICommand{
        public ACommand() {
        }

        public abstract void Move(Point end);
    }
}