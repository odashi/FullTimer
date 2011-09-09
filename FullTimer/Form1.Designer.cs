namespace FullTimer
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.labelTime = new System.Windows.Forms.Label();
			this.buttonBiger = new System.Windows.Forms.Button();
			this.buttonSmaller = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonPlus10m = new System.Windows.Forms.Button();
			this.buttonPlus1m = new System.Windows.Forms.Button();
			this.buttonPlus10s = new System.Windows.Forms.Button();
			this.buttonPlus1s = new System.Windows.Forms.Button();
			this.buttonMinus10m = new System.Windows.Forms.Button();
			this.buttonMinus1m = new System.Windows.Forms.Button();
			this.buttonMinus10s = new System.Windows.Forms.Button();
			this.buttonMinus1s = new System.Windows.Forms.Button();
			this.labelSetTime = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.buttonStartStop = new System.Windows.Forms.Button();
			this.panelMenu = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.panelMenu.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.Location = new System.Drawing.Point(342, 150);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(39, 12);
			this.labelTime.TabIndex = 1;
			this.labelTime.Text = "0\' 00 0";
			this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
			// 
			// buttonBiger
			// 
			this.buttonBiger.Location = new System.Drawing.Point(239, 3);
			this.buttonBiger.Name = "buttonBiger";
			this.buttonBiger.Size = new System.Drawing.Size(75, 35);
			this.buttonBiger.TabIndex = 8;
			this.buttonBiger.Text = "表示大きく";
			this.buttonBiger.UseVisualStyleBackColor = true;
			this.buttonBiger.Click += new System.EventHandler(this.buttonBiger_Click);
			// 
			// buttonSmaller
			// 
			this.buttonSmaller.Location = new System.Drawing.Point(239, 49);
			this.buttonSmaller.Name = "buttonSmaller";
			this.buttonSmaller.Size = new System.Drawing.Size(75, 35);
			this.buttonSmaller.TabIndex = 9;
			this.buttonSmaller.Text = "表示小さく";
			this.buttonSmaller.UseVisualStyleBackColor = true;
			this.buttonSmaller.Click += new System.EventHandler(this.buttonSmaller_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(450, 3);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(48, 81);
			this.buttonExit.TabIndex = 12;
			this.buttonExit.Text = "終了";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonPlus10m
			// 
			this.buttonPlus10m.Location = new System.Drawing.Point(174, 3);
			this.buttonPlus10m.Name = "buttonPlus10m";
			this.buttonPlus10m.Size = new System.Drawing.Size(51, 23);
			this.buttonPlus10m.TabIndex = 3;
			this.buttonPlus10m.Text = "+10m";
			this.buttonPlus10m.UseVisualStyleBackColor = true;
			this.buttonPlus10m.Click += new System.EventHandler(this.buttonPlus10m_Click);
			// 
			// buttonPlus1m
			// 
			this.buttonPlus1m.Location = new System.Drawing.Point(117, 3);
			this.buttonPlus1m.Name = "buttonPlus1m";
			this.buttonPlus1m.Size = new System.Drawing.Size(51, 23);
			this.buttonPlus1m.TabIndex = 2;
			this.buttonPlus1m.Text = "+1m";
			this.buttonPlus1m.UseVisualStyleBackColor = true;
			this.buttonPlus1m.Click += new System.EventHandler(this.buttonPlus1m_Click);
			// 
			// buttonPlus10s
			// 
			this.buttonPlus10s.Location = new System.Drawing.Point(174, 61);
			this.buttonPlus10s.Name = "buttonPlus10s";
			this.buttonPlus10s.Size = new System.Drawing.Size(51, 23);
			this.buttonPlus10s.TabIndex = 7;
			this.buttonPlus10s.Text = "+10s";
			this.buttonPlus10s.UseVisualStyleBackColor = true;
			this.buttonPlus10s.Click += new System.EventHandler(this.buttonPlus10s_Click);
			// 
			// buttonPlus1s
			// 
			this.buttonPlus1s.Location = new System.Drawing.Point(117, 61);
			this.buttonPlus1s.Name = "buttonPlus1s";
			this.buttonPlus1s.Size = new System.Drawing.Size(51, 23);
			this.buttonPlus1s.TabIndex = 6;
			this.buttonPlus1s.Text = "+1s";
			this.buttonPlus1s.UseVisualStyleBackColor = true;
			this.buttonPlus1s.Click += new System.EventHandler(this.buttonPlus1s_Click);
			// 
			// buttonMinus10m
			// 
			this.buttonMinus10m.Location = new System.Drawing.Point(3, 3);
			this.buttonMinus10m.Name = "buttonMinus10m";
			this.buttonMinus10m.Size = new System.Drawing.Size(51, 23);
			this.buttonMinus10m.TabIndex = 0;
			this.buttonMinus10m.Text = "-10m";
			this.buttonMinus10m.UseVisualStyleBackColor = true;
			this.buttonMinus10m.Click += new System.EventHandler(this.buttonMinus10m_Click);
			// 
			// buttonMinus1m
			// 
			this.buttonMinus1m.Location = new System.Drawing.Point(60, 3);
			this.buttonMinus1m.Name = "buttonMinus1m";
			this.buttonMinus1m.Size = new System.Drawing.Size(51, 23);
			this.buttonMinus1m.TabIndex = 1;
			this.buttonMinus1m.Text = "-1m";
			this.buttonMinus1m.UseVisualStyleBackColor = true;
			this.buttonMinus1m.Click += new System.EventHandler(this.buttonMinus1m_Click);
			// 
			// buttonMinus10s
			// 
			this.buttonMinus10s.Location = new System.Drawing.Point(3, 61);
			this.buttonMinus10s.Name = "buttonMinus10s";
			this.buttonMinus10s.Size = new System.Drawing.Size(51, 23);
			this.buttonMinus10s.TabIndex = 4;
			this.buttonMinus10s.Text = "-10s";
			this.buttonMinus10s.UseVisualStyleBackColor = true;
			this.buttonMinus10s.Click += new System.EventHandler(this.buttonMinus10s_Click);
			// 
			// buttonMinus1s
			// 
			this.buttonMinus1s.Location = new System.Drawing.Point(60, 61);
			this.buttonMinus1s.Name = "buttonMinus1s";
			this.buttonMinus1s.Size = new System.Drawing.Size(51, 23);
			this.buttonMinus1s.TabIndex = 5;
			this.buttonMinus1s.Text = "-1s";
			this.buttonMinus1s.UseVisualStyleBackColor = true;
			this.buttonMinus1s.Click += new System.EventHandler(this.buttonMinus1s_Click);
			// 
			// labelSetTime
			// 
			this.labelSetTime.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelSetTime.Location = new System.Drawing.Point(3, 29);
			this.labelSetTime.Name = "labelSetTime";
			this.labelSetTime.Size = new System.Drawing.Size(222, 29);
			this.labelSetTime.TabIndex = 13;
			this.labelSetTime.Text = "label1";
			this.labelSetTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer1
			// 
			this.timer1.Interval = 33;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// buttonStartStop
			// 
			this.buttonStartStop.Location = new System.Drawing.Point(344, 3);
			this.buttonStartStop.Name = "buttonStartStop";
			this.buttonStartStop.Size = new System.Drawing.Size(75, 81);
			this.buttonStartStop.TabIndex = 10;
			this.buttonStartStop.Text = "スタート";
			this.buttonStartStop.UseVisualStyleBackColor = true;
			this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
			// 
			// panelMenu
			// 
			this.panelMenu.AutoSize = true;
			this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelMenu.BackColor = System.Drawing.Color.Silver;
			this.panelMenu.Controls.Add(this.buttonMinus10m);
			this.panelMenu.Controls.Add(this.buttonBiger);
			this.panelMenu.Controls.Add(this.buttonStartStop);
			this.panelMenu.Controls.Add(this.buttonSmaller);
			this.panelMenu.Controls.Add(this.labelSetTime);
			this.panelMenu.Controls.Add(this.buttonExit);
			this.panelMenu.Controls.Add(this.buttonMinus1s);
			this.panelMenu.Controls.Add(this.buttonPlus10m);
			this.panelMenu.Controls.Add(this.buttonPlus1s);
			this.panelMenu.Controls.Add(this.buttonPlus1m);
			this.panelMenu.Controls.Add(this.buttonMinus10s);
			this.panelMenu.Controls.Add(this.buttonMinus1m);
			this.panelMenu.Controls.Add(this.buttonPlus10s);
			this.panelMenu.Location = new System.Drawing.Point(10, 10);
			this.panelMenu.Margin = new System.Windows.Forms.Padding(1);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(501, 87);
			this.panelMenu.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 240);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(708, 23);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(332, 18);
			this.toolStripStatusLabel1.Text = "画面の白い部分をダブルクリック：メニューの表示／非表示";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(708, 263);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.panelMenu);
			this.Controls.Add(this.labelTime);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "FullTimer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
			this.panelMenu.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Button buttonBiger;
		private System.Windows.Forms.Button buttonSmaller;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonPlus10m;
		private System.Windows.Forms.Button buttonPlus1m;
		private System.Windows.Forms.Button buttonPlus10s;
		private System.Windows.Forms.Button buttonPlus1s;
		private System.Windows.Forms.Button buttonMinus10m;
		private System.Windows.Forms.Button buttonMinus1m;
		private System.Windows.Forms.Button buttonMinus10s;
		private System.Windows.Forms.Button buttonMinus1s;
		private System.Windows.Forms.Label labelSetTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button buttonStartStop;
		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

	}
}

