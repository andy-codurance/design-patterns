namespace Bridge
{
    public class UniversalRemoteControl : RemoteControl
    {
        private int currentChannel;

        public void UpChannel()
        {
            currentChannel += 1;
            SetChannel(currentChannel);
        }
        
        public void DownChannel()
        {
            currentChannel -= 1;
            SetChannel(currentChannel);
        }
    }
}