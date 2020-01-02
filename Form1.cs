using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace AutoBoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Get a handle to an application window.
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        // Send a series of key presses to the Calculator application.
        private async void BTN_Start_Click(object sender, EventArgs e)
        {
            getParams();
            Debug.WriteLine(Variables.delay_init);            
            Debug.WriteLine(Variables.delay_keys);
            Debug.WriteLine(Variables.delay_runs);
            Debug.WriteLine(Variables.repeats);
            Debug.WriteLine(Variables.input);
            List<string> keys = parseKeys(Variables.input);
            await Task.Delay(Variables.delay_init);
            for (int i = 0; i < Variables.repeats; i++)
            {
                for (int j = 0; j < keys.Count; j++)
                {
                    SendKeys.Send(keys[j]);
                    await Task.Delay(Variables.delay_keys);
                }                
                //SendKeys.Send("{ADD}");
                await Task.Delay(Variables.delay_runs);
            }
            //SendKeys.Send("{ENTER}");
            Debug.WriteLine("Finish");
        }

        private List<string> parseKeys(string input)
        {
            List<string> keys = new List<string>();
            bool inside = false;
            string temp = "", buffer = "";
            for (int i = 0; i < input.Length; i++)
            {
                temp = input.Substring(i, 1);
                if (temp.Equals("{"))
                {
                    inside = true;
                    buffer = "{";
                } else if (inside)
                {
                    if (temp.Equals("}"))
                    { //closing buffer
                        buffer += "}";
                        keys.Add(buffer);
                        inside = false;
                    } else
                    { //adding another key to buffer
                        buffer += temp;
                    }
                }
                else
                {
                    keys.Add(temp);
                }                
            }
            return keys;
        }

        private void getParams()
        {
            try
            {
                Variables.delay_init = Convert.ToInt32(TB_Delay_Init.Text);
            } catch (Exception)
            {
                Variables.delay_init = 5000;
            }
            try
            {
                Variables.delay_keys = Convert.ToInt32(TB_Delay_Keys.Text);
            }
            catch (Exception)
            {
                Variables.delay_keys = 100;
            }
            try
            { 
                Variables.delay_runs = Convert.ToInt32(TB_Delay_Runs.Text); 
            }
            catch (Exception)
            {
                Variables.delay_runs = 1000;
            }
            try { 
                Variables.repeats = Convert.ToInt32(TB_Repeats.Text); 
            }
            catch (Exception)
            {
                Variables.repeats = 1;
            }
            Variables.input = TB_Input.Text;
        }

        private void BTN_Advanced_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Show();
        }
    }
}
