namespace Inventario
{
    partial class Lobby
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.VerificarBtn = new MaterialSkin.Controls.MaterialButton();
            this.ProductosBtn = new MaterialSkin.Controls.MaterialButton();
            this.AgregarProBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(468, 185);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "¡Bienvenido!";
            // 
            // VerificarBtn
            // 
            this.VerificarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VerificarBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.VerificarBtn.Depth = 0;
            this.VerificarBtn.HighEmphasis = true;
            this.VerificarBtn.Icon = null;
            this.VerificarBtn.Location = new System.Drawing.Point(462, 268);
            this.VerificarBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VerificarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.VerificarBtn.Name = "VerificarBtn";
            this.VerificarBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.VerificarBtn.Size = new System.Drawing.Size(93, 36);
            this.VerificarBtn.TabIndex = 4;
            this.VerificarBtn.Text = "Verificar";
            this.VerificarBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.VerificarBtn.UseAccentColor = false;
            this.VerificarBtn.UseVisualStyleBackColor = true;
            this.VerificarBtn.Click += new System.EventHandler(this.VerificarBtn_Click);
            // 
            // ProductosBtn
            // 
            this.ProductosBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProductosBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ProductosBtn.Depth = 0;
            this.ProductosBtn.HighEmphasis = true;
            this.ProductosBtn.Icon = null;
            this.ProductosBtn.Location = new System.Drawing.Point(456, 229);
            this.ProductosBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ProductosBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProductosBtn.Name = "ProductosBtn";
            this.ProductosBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ProductosBtn.Size = new System.Drawing.Size(107, 36);
            this.ProductosBtn.TabIndex = 3;
            this.ProductosBtn.Text = "Productos";
            this.ProductosBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ProductosBtn.UseAccentColor = false;
            this.ProductosBtn.UseVisualStyleBackColor = true;
            this.ProductosBtn.Click += new System.EventHandler(this.ProductosBtn_Click);
            // 
            // AgregarProBtn
            // 
            this.AgregarProBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgregarProBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AgregarProBtn.Depth = 0;
            this.AgregarProBtn.HighEmphasis = true;
            this.AgregarProBtn.Icon = null;
            this.AgregarProBtn.Location = new System.Drawing.Point(422, 317);
            this.AgregarProBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.AgregarProBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarProBtn.Name = "AgregarProBtn";
            this.AgregarProBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AgregarProBtn.Size = new System.Drawing.Size(177, 36);
            this.AgregarProBtn.TabIndex = 6;
            this.AgregarProBtn.Text = "Agregar Productos";
            this.AgregarProBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AgregarProBtn.UseAccentColor = false;
            this.AgregarProBtn.UseVisualStyleBackColor = true;
            this.AgregarProBtn.Click += new System.EventHandler(this.AgregarProBtn_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.AgregarProBtn);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.VerificarBtn);
            this.Controls.Add(this.ProductosBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Lobby";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton VerificarBtn;
        private MaterialSkin.Controls.MaterialButton ProductosBtn;
        private MaterialSkin.Controls.MaterialButton AgregarProBtn;
    }
}