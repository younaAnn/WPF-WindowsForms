﻿
namespace DBCommand
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.button4 = new System.Windows.Forms.Button();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.button5 = new System.Windows.Forms.Button();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.button6 = new System.Windows.Forms.Button();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.OrdYearTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-I6RMQON\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Secur" +
    "ity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT        CustomerID, CompanyName\r\nFROM            Customers";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запрос данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(31, 31);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(406, 300);
            this.ResultsTextBox.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Пакетный запрос";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Вызов процедуры";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "Ten Most Expensive Products";
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConnection1;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(489, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Создание таблицы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.Connection = this.sqlConnection1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(489, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Запрос с параметром";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(489, 86);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(136, 20);
            this.CityTextBox.TabIndex = 6;
            this.CityTextBox.Text = "London";
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "SELECT CustomerID, CompanyName, City FROM Customers WHERE City = @City";
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City")});
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(489, 223);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 37);
            this.button6.TabIndex = 7;
            this.button6.Text = "Процедура с параметром";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(489, 170);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.CategoryNameTextBox.TabIndex = 8;
            this.CategoryNameTextBox.Text = "Beverages";
            // 
            // OrdYearTextBox
            // 
            this.OrdYearTextBox.Location = new System.Drawing.Point(489, 197);
            this.OrdYearTextBox.Name = "OrdYearTextBox";
            this.OrdYearTextBox.Size = new System.Drawing.Size(136, 20);
            this.OrdYearTextBox.TabIndex = 9;
            this.OrdYearTextBox.Text = "1997";
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SalesByCategory";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NVarChar, 4)});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.OrdYearTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.Button button4;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox OrdYearTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
    }
}

