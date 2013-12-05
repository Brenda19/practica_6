/*
 * Created by SharpDevelop.
 * User: hp
 * Date: 01/11/2013
 * Time: 12:58 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace aaaa
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();		
			
		}
			void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		void DFCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
		}
		
		void DomainUpDown1SelectedItemChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int cor =0;
				if(this.DF.Checked){
				cor++;
			}
			
			if(this.Port.Checked){
			 
				cor++;
			}
			if(this.Macedonia.Checked){
                cor++;
            }

			if(this.RU.Checked){
               cor++;
                    }

				
			if (this.domainUpDown1.Text == "32"){
			cor++;
			}
			
		  DateTime f = cal.SelectionStart;
		  if(f.ToShortDateString()=="07/05/1945"){
		  	cor++;
		  }
		  	MessageBox.Show("Nombre: "+nom.Text+ " \nCodigo: "+cod.Text+
			   "\nCorrectas"+cor);
			

		}
	}
}