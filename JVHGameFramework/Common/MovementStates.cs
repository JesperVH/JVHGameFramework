using System;
using System.Collections.Generic;
using System.Text;

namespace JVHGameFramework.Common
{
    public class MovementStates
    {
        //Først er der oprettet en liste (her en enum)
        //som indeholder de forskellige tilstande man kan befinde sig i
        //man kan gå mod enten op, ned, højre eller venstre.
        public enum internalState { upwards, left, right, downwards }

        //Her laves en liste (igen en enum) med de tasteinput
        //man forventer at møde.
        public enum internalInput { left, right, forward }

        //Man opretter en instans af en state machine.
        private internalState State { get; set; }

        //Et state table bliver oprettet, hvor man designerer,
        //hvor stort en antal tilstande og inputs man har
        //med tilstanden som x-værdi og input som y-værdi.        
        internalState[,] stateTable = new internalState[4, 3];

        //Her bliver en start tilstand angivet,
        //samt hvad tilstanden skal ændres til
        //ved et speciffikt input
        public MovementStates()
        {
            State = internalState.left;
            stateTable[0, 0] = internalState.left;
            stateTable[0, 1] = internalState.right;
            stateTable[0, 2] = internalState.upwards;
            stateTable[1, 0] = internalState.downwards;
            stateTable[1, 1] = internalState.upwards;
            stateTable[1, 2] = internalState.left;
            stateTable[2, 0] = internalState.upwards;
            stateTable[2, 1] = internalState.downwards;
            stateTable[2, 2] = internalState.right;
            stateTable[3, 0] = internalState.right;
            stateTable[3, 1] = internalState.left;
            stateTable[3, 2] = internalState.downwards;
        }

        //Man angiver, hvad de forskellige input er og deres type.
        //Her er det gjort ved fortælle at input'et er et tryk på tastaturet
        //og de tre udvalgte tastetryk får tildelt et input
        public internalInput input()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case 'a':
                    return internalInput.left;
                case 'd':
                    return internalInput.right;
                case 'w':
                    return internalInput.forward;
                default:
                    return internalInput.forward;
            }

        }

        //Tilstanden ændres ved at ændre tilstandstabellens værdier
        //til den nuværende tilstand samt det input som bliver givet.
        public internalState changeState(internalInput input)
        {
            State = stateTable[(int)State, (int)input];
            return State;
        }
    }
}
