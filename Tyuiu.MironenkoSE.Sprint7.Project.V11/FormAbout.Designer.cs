
namespace Tyuiu.MironenkoSE.Sprint7.Project.V11
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox_LED = new PictureBox();
            buttonOK_LED = new Button();
            textBox_MSE = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_LED).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_LED
            // 
            pictureBox_LED.ErrorImage = null;
            pictureBox_LED.Image = (Image)resources.GetObject("pictureBox_LED.Image");
            pictureBox_LED.Location = new Point(41, 11);
            pictureBox_LED.Margin = new Padding(3, 2, 3, 2);
            pictureBox_LED.Name = "pictureBox_LED";
            pictureBox_LED.Size = new Size(59, 87);
            pictureBox_LED.TabIndex = 1;
            pictureBox_LED.TabStop = false;
            // 
            // buttonOK_LED
            // 
            buttonOK_LED.Location = new Point(640, 251);
            buttonOK_LED.Margin = new Padding(3, 2, 3, 2);
            buttonOK_LED.Name = "buttonOK_LED";
            buttonOK_LED.Size = new Size(82, 22);
            buttonOK_LED.TabIndex = 2;
            buttonOK_LED.Text = "OK";
            buttonOK_LED.UseVisualStyleBackColor = true;
            buttonOK_LED.Click += buttonOK_MSE_Click;
            // 
            // textBox_MSE
            // 
            textBox_MSE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_MSE.Location = new Point(140, 11);
            textBox_MSE.Margin = new Padding(3, 2, 3, 2);
            textBox_MSE.Multiline = true;
            textBox_MSE.Name = "textBox_MSE";
            textBox_MSE.ReadOnly = true;
            textBox_MSE.Size = new Size(467, 221);
            textBox_MSE.TabIndex = 0;
            textBox_MSE.TabStop = false;
            textBox_MSE.Text = "Группа-Асоиу24-1     \r\nРазработал:Мироненко Сергей Эдуардович\r\nПрограмма была создана на языке C#\r\nТюменский Индустриальный Университет\r\nВШЦТ\r\n\r\n\r\n                                   ";
            textBox_MSE.TextChanged += textBox_LED_TextChanged;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 280);
            Controls.Add(buttonOK_LED);
            Controls.Add(pictureBox_LED);
            Controls.Add(textBox_MSE);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)pictureBox_LED).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonOK_MSE_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private PictureBox pictureBox_LED;
        private Button buttonOK_LED;
        private TextBox textBox_MSE;
    }
}
    
