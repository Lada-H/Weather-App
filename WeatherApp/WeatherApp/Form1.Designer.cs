namespace WeatherApp
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBoxCityName;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.Label labelError;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.textBoxCityName = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.labelResult = new System.Windows.Forms.Label();
			this.labelError = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxCityName
			// 
			this.textBoxCityName.Location = new System.Drawing.Point(12, 12);
			this.textBoxCityName.Name = "textBoxCityName";
			this.textBoxCityName.Size = new System.Drawing.Size(260, 20);
			this.textBoxCityName.TabIndex = 0;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(278, 10);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 1;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Location = new System.Drawing.Point(12, 45);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(0, 13);
			this.labelResult.TabIndex = 2;
			// 
			// labelError
			// 
			this.labelError.AutoSize = true;
			this.labelError.ForeColor = System.Drawing.Color.Red;
			this.labelError.Location = new System.Drawing.Point(12, 70);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(0, 13);
			this.labelError.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 101);
			this.Controls.Add(this.labelError);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxCityName);
			this.Name = "Form1";
			this.Text = "Weather App";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
