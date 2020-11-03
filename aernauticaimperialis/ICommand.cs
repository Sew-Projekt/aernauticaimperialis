namespace aernauticaimperialis {
    public interface ICommand {
        public void Move(Point end);

        public bool IsSpin();
    }
}