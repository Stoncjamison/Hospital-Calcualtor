namespace Hospital_Calcualtor
{
    partial class Form1
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
            this.labelDays = new System.Windows.Forms.Label();
            this.labelMedication = new System.Windows.Forms.Label();
            this.labelSurgical = new System.Windows.Forms.Label();
            this.labelLab = new System.Windows.Forms.Label();
            this.labelRehab = new System.Windows.Forms.Label();
            this.labelStay = new System.Windows.Forms.Label();
            this.groupBoxHospitalCharges = new System.Windows.Forms.GroupBox();
            this.LabeltotalCharges = new System.Windows.Forms.Label();
            this.labelMiscCharges = new System.Windows.Forms.Label();
            this.labelStayCharges = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelMisc = new System.Windows.Forms.Label();
            this.textBoxdays = new System.Windows.Forms.TextBox();
            this.textBoxMedication = new System.Windows.Forms.TextBox();
            this.textBoxSurgical = new System.Windows.Forms.TextBox();
            this.textBoxLab = new System.Windows.Forms.TextBox();
            this.textBoxRehab = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxHospitalCharges.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDays.Location = new System.Drawing.Point(42, 35);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(226, 20);
            this.labelDays.TabIndex = 0;
            this.labelDays.Text = "Number of days in the hospital:";
            this.labelDays.Click += new System.EventHandler(this.labelDays_Click);
            // 
            // labelMedication
            // 
            this.labelMedication.AutoSize = true;
            this.labelMedication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedication.Location = new System.Drawing.Point(117, 78);
            this.labelMedication.Name = "labelMedication";
            this.labelMedication.Size = new System.Drawing.Size(154, 20);
            this.labelMedication.TabIndex = 1;
            this.labelMedication.Text = "Medication Charges:";
            // 
            // labelSurgical
            // 
            this.labelSurgical.AutoSize = true;
            this.labelSurgical.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurgical.Location = new System.Drawing.Point(142, 127);
            this.labelSurgical.Name = "labelSurgical";
            this.labelSurgical.Size = new System.Drawing.Size(134, 20);
            this.labelSurgical.TabIndex = 2;
            this.labelSurgical.Text = "Surgical Charges:";
            // 
            // labelLab
            // 
            this.labelLab.AutoSize = true;
            this.labelLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLab.Location = new System.Drawing.Point(196, 171);
            this.labelLab.Name = "labelLab";
            this.labelLab.Size = new System.Drawing.Size(75, 20);
            this.labelLab.TabIndex = 3;
            this.labelLab.Text = "Lab fees:";
            // 
            // labelRehab
            // 
            this.labelRehab.AutoSize = true;
            this.labelRehab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRehab.Location = new System.Drawing.Point(151, 207);
            this.labelRehab.Name = "labelRehab";
            this.labelRehab.Size = new System.Drawing.Size(125, 20);
            this.labelRehab.TabIndex = 4;
            this.labelRehab.Text = "Rehab Charges:";
            // 
            // labelStay
            // 
            this.labelStay.AutoSize = true;
            this.labelStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStay.Location = new System.Drawing.Point(117, 16);
            this.labelStay.Name = "labelStay";
            this.labelStay.Size = new System.Drawing.Size(109, 20);
            this.labelStay.TabIndex = 5;
            this.labelStay.Text = "Stay Charges:";
            // 
            // groupBoxHospitalCharges
            // 
            this.groupBoxHospitalCharges.Controls.Add(this.labelStay);
            this.groupBoxHospitalCharges.Controls.Add(this.LabeltotalCharges);
            this.groupBoxHospitalCharges.Controls.Add(this.labelMiscCharges);
            this.groupBoxHospitalCharges.Controls.Add(this.labelStayCharges);
            this.groupBoxHospitalCharges.Controls.Add(this.labelTotal);
            this.groupBoxHospitalCharges.Controls.Add(this.labelMisc);
            this.groupBoxHospitalCharges.Location = new System.Drawing.Point(46, 245);
            this.groupBoxHospitalCharges.Name = "groupBoxHospitalCharges";
            this.groupBoxHospitalCharges.Size = new System.Drawing.Size(388, 160);
            this.groupBoxHospitalCharges.TabIndex = 6;
            this.groupBoxHospitalCharges.TabStop = false;
            this.groupBoxHospitalCharges.Text = "Hospital Charges";
            // 
            // LabeltotalCharges
            // 
            this.LabeltotalCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabeltotalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabeltotalCharges.Location = new System.Drawing.Point(280, 121);
            this.LabeltotalCharges.Name = "LabeltotalCharges";
            this.LabeltotalCharges.Size = new System.Drawing.Size(100, 23);
            this.LabeltotalCharges.TabIndex = 4;
            this.LabeltotalCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMiscCharges
            // 
            this.labelMiscCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMiscCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiscCharges.Location = new System.Drawing.Point(280, 62);
            this.labelMiscCharges.Name = "labelMiscCharges";
            this.labelMiscCharges.Size = new System.Drawing.Size(100, 23);
            this.labelMiscCharges.TabIndex = 3;
            this.labelMiscCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStayCharges
            // 
            this.labelStayCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStayCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStayCharges.Location = new System.Drawing.Point(282, 15);
            this.labelStayCharges.Name = "labelStayCharges";
            this.labelStayCharges.Size = new System.Drawing.Size(100, 23);
            this.labelStayCharges.TabIndex = 2;
            this.labelStayCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(114, 114);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(112, 20);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total Charges:";
            // 
            // labelMisc
            // 
            this.labelMisc.AutoSize = true;
            this.labelMisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMisc.Location = new System.Drawing.Point(53, 62);
            this.labelMisc.Name = "labelMisc";
            this.labelMisc.Size = new System.Drawing.Size(173, 20);
            this.labelMisc.TabIndex = 0;
            this.labelMisc.Text = "Miscellaneous Charges";
            // 
            // textBoxdays
            // 
            this.textBoxdays.Location = new System.Drawing.Point(326, 37);
            this.textBoxdays.Name = "textBoxdays";
            this.textBoxdays.Size = new System.Drawing.Size(100, 20);
            this.textBoxdays.TabIndex = 7;
            // 
            // textBoxMedication
            // 
            this.textBoxMedication.Location = new System.Drawing.Point(326, 80);
            this.textBoxMedication.Name = "textBoxMedication";
            this.textBoxMedication.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedication.TabIndex = 8;
            // 
            // textBoxSurgical
            // 
            this.textBoxSurgical.Location = new System.Drawing.Point(326, 129);
            this.textBoxSurgical.Name = "textBoxSurgical";
            this.textBoxSurgical.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurgical.TabIndex = 9;
            // 
            // textBoxLab
            // 
            this.textBoxLab.Location = new System.Drawing.Point(326, 173);
            this.textBoxLab.Name = "textBoxLab";
            this.textBoxLab.Size = new System.Drawing.Size(100, 20);
            this.textBoxLab.TabIndex = 10;
            // 
            // textBoxRehab
            // 
            this.textBoxRehab.Location = new System.Drawing.Point(329, 209);
            this.textBoxRehab.Name = "textBoxRehab";
            this.textBoxRehab.Size = new System.Drawing.Size(100, 20);
            this.textBoxRehab.TabIndex = 11;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalc.Location = new System.Drawing.Point(88, 424);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(88, 44);
            this.buttonCalc.TabIndex = 12;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(298, 424);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 43);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(467, 424);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 43);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 479);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxRehab);
            this.Controls.Add(this.textBoxLab);
            this.Controls.Add(this.textBoxSurgical);
            this.Controls.Add(this.textBoxMedication);
            this.Controls.Add(this.textBoxdays);
            this.Controls.Add(this.groupBoxHospitalCharges);
            this.Controls.Add(this.labelRehab);
            this.Controls.Add(this.labelLab);
            this.Controls.Add(this.labelSurgical);
            this.Controls.Add(this.labelMedication);
            this.Controls.Add(this.labelDays);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxHospitalCharges.ResumeLayout(false);
            this.groupBoxHospitalCharges.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelMedication;
        private System.Windows.Forms.Label labelSurgical;
        private System.Windows.Forms.Label labelLab;
        private System.Windows.Forms.Label labelRehab;
        private System.Windows.Forms.Label labelStay;
        private System.Windows.Forms.GroupBox groupBoxHospitalCharges;
        private System.Windows.Forms.Label LabeltotalCharges;
        private System.Windows.Forms.Label labelMiscCharges;
        private System.Windows.Forms.Label labelStayCharges;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelMisc;
        private System.Windows.Forms.TextBox textBoxdays;
        private System.Windows.Forms.TextBox textBoxMedication;
        private System.Windows.Forms.TextBox textBoxSurgical;
        private System.Windows.Forms.TextBox textBoxLab;
        private System.Windows.Forms.TextBox textBoxRehab;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
    }
}

