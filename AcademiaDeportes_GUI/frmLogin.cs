﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Using...
using AcademiaDeportes_BE;
using AcademiaDeportes_BL;

namespace AcademiaDeportes_GUI
{
    public partial class frmLogin : Form
    {
        // Declaramos variableas de intentos y tiempo....
        Int16 intentos = 0;
        Int16 tiempo = 20;
        // Declaramos instancias para autenficacion de Usuarios....
        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();

        

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtLogin .Text.Trim() != "" & txtPassword.Text.Trim() != "")
             {
                // Codifique...
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtLogin.Text.Trim());

                if (objUsuarioBE.login_usuario == null)
                {
                    intentos += 1;
                    ValidaAccesos();

                    MessageBox.Show("Usuario no existe",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw new Exception("Usuario no existe");
                }
                else if(objUsuarioBE.login_usuario == txtLogin.Text.Trim() 
                    && objUsuarioBE.password_usuario == txtPassword.Text.Trim())
                {
                    //Acceso correcto
                    this.Hide();
                    timer1.Enabled = false;

                    //Guardamos las credenciales...

                    clsCredenciales.Usuario = objUsuarioBE.login_usuario;
                    clsCredenciales.Password = objUsuarioBE.password_usuario;
                    clsCredenciales.Nivel = objUsuarioBE.nivel_usuario;

                    //Cargamos el MDIPrincipal...
                    Principal objMDI = new Principal();

                    objMDI.ShowDialog();
                }


                else
                {
                    MessageBox.Show("Usuario o Password incorrectos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos();

                }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
               intentos +=1;
                ValidaAccesos();
            }
           
        }

        private void ValidaAccesos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            // Para al pulsar Enter acceder al MDI...
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();
            
            }
        }
    }
}
