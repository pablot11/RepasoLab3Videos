namespace pryVideosLab3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvVideos = new System.Windows.Forms.TreeView();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.wmpVideos = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // tvVideos
            // 
            this.tvVideos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvVideos.Location = new System.Drawing.Point(12, 12);
            this.tvVideos.Name = "tvVideos";
            this.tvVideos.Size = new System.Drawing.Size(354, 250);
            this.tvVideos.TabIndex = 0;
            this.tvVideos.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvVideos_NodeMouseClick);
            // 
            // btnReproducir
            // 
            this.btnReproducir.Location = new System.Drawing.Point(382, 12);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(99, 23);
            this.btnReproducir.TabIndex = 1;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // wmpVideos
            // 
            this.wmpVideos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmpVideos.Enabled = true;
            this.wmpVideos.Location = new System.Drawing.Point(382, 41);
            this.wmpVideos.Name = "wmpVideos";
            this.wmpVideos.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideos.OcxState")));
            this.wmpVideos.Size = new System.Drawing.Size(406, 221);
            this.wmpVideos.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wmpVideos);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.tvVideos);
            this.Name = "Form1";
            this.Text = "Mis videos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvVideos;
        private System.Windows.Forms.Button btnReproducir;
        private AxWMPLib.AxWindowsMediaPlayer wmpVideos;
    }
}

