/*
 * GamePad to KeyBoard
 * Copyright (c) 2010 Rodrigo 'r2d2rigo' Diaz
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software
 * without restriction, including without limitation the rights to use, copy, modify,
 * merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
 * permit persons to whom the Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies
 * or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
 * PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
 * CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
 * OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Threading;

namespace GP2KB
{
    public partial class GP2KB : Form
    {
#region WinAPI function imports
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint nInputs, ref INPUT pInputs, int cbSize);
#endregion

#region WinAPI Constants and data types
        const int INPUT_KEYBOARD = 1;
        const uint KEYEVENTF_KEYUP = 0x0002;

        public struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public long time;
            public uint dwExtraInfo;
        };

        [StructLayout(LayoutKind.Explicit, Size = 28)]
        public struct INPUT
        {
            [FieldOffset(0)]
            public uint type;
            [FieldOffset(4)]
            public KEYBDINPUT ki;
        };
#endregion

#region Variables
        static GamePadState prevState, currState;
        private Thread thread;

        public static Semaphore semaphore;

        public static Dictionary<string, string> keyButtons;
#endregion

#region Functions
        /// <summary>
        /// Initializes variables and starts thread.
        /// </summary>
        public GP2KB()
        {
            InitializeComponent();

            prevState = currState = GamePad.GetState(PlayerIndex.One);

            semaphore = new Semaphore(1, 1);
            keyButtons = new Dictionary<string, string>();

            thread = new Thread(new ThreadStart(InputCheck));
            thread.Start();
        }

        /// <summary>
        /// Background thread function. Manages gamepad input and send keyboard messages.
        /// </summary>
        static void InputCheck()
        {
            INPUT structInput = new INPUT();

            while (true)
            {
                currState = GamePad.GetState(PlayerIndex.One);

                structInput.type = INPUT_KEYBOARD;
                structInput.ki.wScan = 0;
                structInput.ki.time = 0;
                structInput.ki.dwFlags = 0;

                // Check that no one else is accessing the dictionary
                semaphore.WaitOne();
                foreach (KeyValuePair<string, string> keybutton in keyButtons)
                {
                    Buttons but = (Buttons)Enum.Parse(typeof(Buttons),keybutton.Key);
                    System.Windows.Forms.Keys keyv = (System.Windows.Forms.Keys)Enum.Parse(typeof(System.Windows.Forms.Keys), keybutton.Value);
                    ushort keyvalue = (ushort)keyv;

                    if (currState.IsButtonDown(but) && !prevState.IsButtonDown(but))
                    {
                        structInput.ki.wVk = keyvalue;
                        uint intReturn = SendInput(1, ref structInput, Marshal.SizeOf(new INPUT()));
                        
                    }
                    if (!currState.IsButtonDown(but) && prevState.IsButtonDown(but))
                    {
                        structInput.ki.wVk = keyvalue;
                        structInput.ki.dwFlags = KEYEVENTF_KEYUP;
                        uint intReturn = SendInput(1, ref structInput, Marshal.SizeOf(new INPUT()));
                    }
                }
                semaphore.Release();

                prevState = currState;
                Thread.Sleep(1);
            }
        }

        /// <summary>
        /// Application closing, stop background thread.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GP2KB_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread.Abort();
        }

        /// <summary>
        /// Key pressed on a TextBox, change keyboard key <-> gamepad button association.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyButton_KeyDown(object sender, KeyEventArgs e)
        {
            // Check that no one else is accessing the dictionary
            semaphore.WaitOne();
            // Associated gamepad button is stored in TextBox.Tag
            keyButtons[(string)((TextBox)sender).Tag] = e.KeyCode.ToString();
            semaphore.Release();

            ((TextBox)sender).Text = e.KeyCode.ToString();
            // Don't propagate input
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        /// <summary>
        /// Notify icon clicked, show main window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (!this.Visible)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.notifyIcon.Visible = false;
            }
        }

        /// <summary>
        /// Window minimized, hide and show notify icon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GP2KB_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon.Visible = true;
            }
        }

        /// <summary>
        /// Shows about box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
#endregion
    }
}
