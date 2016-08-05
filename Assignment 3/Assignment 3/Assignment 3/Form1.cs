using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        private double sum = 0; // Keeps track of the Integral sum of all errors for PI calculations 
        private int samples = 0; // Keeps track of sample size plotted on Chart within the Temp Control Tab
        private int timeStamp = 0; // Keeps track of whether a second has passed
        EventHandler ev; // EventHandler object used for C# Timer
        public Form1()
        {
            InitializeComponent();

            // Retrieve available COM Ports on this computer
            string[] ports = SerialPort.GetPortNames();
            // Adding available COM Ports to the combo box
            comPortComboBox.Items.AddRange(ports);
            setupLEDBulb.On = false;
            // Remove every tab besides Setup tab initially
            appTabs.TabPages.Remove(digitalIOTab);
            appTabs.TabPages.Remove(potsTab);
            appTabs.TabPages.Remove(lightTab);
            appTabs.TabPages.Remove(tempControlTab);

        }

        // Event handler that gets called when the user clicks the Connect Button
        // within the Setup Tab
        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieves selected COM Port from the combo box
                string port = comPortComboBox.SelectedItem.ToString();
                // If no option from the combo box is selected, then the SerialPort
                // will set the default COM Port, typically COM Port1, else set the
                // selected COM Port
                if (port.Equals(""))
                {
                    serialPort1.PortName = serialPort1.PortName;
                }
                else
                {
                    serialPort1.PortName = port;
                }
                // Retrieve selected Baud Rate from combo box, set timeouts and open the COM
                // Port to allow serial communications
                serialPort1.BaudRate = int.Parse(baudRateComboBox.SelectedItem.ToString());
                serialPort1.ReadTimeout = 500;
                serialPort1.WriteTimeout = 500;
                serialPort1.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry, there was an error" + ex.Message, "Error", MessageBoxButtons.OKCancel);
            }
            
            // Sending instruction to check whether communication is working
            byte checkComms = readInstruction(0x00);
            // If byte returned is 0x0F, the communications is working correctly
            // This is then indicated on the GUI turning on the LED Bulb and displaying
            // a label to the user 
            if (checkComms == 0x0F)
            {
                setupLEDBulb.On = true;
                connectLabel.Visible = true;
                // Once communications is working, add the other tabs to the GUI
                appTabs.TabPages.Add(digitalIOTab);
                appTabs.TabPages.Add(potsTab);
                appTabs.TabPages.Add(lightTab);
                appTabs.TabPages.Add(tempControlTab);
            }
        }

        // Method used to send a read instruction to the MCU and returns a byte
        // which was sent from the MCU
        private byte readInstruction(byte instr)
        {
            try
            {
                // Sends a byte array from the serial port, consisting of a start byte,
                // the corresponding instruction byte and a stop byte
                byte[] buffer = { 0x53, instr, 0xAA };
                serialPort1.Write(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OKCancel);
            }
            return (byte)serialPort1.ReadByte(); 
        }

        // A similar method to the above with the exception being that it is used 
        // to send the respective data from the Digital I/O, Light and Temp Control Tabs
        private byte readInstructionData(byte instr, ushort portCData)
        {
            try
            {
                // Breaks up a 16 bit integer into its respective bytes
                byte[] data = BitConverter.GetBytes(portCData);
                // Byte array which will be used to send a start byte, instruction
                // byte, the data bytes in order and the stop byte
                byte[] buffer = { 0x53, instr, data[0], data[1], 0xAA };
                serialPort1.Write(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OKCancel);
            }
            return (byte)serialPort1.ReadByte();
        }

        // An event handler that processes what needs to be done whenever the user 
        // selects one of the tabs in the GUI
        private void appTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Resetting sum to 0 when a new PI calculation should start, i.e. if exiting the Temp Control tab and then returning back to it
            // Otherwise sum will always increase and the Integral part of PI will keep getting larger
            switch (appTabs.SelectedIndex)
            {
                case 0: //Setup Tab
                    sum = 0;
                    appTimer.Stop();
                    break;
                case 1: //Digital I/O Tab
                    sum = 0;
                    UpdateTimerEvent(digIO_Tick);
                    break;
                case 2: //Pots Tab
                    sum = 0;
                    UpdateTimerEvent(pots_Tick);
                    break;
                case 3: //Light Tab
                    sum = 0;
                    UpdateTimerEvent(light_Tick);
                    break;
                case 4: //Temp Control Tab
                    byte sentHeaterValue = readInstructionData(0x0B, (ushort)100); // Effetively send 100% so heater on MCU is maxed out using PWM
                    UpdateTimerEvent(tempControl_Tick);
                    break;
            }
        }

        //Digital I/O Callback to Automate LEDs
        void digIO_Tick(object sender, EventArgs e)
        {
            int result = 0;
            int first7Seg = 0; // Stores the result to be displayed on the first 7 segment
            int second7Seg = 0; // Stores the result to be displayed on the second 7 segment
            int sevenSegTotal = 0;
            ushort sevenSegValue = 0;

            // Iterates through all the options within the checked list box
            for (int i = 0; i < (portcCheckedListBox.Items.Count); i++)
            {
                // If one of the options is selected, then raise that numbered
                // option to the power of 2
                if (portcCheckedListBox.GetItemChecked(i))
                {
                    result = result + (int)Math.Pow(2, i);
                    // Keep perforiming modulo division on the result according to
                    // 2^i until result equals 0
                    if (result >= 128)
                    {
                        result = result % 128;
                        second7Seg += 8;
                    }
                    if (result >= 64)
                    {
                        result = result % 64;
                        second7Seg += 4;
                    }
                    if (result >= 32)
                    {
                        result = result % 32;
                        second7Seg += 2;
                    }
                    if (result >= 16)
                    {
                        result = result % 16;
                        second7Seg += 1;
                    }
                    if (result >= 8)
                    {
                        result = result % 8;
                        first7Seg += 8;
                    }
                    if (result >= 4)
                    {
                        result = result % 4;
                        first7Seg += 4;
                    }
                    if (result >= 2)
                    {
                        result = result % 2;
                        first7Seg += 2;
                    }
                    if (result >= 1)
                    {
                        result = result % 1;
                        first7Seg += 1;
                    }
                }
            }

            // Convert corresponding 7 seg values to string in hexadecimal format
            // in order to be displayed on the GUI 7 segment display
            sevenSegment1.Value = first7Seg.ToString("X");
            sevenSegment2.Value = second7Seg.ToString("X");
            // Combining both 7 seg values into one decimal format number and casting
            // it into an unsigned 16 bit integer
            sevenSegTotal = second7Seg * 16 + first7Seg;
            sevenSegValue = (ushort)sevenSegTotal;
            // Send instruction to the MCU stating the sevenSegValue is to be displayed
            // on the MCU's PORTC LED's (PORTC Data displayed on the MCU should correspond
            // to the value displayed on the GUI 7 Segment Display), byte returned is the 
            // instruction sent
            byte sentPortC = readInstructionData(0x0A, sevenSegValue);

            // Sends an instruction to read the toggle switch values set in PINA on the 
            // MCU, receieves that data back as a byte
            byte PinA = readInstruction(0x01);

            // Based on byte received from the MCU, turn on the corresponding LED Bulbs
            // on the GUI according to the toggle switches turned on, within the MCU
            pina0LedBulb.On = Convert.ToBoolean(PinA & 1);
            pina1LedBulb.On = Convert.ToBoolean(PinA & 2);
            pina2LedBulb.On = Convert.ToBoolean(PinA & 4);
            pina3LedBulb.On = Convert.ToBoolean(PinA & 8);
            pina4LedBulb.On = Convert.ToBoolean(PinA & 16);
            pina5LedBulb.On = Convert.ToBoolean(PinA & 32);
            pina6LedBulb.On = Convert.ToBoolean(PinA & 64);
            pina7LedBulb.On = Convert.ToBoolean(PinA & 128);
        }
       
       //Pots Callback to Automate Voltage reading for MCU Potentiometers
        void pots_Tick(object sender, EventArgs e)
        {
            byte ADCH = readInstruction(0x02); // Read MCU Potentiometer 1 
            byte ADCHTwo = readInstruction(0x03); // Read MCU Potentiometer 2

            double ADCHDoubleOne = Convert.ToDouble(ADCH);
            double ADCHDoubleTwo = Convert.ToDouble(ADCHTwo);

            // Converting ADCH readings from MCU Potentiometers into its Analogue Voltage
            // Analogue Voltage = ADCH (Digital Value) * refVoltage / ADC Resolution
            double voltageOne = (ADCHDoubleOne * 5) / 256; 
            double voltageTwo = (ADCHDoubleTwo * 5) / 256;

            // Displaying the volatge values on the GUI Potentiometers
            potGauge1.DialText = voltageOne.ToString();
            potGauge1.Value = (float)voltageOne;
            potGauge2.DialText = voltageTwo.ToString();
            potGauge2.Value = (float)voltageTwo;
        }

        //Light Callback to Automate setting lamp brightness on MCU
        void light_Tick(object sender, EventArgs e)
        {
            // Displays scroll bar value within a read only text box
            lampBrightnessTextBox.Text = lampBrightnessScrollBar.Value.ToString() + "%";
            ushort scrollBarValue = (ushort)lampBrightnessScrollBar.Value;
            // Sending scroll bar value to MCU so that it will set the brightness of the
            // MCU Lamp using PWM
            byte sentLampValue = readInstructionData(0x0C, scrollBarValue);

            // Instruction sent to MCU so that it will return the ADCH reading from the 
            // MCU Light Sensor
            byte readLightSensor = readInstruction(0x05);
            double light = Convert.ToDouble(readLightSensor);
            // Displaying the ADCH reading of the MCU Light Sensor on the GUI Potentiometer
            lightGauge.DialText = light.ToString();
            lightGauge.Value = (float)light;
        }

        //Temp Control Callback to Automate PI control for Temperature
        void tempControl_Tick(object sender, EventArgs e)
        {
            // Instruction sent to MCU so that it will return the ADCH reading from the 
            // MCU Temperature Sensor
            byte readTempSensor = readInstruction(0x04);
            // Converting the ADCH reading from the MCU Temperature Sensor into degrees
            // celsius, according to AUT Lab board schematic, every 50 mV equates to 1 degree
            // celsius, therefore...
            // 5V(refVoltage)/256(ADC Resolution) = 19.53 mV
            // 50 mV / 19.53 mV = 2.56 = 2, every 2 ADC counts equals 50 mV
            double actualTemp = Convert.ToDouble(readTempSensor/2.56);
            // Formatting temperature to 2 d.p. to be displayed within a read only text box
            actualTempTextBox.Text = actualTemp.ToString("0.00");
            
            // Samples occur every 50 ms but graph will be updated every second
            if (timeStamp >= 20) // 50 ms * 20 = 1 second
            {
                // Plotting data on chart
                tempChart.Series["Temperature"].Points.AddXY(samples, actualTemp);
                // Setting max and min values for graphs x-axis so that the scale keeps updating
                tempChart.ChartAreas[0].AxisX.Maximum = (samples);
                tempChart.ChartAreas[0].AxisX.Minimum = (samples - 10);
                samples += 1;
                timeStamp = 0; // Reset timeStamp variable so graph updates every second
            }


            // Retrieveing appropriate values from the controls in the Temp Control tab
            double setPoint = (double)tempControlnumericUpDown.Value;
            double kP = (double)kPnumericUpDown.Value;
            double kI = (double)kInumericUpDown.Value;

            // Ensuring kP and kI are positive constants
            if (kP < 0)
                kP = kP * -1;
            if (kI < 0)
                kI = kI * -1;

            double error = actualTemp - setPoint;
            sum = sum + (error * 0.05);

            // Limiting what the sum (integral error) can become equal to
          /*  if (sum >= 20)
            {
                sum = 20;
            }
            if(sum <= -20)
            {
                sum = -20;
            }*/

            // Calculating PI output for motor speed using formula provided in the Assignment 3 pdf
            double f = (kP * error) + (kI * sum);

            //Ensuring f (PI output) is between 0 and 399, 399 is the TOP value set for Timer/Counter 1 in the MCU
            if (f < 0)
                f = 0;
            if (f >= 399)
                f = 399;

            ushort motorSpeedValue = (ushort)f;
            // Displaying f as a percentage in a read only text box
            motorSpeedTextBox.Text = ((f / 399) * 100).ToString("0.00") + "%"; 
            // Send motor speed value to MCU so that it can set the MCU Motor Speed using PWM
            byte sentMotorValue = readInstructionData(0x0D, motorSpeedValue);
            timeStamp++;
        }


        private void UpdateTimerEvent(EventHandler newev)
        {
            appTimer.Stop(); //Stop the Timer
            if (ev != null) //If we have a previous event (ev is a data member of
                            // type EventHandler)
                appTimer.Tick -= ev; //Remove the previous tick event
            appTimer.Tick += newev; //Add our new one
            ev = newev; //Save the new one
            appTimer.Start(); //Restart the timer
        }
    }
}
