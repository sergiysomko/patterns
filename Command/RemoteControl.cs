using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class RemoteControl
    {
        private Command[] onCommands;
        private Command[] offCommands;
        private Command undoCommand;
        public RemoteControl()
        {
            this.onCommands = new Command[7];
            this.offCommands = new Command[7];

            Command noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                this.onCommands[i] = noCommand;
                this.offCommands[i] = noCommand;
            }
            this.undoCommand = new NoCommand();
        }
        public void SetCommand(int slot,Command onCommand,Command offCommand)
        {
            this.onCommands[slot] = onCommand;
            this.offCommands[slot] = offCommand;
        }
        public void OnButtonWasPushed(int slot)
        {
            this.onCommands[slot].Execute();
            this.undoCommand = onCommands[slot];
        }
        public void OffButtonWasPushed(int slot)
        {
            this.offCommands[slot].Execute();
            this.undoCommand = offCommands[slot];
        }
        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("\n----- Remote Control -----\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                res.AppendFormat(
                    "[slot {0}] {1} {2}\n", 
                    i, onCommands[i].GetType().Name, offCommands[i].GetType().Name
                    );
            }
            res.AppendFormat("[undo]  {0}", undoCommand.GetType().Name);
                return res.ToString();
        }
    }
}
