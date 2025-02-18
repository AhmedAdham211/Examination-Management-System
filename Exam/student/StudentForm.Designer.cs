namespace student
{
    partial class StudentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            labl1 = new Label();
            TrackCombo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.ImeMode = ImeMode.NoControl;
            comboBox1.Location = new Point(551, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(337, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(127, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(646, 256);
            dataGridView1.TabIndex = 5;
            // 
            // labl1
            // 
            labl1.AutoSize = true;
            labl1.Location = new Point(302, 9);
            labl1.Name = "labl1";
            labl1.Size = new Size(125, 20);
            labl1.TabIndex = 6;
            labl1.Text = "Courses & Students";
            // 
            // TrackCombo
            // 
            TrackCombo.BackColor = SystemColors.Window;
            TrackCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TrackCombo.FormattingEnabled = true;
            TrackCombo.ImeMode = ImeMode.NoControl;
            TrackCombo.Location = new Point(102, 75);
            TrackCombo.Name = "TrackCombo";
            TrackCombo.Size = new Size(337, 28);
            TrackCombo.TabIndex = 7;
            TrackCombo.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 75);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 8;
            label1.Text = "Track";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 75);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 9;
            label2.Text = "Course";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(38, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 450);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TrackCombo);
            Controls.Add(labl1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            ImeMode = ImeMode.AlphaFull;
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label labl1;
        private ComboBox TrackCombo;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
    }
}
