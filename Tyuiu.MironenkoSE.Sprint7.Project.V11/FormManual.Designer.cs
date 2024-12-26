namespace Tyuiu.MironenkoSE.Sprint7.Project.V11
{
    partial class FormManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual));
            textBoxHelp_MSE = new TextBox();
            labelHelp_MSE = new Label();
            buttonOk_MSE = new Button();
            SuspendLayout();
            // 
            // textBoxHelp_MSE
            // 
            textBoxHelp_MSE.BackColor = Color.FloralWhite;
            textBoxHelp_MSE.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxHelp_MSE.Location = new Point(-1, 91);
            textBoxHelp_MSE.Margin = new Padding(3, 2, 3, 2);
            textBoxHelp_MSE.Multiline = true;
            textBoxHelp_MSE.Name = "textBoxHelp_MSE";
            textBoxHelp_MSE.ReadOnly = true;
            textBoxHelp_MSE.Size = new Size(889, 185);
            textBoxHelp_MSE.TabIndex = 0;
            textBoxHelp_MSE.TabStop = false;
            textBoxHelp_MSE.Text = resources.GetString("textBoxHelp_MSE.Text");
            // 
            // labelHelp_MSE
            // 
            labelHelp_MSE.AutoSize = true;
            labelHelp_MSE.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelHelp_MSE.ForeColor = Color.Coral;
            labelHelp_MSE.Location = new Point(351, 51);
            labelHelp_MSE.Name = "labelHelp_MSE";
            labelHelp_MSE.Size = new Size(120, 22);
            labelHelp_MSE.TabIndex = 2;
            labelHelp_MSE.Text = "Руководство";
            // 
            // buttonOk_MSE
            // 
            buttonOk_MSE.BackColor = Color.Green;
            buttonOk_MSE.Location = new Point(808, 308);
            buttonOk_MSE.Margin = new Padding(3, 2, 3, 2);
            buttonOk_MSE.Name = "buttonOk_MSE";
            buttonOk_MSE.Size = new Size(82, 22);
            buttonOk_MSE.TabIndex = 3;
            buttonOk_MSE.TabStop = false;
            buttonOk_MSE.Text = "OK";
            buttonOk_MSE.UseVisualStyleBackColor = false;
            buttonOk_MSE.Click += buttonOk_MSE_Click;
            // 
            // FormManual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 338);
            Controls.Add(buttonOk_MSE);
            Controls.Add(labelHelp_MSE);
            Controls.Add(textBoxHelp_MSE);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormManual";
            Text = "Подсказка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHelp_MSE;
        private Label labelHelp_MSE;
        private Button buttonOk_MSE;
    }
}