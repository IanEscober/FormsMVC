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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Input = new System.Windows.Forms.Label();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.lbl_Sorting = new System.Windows.Forms.Label();
            this.cb_Sorting = new System.Windows.Forms.ComboBox();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.lbl_Sorted = new System.Windows.Forms.Label();
            this.lbl_Sorted_Value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(13, 13);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(82, 13);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Design Patterns";
            // 
            // lbl_Input
            // 
            this.lbl_Input.AutoSize = true;
            this.lbl_Input.Location = new System.Drawing.Point(16, 49);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(34, 13);
            this.lbl_Input.TabIndex = 1;
            this.lbl_Input.Text = "Input:";
            // 
            // tb_Input
            // 
            this.tb_Input.Location = new System.Drawing.Point(57, 49);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(100, 20);
            this.tb_Input.TabIndex = 2;
            // 
            // lbl_Sorting
            // 
            this.lbl_Sorting.AutoSize = true;
            this.lbl_Sorting.Location = new System.Drawing.Point(16, 85);
            this.lbl_Sorting.Name = "lbl_Sorting";
            this.lbl_Sorting.Size = new System.Drawing.Size(85, 13);
            this.lbl_Sorting.TabIndex = 3;
            this.lbl_Sorting.Text = "Sorting Strategy:";
            // 
            // cb_Sorting
            // 
            this.cb_Sorting.FormattingEnabled = true;
            this.cb_Sorting.Location = new System.Drawing.Point(108, 85);
            this.cb_Sorting.Name = "cb_Sorting";
            this.cb_Sorting.Size = new System.Drawing.Size(121, 21);
            this.cb_Sorting.TabIndex = 4;
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(19, 118);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(75, 23);
            this.btn_Sort.TabIndex = 5;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            // 
            // lbl_Sorted
            // 
            this.lbl_Sorted.AutoSize = true;
            this.lbl_Sorted.Location = new System.Drawing.Point(19, 161);
            this.lbl_Sorted.Name = "lbl_Sorted";
            this.lbl_Sorted.Size = new System.Drawing.Size(68, 13);
            this.lbl_Sorted.TabIndex = 6;
            this.lbl_Sorted.Text = "Sorted Input:";
            // 
            // lbl_Sorted_Value
            // 
            this.lbl_Sorted_Value.AutoSize = true;
            this.lbl_Sorted_Value.Location = new System.Drawing.Point(94, 161);
            this.lbl_Sorted_Value.Name = "lbl_Sorted_Value";
            this.lbl_Sorted_Value.Size = new System.Drawing.Size(16, 13);
            this.lbl_Sorted_Value.TabIndex = 7;
            this.lbl_Sorted_Value.Text = "...";
            // 
            // DesignPatternsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 186);
            this.Controls.Add(this.lbl_Sorted_Value);
            this.Controls.Add(this.lbl_Sorted);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.cb_Sorting);
            this.Controls.Add(this.lbl_Sorting);
            this.Controls.Add(this.tb_Input);
            this.Controls.Add(this.lbl_Input);
            this.Controls.Add(this.lbl_Title);
            this.Name = "DesignPatternsView";
            this.Text = "DesignPatternsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.Label lbl_Sorting;
        private System.Windows.Forms.ComboBox cb_Sorting;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Label lbl_Sorted;
        private System.Windows.Forms.Label lbl_Sorted_Value;
    }
}