using System;
using System.Collections.Generic;
using System.Device.Gpio;
using System.Linq;
using System.Threading.Tasks;

namespace RPiGPIO.Data
{
    public class GPIOControl
    {
        public GpioController controller { get; set; } = new GpioController();

        
    }
}
