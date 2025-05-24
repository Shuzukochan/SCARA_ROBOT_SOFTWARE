using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SCARA_ROBOT_SOFTWARE
{
    public partial class ManualControl : Form
    {
        private bool isHolding = false;
        private double currentAngle = 0;

        public ManualControl()
        {
            InitializeComponent();
            cbStepSize.SelectedIndex = 0;

            string selectedText = cbStepSize.SelectedItem?.ToString() ?? "0";
            string numberPart = new string(selectedText.Where(char.IsDigit).ToArray());
            //UartManager.Instance.SendCommand($"STEP{numberPart}");
        }

        private void btnSetHome_Click(object sender, EventArgs e)
        {
            UartManager.Instance.SendCommand("HOME\r\n");
            currentAngle = 0;
        }

        private async void btnZUp_MouseDown(object sender, MouseEventArgs e)
        {
            isHolding = true;
            await HoldToSend("Z+\r\n");
        }

        private void btnZUp_MouseUp(object sender, MouseEventArgs e)
        {
            isHolding = false;
        }

        private async void btnZDown_MouseDown(object sender, MouseEventArgs e)
        {
            isHolding = true;
            await HoldToSend("Z-\r\n");
        }

        private void btnZDown_MouseUp(object sender, MouseEventArgs e)
        {
            isHolding = false;
        }

        private async void btnXLeft_MouseDown(object sender, MouseEventArgs e)
        {
            isHolding = true;

            await Task.Run(() =>
            {
                while (isHolding)
                {
                    string selectedText = cbStepSize.Invoke(() => cbStepSize.SelectedItem?.ToString() ?? "0");
                    string numberPart = new string(selectedText.Where(char.IsDigit).ToArray());

                    if (int.TryParse(numberPart, out int stepDeg))
                    {
                        if (currentAngle > 0)
                            currentAngle = -1;              
                        else
                            currentAngle -= stepDeg;         

                        if (currentAngle < -135) currentAngle = -135;

                        string thetaStr = Math.Abs(currentAngle).ToString("F2");
                        UartManager.Instance.SendCommand($"X-{thetaStr}\r\n");
                    }

                    Thread.Sleep(300);
                }
            });
        }


        private void btnXLeft_MouseUp(object sender, MouseEventArgs e)
        {
            isHolding = false;
        }

        private async void btnXRight_MouseDown(object sender, MouseEventArgs e)
        {
            isHolding = true;

            await Task.Run(() =>
            {
                while (isHolding)
                {
                    string selectedText = cbStepSize.Invoke(() => cbStepSize.SelectedItem?.ToString() ?? "0");
                    string numberPart = new string(selectedText.Where(char.IsDigit).ToArray());

                    if (int.TryParse(numberPart, out int stepDeg))
                    {
                        currentAngle += stepDeg;
                        if (currentAngle < 0) currentAngle = 1;        
                        if (currentAngle > 135) currentAngle = 135;    

                        string thetaStr = currentAngle.ToString("F2");
                        UartManager.Instance.SendCommand($"X+{thetaStr}\r\n");
                    }

                    Thread.Sleep(300);
                }
            });
        }



        private void btnXRight_MouseUp(object sender, MouseEventArgs e)
        {
            isHolding = false;
        }

        private async void btnYUp_MouseDown(object sender, MouseEventArgs e)
        {
            isHolding = true;
            await HoldToSend("Y+\r\n");
        }

        private void btnYUp_MouseUp(object sender, MouseEventArgs e)
        {
            isHolding = false;
        }

        private async void btnYDown_MouseDown(object sender, MouseEventArgs e)
        {
            isHolding = true;
            await HoldToSend("Y-\r\n");
        }

        private void btnYDown_MouseUp(object sender, MouseEventArgs e)
        {
            isHolding = false;
        }
        private async void btnBLeft_MouseDown(object sender, MouseEventArgs e)
        {
            isHolding = true;

            await Task.Run(() =>
            {
                while (isHolding)
                {
                    string selectedText = cbStepSize.Invoke(() => cbStepSize.SelectedItem?.ToString() ?? "0");
                    string numberPart = new string(selectedText.Where(char.IsDigit).ToArray());

                    if (int.TryParse(numberPart, out int stepDeg))
                    {
                        if (currentAngle > 0)
                            currentAngle = -1;
                        else
                            currentAngle -= stepDeg;

                        if (currentAngle < -135) currentAngle = -135;

                        string thetaStr = Math.Abs(currentAngle).ToString("F2");
                        UartManager.Instance.SendCommand($"B-{thetaStr}\r\n");
                    }

                    Thread.Sleep(500);
                }
            });
        }

        private void btnBLeft_MouseUp(object sender, MouseEventArgs e)
        {
            isHolding = false;
        }

        private async void btnBRight_MouseDown(object sender, MouseEventArgs e)
        {
            isHolding = true;

            await Task.Run(() =>
            {
                while (isHolding)
                {
                    string selectedText = cbStepSize.Invoke(() => cbStepSize.SelectedItem?.ToString() ?? "0");
                    string numberPart = new string(selectedText.Where(char.IsDigit).ToArray());

                    if (int.TryParse(numberPart, out int stepDeg))
                    {
                        currentAngle += stepDeg;
                        if (currentAngle < 0) currentAngle = 1;
                        if (currentAngle > 135) currentAngle = 135;

                        string thetaStr = currentAngle.ToString("F2");
                        UartManager.Instance.SendCommand($"B+{thetaStr}\r\n");
                    }

                    Thread.Sleep(500);
                }
            });
        }

        private void btnBRight_MouseUp(object sender, MouseEventArgs e)
        {
            isHolding = false;
        }

        private Task HoldToSend(string command)
        {
            return Task.Run(() =>
            {
                while (isHolding)
                {
                    UartManager.Instance.SendCommand(command);
                    Thread.Sleep(400);
                }
            });
        }

        private void cbStepSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = cbStepSize.SelectedItem?.ToString() ?? "0";
            string numberPart = new string(selectedText.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(numberPart))
            {
                UartManager.Instance.SendCommand($"STEP{numberPart}\r\n");
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string value = testTB.Text.Trim();
            string command = string.IsNullOrEmpty(value) ? "RUN" : $"RUN{value}\r\n";
            UartManager.Instance.SendCommand(command);
        }


    }
}
