using System;
using System.Collections;
using System.Collections.Generic;
using Command.Command.AbstractCommand;
using UnityEngine;
using UnityEngine.UIElements;

namespace Command.Commands
{
    public class CommandInvoker 
    {
        private Stack<ICommand> commandRegistry = new Stack<ICommand>();

        public void ProcessCommand(ICommand commandToProcess)
        {
            ExecuteCommand(commandToProcess);
            RegisterCommand(commandToProcess);
        }
        private void ExecuteCommand(ICommand commandToExecute)
        {
            commandToExecute.Execute();
        }
        private void RegisterCommand(ICommand commandToRegister)
        {
            commandRegistry.Push(commandToRegister);
        }
    }



}
