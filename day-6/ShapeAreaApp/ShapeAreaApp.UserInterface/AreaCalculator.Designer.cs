namespace ShapeAreaApp.UserInterface
{
    partial class AreaCalculator
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
            this.radioCircle = new System.Windows.Forms.RadioButton();
            this.radioTriangle = new System.Windows.Forms.RadioButton();
            this.panelShape = new System.Windows.Forms.Panel();
            this.btnCalculateArea = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.panelShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioCircle
            // 
            this.radioCircle.AutoEllipsis = true;
            this.radioCircle.AutoSize = true;
            this.radioCircle.BackColor = System.Drawing.SystemColors.Control;
            this.radioCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCircle.Location = new System.Drawing.Point(94, 68);
            this.radioCircle.Name = "radioCircle";
            this.radioCircle.Size = new System.Drawing.Size(89, 29);
            this.radioCircle.TabIndex = 0;
            this.radioCircle.Text = "Circle";
            this.radioCircle.UseVisualStyleBackColor = false;
            this.radioCircle.CheckedChanged += new System.EventHandler(this.radioCircle_CheckedChanged);
            // 
            // radioTriangle
            // 
            this.radioTriangle.AutoSize = true;
            this.radioTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTriangle.Location = new System.Drawing.Point(390, 68);
            this.radioTriangle.Name = "radioTriangle";
            this.radioTriangle.Size = new System.Drawing.Size(112, 29);
            this.radioTriangle.TabIndex = 1;
            this.radioTriangle.Text = "Triangle";
            this.radioTriangle.UseVisualStyleBackColor = true;
            this.radioTriangle.CheckedChanged += new System.EventHandler(this.radioTriangle_CheckedChanged);
            // 
            // panelShape
            // 
            this.panelShape.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelShape.Controls.Add(this.btnCalculateArea);
            this.panelShape.Controls.Add(this.textBoxHeight);
            this.panelShape.Controls.Add(this.lblHeight);
            this.panelShape.Controls.Add(this.textBoxBase);
            this.panelShape.Controls.Add(this.lblBase);
            this.panelShape.Controls.Add(this.textBoxRadius);
            this.panelShape.Controls.Add(this.lblRadius);
            this.panelShape.Location = new System.Drawing.Point(94, 127);
            this.panelShape.Name = "panelShape";
            this.panelShape.Size = new System.Drawing.Size(570, 259);
            this.panelShape.TabIndex = 2;
            // 
            // btnCalculateArea
            // 
            this.btnCalculateArea.Location = new System.Drawing.Point(183, 184);
            this.btnCalculateArea.Name = "btnCalculateArea";
            this.btnCalculateArea.Size = new System.Drawing.Size(161, 51);
            this.btnCalculateArea.TabIndex = 6;
            this.btnCalculateArea.Text = "Calculate Area";
            this.btnCalculateArea.UseVisualStyleBackColor = true;
            this.btnCalculateArea.Click += new System.EventHandler(this.btnCalculateArea_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(183, 125);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(182, 22);
            this.textBoxHeight.TabIndex = 5;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(20, 125);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(108, 20);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Enter Height:";
            // 
            // textBoxBase
            // 
            this.textBoxBase.Location = new System.Drawing.Point(183, 71);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(182, 22);
            this.textBoxBase.TabIndex = 3;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(20, 71);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(103, 20);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Enter Base: ";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(183, 26);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(182, 22);
            this.textBoxRadius.TabIndex = 1;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(20, 26);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(116, 20);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Enter Radius: ";
            // 
            // AreaCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelShape);
            this.Controls.Add(this.radioTriangle);
            this.Controls.Add(this.radioCircle);
            this.Name = "AreaCalculator";
            this.Text = "AreaCalculator";
            this.Load += new System.EventHandler(this.AreaCalculator_Load);
            this.panelShape.ResumeLayout(false);
            this.panelShape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioCircle;
        private System.Windows.Forms.RadioButton radioTriangle;
        private System.Windows.Forms.Panel panelShape;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Button btnCalculateArea;
    }
}