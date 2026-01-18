namespace WorldMap
{
    partial class MainForm
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
            this.btnCountries = new System.Windows.Forms.Button();
            this.btnCities = new System.Windows.Forms.Button();
            this.btnRivers = new System.Windows.Forms.Button();
            this.btnLakes = new System.Windows.Forms.Button();
            this.btnMountains = new System.Windows.Forms.Button();
            this.btnSeas = new System.Windows.Forms.Button();
            this.btnRegions = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCountries
            // 
            this.btnCountries.Location = new System.Drawing.Point(34, 200);
            this.btnCountries.Name = "btnCountries";
            this.btnCountries.Size = new System.Drawing.Size(160, 87);
            this.btnCountries.TabIndex = 0;
            this.btnCountries.Text = "Countries";
            this.btnCountries.UseVisualStyleBackColor = true;
            this.btnCountries.Click += new System.EventHandler(this.btnCountries_Click_1);
            // 
            // btnCities
            // 
            this.btnCities.Location = new System.Drawing.Point(328, 311);
            this.btnCities.Name = "btnCities";
            this.btnCities.Size = new System.Drawing.Size(161, 98);
            this.btnCities.TabIndex = 1;
            this.btnCities.Text = "Cities";
            this.btnCities.UseVisualStyleBackColor = true;
            this.btnCities.Click += new System.EventHandler(this.btnCities_Click_1);
            // 
            // btnRivers
            // 
            this.btnRivers.Location = new System.Drawing.Point(34, 311);
            this.btnRivers.Name = "btnRivers";
            this.btnRivers.Size = new System.Drawing.Size(160, 98);
            this.btnRivers.TabIndex = 2;
            this.btnRivers.Text = "Rivers";
            this.btnRivers.UseVisualStyleBackColor = true;
            this.btnRivers.Click += new System.EventHandler(this.btnRivers_Click_1);
            // 
            // btnLakes
            // 
            this.btnLakes.Location = new System.Drawing.Point(34, 69);
            this.btnLakes.Name = "btnLakes";
            this.btnLakes.Size = new System.Drawing.Size(160, 93);
            this.btnLakes.TabIndex = 3;
            this.btnLakes.Text = "Lakes";
            this.btnLakes.UseVisualStyleBackColor = true;
            this.btnLakes.Click += new System.EventHandler(this.btnLakes_Click_1);
            // 
            // btnMountains
            // 
            this.btnMountains.Location = new System.Drawing.Point(328, 69);
            this.btnMountains.Name = "btnMountains";
            this.btnMountains.Size = new System.Drawing.Size(161, 89);
            this.btnMountains.TabIndex = 4;
            this.btnMountains.Text = "Mountains";
            this.btnMountains.UseVisualStyleBackColor = true;
            this.btnMountains.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSeas
            // 
            this.btnSeas.Location = new System.Drawing.Point(328, 200);
            this.btnSeas.Name = "btnSeas";
            this.btnSeas.Size = new System.Drawing.Size(161, 87);
            this.btnSeas.TabIndex = 5;
            this.btnSeas.Text = "Seas";
            this.btnSeas.UseVisualStyleBackColor = true;
            this.btnSeas.Click += new System.EventHandler(this.btnSeas_Click_1);
            // 
            // btnRegions
            // 
            this.btnRegions.Location = new System.Drawing.Point(592, 69);
            this.btnRegions.Name = "btnRegions";
            this.btnRegions.Size = new System.Drawing.Size(152, 89);
            this.btnRegions.TabIndex = 6;
            this.btnRegions.Text = "Regions";
            this.btnRegions.UseVisualStyleBackColor = true;
            this.btnRegions.Click += new System.EventHandler(this.btnRegions_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(700, 387);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 51);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(700, 311);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 47);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRegions);
            this.Controls.Add(this.btnSeas);
            this.Controls.Add(this.btnMountains);
            this.Controls.Add(this.btnLakes);
            this.Controls.Add(this.btnRivers);
            this.Controls.Add(this.btnCities);
            this.Controls.Add(this.btnCountries);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.btnExit_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCountries;
        private System.Windows.Forms.Button btnCities;
        private System.Windows.Forms.Button btnRivers;
        private System.Windows.Forms.Button btnLakes;
        private System.Windows.Forms.Button btnMountains;
        private System.Windows.Forms.Button btnSeas;
        private System.Windows.Forms.Button btnRegions;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
    }
}