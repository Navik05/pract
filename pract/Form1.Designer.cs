namespace pract
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.trackSymptoms = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.numericContact = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trackChance = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.numericTime = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackIncubation = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackRange = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericResol = new System.Windows.Forms.NumericUpDown();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.trackDeadliness = new System.Windows.Forms.TrackBar();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSymptoms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackIncubation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDeadliness)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pictureBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Panel2.Controls.Add(this.bStop);
            this.splitContainer.Panel2.Controls.Add(this.bStart);
            this.splitContainer.Size = new System.Drawing.Size(1269, 749);
            this.splitContainer.SplitterDistance = 1047;
            this.splitContainer.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1043, 745);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.trackDeadliness);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.trackSymptoms);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.numericContact);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.trackChance);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numericTime);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.trackIncubation);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.trackRange);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericResol);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 620);
            this.panel1.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(10, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = " Длительность симптомов";
            // 
            // trackSymptoms
            // 
            this.trackSymptoms.LargeChange = 1;
            this.trackSymptoms.Location = new System.Drawing.Point(19, 189);
            this.trackSymptoms.Maximum = 15;
            this.trackSymptoms.Minimum = 1;
            this.trackSymptoms.Name = "trackSymptoms";
            this.trackSymptoms.Size = new System.Drawing.Size(161, 56);
            this.trackSymptoms.TabIndex = 20;
            this.trackSymptoms.Value = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(15, 490);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Контактов в день";
            // 
            // numericContact
            // 
            this.numericContact.Location = new System.Drawing.Point(39, 513);
            this.numericContact.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericContact.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericContact.Name = "numericContact";
            this.numericContact.Size = new System.Drawing.Size(120, 22);
            this.numericContact.TabIndex = 18;
            this.numericContact.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(167, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(16, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Вероятность заражения";
            // 
            // trackChance
            // 
            this.trackChance.LargeChange = 1;
            this.trackChance.Location = new System.Drawing.Point(19, 269);
            this.trackChance.Name = "trackChance";
            this.trackChance.Size = new System.Drawing.Size(161, 56);
            this.trackChance.TabIndex = 14;
            this.trackChance.Value = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Интервал времени";
            // 
            // numericTime
            // 
            this.numericTime.Location = new System.Drawing.Point(39, 571);
            this.numericTime.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericTime.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericTime.Name = "numericTime";
            this.numericTime.Size = new System.Drawing.Size(120, 22);
            this.numericTime.TabIndex = 12;
            this.numericTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(164, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "15";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = " Инкубационный период";
            // 
            // trackIncubation
            // 
            this.trackIncubation.LargeChange = 1;
            this.trackIncubation.Location = new System.Drawing.Point(15, 109);
            this.trackIncubation.Maximum = 15;
            this.trackIncubation.Minimum = 1;
            this.trackIncubation.Name = "trackIncubation";
            this.trackIncubation.Size = new System.Drawing.Size(161, 56);
            this.trackIncubation.TabIndex = 8;
            this.trackIncubation.Value = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(167, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "1";
            // 
            // trackRange
            // 
            this.trackRange.LargeChange = 1;
            this.trackRange.Location = new System.Drawing.Point(15, 39);
            this.trackRange.Minimum = 1;
            this.trackRange.Name = "trackRange";
            this.trackRange.Size = new System.Drawing.Size(161, 56);
            this.trackRange.TabIndex = 2;
            this.trackRange.Value = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Плотность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Радиус заражения";
            // 
            // numericResol
            // 
            this.numericResol.Location = new System.Drawing.Point(39, 465);
            this.numericResol.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericResol.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericResol.Name = "numericResol";
            this.numericResol.Size = new System.Drawing.Size(120, 22);
            this.numericResol.TabIndex = 4;
            this.numericResol.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // bStop
            // 
            this.bStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStop.Location = new System.Drawing.Point(51, 681);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(106, 42);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.Location = new System.Drawing.Point(51, 626);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(106, 39);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(16, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(167, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 15);
            this.label15.TabIndex = 23;
            this.label15.Text = "15";
            // 
            // trackDeadliness
            // 
            this.trackDeadliness.LargeChange = 1;
            this.trackDeadliness.Location = new System.Drawing.Point(24, 350);
            this.trackDeadliness.Name = "trackDeadliness";
            this.trackDeadliness.Size = new System.Drawing.Size(161, 56);
            this.trackDeadliness.TabIndex = 24;
            this.trackDeadliness.Value = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(51, 328);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 18);
            this.label16.TabIndex = 25;
            this.label16.Text = "Летальность";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(21, 376);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 15);
            this.label17.TabIndex = 26;
            this.label17.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(171, 376);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 15);
            this.label18.TabIndex = 27;
            this.label18.Text = "1";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 749);
            this.Controls.Add(this.splitContainer);
            this.Name = "Form";
            this.Text = "life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form_Activated);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSymptoms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackIncubation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDeadliness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.TrackBar trackRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericResol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackIncubation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackChance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericContact;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar trackSymptoms;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar trackDeadliness;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}

