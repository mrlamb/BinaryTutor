using System.Windows.Forms;

namespace BinaryTutorial
{
    public partial class BinaryTutorialButton : Button
    {
        private int value;
        private bool state = false;

        public int  ValueAccess
        {
            get { return value; }
            set { if (this.value == value)
                {
                    return;
                }
                else
                {
                    this.value = value;
                }
            }
        }

        public BinaryTutorialButton()
        {
            InitializeComponent();
        }

        public void SwitchState()
        {
            state = !state;
        }

        public void onClick(BinaryTutorialResult btr)
        {
            if (state)
            {
                Text = "0";
                BackColor = System.Drawing.SystemColors.Control; 
                btr.subtract(value);
                SwitchState();
            }
            else
            {
                Text = "1";
                BackColor = System.Drawing.Color.Lime;
                btr.add(value);
                SwitchState();
            }
        }

    }
}
