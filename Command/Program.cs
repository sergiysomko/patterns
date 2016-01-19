using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
            #region
            // 
            //Light light = new Light();
            //Light garageDoorLight = new Light();
            //Stereo stereo = new Stereo();
            //// 
            //LightOnCommand lightOnCommand = new LightOnCommand(light);
            //GarageLightOnCommand garageLightOnCommand = new GarageLightOnCommand(garageDoorLight);
            //StereoOnWithCdCommand stereoOnWithCdCommand = new StereoOnWithCdCommand(stereo);

            //LightOffCommand lightOffCommand = new LightOffCommand(light);
            //GarageLightOffCommand garageLightOffCommand = new GarageLightOffCommand(garageDoorLight);
            //StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);
            ////
            //remoteControl.SetCommand(0, lightOnCommand, lightOffCommand);
            //remoteControl.SetCommand(1, garageLightOnCommand, garageLightOffCommand);
            //remoteControl.SetCommand(2, stereoOnWithCdCommand, stereoOffCommand);
            ////
            //Console.WriteLine(remoteControl);

            //remoteControl.OnButtonWasPushed(0);
            //remoteControl.OffButtonWasPushed(0);
            //Console.WriteLine(remoteControl);
            //remoteControl.UndoButtonWasPushed();
            //remoteControl.OffButtonWasPushed(0);
            //remoteControl.OnButtonWasPushed(0);
            //Console.WriteLine(remoteControl);
            //remoteControl.UndoButtonWasPushed();

            ////remoteControl.OnButtonWasPushed(1);
            ////remoteControl.OffButtonWasPushed(1);
            ////remoteControl.OnButtonWasPushed(2);
            ////remoteControl.OffButtonWasPushed(2);
            #endregion
            var ceilingFan = new CeilingFan();
            var ceilingFanHight = new CeilingFanHightCommand(ceilingFan);
            var ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(1, ceilingFanHight, ceilingFanOff);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(1);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();
            
            Console.ReadKey(true);

        }
    }
}
/*
 * Для макро-команд створюється масив команд і 
    при виклиці методу він виконується для кожного елемента масиву
 * такожи до інтерфейсу Command можна додавати метод load() i store() 
   для реєстрації команд та відновлення їх (якщо стався збій)
*/