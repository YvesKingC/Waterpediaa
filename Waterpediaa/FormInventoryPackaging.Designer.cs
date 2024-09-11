namespace Waterpediaa
{
    partial class FormInventoryPackaging
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
            dataGridViewPackaging = new DataGridView();
            buttonEditInventory = new Button();
            buttonItemPack = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPackaging).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPackaging
            // 
            dataGridViewPackaging.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewPackaging.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPackaging.Location = new Point(12, 11);
            dataGridViewPackaging.Margin = new Padding(3, 2, 3, 2);
            dataGridViewPackaging.Name = "dataGridViewPackaging";
            dataGridViewPackaging.RowHeadersWidth = 51;
            dataGridViewPackaging.RowTemplate.Height = 29;
            dataGridViewPackaging.Size = new Size(1090, 639);
            dataGridViewPackaging.TabIndex = 2;
            // 
            // buttonEditInventory
            // 
            buttonEditInventory.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditInventory.Location = new Point(1134, 235);
            buttonEditInventory.Margin = new Padding(3, 2, 3, 2);
            buttonEditInventory.Name = "buttonEditInventory";
            buttonEditInventory.Size = new Size(132, 36);
            buttonEditInventory.TabIndex = 6;
            buttonEditInventory.Text = "Edit Item";
            buttonEditInventory.UseVisualStyleBackColor = true;
            buttonEditInventory.Click += buttonEditInventory_Click;
            // 
            // buttonItemPack
            // 
            buttonItemPack.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonItemPack.Location = new Point(1134, 275);
            buttonItemPack.Margin = new Padding(3, 2, 3, 2);
            buttonItemPack.Name = "buttonItemPack";
            buttonItemPack.Size = new Size(132, 36);
            buttonItemPack.TabIndex = 7;
            buttonItemPack.Text = "Item Baru";
            buttonItemPack.UseVisualStyleBackColor = true;
            buttonItemPack.Click += buttonItemPack_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Salmon;
            button7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(1134, 436);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(132, 36);
            button7.TabIndex = 10;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // FormInventoryPackaging
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 661);
            Controls.Add(button7);
            Controls.Add(buttonItemPack);
            Controls.Add(buttonEditInventory);
            Controls.Add(dataGridViewPackaging);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormInventoryPackaging";
            Text = "FormInventoryPackaging";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPackaging).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewPackaging;
        private Button buttonEditInventory;
        private Button buttonItemPack;
        private Button button7;
    }
}