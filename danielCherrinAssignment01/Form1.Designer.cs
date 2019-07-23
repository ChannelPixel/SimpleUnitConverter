namespace danielCherrinAssignment01
{
    partial class frm_distanceConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lbl_LABEL_INPUT = new System.Windows.Forms.Label();
            this.lbl_inputLabel = new System.Windows.Forms.Label();
            this.lbl_LABEL_EQUALS = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.lbl_outputLabel = new System.Windows.Forms.Label();
            this.btn_inchesToCms = new System.Windows.Forms.Button();
            this.btn_FeetToMetres = new System.Windows.Forms.Button();
            this.btn_YardsToMetres = new System.Windows.Forms.Button();
            this.btn_MilesToKms = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_LABEL_TYPE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_input.Location = new System.Drawing.Point(24, 35);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(109, 32);
            this.txt_input.TabIndex = 0;
            this.txt_input.Click += new System.EventHandler(this.txt_input_Click);
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            this.txt_input.Enter += new System.EventHandler(this.txt_input_Enter);
            // 
            // lbl_LABEL_INPUT
            // 
            this.lbl_LABEL_INPUT.AutoSize = true;
            this.lbl_LABEL_INPUT.Location = new System.Drawing.Point(21, 13);
            this.lbl_LABEL_INPUT.Name = "lbl_LABEL_INPUT";
            this.lbl_LABEL_INPUT.Size = new System.Drawing.Size(157, 13);
            this.lbl_LABEL_INPUT.TabIndex = 1;
            this.lbl_LABEL_INPUT.Text = "Enter the value to be converted";
            this.lbl_LABEL_INPUT.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_inputLabel
            // 
            this.lbl_inputLabel.AutoSize = true;
            this.lbl_inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_inputLabel.Location = new System.Drawing.Point(139, 42);
            this.lbl_inputLabel.Name = "lbl_inputLabel";
            this.lbl_inputLabel.Size = new System.Drawing.Size(51, 20);
            this.lbl_inputLabel.TabIndex = 2;
            this.lbl_inputLabel.Text = "label2";
            this.lbl_inputLabel.Visible = false;
            // 
            // lbl_LABEL_EQUALS
            // 
            this.lbl_LABEL_EQUALS.AutoSize = true;
            this.lbl_LABEL_EQUALS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LABEL_EQUALS.Location = new System.Drawing.Point(213, 40);
            this.lbl_LABEL_EQUALS.Name = "lbl_LABEL_EQUALS";
            this.lbl_LABEL_EQUALS.Size = new System.Drawing.Size(25, 25);
            this.lbl_LABEL_EQUALS.TabIndex = 3;
            this.lbl_LABEL_EQUALS.Text = "=";
            this.lbl_LABEL_EQUALS.Visible = false;
            // 
            // txt_output
            // 
            this.txt_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_output.Location = new System.Drawing.Point(258, 35);
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(133, 32);
            this.txt_output.TabIndex = 4;
            this.txt_output.Visible = false;
            // 
            // lbl_outputLabel
            // 
            this.lbl_outputLabel.AutoSize = true;
            this.lbl_outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_outputLabel.Location = new System.Drawing.Point(397, 42);
            this.lbl_outputLabel.Name = "lbl_outputLabel";
            this.lbl_outputLabel.Size = new System.Drawing.Size(51, 20);
            this.lbl_outputLabel.TabIndex = 5;
            this.lbl_outputLabel.Text = "label4";
            this.lbl_outputLabel.Visible = false;
            // 
            // btn_inchesToCms
            // 
            this.btn_inchesToCms.Location = new System.Drawing.Point(24, 120);
            this.btn_inchesToCms.Name = "btn_inchesToCms";
            this.btn_inchesToCms.Size = new System.Drawing.Size(165, 23);
            this.btn_inchesToCms.TabIndex = 6;
            this.btn_inchesToCms.Text = "&Inches to Centimetres";
            this.btn_inchesToCms.UseVisualStyleBackColor = true;
            this.btn_inchesToCms.Click += new System.EventHandler(this.btn_inchesToCms_Click);
            // 
            // btn_FeetToMetres
            // 
            this.btn_FeetToMetres.Location = new System.Drawing.Point(24, 149);
            this.btn_FeetToMetres.Name = "btn_FeetToMetres";
            this.btn_FeetToMetres.Size = new System.Drawing.Size(165, 23);
            this.btn_FeetToMetres.TabIndex = 7;
            this.btn_FeetToMetres.Text = "&Feet to Metres";
            this.btn_FeetToMetres.UseVisualStyleBackColor = true;
            this.btn_FeetToMetres.Click += new System.EventHandler(this.btn_FeetToMetres_Click);
            // 
            // btn_YardsToMetres
            // 
            this.btn_YardsToMetres.Location = new System.Drawing.Point(25, 178);
            this.btn_YardsToMetres.Name = "btn_YardsToMetres";
            this.btn_YardsToMetres.Size = new System.Drawing.Size(165, 23);
            this.btn_YardsToMetres.TabIndex = 8;
            this.btn_YardsToMetres.Text = "&Yards to Metres";
            this.btn_YardsToMetres.UseVisualStyleBackColor = true;
            this.btn_YardsToMetres.Click += new System.EventHandler(this.btn_YardsToMetres_Click);
            // 
            // btn_MilesToKms
            // 
            this.btn_MilesToKms.Location = new System.Drawing.Point(25, 207);
            this.btn_MilesToKms.Name = "btn_MilesToKms";
            this.btn_MilesToKms.Size = new System.Drawing.Size(165, 23);
            this.btn_MilesToKms.TabIndex = 9;
            this.btn_MilesToKms.Text = "&Miles to Kilometres";
            this.btn_MilesToKms.UseVisualStyleBackColor = true;
            this.btn_MilesToKms.Click += new System.EventHandler(this.btn_MilesToKms_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(342, 207);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "or press \"esc\"";
            // 
            // lbl_LABEL_TYPE
            // 
            this.lbl_LABEL_TYPE.AutoSize = true;
            this.lbl_LABEL_TYPE.Location = new System.Drawing.Point(22, 89);
            this.lbl_LABEL_TYPE.Name = "lbl_LABEL_TYPE";
            this.lbl_LABEL_TYPE.Size = new System.Drawing.Size(98, 13);
            this.lbl_LABEL_TYPE.TabIndex = 12;
            this.lbl_LABEL_TYPE.Text = "Type of conversion";
            // 
            // frm_distanceConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 254);
            this.Controls.Add(this.lbl_LABEL_TYPE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_MilesToKms);
            this.Controls.Add(this.btn_YardsToMetres);
            this.Controls.Add(this.btn_FeetToMetres);
            this.Controls.Add(this.btn_inchesToCms);
            this.Controls.Add(this.lbl_outputLabel);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.lbl_LABEL_EQUALS);
            this.Controls.Add(this.lbl_inputLabel);
            this.Controls.Add(this.lbl_LABEL_INPUT);
            this.Controls.Add(this.txt_input);
            this.KeyPreview = true;
            this.Name = "frm_distanceConverter";
            this.Text = "Distance Converter";
            this.Load += new System.EventHandler(this.frm_distanceConverter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_distanceConverter_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frm_distanceConverter_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label lbl_LABEL_INPUT;
        private System.Windows.Forms.Label lbl_inputLabel;
        private System.Windows.Forms.Label lbl_LABEL_EQUALS;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label lbl_outputLabel;
        private System.Windows.Forms.Button btn_inchesToCms;
        private System.Windows.Forms.Button btn_FeetToMetres;
        private System.Windows.Forms.Button btn_YardsToMetres;
        private System.Windows.Forms.Button btn_MilesToKms;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_LABEL_TYPE;
    }
}

