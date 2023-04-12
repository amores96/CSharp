using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;    // 

namespace WF_Test_1 {
  public partial class FORM_Main : Form {
    
    #region FORM MAIN
    public FORM_Main() {
      InitializeComponent();
      // Codigo siempre despues de InitializeComponent().


    }

    private void FORM_Main_Load(object sender, EventArgs e) {
      LBL_Saludo.Visible = false;
      LBL_SaludoNombre.Visible = false;

      LBL_Precio.Text = "0 €";

      NUD_IMGL_IndexSelection.Maximum = (IMGL_Prueba.Images.Count-1);
      LBL_IMGL_ImageListLabel.Image = IMGL_Prueba.Images[0];
      PCT_IMGL_ImageListPictureBox.Image = IMGL_Prueba.Images[0];
    }

    private void FORM_Main_FormClosing(object sender, FormClosingEventArgs e) {
      TMR_Prueba.Enabled = false;   
      TMR_ProgressBar.Stop();     // TMR_ProgressBar.Stop() = TMR_ProgressBar.Enabled = false
    }

    private void BTN_Cerrar_Click(object sender, EventArgs e) {
      this.Close();
    }
    #endregion

    #region BOTON y LABEL
    private void BTN_Saludo_Click(object sender, EventArgs e) {
      LBL_Saludo.Text = "Hola a todos.";
      LBL_Saludo.Visible = true;
      LBL_Calculadora_Resultado.Text = "";

      SST_LBL_EstadoInformacion.Text = "Saludo realizado.";
    }

    private void BTN_Despedida_Click(object sender, EventArgs e) {
      LBL_Saludo.Text = "Adios a todos!";
      LBL_Saludo.Visible = true;

      SST_LBL_EstadoInformacion.Text = "Despedida realizada.";
    }
    #endregion

    #region TEXT BOX
    private void BTN_SaludoNombre_Click(object sender, EventArgs e) {
      if(TXT_Nombre.Text != "") {
        LBL_SaludoNombre.Text = "Hola " + TXT_Nombre.Text;
        LBL_SaludoNombre.Visible = true;

        SST_LBL_EstadoInformacion.Text = "Saludo con nombre realizado.";
      }
    }
    #endregion

    #region CHECK BOX
    private void CHK_Precio1_CheckedChanged(object sender, EventArgs e) {
      double precioTotal = 0;

      if (CHK_Precio1.Checked) {
        precioTotal += 50;
      }
      if (CHK_Precio2.Checked) {
        precioTotal += 100;
      }
      if (CHK_Precio3.Checked) {
        precioTotal += 150;
      }

      LBL_Precio.Text = precioTotal.ToString() + " €.";

      SST_LBL_EstadoInformacion.Text = "Precio actualizado.";
    }

    private void CHK_Precio2_CheckedChanged(object sender, EventArgs e) {
      double precioTotal = 0;

      if (CHK_Precio1.Checked) {
        precioTotal += 50;
      }
      if (CHK_Precio2.Checked) {
        precioTotal += 100;
      }
      if (CHK_Precio3.Checked) {
        precioTotal += 150;
      }

      LBL_Precio.Text = precioTotal.ToString() + " €.";

      SST_LBL_EstadoInformacion.Text = "Precio actualizado.";
    }

    private void CHK_Precio3_CheckedChanged(object sender, EventArgs e) {
      double precioTotal = 0;

      if (CHK_Precio1.Checked) {
        precioTotal += 50;
      }
      if (CHK_Precio2.Checked) {
        precioTotal += 100;
      }
      if (CHK_Precio3.Checked) {
        precioTotal += 150;
      }

      LBL_Precio.Text = precioTotal.ToString() + " €.";

      SST_LBL_EstadoInformacion.Text = "Precio actualizado.";
    }

    private void BTN_MensajePrecio_Click(object sender, EventArgs e) {
      double precioTotal = 0;

      if (CHK_Precio1.Checked) {
        precioTotal += 50;
      }
      if (CHK_Precio2.Checked) {
        precioTotal += 100;
      }
      if (CHK_Precio3.Checked) {
        precioTotal += 150;
      }

      SST_LBL_EstadoInformacion.Text = "Mensaje con precio actualizado.";

      MessageBox.Show((precioTotal.ToString() + " €."), "Precio total.", MessageBoxButtons.OK);

      SST_LBL_EstadoInformacion.Text = "Mensaje con precio actualizado cerrado.";
    }
    #endregion

    #region RADIO BUTTON
    private void BTN_Calculadora_Calcular_Click(object sender, EventArgs e) {

      if (MNU_CalculadoraHabilitar.Checked) {
        double auxCalculadoraResultado = 0.0;

        if (RBTN_Calculadora_Suma.Checked) {
          auxCalculadoraResultado = Convert.ToDouble(TXT_Calculadora_A.Text) + Convert.ToDouble(TXT_Calculadora_B.Text);
        }
        if (RBTN_Calculadora_Resta.Checked) {
          auxCalculadoraResultado = Convert.ToDouble(TXT_Calculadora_A.Text) - Convert.ToDouble(TXT_Calculadora_B.Text);
        }
        if (RBTN_Calculadora_Multiplicar.Checked) {
          auxCalculadoraResultado = Convert.ToDouble(TXT_Calculadora_A.Text) * Convert.ToDouble(TXT_Calculadora_B.Text);
        }
        if (RBTN_Calculadora_Dividir.Checked) {
          auxCalculadoraResultado = Convert.ToDouble(TXT_Calculadora_A.Text) / Convert.ToDouble(TXT_Calculadora_B.Text);
        }

        LBL_Calculadora_Resultado.Text = auxCalculadoraResultado.ToString();

        SST_LBL_EstadoInformacion.Text = "Calculo realizado.";
      }
    }

    private void RBTN_Calculadora_Suma_CheckedChanged(object sender, EventArgs e) {

      if (MNU_CalculadoraHabilitar.Checked) {
        double auxCalculadoraResultado = 0.0;

        auxCalculadoraResultado = Convert.ToDouble(TXT_Calculadora_A.Text) + Convert.ToDouble(TXT_Calculadora_B.Text);

        LBL_Calculadora_Resultado.Text = auxCalculadoraResultado.ToString();

        SST_LBL_EstadoInformacion.Text = "Calculo suma realizado.";
      }

    }

    private void RBTN_Calculadora_Resta_CheckedChanged(object sender, EventArgs e) {

      if (MNU_CalculadoraHabilitar.Checked) {
        double auxCalculadoraResultado = 0.0;

        auxCalculadoraResultado = Convert.ToDouble(TXT_Calculadora_A.Text) - Convert.ToDouble(TXT_Calculadora_B.Text);

        LBL_Calculadora_Resultado.Text = auxCalculadoraResultado.ToString();

        SST_LBL_EstadoInformacion.Text = "Calculo resta realizado.";
      }

    }

    private void RBTN_Calculadora_Multiplicar_CheckedChanged(object sender, EventArgs e) {

      if (MNU_CalculadoraHabilitar.Checked) {
        double auxCalculadoraResultado = 0.0;

        auxCalculadoraResultado = Convert.ToDouble(TXT_Calculadora_A.Text) * Convert.ToDouble(TXT_Calculadora_B.Text);

        LBL_Calculadora_Resultado.Text = auxCalculadoraResultado.ToString();

        SST_LBL_EstadoInformacion.Text = "Calculo multiplicacion realizado.";
      }

    }

    private void RBTN_Calculadora_Dividir_CheckedChanged(object sender, EventArgs e) {

      if (MNU_CalculadoraHabilitar.Checked) {
        double auxCalculadoraResultado = 0.0;

        auxCalculadoraResultado = Convert.ToDouble(TXT_Calculadora_A.Text) / Convert.ToDouble(TXT_Calculadora_B.Text);

        LBL_Calculadora_Resultado.Text = auxCalculadoraResultado.ToString();

        SST_LBL_EstadoInformacion.Text = "Calculo division realizado.";
      }

    }
    #endregion

    #region MESSAGE BOX
    private void BTN_MostrarMessageBox_Click(object sender, EventArgs e) {

      SST_LBL_EstadoInformacion.Text = "Mostrando message box.";

      // DialogResult = Es una propiedad que se utiliza para ver que boton ha sido pulsado al cerrar el messageBox.
      DialogResult resultadoBoton = MessageBox.Show("Texto del mensaje.", "Titulo.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

      if (resultadoBoton == DialogResult.Yes) LBL_EleccionMessageBox.Text = "Eleccion SI.";
      if (resultadoBoton == DialogResult.No) LBL_EleccionMessageBox.Text = "Eleccion NO.";
      if (resultadoBoton == DialogResult.Cancel) LBL_EleccionMessageBox.Text = "Eleccion CANCEL.";

      SST_LBL_EstadoInformacion.Text = "Message box cerrado.";

    }
    #endregion

    #region FORM VENTANA
    // Instanciamos la FORMA_Ventana.
    FORM_Ventana formVentana;

    private void BTN_FORMVentana_Abrir_Click(object sender, EventArgs e) {

      if (formVentana == null || !formVentana.Visible) {    // Comprobamos que la ventana no esta abierta.

        formVentana = new FORM_Ventana();   // Instanciamos la nueva ventana.

        formVentana.Text = TXT_VentanaTitulo.Text;
        formVentana.TextoVentana = TXT_VentanaTexto.Text;

        formVentana.ActivarEnviarMensaje = false;

        formVentana.Show();       // Muestra el form ventana y detiene la ejecucion hasta que cerramos la ventana formVentana.

        SST_LBL_EstadoInformacion.Text = "Ventana abierta.";

      }

    }

    private void BTN_FORMVentana_Modificar_Click(object sender, EventArgs e) {

      if (formVentana != null && formVentana.Visible) {

        formVentana.Text = TXT_VentanaTitulo.Text;
        formVentana.TextoVentana = TXT_VentanaTexto.Text;

        SST_LBL_EstadoInformacion.Text = "Ventana modificada.";
      }

    }

    private void BTN_FORMVentana_Abrir_2_Click(object sender, EventArgs e) {

      if (formVentana == null || !formVentana.Visible) {    // Comprobamos que la ventana no esta abierta.

        formVentana = new FORM_Ventana();   // Instanciamos la nueva ventana.

        SST_LBL_EstadoInformacion.Text = "Ventana con mensaje a devolver abierta.";

        formVentana.Text = "Ventana para devolver texto a main.";
        formVentana.TextoVentana = "Escribe texto y pulse enviar.";

        formVentana.ActivarEnviarMensaje = true;

        // Muestra el form ventana y detiene la ejecucion hasta que cerramos la ventana formVentana.
        // Guardamos el resultado en la variable resultadoVentana al cerrar la ventana.
        DialogResult resultadoVentana = formVentana.ShowDialog();

        // Vermos que acciones se han realizado en formVentana para mostrar un mensaje u otro en la ventana main.
        if (resultadoVentana == DialogResult.OK) LBL_FORM2_Texto.Text = formVentana.TextoVentanaMain;
        else if (resultadoVentana == DialogResult.Abort) LBL_FORM2_Texto.Text = "Cancelado el envio.";
        else LBL_FORM2_Texto.Text = "Ventana cerrada.";

        SST_LBL_EstadoInformacion.Text = "Ventana con mensaje a devolver cerrada.";
      }
    }
    #endregion

    #region MENU STRIP
    private void MNU_AyudaAcercaDe_Click(object sender, EventArgs e) {
      MessageBox.Show("Esta es la ayuda de la aplicacion.", "Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Information);

      SST_LBL_EstadoInformacion.Text = "Ayuda mostrada.";
    }

    private void MNU_CalculadoraHabilitar_CheckedChanged(object sender, EventArgs e) {
      GBOX_RadioButton.Enabled = MNU_CalculadoraHabilitar.Checked;

      if (MNU_CalculadoraHabilitar.Checked) SST_LBL_EstadoInformacion.Text = "Calculadora habilitada.";
      else SST_LBL_EstadoInformacion.Text = "Calculadora deshabilitada.";
    }
    #endregion

    #region MENU CONTEXTUAL
    private void escribirHolaToolStripMenuItem_Click(object sender, EventArgs e) {
      LBL_MenuContextual.Text = "Hola";

      SST_LBL_EstadoInformacion.Text = "Menu contextual. Mensaje cambiado.";
    }

    private void restaurarToolStripMenuItem_Click(object sender, EventArgs e) {
      LBL_MenuContextual.Text = "Haz boton derecho aquí.";

      SST_LBL_EstadoInformacion.Text = "Menu contextual. Mensaje restaurado.";
    }
    #endregion

    #region TIMER
    private int conteoTimerPrueba = 0;

    private void TMR_Prueba_Tick(object sender, EventArgs e) {

      conteoTimerPrueba += 1;

      SST_LBL_EstadoTimer.Text = "Tiempo = " + conteoTimerPrueba.ToString();

      if (conteoTimerPrueba >= 100) conteoTimerPrueba = 0;
      
    }

    private void BTN_TimerIniciar_Click(object sender, EventArgs e) {

      if (!TMR_Prueba.Enabled) {
        SST_LBL_EstadoTimer.Text = "Tiempo = 0";
        TMR_Prueba.Enabled = true;
        // TMR_Prueba.Start();    // TMR_Prueba.Start() == TMR_Prueba.Enabled = true
        BTN_TimerIniciar.Text = "Detener Timer";

        SST_LBL_EstadoInformacion.Text = "Timer contador 1 iniciado.";
      }
      else {
        conteoTimerPrueba = 0;
        TMR_Prueba.Enabled = false;
        // TMR_Prueba.Stop();    // TMR_Prueba.Stop() = TMR_Prueba.Enabled = false
        BTN_TimerIniciar.Text = "Iniciar Timer";

        SST_LBL_EstadoInformacion.Text = "Timer contador 1 detenido.";
      }

    }
    #endregion

    #region TRACK BAR
    private void TBAR_Prueba_ValueChanged(object sender, EventArgs e) {
      LBL_TrackBar_Valor.Text = "Valor = " + TBAR_Prueba.Value.ToString();

      SST_LBL_EstadoInformacion.Text = "Track Bar modificado.";
    }

    private void BTN_TrackBar_Minimo_Click(object sender, EventArgs e) {
      TBAR_Prueba.Value = TBAR_Prueba.Minimum;

      SST_LBL_EstadoInformacion.Text = "Track Bar movido a posicion minima.";
    }

    private void BTN_TrackBar_Maximo_Click(object sender, EventArgs e) {
      TBAR_Prueba.Value = TBAR_Prueba.Maximum;

      SST_LBL_EstadoInformacion.Text = "Track Bar movido a posicion maxima.";
    }
    #endregion

    #region PROGRESS BAR
    private void BTN_PGBAR_Timer_Click(object sender, EventArgs e) {

      if (!TMR_ProgressBar.Enabled) {
        TMR_ProgressBar.Start();    // TMR_Prueba.Start() == TMR_Prueba.Enabled = true
        BTN_PGBAR_Timer.Text = "Detener.";
        SST_PGBAR_Prueba.Value = 0;

        BTN_PGBAR_Posicion25.Enabled = false;
        BTN_PGBAR_Posicion50.Enabled = false;
        BTN_PGBAR_Posicion75.Enabled = false;
        BTN_PGBAR_Posicion100.Enabled = false;

        SST_LBL_EstadoInformacion.Text = "Progress Bar iniciada con timer.";

      } else {
        TMR_ProgressBar.Stop();    // TMR_Prueba.Stop() = TMR_Prueba.Enabled = false
        BTN_PGBAR_Timer.Text = "Iniciar con timer.";

        BTN_PGBAR_Posicion25.Enabled = true;
        BTN_PGBAR_Posicion50.Enabled = true;
        BTN_PGBAR_Posicion75.Enabled = true;
        BTN_PGBAR_Posicion100.Enabled = true;

        SST_LBL_EstadoInformacion.Text = "Progress Bar detenida.";

      }
    }

    private void TMR_ProgressBar_Tick(object sender, EventArgs e) {

      if (SST_PGBAR_Prueba.Value < 100) SST_PGBAR_Prueba.PerformStep();   // Para incrementar la barra en funcion del valor de la propiedad step.

      if (SST_PGBAR_Prueba.Value >= 100) {
        SST_PGBAR_Prueba.Value = 0;
      }

    }

    private void BTN_PGBAR_Posicion25_Click(object sender, EventArgs e) {
      if (!TMR_ProgressBar.Enabled) SST_PGBAR_Prueba.Value = 25;

      SST_LBL_EstadoInformacion.Text = "Progress Bar movida al 25%.";
    }

    private void BTN_PGBAR_Posicion50_Click(object sender, EventArgs e) {
      if (!TMR_ProgressBar.Enabled) SST_PGBAR_Prueba.Value = 50;

      SST_LBL_EstadoInformacion.Text = "Progress Bar movida al 50%.";
    }

    private void BTN_PGBAR_Posicion75_Click(object sender, EventArgs e) {
      if (!TMR_ProgressBar.Enabled) SST_PGBAR_Prueba.Value = 75;

      SST_LBL_EstadoInformacion.Text = "Progress Bar movida al 75%.";
    }

    private void BTN_PGBAR_Posicion100_Click(object sender, EventArgs e) {
      if (!TMR_ProgressBar.Enabled) SST_PGBAR_Prueba.Value = 100;

      SST_LBL_EstadoInformacion.Text = "Progress Bar movida al 100%.";
    }
    #endregion

    #region CHECKED LIST BOX
    private void CHKL_Prueba_SelectedIndexChanged(object sender, EventArgs e) {

      int indiceSeleccion = CHKL_Prueba.SelectedIndex;

      if (indiceSeleccion > 0) {
        if (CHKL_Prueba.GetItemChecked(CHKL_Prueba.Items.Count - 1)) {
          LBL_CHKL_Seleccion.Text = "Ultimo elemento seleccionado.";
        } else {
          LBL_CHKL_Seleccion.Text = ((indiceSeleccion + 1).ToString()) + " / " + CHKL_Prueba.Items.Count + " = " + CHKL_Prueba.Items[indiceSeleccion].ToString();
        }
      }
    }

    private void BTN_NuevoCrear_Click(object sender, EventArgs e) {
      CHKL_Prueba.Items.Add(TXT_NuevoNombre.Text, CHK_NuevoEstado.Checked);

      LBL_CHKL_Seleccion.Text = "Nuevo: " + CHKL_Prueba.Items[CHKL_Prueba.Items.Count-1].ToString();
    }

    private void BTN_CHKL_EliminarSeleccion_Click(object sender, EventArgs e) {
      CHKL_Prueba.Items.Remove(CHKL_Prueba.Items[CHKL_Prueba.SelectedIndex]);
    }
    #endregion

    #region COMBO BOX
    private void CMB_Prueba_SelectedIndexChanged(object sender, EventArgs e) {
      if (CMB_Prueba.SelectedIndex == (CMB_Prueba.Items.Count - 1)) {
        LBL_CMB_Seleccion.Text = "Ultimo elemento seleccionado.";
      } else {
        int indiceSeleccion = CMB_Prueba.SelectedIndex;
        LBL_CMB_Seleccion.Text = ((indiceSeleccion + 1).ToString()) + " / " + CMB_Prueba.Items.Count + " = " + CMB_Prueba.Items[indiceSeleccion].ToString();
      }
    }

    private void BTN_CMB_NuevoCrear_Click(object sender, EventArgs e) {
      CMB_Prueba.Items.Add(TXT_CMB_NuevoNombre.Text);

      LBL_CMB_Seleccion.Text = "Nuevo: " + CMB_Prueba.Items[CMB_Prueba.Items.Count - 1].ToString();
    }

    private void BTN_CMB_EliminarSeleccion_Click(object sender, EventArgs e) {
      CMB_Prueba.Items.Remove(CMB_Prueba.Items[CMB_Prueba.SelectedIndex]);
    }
    #endregion

    #region DATA GRID VIEW
    private int dgv_indiceSeleccion = 0;

    private void BTN_DGV_Añadir_Click(object sender, EventArgs e) {

      // Añadir una fila nueva vacia y guardar el numero de indice.
      int indiceNuevo = DGV_Prueba.Rows.Add();

      // Crear filas nuevas con los valores de cada columna.
      DGV_Prueba.Rows[indiceNuevo].Cells[0].Value = TXT_DGV_Nombre.Text;
      DGV_Prueba.Rows[indiceNuevo].Cells[1].Value = TXT_DGV_Apellido.Text;
      DGV_Prueba.Rows[indiceNuevo].Cells[2].Value = TXT_DGV_Edad.Text;

      // Borrar etiquetas.
      TXT_DGV_Nombre.Text = "";
      TXT_DGV_Apellido.Text = "";
      TXT_DGV_Edad.Text = "";


    }

    private void DGV_Prueba_CellClick(object sender, DataGridViewCellEventArgs e) {

      // Leemos el idnice de la fila seleccionada que genera el evento de este handler.
      dgv_indiceSeleccion = e.RowIndex;

      LBL_DGV_Seleccion.Text = "Seleccion: " + (string)DGV_Prueba.Rows[dgv_indiceSeleccion].Cells[0].Value + " " + DGV_Prueba.Rows[dgv_indiceSeleccion].Cells[1].Value + " " + DGV_Prueba.Rows[dgv_indiceSeleccion].Cells[2].Value + ".";

    }

    private void button1BTN_DGV_Eliminar_Click(object sender, EventArgs e) {

      if (dgv_indiceSeleccion >= 0) {
        DGV_Prueba.Rows.RemoveAt(dgv_indiceSeleccion);
      }
    }
    #endregion

    #region DOMAIN UP DOWN
    private int dud_indiceSeleccion = 0;

    private void DUD_Prueba_SelectedItemChanged(object sender, EventArgs e) {
      dud_indiceSeleccion = DUD_Prueba.SelectedIndex;

      if (dud_indiceSeleccion >= 0) LBL_DUD_Seleccion.Text = "Seleccion: " + (string)DUD_Prueba.Items[dud_indiceSeleccion];

    }

    private void BTN_DUD_Nuevo_Click(object sender, EventArgs e) {
      DUD_Prueba.Items.Add(TXT_DUD_Nombre.Text);

      DUD_Prueba.SelectedIndex = DUD_Prueba.Items.Count - 1;
    }

    private void BTN_DUD_Eliminar_Click(object sender, EventArgs e) {

      
      if (dud_indiceSeleccion  > 0 && dud_indiceSeleccion < (DUD_Prueba.Items.Count-1)) {
          DUD_Prueba.Items.RemoveAt(dud_indiceSeleccion);

          DUD_Prueba.SelectedIndex = dud_indiceSeleccion;
      }
      else if (dud_indiceSeleccion > 0 && dud_indiceSeleccion >= (DUD_Prueba.Items.Count - 1)) {
        DUD_Prueba.Items.RemoveAt(dud_indiceSeleccion);

        DUD_Prueba.SelectedIndex = DUD_Prueba.Items.Count-1;
      }
      
    }
    #endregion

    #region LIST BOX
    private int lstb_indiceSeleccion = 0;

    private void LSTB_Prueba_SelectedIndexChanged(object sender, EventArgs e) {

      lstb_indiceSeleccion = LSTB_Prueba.SelectedIndex;

      if (lstb_indiceSeleccion >= 0) LBL_LSTB_Seleccion.Text = "Seleccion: " + (string)LSTB_Prueba.Items[lstb_indiceSeleccion];

    }

    private void BTN_LSTB_Nuevo_Click(object sender, EventArgs e) {
      LSTB_Prueba.Items.Add(TXT_LSTB_NuevoNombre.Text);

    }

    private void BTN_LSTB_Eliminar_Click(object sender, EventArgs e) {
      if (lstb_indiceSeleccion > 0 && lstb_indiceSeleccion < (LSTB_Prueba.Items.Count - 1)) {
        LSTB_Prueba.Items.RemoveAt(lstb_indiceSeleccion);

        LSTB_Prueba.SelectedIndex = lstb_indiceSeleccion;
      } else if (lstb_indiceSeleccion > 0 && lstb_indiceSeleccion >= (LSTB_Prueba.Items.Count - 1)) {
        LSTB_Prueba.Items.RemoveAt(lstb_indiceSeleccion);

      }
    }
    #endregion

    #region PICTURE BOX
    private void BTN_PCTB_Cargar_Click(object sender, EventArgs e) {
      Image img = Image.FromFile(TXT_PCT_Path.Text);

      PCT_Prueba.Image = img;

      PCT_Prueba.SizeMode = PictureBoxSizeMode.Zoom;
    }
    #endregion

    #region IMAGE LIST
    private void NUD_IMGL_IndexSelection_ValueChanged(object sender, EventArgs e) {
      LBL_IMGL_ImageListLabel.Image = IMGL_Prueba.Images[(int)NUD_IMGL_IndexSelection.Value];
      PCT_IMGL_ImageListPictureBox.Image = IMGL_Prueba.Images[(int)NUD_IMGL_IndexSelection.Value];
    }
    #endregion

    #region LIST VIEW 
    // Creamos los grupos.
    ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Left);
    ListViewGroup carnes = new ListViewGroup("Carnes", HorizontalAlignment.Left);

    private void BTN_LSTV_Cargar_Click(object sender, EventArgs e) {

      // Añadimos elementos a los grupos. 
      // Se puede hacer de 2 formas:
      // Forma 1: Con una variable de tipo ListViewItem.
      ListViewItem elementoAñadir;

      elementoAñadir = new ListViewItem("Naranja", frutas);
      LSTV_Prueba.Items.Add(elementoAñadir);

      elementoAñadir = new ListViewItem("Mandarina", frutas);
      LSTV_Prueba.Items.Add(elementoAñadir);

      elementoAñadir = new ListViewItem("Limon", frutas);
      LSTV_Prueba.Items.Add(elementoAñadir);

      elementoAñadir = new ListViewItem("Manzana", frutas);
      LSTV_Prueba.Items.Add(elementoAñadir);

      elementoAñadir = new ListViewItem("Pera", frutas);
      LSTV_Prueba.Items.Add(elementoAñadir);

      // Forma 2: Directamente en el metodo Add.
      LSTV_Prueba.Items.Add(new ListViewItem("Pechuga", carnes));
      LSTV_Prueba.Items.Add(new ListViewItem("Hamburguesa", carnes));
      LSTV_Prueba.Items.Add(new ListViewItem("Longanizas", carnes));
      LSTV_Prueba.Items.Add(new ListViewItem("Ternera", carnes));
      LSTV_Prueba.Items.Add(new ListViewItem("Lomo", carnes));


      // Añadimos los grupos actualizados a la lista.
      LSTV_Prueba.Groups.Add(frutas);
      LSTV_Prueba.Groups.Add(carnes);

    }

    private void BTN_LSTV_NuevoCrear_Click(object sender, EventArgs e) {

      if(LSTV_Prueba.Groups.Count > 0) {
        ListViewItem elementoAñadir;

        if (RBTN_NuevoGrupo_Frutas.Checked == true) {
          elementoAñadir = new ListViewItem(TXT_LSTV_NuevoNombre.Text, frutas);
          LSTV_Prueba.Items.Add(elementoAñadir);
        } else if (RBTN_NuevoGrupo_Carnes.Checked == true) {
          elementoAñadir = new ListViewItem(TXT_LSTV_NuevoNombre.Text, carnes);
          LSTV_Prueba.Items.Add(elementoAñadir);
        }
      }

    }

    private void BTN_LSTV_Eliminar_Click(object sender, EventArgs e) {
      
      LSTV_Prueba.Groups.Remove(frutas);
      LSTV_Prueba.Groups.Remove(carnes);

      LSTV_Prueba.Clear();

    }
    #endregion

    #region LIST VIEW with IMAGE LIST
    // Inicializamos el List View
    ListViewGroup operacionesSimples = new ListViewGroup("Operaciones Simples", HorizontalAlignment.Left);
    ListViewGroup operacionesComplejas = new ListViewGroup("Operaciones Complejas", HorizontalAlignment.Left);

    private void BTN_LSTV_IMGL_Cargar_Click(object sender, EventArgs e) {

      // Creamos un imageList
      ImageList imgLista = new ImageList();
      // Cambiamos las propiedades del imageList
      imgLista.ImageSize = new Size(100, 100);

      // Obtener listado de imagenes.
      string[] pathsArchivos = Directory.GetFiles("imagenes");

      // Cargar todas las imagenes
      try {
        foreach (string archivo in pathsArchivos) {
          imgLista.Images.Add(Image.FromFile(archivo));
        }
      }
      catch {
        MessageBox.Show("Error al cargar las imagenes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      // Asignamos el imageList al List View.
      LSTV_ImageList.SmallImageList = imgLista;

      // Añadimos elementos pero con un indice, que va a ser el orden de las imagenes cargadas.
      LSTV_ImageList.Items.Add(new ListViewItem("Suma", 0, operacionesSimples));
      LSTV_ImageList.Items.Add(new ListViewItem("Resta", 1, operacionesSimples));
      LSTV_ImageList.Items.Add(new ListViewItem("Multiplicacion", 0, operacionesComplejas));
      LSTV_ImageList.Items.Add(new ListViewItem("Division", 1, operacionesComplejas));

      // Añadimos los grupos actualizados a la lista.
      LSTV_ImageList.Groups.Add(operacionesSimples);
      LSTV_ImageList.Groups.Add(operacionesComplejas);

    }

    private void LSTV_ImageList_MouseClick(object sender, MouseEventArgs e) {

      // Leemos el nombre del elemento seleccionado.
      LBL_LSTV_IMGL_Seleccion.Text = "Seleccion: " + LSTV_ImageList.SelectedItems[0].Text;

    }

    private void BTN_LSTV_IMGL_Eliminar_Click(object sender, EventArgs e) {
      LSTV_ImageList.Items.Clear();
      LBL_LSTV_IMGL_Seleccion.Text = "";
    }

    private void BTN_LSTV_IMGL_SeleccionModificar_Click(object sender, EventArgs e) {

      // Modificamos el nombre del elemento que tenemos seleccionado.
      LSTV_ImageList.SelectedItems[0].SubItems[0].Text = TXT_LSTV_IMGL_ModificarNombre.Text;

      // Modificamos el indice del elemento que esta referenciado a la imagen asociada. Al cambiar el indice, cambiara la imagen asociada a este elemento.
      LSTV_ImageList.SelectedItems[0].ImageIndex = (int)NUD_LSTV_IMGL_ModificarIndice.Value;


    }

    private void BTN_LSTV_IMGL_SeleccionEliminar_Click(object sender, EventArgs e) {

      // Eliminamos el elemento seleccionado. 
      LSTV_ImageList.Items.RemoveAt(LSTV_ImageList.SelectedIndices[0]);
    }

    #endregion

    #region COLOR DIALOG
    private void BTN_CLD_SeleccionarColor_Click(object sender, EventArgs e) {

      // Agregamos el color por defecto al dialogo de seleccion de color CLD_Prueba.
      CLD_Prueba.Color = Color.FromArgb(94, 94, 94);

      // Mostramos el dialogo para seleccionar el color y realizamos una accion en funcion del boton del dialogo.
      if (CLD_Prueba.ShowDialog() == DialogResult.OK) {
        LBL_CLD_SeleccionColor.BackColor = CLD_Prueba.Color;
      }
    }
    #endregion

    #region DATE TIME
    private void BTN_DTT_Actualizar_Click(object sender, EventArgs e) {
      DateTime fecha = DateTime.Today;

      string formato = "MMM ddd d, yyyy. HH:mm:ss";
      LBL_DTT_Fecha.Text = fecha.ToString(formato);
    }
    #endregion

    #region DATE TIME PICKER
    private void DTP_Prueba_ValueChanged(object sender, EventArgs e) {

      // Leemos el valor de fecha del DateTimePicker
      DateTime fecha = DTP_Prueba.Value;

      string formato = "MMM ddd d, yyyy. HH:mm:ss";
      LBL_DTP_Seleccion.Text = fecha.ToString(formato);
    }

    private void BTN_DTP_DiasCalcular_Click(object sender, EventArgs e) {

      DateTime fechaCalculada = DateTime.Today.AddDays((int)NUP_DTP_Dias.Value);

      DTP_Prueba.Value = fechaCalculada;

      string formato = "MMM ddd d, yyyy. HH:mm:ss";
      LBL_DTP_Seleccion.Text = fechaCalculada.ToString(formato);
    }
    #endregion

    #region ERROR PROVIDER
    private void TXT_ERRP_Nombre_TextChanged(object sender, EventArgs e) {
      bool error = false;

      // Revisamos si en el string del nombre hay algun numero.
      foreach (char caracter in TXT_ERRP_Nombre.Text) {
        if (char.IsDigit(caracter)) {
          error = true;
          break;
        }
      }

      // Ejecutamos el error en el textBox TXT_ERRP_Nombre.
      if (error) {
        ERRP_Prueba.SetError(TXT_ERRP_Nombre, "No se admiten numeros en el nombre.");
      } else {
        ERRP_Prueba.Clear();
      }
    }

    #endregion

    #region FONT DIALOG
    private void BTN_FNTD_FuentePredeterminada_Click(object sender, EventArgs e) {
      Font fuente1 = new Font("Arial", 18, FontStyle.Bold | FontStyle.Italic);

      LBL_FNTD_Texto.Font = fuente1;
    }

    private void BTN_FNTP_FuenteSeleccionar_Click(object sender, EventArgs e) {

      if (FNTD_Prueba.ShowDialog() == DialogResult.OK) {
        LBL_FNTD_Texto.Font = FNTD_Prueba.Font;
      }
    }

    #endregion

    #region MASKED TEXT BOX
    private void BTN_MTB_TextoMostrar_Click(object sender, EventArgs e) {
      LBL_MTB_Numero.Text = MTXT_MTB_Numero.Text;
    }

    private void BTN_MTB_HoraMostrar_Click(object sender, EventArgs e) {
      LBL_MTB_Hora.Text = MTXT_MTB_Hora.Text;
    }

    private void MTXT_MTB_Numero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
      MessageBox.Show("Erro al introducir el numero de telefono.\nSolo se aceptan 9 caracteres de tipo numerico.", "Error dato.", MessageBoxButtons.OK);
    }

    private void MTXT_MTB_Hora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
      MessageBox.Show("Erro al introducir La hora.\nSolo se acepta en formato hora. \nEj: 22:35.", "Error dato.", MessageBoxButtons.OK);
    }
    #endregion

    #region PLANTILLA

    #endregion

    #region PLANTILLA

    #endregion


  }
}
