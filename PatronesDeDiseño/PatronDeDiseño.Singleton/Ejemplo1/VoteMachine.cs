using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño.Singleton.Ejemplo1
{
    /// <summary>
    /// La VoteMachineclase anterior es una clase singleton donde su constructor es privado y la propiedad Instancia devuelve la misma instancia cada vez. 
    /// El RegisterVote()método aumenta el recuento de votos en 1. 
    /// La TotalVotespropiedad devuelve el total de votos registrados.
    /// </summary>
    public class VoteMachine
    {
        private static VoteMachine _Instance = null;
        private int _totalesVotes = 0;

        private VoteMachine()
        {
            
        }

        public static VoteMachine Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new VoteMachine();
                }
                return _Instance;

            }
        }

        public void RegisterVote()
        {
            _totalesVotes += 1;
            Console.WriteLine($"Voto resgistrado { _totalesVotes }");
        }

        public int TotalVotes
        {
            get
            {
                return _totalesVotes;
            }
        }
    }
}
