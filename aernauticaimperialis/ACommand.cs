﻿namespace aernauticaimperialis {
    public abstract class ACommand{
        public ACommand() {
        }


        public void Move(Point end)
        {
            throw new System.NotImplementedException();
        }

        public bool IsSpin()
        {
            throw new System.NotImplementedException();
        }
    }
}