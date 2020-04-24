﻿using MyLib_Csharp.DataStructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.Tool
{

    public partial class FSM
    {
        public List<FSMState> states = new List<FSMState>();
        public FSMState currentState;

        public FSM(FSMState initState, params FSMState[] state)
        {
            currentState = initState;
            states.Add(initState);
            states.AddRange(state);
        }
        public void AddState(params FSMState[] state) => states.AddRange(state);

        public void Update()
        {
            currentState.Enter();
            (var isTransition, var targetState) = currentState.CheckTransition();
            if (isTransition)
            {
                currentState.Exit();
                currentState = targetState;
                currentState.Enter();
            }
            currentState.update();
        }

    }
}
