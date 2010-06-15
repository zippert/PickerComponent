namespace WW
{
    partial class TestApp
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
            this.picker = new WW.PickerCreator();
            this.SuspendLayout();
            // 
            // picker
            // 
            this.picker.Location = new System.Drawing.Point(0, 0);
            this.picker.Name = "picker";
            this.picker.Size = new System.Drawing.Size(317, 302);
            this.picker.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(picker.Size.Width, picker.Size.Height);
            this.Controls.Add(this.picker);
            this.Name = "Form1";
            this.Text = "Picker Test";
            this.ResumeLayout(false);

        }

        private PickerCreatorHandler createTestHandler()
        {
            PickerCreatorHandler handler = new PickerCreatorHandler();
            handler.Add("test", "test");
            handler.Add("test2", "test2");
            return handler;
        }

        #endregion
        private PickerCreator picker;
    }
}

