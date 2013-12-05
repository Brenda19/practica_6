/*
 * Created by SharpDevelop.
 * User: hp
 * Date: 01/11/2013
 * Time: 12:58 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace aaaa
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nom = new System.Windows.Forms.TextBox();
			this.cod = new System.Windows.Forms.TextBox();
			this.Michoacan = new System.Windows.Forms.RadioButton();
			this.DF = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.RU = new System.Windows.Forms.CheckBox();
			this.Port = new System.Windows.Forms.CheckBox();
			this.Macedonia = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cal = new System.Windows.Forms.MonthCalendar();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(236, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Codigo";
			// 
			// nom
			// 
			this.nom.Location = new System.Drawing.Point(81, 16);
			this.nom.Name = "nom";
			this.nom.Size = new System.Drawing.Size(100, 20);
			this.nom.TabIndex = 2;
			this.nom.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// cod
			// 
			this.cod.Location = new System.Drawing.Point(337, 16);
			this.cod.Name = "cod";
			this.cod.Size = new System.Drawing.Size(100, 20);
			this.cod.TabIndex = 3;
			// 
			// Michoacan
			// 
			this.Michoacan.Location = new System.Drawing.Point(13, 99);
			this.Michoacan.Name = "Michoacan";
			this.Michoacan.Size = new System.Drawing.Size(87, 24);
			this.Michoacan.TabIndex = 5;
			this.Michoacan.TabStop = true;
			this.Michoacan.Text = "Michoacan";
			this.Michoacan.UseVisualStyleBackColor = true;
			// 
			// DF
			// 
			this.DF.Location = new System.Drawing.Point(106, 99);
			this.DF.Name = "DF";
			this.DF.Size = new System.Drawing.Size(63, 24);
			this.DF.TabIndex = 6;
			this.DF.TabStop = true;
			this.DF.Text = "DF";
			this.DF.UseVisualStyleBackColor = true;
			this.DF.CheckedChanged += new System.EventHandler(this.DFCheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(184, 99);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(89, 24);
			this.radioButton3.TabIndex = 7;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Guadalajara";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "1° ¿Cual es el estado de Mexico?";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(190, 30);
			this.label4.TabIndex = 8;
			this.label4.Text = "2° ¿Cualaes son las capitales de Europa?";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(13, 186);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 9;
			this.checkBox1.Text = "Australia";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// RU
			// 
			this.RU.Location = new System.Drawing.Point(13, 216);
			this.RU.Name = "RU";
			this.RU.Size = new System.Drawing.Size(104, 24);
			this.RU.TabIndex = 10;
			this.RU.Text = "Reino Unido";
			this.RU.UseVisualStyleBackColor = true;
			this.RU.CheckedChanged += new System.EventHandler(this.CheckBox2CheckedChanged);
			// 
			// Port
			// 
			this.Port.Location = new System.Drawing.Point(12, 246);
			this.Port.Name = "Port";
			this.Port.Size = new System.Drawing.Size(104, 24);
			this.Port.TabIndex = 11;
			this.Port.Text = "Portugal";
			this.Port.UseVisualStyleBackColor = true;
			
			// 
			// Macedonia
			// 
			this.Macedonia.Location = new System.Drawing.Point(12, 276);
			this.Macedonia.Name = "Macedonia";
			this.Macedonia.Size = new System.Drawing.Size(104, 24);
			this.Macedonia.TabIndex = 12;
			this.Macedonia.Text = "Masedonia";
			this.Macedonia.UseVisualStyleBackColor = true;
			
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 324);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(168, 35);
			this.label5.TabIndex = 13;
			this.label5.Text = "3° ¿Cuantos estados tiene Mexico?";
			// 
			// cal
			// 
			this.cal.Location = new System.Drawing.Point(337, 119);
			this.cal.Name = "cal";
			this.cal.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(337, 63);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(227, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "4° ¿En que fecha fue la guerra Mundial?";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(350, 324);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "Listo";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// domainUpDown1
			// 
			this.domainUpDown1.Location = new System.Drawing.Point(12, 363);
			this.domainUpDown1.Name = "domainUpDown1";
			this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
			this.domainUpDown1.TabIndex = 17;
			this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.DomainUpDown1SelectedItemChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 480);
			this.Controls.Add(this.domainUpDown1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Macedonia);
			this.Controls.Add(this.Port);
			this.Controls.Add(this.RU);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.DF);
			this.Controls.Add(this.Michoacan);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cod);
			this.Controls.Add(this.nom);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "aaaa";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.MonthCalendar cal;
		private System.Windows.Forms.TextBox nom;
		private System.Windows.Forms.TextBox cod;
		private System.Windows.Forms.CheckBox Port;
		private System.Windows.Forms.CheckBox Macedonia;
		private System.Windows.Forms.CheckBox RU;
		private System.Windows.Forms.DomainUpDown domainUpDown1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton DF;
		private System.Windows.Forms.RadioButton Michoacan;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		
	}
}
