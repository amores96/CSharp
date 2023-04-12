using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WF_Test_1 {
  public partial class FORM_Ventana : Form {

    private string textoTitulo = "";
    public string TextoTitulo {
      get => TextoTitulo;
      set {
        TextoTitulo = value;
        this.Text = TextoTitulo;
      }
    }
    private string textoVentana = "";
    public string TextoVentana { get => textoVentana;
      set {
        textoVentana = value;
        LBL_Texto_FormVentana.Text = textoVentana;
      } 
    }
    private string textoVentanaMain = "";
    public string TextoVentanaMain { get => textoVentanaMain; }

    private bool activarEnviarMensaje = false;
    public bool ActivarEnviarMensaje { set => activarEnviarMensaje = value; }



    public FORM_Ventana() {
      InitializeComponent();
      // Codigo siempre despues de InitializeComponent().

    }

    private void FORM_Ventana_Load(object sender, EventArgs e) {
      if (activarEnviarMensaje) {
        LBL_FORMMain_Texto.Visible = true;
        TXT_FORMMAin_Texto.Visible = true;

        BTN_FORM2_Enviar.Visible = true;
        BTN_FORM2_Cancelar.Visible = true;
      }
      else {
        LBL_FORMMain_Texto.Visible = false;
        TXT_FORMMAin_Texto.Visible = false;

        BTN_FORM2_Enviar.Visible = false;
        BTN_FORM2_Cancelar.Visible = false;
      }
    }

    private void BTN_FORM2_Cancelar_Click(object sender, EventArgs e) {

      this.Close();
    }

    private void BTN_FORM2_Enviar_Click(object sender, EventArgs e) {

      textoVentanaMain = TXT_FORMMAin_Texto.Text;

      this.Close();
    }
  }
}
