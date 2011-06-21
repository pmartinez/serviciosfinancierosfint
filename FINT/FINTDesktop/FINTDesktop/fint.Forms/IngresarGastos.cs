﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using fint.Forms.fint.controller;

namespace fint.Forms
{
    public partial class IngresarGastos : Form
    {
        public IngresarGastos()
        {
            InitializeComponent();
        }

        private void descLbl_Click(object sender, EventArgs e)
        {

        }

        private void montoTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void descTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void montoLbl_Click(object sender, EventArgs e)
        {

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {

            String nFac = this.nFacTxt.Text;
            String desc = this.descTxt.Text;
            String monto = this.montoTxt.Text;
            DateTime fVen = this.fVenDPicker.Value.Date;
            
            //Console.WriteLine(fVen.Date.ToString());
            //Console.WriteLine(fVen.ToString());

            if (!nFac.Equals("") && !desc.Equals("") && !monto.Equals(""))
            {

                if(Controller.agregarGasto(int.Parse(nFac),desc,double.Parse(monto),fVen)){
                    this.msgLbl.Text = "Gasto ingresado con exito.";
                }
                
                this.clear();
            }
            else
            {
                this.msgLbl.Text = "Todos los datos son requeridos.";
            }



        }


        private void clear()
        {
            this.nFacTxt.Text = "";
            this.descTxt.Text = "";
            this.montoTxt.Text = "";
            this.fVenDPicker.Value = DateTime.Today;
        }


    }
}
