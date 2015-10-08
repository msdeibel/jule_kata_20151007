using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jule_kata_20151007
{
    public class GameMaster
    {
        private MarkerStack markerStack;
        private uint lastAddedPlayerId;
        private SixSidedDie[] diceSet;

        private Dictionary<uint, Player> players;

        public GameMaster()
        {
            lastAddedPlayerId = 0;
            markerStack = MarkerStack.GameMarkerStack();
            players = new Dictionary<uint, Player>();
            InitializeDiceSet();
        }

        private void InitializeDiceSet()
        {
            diceSet = new SixSidedDie[3];

            diceSet[0] = new SixSidedDie();
            diceSet[1] = new SixSidedDie();
            diceSet[2] = new SixSidedDie();
        }

        public object MarkerCount()
        {
            return markerStack.Count();
        }

        public object PlayerCount()
        {
            return players.Count;
        }

        public void RegisterPlayer()
        {
            lastAddedPlayerId++;
            players.Add(lastAddedPlayerId, new Player());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="playerId">Position count starts at 1</param>
        public void DeregisterPlayer(uint palyerId)
        {
            players.Remove(palyerId);
        }

        public RollResult RollDice(bool rollDie1, bool rollDie2, bool rollDie3, RollResult previousResult)
        {
            RollResult previousRoll = null != previousResult ? previousResult : new NullRollResult();

            int temp1 = 0;
            int temp2 = 0;
            int temp3 = 0;

            if (rollDie1 || 0 == previousResult.Die1()) 
            {
                temp1 = diceSet[0].Roll();
            }
            else
            {
                temp1 = previousResult.Die1();
            }

            if (rollDie2 || 0 == previousResult.Die2())
            {
                temp2 = diceSet[1].Roll();
            }
            else
            {
                temp2 = previousResult.Die2();
            }

            if (rollDie3 || 0 == previousResult.Die3())
            {
                temp3 = diceSet[2].Roll();
            }
            else
            {
                temp3 = previousResult.Die3();
            }

            return new RollResult(temp1, temp2, temp3);
        }
    }
}
