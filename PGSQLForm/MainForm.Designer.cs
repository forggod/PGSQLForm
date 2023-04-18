﻿namespace PGSQLForm
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
            panel_main = new Panel();
            button_products = new Button();
            button_clients = new Button();
            button_invoices = new Button();
            button_reports = new Button();
            panel_main.SuspendLayout();
            SuspendLayout();
            // 
            // panel_main
            // 
            panel_main.Controls.Add(button_reports);
            panel_main.Controls.Add(button_invoices);
            panel_main.Controls.Add(button_clients);
            panel_main.Controls.Add(button_products);
            panel_main.Location = new Point(12, 12);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(210, 238);
            panel_main.TabIndex = 0;
            // 
            // button_products
            // 
            button_products.Location = new Point(54, 43);
            button_products.Name = "button_products";
            button_products.Size = new Size(100, 30);
            button_products.TabIndex = 0;
            button_products.Text = "Товары";
            button_products.UseVisualStyleBackColor = true;
            button_products.Click += button_products_Click;
            // 
            // button_clients
            // 
            button_clients.Location = new Point(54, 79);
            button_clients.Name = "button_clients";
            button_clients.Size = new Size(100, 30);
            button_clients.TabIndex = 0;
            button_clients.Text = "Клиенты";
            button_clients.UseVisualStyleBackColor = true;
            button_clients.Click += button_clients_Click;
            // 
            // button_invoices
            // 
            button_invoices.Location = new Point(54, 115);
            button_invoices.Name = "button_invoices";
            button_invoices.Size = new Size(100, 30);
            button_invoices.TabIndex = 0;
            button_invoices.Text = "Накладные";
            button_invoices.UseVisualStyleBackColor = true;
            button_invoices.Click += button_invoices_Click;
            // 
            // button_reports
            // 
            button_reports.Location = new Point(54, 151);
            button_reports.Name = "button_reports";
            button_reports.Size = new Size(100, 30);
            button_reports.TabIndex = 0;
            button_reports.Text = "Отчёты";
            button_reports.UseVisualStyleBackColor = true;
            button_reports.Click += button_reports_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 261);
            Controls.Add(panel_main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Приложение";
            panel_main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_main;
        private Button button_reports;
        private Button button_invoices;
        private Button button_clients;
        private Button button_products;
    }
}