using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Crono_Remmo
{
    public partial class MainForm : Form
    {
        private const string StartButton = "Start";
        private const string StopButton = "Stop";
        private int timeCs, timeSe, timeMin, timeHou;
        private bool isActive;

        public MainForm()
        {
            InitializeComponent();
            buttonAction.Text = StartButton;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            resetTimer();
            isActive = false;
        }

        private void resetTimer()
        {
            timeCs = 0;
            timeSe = 0;
            timeMin = 0;
            timeHou = 0;
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if (isToStatart())
            {
                buttonAction.Text = StopButton;
                isActive = true;
            }
            else if (!isToStatart())
            {
                buttonAction.Text = StartButton;
                isActive = false;
            }
        }

        private bool isToStatart()
        {
            if (buttonAction.Text == StartButton)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetTimer();
            isActive = false;
        }

        private void timerEvent_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeCs++;

                if (timeCs >= 100)
                {
                    timeSe++;
                    timeCs = 0;

                    if (timeSe >= 60)
                    {
                        timeMin++;
                        timeSe = 0;

                        if (timeMin >= 60)
                        {
                            timeHou++;
                            timeMin = 0;
                        }
                    }
                }
            }

            showTimer();
        }

        private void showTimer()
        {
            labelHour.Text = String.Format("{0:00}", timeHou);
            labelMinute.Text = String.Format("{0:00}", timeMin);
            labelSeconds.Text = String.Format("{0:00}", timeSe);
            labelMlSec.Text = String.Format("{0:00}", timeCs);
        }
    }
}