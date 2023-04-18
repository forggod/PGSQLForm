namespace PGSQLForm
{
    partial class ProductTableForm
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem_menu = new ToolStripMenuItem();
            toolStripMenuItem_add = new ToolStripMenuItem();
            toolStripMenuItem_modify = new ToolStripMenuItem();
            toolStripMenuItem_delete = new ToolStripMenuItem();
            dataGridView_table = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_table).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_menu
            // 
            toolStripMenuItem_menu.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem_add, toolStripMenuItem_modify, toolStripMenuItem_delete });
            toolStripMenuItem_menu.Name = "toolStripMenuItem_menu";
            toolStripMenuItem_menu.Size = new Size(53, 20);
            toolStripMenuItem_menu.Text = "Меню";
            // 
            // toolStripMenuItem_add
            // 
            toolStripMenuItem_add.Name = "toolStripMenuItem_add";
            toolStripMenuItem_add.Size = new Size(128, 22);
            toolStripMenuItem_add.Text = "Добавить";
            toolStripMenuItem_add.Click += toolStripMenuItem_add_Click;
            // 
            // toolStripMenuItem_modify
            // 
            toolStripMenuItem_modify.Name = "toolStripMenuItem_modify";
            toolStripMenuItem_modify.Size = new Size(128, 22);
            toolStripMenuItem_modify.Text = "Изменить";
            toolStripMenuItem_modify.Click += toolStripMenuItem_modify_Click;
            // 
            // toolStripMenuItem_delete
            // 
            toolStripMenuItem_delete.Name = "toolStripMenuItem_delete";
            toolStripMenuItem_delete.Size = new Size(128, 22);
            toolStripMenuItem_delete.Text = "Удалить";
            toolStripMenuItem_delete.Click += toolStripMenuItem_delete_Click_;
            // 
            // dataGridView_table
            // 
            dataGridView_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_table.Dock = DockStyle.Fill;
            dataGridView_table.Location = new Point(0, 24);
            dataGridView_table.Name = "dataGridView_table";
            dataGridView_table.RowTemplate.Height = 25;
            dataGridView_table.Size = new Size(800, 426);
            dataGridView_table.TabIndex = 1;
            // 
            // ProductTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_table);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ProductTableForm";
            Text = "ProductTableForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem_menu;
        private ToolStripMenuItem toolStripMenuItem_add;
        private ToolStripMenuItem toolStripMenuItem_modify;
        private ToolStripMenuItem toolStripMenuItem_delete;
        private DataGridView dataGridView_table;
    }
}