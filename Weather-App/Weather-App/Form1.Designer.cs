namespace Weather_App
{
    partial class Form1
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
            CityName = new Label();
            MinTemperatureLabel = new Label();
            MaxTemperatureLabel = new Label();
            HumidityLabel = new Label();
            CityTextBox = new TextBox();
            GetWeatherButton = new Button();
            SuspendLayout();
            // 
            // CityName
            // 
            CityName.AutoSize = true;
            CityName.Location = new Point(84, 37);
            CityName.Name = "CityName";
            CityName.Size = new Size(116, 20);
            CityName.TabIndex = 0;
            CityName.Text = "Enter City Name";
            // 
            // MinTemperatureLabel
            // 
            MinTemperatureLabel.AutoSize = true;
            MinTemperatureLabel.Location = new Point(84, 69);
            MinTemperatureLabel.Name = "MinTemperatureLabel";
            MinTemperatureLabel.Size = new Size(160, 20);
            MinTemperatureLabel.TabIndex = 1;
            MinTemperatureLabel.Text = "Minimum Temperature";
            // 
            // MaxTemperatureLabel
            // 
            MaxTemperatureLabel.AutoSize = true;
            MaxTemperatureLabel.Location = new Point(84, 114);
            MaxTemperatureLabel.Name = "MaxTemperatureLabel";
            MaxTemperatureLabel.Size = new Size(163, 20);
            MaxTemperatureLabel.TabIndex = 2;
            MaxTemperatureLabel.Text = "Maximum Temperature";
            // 
            // HumidityLabel
            // 
            HumidityLabel.AutoSize = true;
            HumidityLabel.Location = new Point(84, 150);
            HumidityLabel.Name = "HumidityLabel";
            HumidityLabel.Size = new Size(70, 20);
            HumidityLabel.TabIndex = 3;
            HumidityLabel.Text = "Humidity";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(257, 30);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(250, 27);
            CityTextBox.TabIndex = 4;
            // 
            // GetWeatherButton
            // 
            GetWeatherButton.Location = new Point(257, 236);
            GetWeatherButton.Name = "GetWeatherButton";
            GetWeatherButton.Size = new Size(291, 51);
            GetWeatherButton.TabIndex = 5;
            GetWeatherButton.Text = "Get Weather";
            GetWeatherButton.UseVisualStyleBackColor = true;
            GetWeatherButton.Click += GetWeatherButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GetWeatherButton);
            Controls.Add(CityTextBox);
            Controls.Add(HumidityLabel);
            Controls.Add(MaxTemperatureLabel);
            Controls.Add(MinTemperatureLabel);
            Controls.Add(CityName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CityName;
        private Label MinTemperatureLabel;
        private Label MaxTemperatureLabel;
        private Label HumidityLabel;
        private TextBox CityTextBox;
        private Button GetWeatherButton;
    }
}