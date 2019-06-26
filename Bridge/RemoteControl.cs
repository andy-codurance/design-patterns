namespace Bridge
{
    public abstract class RemoteControl
    {
        private TV tv;

        public void On()
        {
            tv.On();
        }

        public void Off()
        {
            tv.Off();
        }

        public void SetChannel(int channel)
        {
            tv.TuneChannel(channel);
        }
    }
}