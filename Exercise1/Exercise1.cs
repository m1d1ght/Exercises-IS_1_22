using System;

namespace Exercise1
{
    class Engine
    {
        private const int Statestopped = 1;
        private const int Statestarted = 2;
        public int Enginestate;

        public void start()
        {
            Console.Out.WriteLine( "Start" );
            Enginestate = Statestopped;
        }

        public void Stop()
        {
            Console.Out.WriteLine( "Stop" );
            Enginestate = Statestarted;
        }

        public String GetState()
        {
            String state = null;
            if( Enginestate == Statestarted)
                state = "STOPPED";          
            else if( Enginestate == Statestopped)
                state = "STARTED";
            return state;
        }
    }
}
