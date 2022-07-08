namespace FindNumber2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTitle = new System.Windows.Forms.Label();
            this.buttonReload = new System.Windows.Forms.Button();
            this.infoPannel = new System.Windows.Forms.Label();
            this.labelAboutHealth = new System.Windows.Forms.Label();
            this.countOfHealth = new System.Windows.Forms.Label();
            this.inputNumberBox = new System.Windows.Forms.TextBox();
            this.checkNumberButton = new System.Windows.Forms.Button();
            this.prevNumbers = new System.Windows.Forms.Label();
            this.PrevInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            resources.ApplyResources(this.mainTitle, "mainTitle");
            this.mainTitle.Name = "mainTitle";
            // 
            // buttonReload
            // 
            resources.ApplyResources(this.buttonReload, "buttonReload");
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // infoPannel
            // 
            resources.ApplyResources(this.infoPannel, "infoPannel");
            this.infoPannel.Name = "infoPannel";
            // 
            // labelAboutHealth
            // 
            resources.ApplyResources(this.labelAboutHealth, "labelAboutHealth");
            this.labelAboutHealth.Name = "labelAboutHealth";
            // 
            // countOfHealth
            // 
            resources.ApplyResources(this.countOfHealth, "countOfHealth");
            this.countOfHealth.Name = "countOfHealth";
            // 
            // inputNumberBox
            // 
            resources.ApplyResources(this.inputNumberBox, "inputNumberBox");
            this.inputNumberBox.Name = "inputNumberBox";
            // 
            // checkNumberButton
            // 
            resources.ApplyResources(this.checkNumberButton, "checkNumberButton");
            this.checkNumberButton.Name = "checkNumberButton";
            this.checkNumberButton.UseVisualStyleBackColor = true;
            this.checkNumberButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // prevNumbers
            // 
            resources.ApplyResources(this.prevNumbers, "prevNumbers");
            this.prevNumbers.Name = "prevNumbers";
            // 
            // PrevInformation
            // 
            resources.ApplyResources(this.PrevInformation, "PrevInformation");
            this.PrevInformation.Name = "PrevInformation";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrevInformation);
            this.Controls.Add(this.prevNumbers);
            this.Controls.Add(this.checkNumberButton);
            this.Controls.Add(this.inputNumberBox);
            this.Controls.Add(this.countOfHealth);
            this.Controls.Add(this.labelAboutHealth);
            this.Controls.Add(this.infoPannel);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.mainTitle);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Label infoPannel;
        private System.Windows.Forms.Label labelAboutHealth;
        private System.Windows.Forms.Label countOfHealth;
        private System.Windows.Forms.TextBox inputNumberBox;
        private System.Windows.Forms.Button checkNumberButton;
        private System.Windows.Forms.Label prevNumbers;
        private System.Windows.Forms.Label PrevInformation;
    }
}

