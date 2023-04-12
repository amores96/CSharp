
namespace WF_Test_1 {
  partial class FORM_Ventana {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.LBL_Texto_FormVentana = new System.Windows.Forms.Label();
      this.BTN_FORM2_Cancelar = new System.Windows.Forms.Button();
      this.LBL_FORMMain_Texto = new System.Windows.Forms.Label();
      this.TXT_FORMMAin_Texto = new System.Windows.Forms.TextBox();
      this.BTN_FORM2_Enviar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // LBL_Texto_FormVentana
      // 
      this.LBL_Texto_FormVentana.AutoSize = true;
      this.LBL_Texto_FormVentana.Location = new System.Drawing.Point(13, 13);
      this.LBL_Texto_FormVentana.Name = "LBL_Texto_FormVentana";
      this.LBL_Texto_FormVentana.Size = new System.Drawing.Size(134, 13);
      this.LBL_Texto_FormVentana.TabIndex = 0;
      this.LBL_Texto_FormVentana.Text = "Texto ventana secundaria.";
      // 
      // BTN_FORM2_Cancelar
      // 
      this.BTN_FORM2_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Abort;
      this.BTN_FORM2_Cancelar.Location = new System.Drawing.Point(111, 104);
      this.BTN_FORM2_Cancelar.Name = "BTN_FORM2_Cancelar";
      this.BTN_FORM2_Cancelar.Size = new System.Drawing.Size(75, 23);
      this.BTN_FORM2_Cancelar.TabIndex = 1;
      this.BTN_FORM2_Cancelar.Text = "Cancelar";
      this.BTN_FORM2_Cancelar.UseVisualStyleBackColor = true;
      this.BTN_FORM2_Cancelar.Click += new System.EventHandler(this.BTN_FORM2_Cancelar_Click);
      // 
      // LBL_FORMMain_Texto
      // 
      this.LBL_FORMMain_Texto.AutoSize = true;
      this.LBL_FORMMain_Texto.Location = new System.Drawing.Point(13, 61);
      this.LBL_FORMMain_Texto.Name = "LBL_FORMMain_Texto";
      this.LBL_FORMMain_Texto.Size = new System.Drawing.Size(66, 13);
      this.LBL_FORMMain_Texto.TabIndex = 2;
      this.LBL_FORMMain_Texto.Text = "Enviar texto:";
      // 
      // TXT_FORMMAin_Texto
      // 
      this.TXT_FORMMAin_Texto.Location = new System.Drawing.Point(85, 57);
      this.TXT_FORMMAin_Texto.Name = "TXT_FORMMAin_Texto";
      this.TXT_FORMMAin_Texto.Size = new System.Drawing.Size(182, 20);
      this.TXT_FORMMAin_Texto.TabIndex = 3;
      // 
      // BTN_FORM2_Enviar
      // 
      this.BTN_FORM2_Enviar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.BTN_FORM2_Enviar.Location = new System.Drawing.Point(192, 104);
      this.BTN_FORM2_Enviar.Name = "BTN_FORM2_Enviar";
      this.BTN_FORM2_Enviar.Size = new System.Drawing.Size(75, 23);
      this.BTN_FORM2_Enviar.TabIndex = 4;
      this.BTN_FORM2_Enviar.Text = "Enviar";
      this.BTN_FORM2_Enviar.UseVisualStyleBackColor = true;
      this.BTN_FORM2_Enviar.Click += new System.EventHandler(this.BTN_FORM2_Enviar_Click);
      // 
      // FORM_Ventana
      // 
      this.AcceptButton = this.BTN_FORM2_Enviar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.BTN_FORM2_Cancelar;
      this.ClientSize = new System.Drawing.Size(285, 139);
      this.Controls.Add(this.BTN_FORM2_Enviar);
      this.Controls.Add(this.TXT_FORMMAin_Texto);
      this.Controls.Add(this.LBL_FORMMain_Texto);
      this.Controls.Add(this.BTN_FORM2_Cancelar);
      this.Controls.Add(this.LBL_Texto_FormVentana);
      this.Name = "FORM_Ventana";
      this.Text = "FORM_Ventana";
      this.Load += new System.EventHandler(this.FORM_Ventana_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LBL_Texto_FormVentana;
    private System.Windows.Forms.Button BTN_FORM2_Cancelar;
    private System.Windows.Forms.Label LBL_FORMMain_Texto;
    private System.Windows.Forms.TextBox TXT_FORMMAin_Texto;
    private System.Windows.Forms.Button BTN_FORM2_Enviar;
  }
}