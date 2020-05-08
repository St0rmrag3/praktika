namespace Esoft_Project
{
    partial class FormDemand
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
            this.labelClient = new System.Windows.Forms.Label();
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.labelMinArea = new System.Windows.Forms.Label();
            this.labelMaxArea = new System.Windows.Forms.Label();
            this.labelMinRooms = new System.Windows.Forms.Label();
            this.labelMinFloor = new System.Windows.Forms.Label();
            this.labelMaxRooms = new System.Windows.Forms.Label();
            this.labelMaxFloor = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxAgent = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.numericUpDownMinPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinArea = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxArea = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinRooms = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxRooms = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinFloor = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxFloor = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinFloors = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxFloors = new System.Windows.Forms.NumericUpDown();
            this.labelMinFloors = new System.Windows.Forms.Label();
            this.labelMaxFloors = new System.Windows.Forms.Label();
            this.listViewApartment = new System.Windows.Forms.ListView();
            this.listViewHome = new System.Windows.Forms.ListView();
            this.listViewLand = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinFloors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxFloors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(37, 19);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "Клиент";
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Location = new System.Drawing.Point(37, 76);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(49, 13);
            this.labelAgent.TabIndex = 1;
            this.labelAgent.Text = "Риелтор";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(37, 133);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(26, 13);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Тип";
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Location = new System.Drawing.Point(257, 19);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(105, 13);
            this.labelMinPrice.TabIndex = 3;
            this.labelMinPrice.Text = "Минимальная цена";
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Location = new System.Drawing.Point(257, 76);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(111, 13);
            this.labelMaxPrice.TabIndex = 4;
            this.labelMaxPrice.Text = "Максимальная цена";
            // 
            // labelMinArea
            // 
            this.labelMinArea.AutoSize = true;
            this.labelMinArea.Location = new System.Drawing.Point(257, 133);
            this.labelMinArea.Name = "labelMinArea";
            this.labelMinArea.Size = new System.Drawing.Size(126, 13);
            this.labelMinArea.TabIndex = 5;
            this.labelMinArea.Text = "Минимальная площадь";
            // 
            // labelMaxArea
            // 
            this.labelMaxArea.AutoSize = true;
            this.labelMaxArea.Location = new System.Drawing.Point(257, 183);
            this.labelMaxArea.Name = "labelMaxArea";
            this.labelMaxArea.Size = new System.Drawing.Size(132, 13);
            this.labelMaxArea.TabIndex = 6;
            this.labelMaxArea.Text = "Максимальная площадь";
            // 
            // labelMinRooms
            // 
            this.labelMinRooms.AutoSize = true;
            this.labelMinRooms.Location = new System.Drawing.Point(430, 19);
            this.labelMinRooms.Name = "labelMinRooms";
            this.labelMinRooms.Size = new System.Drawing.Size(179, 13);
            this.labelMinRooms.TabIndex = 7;
            this.labelMinRooms.Text = "Минимальное количество комнат";
            // 
            // labelMinFloor
            // 
            this.labelMinFloor.AutoSize = true;
            this.labelMinFloor.Location = new System.Drawing.Point(430, 133);
            this.labelMinFloor.Name = "labelMinFloor";
            this.labelMinFloor.Size = new System.Drawing.Size(108, 13);
            this.labelMinFloor.TabIndex = 8;
            this.labelMinFloor.Text = "Минимальный этаж";
            // 
            // labelMaxRooms
            // 
            this.labelMaxRooms.AutoSize = true;
            this.labelMaxRooms.Location = new System.Drawing.Point(430, 76);
            this.labelMaxRooms.Name = "labelMaxRooms";
            this.labelMaxRooms.Size = new System.Drawing.Size(185, 13);
            this.labelMaxRooms.TabIndex = 9;
            this.labelMaxRooms.Text = "Максимальное количество комнат";
            // 
            // labelMaxFloor
            // 
            this.labelMaxFloor.AutoSize = true;
            this.labelMaxFloor.Location = new System.Drawing.Point(430, 183);
            this.labelMaxFloor.Name = "labelMaxFloor";
            this.labelMaxFloor.Size = new System.Drawing.Size(114, 13);
            this.labelMaxFloor.TabIndex = 10;
            this.labelMaxFloor.Text = "Максимальный этаж";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(40, 35);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClient.TabIndex = 11;
            // 
            // comboBoxAgent
            // 
            this.comboBoxAgent.FormattingEnabled = true;
            this.comboBoxAgent.Location = new System.Drawing.Point(40, 92);
            this.comboBoxAgent.Name = "comboBoxAgent";
            this.comboBoxAgent.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAgent.TabIndex = 12;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(40, 149);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 13;
            // 
            // numericUpDownMinPrice
            // 
            this.numericUpDownMinPrice.Location = new System.Drawing.Point(260, 35);
            this.numericUpDownMinPrice.Name = "numericUpDownMinPrice";
            this.numericUpDownMinPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinPrice.TabIndex = 14;
            // 
            // numericUpDownMaxPrice
            // 
            this.numericUpDownMaxPrice.Location = new System.Drawing.Point(260, 92);
            this.numericUpDownMaxPrice.Name = "numericUpDownMaxPrice";
            this.numericUpDownMaxPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxPrice.TabIndex = 15;
            // 
            // numericUpDownMinArea
            // 
            this.numericUpDownMinArea.Location = new System.Drawing.Point(260, 149);
            this.numericUpDownMinArea.Name = "numericUpDownMinArea";
            this.numericUpDownMinArea.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinArea.TabIndex = 16;
            // 
            // numericUpDownMaxArea
            // 
            this.numericUpDownMaxArea.Location = new System.Drawing.Point(260, 199);
            this.numericUpDownMaxArea.Name = "numericUpDownMaxArea";
            this.numericUpDownMaxArea.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxArea.TabIndex = 17;
            // 
            // numericUpDownMinRooms
            // 
            this.numericUpDownMinRooms.Location = new System.Drawing.Point(433, 35);
            this.numericUpDownMinRooms.Name = "numericUpDownMinRooms";
            this.numericUpDownMinRooms.Size = new System.Drawing.Size(176, 20);
            this.numericUpDownMinRooms.TabIndex = 18;
            // 
            // numericUpDownMaxRooms
            // 
            this.numericUpDownMaxRooms.Location = new System.Drawing.Point(433, 92);
            this.numericUpDownMaxRooms.Name = "numericUpDownMaxRooms";
            this.numericUpDownMaxRooms.Size = new System.Drawing.Size(176, 20);
            this.numericUpDownMaxRooms.TabIndex = 19;
            // 
            // numericUpDownMinFloor
            // 
            this.numericUpDownMinFloor.Location = new System.Drawing.Point(433, 149);
            this.numericUpDownMinFloor.Name = "numericUpDownMinFloor";
            this.numericUpDownMinFloor.Size = new System.Drawing.Size(176, 20);
            this.numericUpDownMinFloor.TabIndex = 20;
            // 
            // numericUpDownMaxFloor
            // 
            this.numericUpDownMaxFloor.Location = new System.Drawing.Point(433, 199);
            this.numericUpDownMaxFloor.Name = "numericUpDownMaxFloor";
            this.numericUpDownMaxFloor.Size = new System.Drawing.Size(176, 20);
            this.numericUpDownMaxFloor.TabIndex = 21;
            // 
            // numericUpDownMinFloors
            // 
            this.numericUpDownMinFloors.Location = new System.Drawing.Point(653, 35);
            this.numericUpDownMinFloors.Name = "numericUpDownMinFloors";
            this.numericUpDownMinFloors.Size = new System.Drawing.Size(161, 20);
            this.numericUpDownMinFloors.TabIndex = 22;
            // 
            // numericUpDownMaxFloors
            // 
            this.numericUpDownMaxFloors.Location = new System.Drawing.Point(653, 92);
            this.numericUpDownMaxFloors.Name = "numericUpDownMaxFloors";
            this.numericUpDownMaxFloors.Size = new System.Drawing.Size(161, 20);
            this.numericUpDownMaxFloors.TabIndex = 23;
            // 
            // labelMinFloors
            // 
            this.labelMinFloors.AutoSize = true;
            this.labelMinFloors.Location = new System.Drawing.Point(650, 19);
            this.labelMinFloors.Name = "labelMinFloors";
            this.labelMinFloors.Size = new System.Drawing.Size(164, 13);
            this.labelMinFloors.TabIndex = 24;
            this.labelMinFloors.Text = "Минимальная этажность дома";
            // 
            // labelMaxFloors
            // 
            this.labelMaxFloors.AutoSize = true;
            this.labelMaxFloors.Location = new System.Drawing.Point(650, 76);
            this.labelMaxFloors.Name = "labelMaxFloors";
            this.labelMaxFloors.Size = new System.Drawing.Size(170, 13);
            this.labelMaxFloors.TabIndex = 25;
            this.labelMaxFloors.Text = "Максимальная этажность дома";
            // 
            // listViewApartment
            // 
            this.listViewApartment.HideSelection = false;
            this.listViewApartment.Location = new System.Drawing.Point(40, 239);
            this.listViewApartment.Name = "listViewApartment";
            this.listViewApartment.Size = new System.Drawing.Size(780, 200);
            this.listViewApartment.TabIndex = 26;
            this.listViewApartment.UseCompatibleStateImageBehavior = false;
            // 
            // listViewHome
            // 
            this.listViewHome.HideSelection = false;
            this.listViewHome.Location = new System.Drawing.Point(40, 239);
            this.listViewHome.Name = "listViewHome";
            this.listViewHome.Size = new System.Drawing.Size(780, 200);
            this.listViewHome.TabIndex = 27;
            this.listViewHome.UseCompatibleStateImageBehavior = false;
            // 
            // listViewLand
            // 
            this.listViewLand.HideSelection = false;
            this.listViewLand.Location = new System.Drawing.Point(40, 239);
            this.listViewLand.Name = "listViewLand";
            this.listViewLand.Size = new System.Drawing.Size(780, 200);
            this.listViewLand.TabIndex = 28;
            this.listViewLand.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(508, 445);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 48);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(589, 445);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 48);
            this.buttonEdit.TabIndex = 30;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(670, 445);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 48);
            this.buttonDel.TabIndex = 31;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(40, 463);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // FormDemand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewLand);
            this.Controls.Add(this.listViewHome);
            this.Controls.Add(this.listViewApartment);
            this.Controls.Add(this.labelMaxFloors);
            this.Controls.Add(this.labelMinFloors);
            this.Controls.Add(this.numericUpDownMaxFloors);
            this.Controls.Add(this.numericUpDownMinFloors);
            this.Controls.Add(this.numericUpDownMaxFloor);
            this.Controls.Add(this.numericUpDownMinFloor);
            this.Controls.Add(this.numericUpDownMaxRooms);
            this.Controls.Add(this.numericUpDownMinRooms);
            this.Controls.Add(this.numericUpDownMaxArea);
            this.Controls.Add(this.numericUpDownMinArea);
            this.Controls.Add(this.numericUpDownMaxPrice);
            this.Controls.Add(this.numericUpDownMinPrice);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxAgent);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelMaxFloor);
            this.Controls.Add(this.labelMaxRooms);
            this.Controls.Add(this.labelMinFloor);
            this.Controls.Add(this.labelMinRooms);
            this.Controls.Add(this.labelMaxArea);
            this.Controls.Add(this.labelMinArea);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.labelMinPrice);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.labelClient);
            this.Name = "FormDemand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потребности";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinFloors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxFloors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.Label labelMinArea;
        private System.Windows.Forms.Label labelMaxArea;
        private System.Windows.Forms.Label labelMinRooms;
        private System.Windows.Forms.Label labelMinFloor;
        private System.Windows.Forms.Label labelMaxRooms;
        private System.Windows.Forms.Label labelMaxFloor;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxAgent;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.NumericUpDown numericUpDownMinPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownMinArea;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxArea;
        private System.Windows.Forms.NumericUpDown numericUpDownMinRooms;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxRooms;
        private System.Windows.Forms.NumericUpDown numericUpDownMinFloor;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxFloor;
        private System.Windows.Forms.NumericUpDown numericUpDownMinFloors;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxFloors;
        private System.Windows.Forms.Label labelMinFloors;
        private System.Windows.Forms.Label labelMaxFloors;
        private System.Windows.Forms.ListView listViewApartment;
        private System.Windows.Forms.ListView listViewHome;
        private System.Windows.Forms.ListView listViewLand;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}