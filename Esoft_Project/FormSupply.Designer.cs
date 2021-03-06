﻿namespace Esoft_Project
{
    partial class FormSupply
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
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelRealEstate = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.listViewSupplySet = new System.Windows.Forms.ListView();
            this.Риелтор = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ФИОриелтора = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Idклиента = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ФИОКлиента = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdОбъекта = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.АдресОбъекта = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Цена = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxRealEstate = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(29, 240);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(182, 20);
            this.textBoxPrice.TabIndex = 0;
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Location = new System.Drawing.Point(26, 22);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(49, 13);
            this.labelAgent.TabIndex = 1;
            this.labelAgent.Text = "Риелтор";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(26, 91);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 2;
            this.labelClient.Text = "Клиент";
            // 
            // labelRealEstate
            // 
            this.labelRealEstate.AutoSize = true;
            this.labelRealEstate.Location = new System.Drawing.Point(26, 161);
            this.labelRealEstate.Name = "labelRealEstate";
            this.labelRealEstate.Size = new System.Drawing.Size(123, 13);
            this.labelRealEstate.TabIndex = 3;
            this.labelRealEstate.Text = "Объект недвижимости";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(26, 224);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Цена";
            // 
            // listViewSupplySet
            // 
            this.listViewSupplySet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Риелтор,
            this.ФИОриелтора,
            this.Idклиента,
            this.ФИОКлиента,
            this.IdОбъекта,
            this.АдресОбъекта,
            this.Цена});
            this.listViewSupplySet.FullRowSelect = true;
            this.listViewSupplySet.GridLines = true;
            this.listViewSupplySet.HideSelection = false;
            this.listViewSupplySet.Location = new System.Drawing.Point(227, 38);
            this.listViewSupplySet.MultiSelect = false;
            this.listViewSupplySet.Name = "listViewSupplySet";
            this.listViewSupplySet.Size = new System.Drawing.Size(855, 222);
            this.listViewSupplySet.TabIndex = 5;
            this.listViewSupplySet.UseCompatibleStateImageBehavior = false;
            this.listViewSupplySet.View = System.Windows.Forms.View.Details;
            this.listViewSupplySet.SelectedIndexChanged += new System.EventHandler(this.listViewSupplySet_SelectedIndexChanged);
            // 
            // Риелтор
            // 
            this.Риелтор.Text = "Id Риелтора";
            this.Риелтор.Width = 72;
            // 
            // ФИОриелтора
            // 
            this.ФИОриелтора.Text = "ФИО риелтора";
            this.ФИОриелтора.Width = 123;
            // 
            // Idклиента
            // 
            this.Idклиента.Text = "Id клиента";
            this.Idклиента.Width = 66;
            // 
            // ФИОКлиента
            // 
            this.ФИОКлиента.Text = "ФИО клиента";
            this.ФИОКлиента.Width = 113;
            // 
            // IdОбъекта
            // 
            this.IdОбъекта.Text = "Id объекта недвижимости";
            this.IdОбъекта.Width = 147;
            // 
            // АдресОбъекта
            // 
            this.АдресОбъекта.Text = "Адрес объекта недвижимости";
            this.АдресОбъекта.Width = 241;
            // 
            // Цена
            // 
            this.Цена.Text = "Цена";
            this.Цена.Width = 89;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(732, 266);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 48);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(813, 266);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 48);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(894, 266);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 48);
            this.buttonDel.TabIndex = 8;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxAgents
            // 
            this.comboBoxAgents.FormattingEnabled = true;
            this.comboBoxAgents.Location = new System.Drawing.Point(29, 38);
            this.comboBoxAgents.Name = "comboBoxAgents";
            this.comboBoxAgents.Size = new System.Drawing.Size(182, 21);
            this.comboBoxAgents.TabIndex = 9;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(29, 107);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(182, 21);
            this.comboBoxClients.TabIndex = 10;
            // 
            // comboBoxRealEstate
            // 
            this.comboBoxRealEstate.FormattingEnabled = true;
            this.comboBoxRealEstate.Location = new System.Drawing.Point(29, 177);
            this.comboBoxRealEstate.Name = "comboBoxRealEstate";
            this.comboBoxRealEstate.Size = new System.Drawing.Size(182, 21);
            this.comboBoxRealEstate.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(29, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 327);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxRealEstate);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.comboBoxAgents);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewSupplySet);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelRealEstate);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.textBoxPrice);
            this.Name = "FormSupply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предложения";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelRealEstate;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ListView listViewSupplySet;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxAgents;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxRealEstate;
        private System.Windows.Forms.ColumnHeader Риелтор;
        private System.Windows.Forms.ColumnHeader ФИОриелтора;
        private System.Windows.Forms.ColumnHeader Idклиента;
        private System.Windows.Forms.ColumnHeader ФИОКлиента;
        private System.Windows.Forms.ColumnHeader IdОбъекта;
        private System.Windows.Forms.ColumnHeader АдресОбъекта;
        private System.Windows.Forms.ColumnHeader Цена;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}