namespace DesignPatterns.View
{
    partial class DesignPatternsView
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
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Lbl_Input = new System.Windows.Forms.Label();
            this.Tb_Input = new System.Windows.Forms.TextBox();
            this.Lbl_Sorting = new System.Windows.Forms.Label();
            this.Cb_Sorting = new System.Windows.Forms.ComboBox();
            this.Btn_Sort = new System.Windows.Forms.Button();
            this.Lbl_Sorted = new System.Windows.Forms.Label();
            this.Lbl_Sorted_Value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Location = new System.Drawing.Point(13, 13);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(82, 13);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Design Patterns";
            // 
            // Lbl_Input
            // 
            this.Lbl_Input.AutoSize = true;
            this.Lbl_Input.Location = new System.Drawing.Point(16, 49);
            this.Lbl_Input.Name = "Lbl_Input";
            this.Lbl_Input.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Input.TabIndex = 1;
            this.Lbl_Input.Text = "Input:";
            // 
            // Tb_Input
            // 
            this.Tb_Input.Location = new System.Drawing.Point(57, 49);
            this.Tb_Input.Name = "Tb_Input";
            this.Tb_Input.Size = new System.Drawing.Size(100, 20);
            this.Tb_Input.TabIndex = 2;
            // 
            // Lbl_Sorting
            // 
            this.Lbl_Sorting.AutoSize = true;
            this.Lbl_Sorting.Location = new System.Drawing.Point(16, 85);
            this.Lbl_Sorting.Name = "Lbl_Sorting";
            this.Lbl_Sorting.Size = new System.Drawing.Size(85, 13);
            this.Lbl_Sorting.TabIndex = 3;
            this.Lbl_Sorting.Text = "Sorting Strategy:";
            // 
            // Cb_Sorting
            // 
            this.Cb_Sorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Sorting.FormattingEnabled = true;
            this.Cb_Sorting.Items.AddRange(new object[] {
            "Bubble",
            "Merge"});
            this.Cb_Sorting.Location = new System.Drawing.Point(108, 85);
            this.Cb_Sorting.Name = "Cb_Sorting";
            this.Cb_Sorting.Size = new System.Drawing.Size(121, 21);
            this.Cb_Sorting.TabIndex = 4;
            // 
            // Btn_Sort
            // 
            this.Btn_Sort.Location = new System.Drawing.Point(19, 118);
            this.Btn_Sort.Name = "Btn_Sort";
            this.Btn_Sort.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sort.TabIndex = 5;
            this.Btn_Sort.Text = "Sort";
            this.Btn_Sort.UseVisualStyleBackColor = true;
            this.Btn_Sort.Click += new System.EventHandler(this.Btn_Sort_Click);
            // 
            // Lbl_Sorted
            // 
            this.Lbl_Sorted.AutoSize = true;
            this.Lbl_Sorted.Location = new System.Drawing.Point(19, 161);
            this.Lbl_Sorted.Name = "Lbl_Sorted";
            this.Lbl_Sorted.Size = new System.Drawing.Size(68, 13);
            this.Lbl_Sorted.TabIndex = 6;
            this.Lbl_Sorted.Text = "Sorted Input:";
            // 
            // Lbl_Sorted_Value
            // 
            this.Lbl_Sorted_Value.AutoSize = true;
            this.Lbl_Sorted_Value.Location = new System.Drawing.Point(94, 161);
            this.Lbl_Sorted_Value.Name = "Lbl_Sorted_Value";
            this.Lbl_Sorted_Value.Size = new System.Drawing.Size(16, 13);
            this.Lbl_Sorted_Value.TabIndex = 7;
            this.Lbl_Sorted_Value.Text = "...";
            // 
            // DesignPatternsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 186);
            this.Controls.Add(this.Lbl_Sorted_Value);
            this.Controls.Add(this.Lbl_Sorted);
            this.Controls.Add(this.Btn_Sort);
            this.Controls.Add(this.Cb_Sorting);
            this.Controls.Add(this.Lbl_Sorting);
            this.Controls.Add(this.Tb_Input);
            this.Controls.Add(this.Lbl_Input);
            this.Controls.Add(this.Lbl_Title);
            this.Name = "DesignPatternsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DesignPatternsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_Input;
        private System.Windows.Forms.TextBox Tb_Input;
        private System.Windows.Forms.Label Lbl_Sorting;
        private System.Windows.Forms.ComboBox Cb_Sorting;
        private System.Windows.Forms.Button Btn_Sort;
        private System.Windows.Forms.Label Lbl_Sorted;
        private System.Windows.Forms.Label Lbl_Sorted_Value;
    }
}