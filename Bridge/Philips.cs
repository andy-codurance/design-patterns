using System;

namespace Bridge
{
    class Philips : TV
    {
        public void On() => throw new NotImplementedException();

        public void Off() => throw new NotImplementedException();

        public void TuneChannel(int channel) => throw new NotImplementedException();
    }
}