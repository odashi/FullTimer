using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FullTimer
{
	public partial class Form1 : Form
	{
		enum State
		{
			Initial,
			Started,
			Finished
		}

		int m_fontSize;
		DateTime m_startTime;
		TimeSpan m_setSpan;

		State m_state;

		public Form1()
		{
			InitializeComponent();
		}

		// 表示の大きさの設定
		private void SetFont()
		{
			labelTime.Font = new Font(FontFamily.GenericSansSerif, (float)m_fontSize, FontStyle.Bold);
		}

		// 表示時間だけ更新
		private void UpdateTimeView()
		{
			TimeSpan last = m_state == State.Started ? m_setSpan - (DateTime.Now -  m_startTime) : m_setSpan;
			labelTime.Text = m_state == State.Finished ? "こ こ ま で" :
				(60 * last.Hours + last.Minutes).ToString() + "' " +
				last.Seconds.ToString("00") + " " +
				(last.Milliseconds / 100).ToString();
		}

		// ウィンドウ全体の更新
		private void UpdateView()
		{
			UpdateTimeView();

			labelSetTime.Text =
				(60 * m_setSpan.Hours + m_setSpan.Minutes).ToString() + "'"
				+ m_setSpan.Seconds.ToString("00");

			labelTime.Left = (this.Width - labelTime.Width) / 2;
			labelTime.Top = (this.Height - labelTime.Height) / 2;

			buttonStartStop.Text = m_state == State.Initial ? "スタート" : "リセット";
		}

		// メニューの表示を切り替え
		private void FlipMenu()
		{
			panelMenu.Visible = !panelMenu.Visible;
		}

		// 新しい設定時間を設定
		private void SetNewTime(int minute_diff, int second_diff)
		{
			TimeSpan newTime = m_setSpan + new TimeSpan(0, minute_diff, second_diff);
			TimeSpan maxTime = new TimeSpan(0, 500, 0);
			TimeSpan minTime = new TimeSpan(0, 0, 1);
			if (newTime >= maxTime)
				m_setSpan = maxTime;
			else if (newTime <= minTime)
				m_setSpan = minTime;
			else
				m_setSpan = newTime;
			UpdateView();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			m_state = State.Initial;
			m_fontSize = 20;
			m_setSpan = new TimeSpan(1, 30, 0);
			this.WindowState = FormWindowState.Maximized;
			SetFont();
			UpdateView();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonBiger_Click(object sender, EventArgs e)
		{
			if (m_fontSize < 500)
			{
				m_fontSize += 5;
				SetFont();
				UpdateView();
			}
		}

		private void buttonSmaller_Click(object sender, EventArgs e)
		{
			if (m_fontSize > 5)
			{
				m_fontSize -= 5;
				SetFont();
				UpdateView();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (DateTime.Now - m_startTime > m_setSpan)
			{
				m_state = State.Finished;
				timer1.Enabled = false;
				UpdateView();
			}
			else
				UpdateTimeView();
		}

		private void buttonPlus10m_Click(object sender, EventArgs e)
		{
			SetNewTime(10, 0);
		}

		private void buttonPlus1m_Click(object sender, EventArgs e)
		{
			SetNewTime(1, 0);
		}

		private void buttonMinus1m_Click(object sender, EventArgs e)
		{
			SetNewTime(-1, 0);
		}

		private void buttonMinus10m_Click(object sender, EventArgs e)
		{
			SetNewTime(-10, 0);
		}

		private void buttonPlus10s_Click(object sender, EventArgs e)
		{
			SetNewTime(0, 10);
		}

		private void buttonPlus1s_Click(object sender, EventArgs e)
		{
			SetNewTime(0, 1);
		}

		private void buttonMinus1s_Click(object sender, EventArgs e)
		{
			SetNewTime(0, -1);
		}

		private void buttonMinus10s_Click(object sender, EventArgs e)
		{
			SetNewTime(0, -10);
		}

		private void labelTime_DoubleClick(object sender, EventArgs e)
		{
			FlipMenu();
		}

		private void Form1_DoubleClick(object sender, EventArgs e)
		{
			FlipMenu();
		}

		private void buttonStartStop_Click(object sender, EventArgs e)
		{
			m_startTime = DateTime.Now;
			timer1.Enabled = m_state == State.Initial;
			m_state = m_state == State.Initial ? State.Started : State.Initial;
			UpdateView();
		}
	}
}
