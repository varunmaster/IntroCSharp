namespace Reflection_Demo
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
            this.btnDiscoverTypeInfo = new System.Windows.Forms.Button();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.lstMethods = new System.Windows.Forms.ListBox();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.lstConstructors = new System.Windows.Forms.ListBox();
            this.TypeName = new System.Windows.Forms.Label();
            this.lblMethods = new System.Windows.Forms.Label();
            this.lblProperties = new System.Windows.Forms.Label();
            this.lblConstructors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDiscoverTypeInfo
            // 
            this.btnDiscoverTypeInfo.Location = new System.Drawing.Point(938, 8);
            this.btnDiscoverTypeInfo.Name = "btnDiscoverTypeInfo";
            this.btnDiscoverTypeInfo.Size = new System.Drawing.Size(341, 41);
            this.btnDiscoverTypeInfo.TabIndex = 0;
            this.btnDiscoverTypeInfo.Text = "Discover Type Info";
            this.btnDiscoverTypeInfo.UseVisualStyleBackColor = true;
            this.btnDiscoverTypeInfo.Click += new System.EventHandler(this.btnDiscoverTypeInfo_Click);
            // 
            // txtTypeName
            // 
            this.txtTypeName.AcceptsReturn = true;
            this.txtTypeName.AcceptsTab = true;
            this.txtTypeName.Location = new System.Drawing.Point(191, 19);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(688, 20);
            this.txtTypeName.TabIndex = 1;
            this.txtTypeName.Text = "System.String";
            // 
            // lstMethods
            // 
            this.lstMethods.FormattingEnabled = true;
            this.lstMethods.Location = new System.Drawing.Point(66, 94);
            this.lstMethods.Name = "lstMethods";
            this.lstMethods.Size = new System.Drawing.Size(298, 459);
            this.lstMethods.TabIndex = 2;
            // 
            // lstProperties
            // 
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.Location = new System.Drawing.Point(506, 94);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(298, 459);
            this.lstProperties.TabIndex = 3;
            // 
            // lstConstructors
            // 
            this.lstConstructors.FormattingEnabled = true;
            this.lstConstructors.Location = new System.Drawing.Point(938, 94);
            this.lstConstructors.Name = "lstConstructors";
            this.lstConstructors.Size = new System.Drawing.Size(298, 459);
            this.lstConstructors.TabIndex = 4;
            // 
            // TypeName
            // 
            this.TypeName.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.TypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeName.Location = new System.Drawing.Point(66, 19);
            this.TypeName.Name = "TypeName";
            this.TypeName.Size = new System.Drawing.Size(127, 30);
            this.TypeName.TabIndex = 5;
            this.TypeName.Text = "Type Name";
            // 
            // lblMethods
            // 
            this.lblMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethods.Location = new System.Drawing.Point(62, 62);
            this.lblMethods.Name = "lblMethods";
            this.lblMethods.Size = new System.Drawing.Size(143, 21);
            this.lblMethods.TabIndex = 6;
            this.lblMethods.Text = "Methods";
            // 
            // lblProperties
            // 
            this.lblProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperties.Location = new System.Drawing.Point(502, 62);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(143, 21);
            this.lblProperties.TabIndex = 7;
            this.lblProperties.Text = "Properties";
            this.lblProperties.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblConstructors
            // 
            this.lblConstructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstructors.Location = new System.Drawing.Point(934, 62);
            this.lblConstructors.Name = "lblConstructors";
            this.lblConstructors.Size = new System.Drawing.Size(143, 21);
            this.lblConstructors.TabIndex = 8;
            this.lblConstructors.Text = "Constructors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 590);
            this.Controls.Add(this.lblConstructors);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.lblMethods);
            this.Controls.Add(this.TypeName);
            this.Controls.Add(this.lstConstructors);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.lstMethods);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.btnDiscoverTypeInfo);
            this.Name = "Form1";
            this.Text = "Reflection Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiscoverTypeInfo;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.ListBox lstMethods;
        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.ListBox lstConstructors;
        private System.Windows.Forms.Label TypeName;
        private System.Windows.Forms.Label lblMethods;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.Label lblConstructors;
    }
}

