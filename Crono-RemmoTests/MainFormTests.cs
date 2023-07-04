using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;

namespace Crono_Remmo.Tests
{
    public class MainFormTests
    {
        [Fact]
        public void TimerEvent_Tick_IncrementsTime()
        {
            // Arrange
            var mainForm = new MainForm();
            mainForm.IsActive = true;
            mainForm.TimeCs = 0;
            mainForm.TimeSe = 0;
            mainForm.TimeMin = 0;
            mainForm.TimeHou = 0;

            // Act
            mainForm.TimerEvent_Tick(null, EventArgs.Empty);

            // Assert
            Assert.Equal(1, mainForm.TimeCs);
        }

        [Fact]
        public void ShowTimer_FormatsTimeCorrectly()
        {
            // Arrange
            var mainForm = new MainForm();
            mainForm.TimeMin = 5;
            mainForm.TimeSe = 10;
            mainForm.TimeCs = 50;

            // Act
            mainForm.ShowTimer();

            // Assert
            Assert.Equal("05", mainForm.LabelMinute.Text);
            Assert.Equal("10", mainForm.LabelSeconds.Text);
            Assert.Equal("50", mainForm.LabelMlSec.Text);
        }
    }
}
