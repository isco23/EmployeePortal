using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Builder.IBuilder;

namespace Web.Builder.ConcreteBuilder
{
    public class DestopBuilder : ISystemBuilder
    {
        ComputerSystem destop = new ComputerSystem();
        public ISystemBuilder AddDrive(string size)
        {
            destop.HDDSize = size;
            return this;
        }

        public ISystemBuilder AddKeyboard(string type)
        {
            destop.Keyboard = type;
            return this;
        }

        public ISystemBuilder AddMemory(string memory)
        {
            destop.RAM = memory;
            return this;
        }

        public ISystemBuilder AddTouchScreen(string enabled)
        {
            return this;
        }
        public ComputerSystem GetSystem()
        {
            return destop;
        }

        public ISystemBuilder AddMouse(string type)
        {
            destop.Mouse = type;
            return this;
        }
    }
}