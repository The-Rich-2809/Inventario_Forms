namespace Inventario
{
    partial class AgregarProductos
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
            this.TipoProductoDGV = new System.Windows.Forms.DataGridView();
            this.TipoProductoGB = new System.Windows.Forms.GroupBox();
            this.ActualizarTipoBtn = new MaterialSkin.Controls.MaterialButton();
            this.AgregarTipoBtn = new MaterialSkin.Controls.MaterialButton();
            this.ElimarTipoBtn = new MaterialSkin.Controls.MaterialButton();
            this.ModificarTipoBtn = new MaterialSkin.Controls.MaterialButton();
            this.TipoProductoTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.MarcaDGV = new System.Windows.Forms.DataGridView();
            this.DetallesDGV = new System.Windows.Forms.DataGridView();
            this.MarcaGB = new System.Windows.Forms.GroupBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TipoProductoSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.ActualizarMarcaBtn = new MaterialSkin.Controls.MaterialButton();
            this.AgregarMarcabtn = new MaterialSkin.Controls.MaterialButton();
            this.EliminarMarcaBtn = new MaterialSkin.Controls.MaterialButton();
            this.ModificarMarcaBtn = new MaterialSkin.Controls.MaterialButton();
            this.MarcaTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.DetallesGB = new System.Windows.Forms.GroupBox();
            this.CostoTxt = new System.Windows.Forms.NumericUpDown();
            this.TipoProductoDetallesTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Costo = new MaterialSkin.Controls.MaterialLabel();
            this.ModeloTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.MarcaSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.ActualizarDetallesBtn = new MaterialSkin.Controls.MaterialButton();
            this.AgregarDetallesBtn = new MaterialSkin.Controls.MaterialButton();
            this.EliminarDetallesBtn = new MaterialSkin.Controls.MaterialButton();
            this.ModificarDetallesBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TipoProductoDGV)).BeginInit();
            this.TipoProductoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDGV)).BeginInit();
            this.MarcaGB.SuspendLayout();
            this.DetallesGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CostoTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoProductoDGV
            // 
            this.TipoProductoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TipoProductoDGV.Location = new System.Drawing.Point(9, 84);
            this.TipoProductoDGV.Margin = new System.Windows.Forms.Padding(4);
            this.TipoProductoDGV.Name = "TipoProductoDGV";
            this.TipoProductoDGV.RowHeadersWidth = 51;
            this.TipoProductoDGV.Size = new System.Drawing.Size(609, 297);
            this.TipoProductoDGV.TabIndex = 0;
            this.TipoProductoDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TipoProductoDGV_CellClick);
            // 
            // TipoProductoGB
            // 
            this.TipoProductoGB.Controls.Add(this.ActualizarTipoBtn);
            this.TipoProductoGB.Controls.Add(this.AgregarTipoBtn);
            this.TipoProductoGB.Controls.Add(this.ElimarTipoBtn);
            this.TipoProductoGB.Controls.Add(this.ModificarTipoBtn);
            this.TipoProductoGB.Controls.Add(this.TipoProductoTxt);
            this.TipoProductoGB.Controls.Add(this.materialLabel1);
            this.TipoProductoGB.Location = new System.Drawing.Point(29, 422);
            this.TipoProductoGB.Margin = new System.Windows.Forms.Padding(4);
            this.TipoProductoGB.Name = "TipoProductoGB";
            this.TipoProductoGB.Padding = new System.Windows.Forms.Padding(4);
            this.TipoProductoGB.Size = new System.Drawing.Size(564, 192);
            this.TipoProductoGB.TabIndex = 6;
            this.TipoProductoGB.TabStop = false;
            this.TipoProductoGB.Text = "Tipo de Producto";
            // 
            // ActualizarTipoBtn
            // 
            this.ActualizarTipoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ActualizarTipoBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ActualizarTipoBtn.Depth = 0;
            this.ActualizarTipoBtn.HighEmphasis = true;
            this.ActualizarTipoBtn.Icon = null;
            this.ActualizarTipoBtn.Location = new System.Drawing.Point(408, 27);
            this.ActualizarTipoBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ActualizarTipoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActualizarTipoBtn.Name = "ActualizarTipoBtn";
            this.ActualizarTipoBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ActualizarTipoBtn.Size = new System.Drawing.Size(109, 36);
            this.ActualizarTipoBtn.TabIndex = 4;
            this.ActualizarTipoBtn.Text = "Actualizar";
            this.ActualizarTipoBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ActualizarTipoBtn.UseAccentColor = false;
            this.ActualizarTipoBtn.UseVisualStyleBackColor = true;
            this.ActualizarTipoBtn.Click += new System.EventHandler(this.ActualizarTipoBtn_Click);
            // 
            // AgregarTipoBtn
            // 
            this.AgregarTipoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgregarTipoBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AgregarTipoBtn.Depth = 0;
            this.AgregarTipoBtn.HighEmphasis = true;
            this.AgregarTipoBtn.Icon = null;
            this.AgregarTipoBtn.Location = new System.Drawing.Point(9, 27);
            this.AgregarTipoBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.AgregarTipoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarTipoBtn.Name = "AgregarTipoBtn";
            this.AgregarTipoBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AgregarTipoBtn.Size = new System.Drawing.Size(88, 36);
            this.AgregarTipoBtn.TabIndex = 1;
            this.AgregarTipoBtn.Text = "Agregar";
            this.AgregarTipoBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AgregarTipoBtn.UseAccentColor = false;
            this.AgregarTipoBtn.UseVisualStyleBackColor = true;
            this.AgregarTipoBtn.Click += new System.EventHandler(this.AgregarTipoBtn_Click);
            // 
            // ElimarTipoBtn
            // 
            this.ElimarTipoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ElimarTipoBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ElimarTipoBtn.Depth = 0;
            this.ElimarTipoBtn.HighEmphasis = true;
            this.ElimarTipoBtn.Icon = null;
            this.ElimarTipoBtn.Location = new System.Drawing.Point(280, 27);
            this.ElimarTipoBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ElimarTipoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ElimarTipoBtn.Name = "ElimarTipoBtn";
            this.ElimarTipoBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ElimarTipoBtn.Size = new System.Drawing.Size(88, 36);
            this.ElimarTipoBtn.TabIndex = 3;
            this.ElimarTipoBtn.Text = "Eliminar";
            this.ElimarTipoBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ElimarTipoBtn.UseAccentColor = false;
            this.ElimarTipoBtn.UseVisualStyleBackColor = true;
            this.ElimarTipoBtn.Click += new System.EventHandler(this.ElimarTipoBtn_Click);
            // 
            // ModificarTipoBtn
            // 
            this.ModificarTipoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModificarTipoBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ModificarTipoBtn.Depth = 0;
            this.ModificarTipoBtn.HighEmphasis = true;
            this.ModificarTipoBtn.Icon = null;
            this.ModificarTipoBtn.Location = new System.Drawing.Point(137, 27);
            this.ModificarTipoBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ModificarTipoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarTipoBtn.Name = "ModificarTipoBtn";
            this.ModificarTipoBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ModificarTipoBtn.Size = new System.Drawing.Size(99, 36);
            this.ModificarTipoBtn.TabIndex = 2;
            this.ModificarTipoBtn.Text = "Modificar";
            this.ModificarTipoBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ModificarTipoBtn.UseAccentColor = false;
            this.ModificarTipoBtn.UseVisualStyleBackColor = true;
            this.ModificarTipoBtn.Click += new System.EventHandler(this.ModificarTipoBtn_Click);
            // 
            // TipoProductoTxt
            // 
            this.TipoProductoTxt.AnimateReadOnly = false;
            this.TipoProductoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TipoProductoTxt.Depth = 0;
            this.TipoProductoTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TipoProductoTxt.LeadingIcon = null;
            this.TipoProductoTxt.Location = new System.Drawing.Point(9, 107);
            this.TipoProductoTxt.Margin = new System.Windows.Forms.Padding(4);
            this.TipoProductoTxt.MaxLength = 50;
            this.TipoProductoTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.TipoProductoTxt.Multiline = false;
            this.TipoProductoTxt.Name = "TipoProductoTxt";
            this.TipoProductoTxt.Size = new System.Drawing.Size(287, 50);
            this.TipoProductoTxt.TabIndex = 8;
            this.TipoProductoTxt.Text = "";
            this.TipoProductoTxt.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(9, 80);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(122, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Tipo de Producto";
            // 
            // MarcaDGV
            // 
            this.MarcaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarcaDGV.Location = new System.Drawing.Point(627, 84);
            this.MarcaDGV.Margin = new System.Windows.Forms.Padding(4);
            this.MarcaDGV.Name = "MarcaDGV";
            this.MarcaDGV.RowHeadersWidth = 51;
            this.MarcaDGV.Size = new System.Drawing.Size(633, 297);
            this.MarcaDGV.TabIndex = 9;
            // 
            // DetallesDGV
            // 
            this.DetallesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallesDGV.Location = new System.Drawing.Point(1268, 84);
            this.DetallesDGV.Margin = new System.Windows.Forms.Padding(4);
            this.DetallesDGV.Name = "DetallesDGV";
            this.DetallesDGV.RowHeadersWidth = 51;
            this.DetallesDGV.Size = new System.Drawing.Size(671, 297);
            this.DetallesDGV.TabIndex = 13;
            this.DetallesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetallesDGV_CellClick);
            // 
            // MarcaGB
            // 
            this.MarcaGB.Controls.Add(this.materialLabel3);
            this.MarcaGB.Controls.Add(this.TipoProductoSelect);
            this.MarcaGB.Controls.Add(this.ActualizarMarcaBtn);
            this.MarcaGB.Controls.Add(this.AgregarMarcabtn);
            this.MarcaGB.Controls.Add(this.EliminarMarcaBtn);
            this.MarcaGB.Controls.Add(this.ModificarMarcaBtn);
            this.MarcaGB.Controls.Add(this.MarcaTxt);
            this.MarcaGB.Controls.Add(this.materialLabel2);
            this.MarcaGB.Location = new System.Drawing.Point(627, 422);
            this.MarcaGB.Margin = new System.Windows.Forms.Padding(4);
            this.MarcaGB.Name = "MarcaGB";
            this.MarcaGB.Padding = new System.Windows.Forms.Padding(4);
            this.MarcaGB.Size = new System.Drawing.Size(633, 192);
            this.MarcaGB.TabIndex = 9;
            this.MarcaGB.TabStop = false;
            this.MarcaGB.Text = "Marca";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(8, 80);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(122, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Tipo de Producto";
            // 
            // TipoProductoSelect
            // 
            this.TipoProductoSelect.AutoResize = false;
            this.TipoProductoSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TipoProductoSelect.Depth = 0;
            this.TipoProductoSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TipoProductoSelect.DropDownHeight = 174;
            this.TipoProductoSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoProductoSelect.DropDownWidth = 121;
            this.TipoProductoSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TipoProductoSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TipoProductoSelect.FormattingEnabled = true;
            this.TipoProductoSelect.IntegralHeight = false;
            this.TipoProductoSelect.ItemHeight = 43;
            this.TipoProductoSelect.Location = new System.Drawing.Point(9, 106);
            this.TipoProductoSelect.Margin = new System.Windows.Forms.Padding(4);
            this.TipoProductoSelect.MaxDropDownItems = 4;
            this.TipoProductoSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.TipoProductoSelect.Name = "TipoProductoSelect";
            this.TipoProductoSelect.Size = new System.Drawing.Size(324, 49);
            this.TipoProductoSelect.StartIndex = 0;
            this.TipoProductoSelect.TabIndex = 9;
            // 
            // ActualizarMarcaBtn
            // 
            this.ActualizarMarcaBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ActualizarMarcaBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ActualizarMarcaBtn.Depth = 0;
            this.ActualizarMarcaBtn.HighEmphasis = true;
            this.ActualizarMarcaBtn.Icon = null;
            this.ActualizarMarcaBtn.Location = new System.Drawing.Point(408, 27);
            this.ActualizarMarcaBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ActualizarMarcaBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActualizarMarcaBtn.Name = "ActualizarMarcaBtn";
            this.ActualizarMarcaBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ActualizarMarcaBtn.Size = new System.Drawing.Size(109, 36);
            this.ActualizarMarcaBtn.TabIndex = 4;
            this.ActualizarMarcaBtn.Text = "Actualizar";
            this.ActualizarMarcaBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ActualizarMarcaBtn.UseAccentColor = false;
            this.ActualizarMarcaBtn.UseVisualStyleBackColor = true;
            this.ActualizarMarcaBtn.Click += new System.EventHandler(this.ActualizarMarcaBtn_Click);
            // 
            // AgregarMarcabtn
            // 
            this.AgregarMarcabtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgregarMarcabtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AgregarMarcabtn.Depth = 0;
            this.AgregarMarcabtn.HighEmphasis = true;
            this.AgregarMarcabtn.Icon = null;
            this.AgregarMarcabtn.Location = new System.Drawing.Point(9, 27);
            this.AgregarMarcabtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.AgregarMarcabtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarMarcabtn.Name = "AgregarMarcabtn";
            this.AgregarMarcabtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AgregarMarcabtn.Size = new System.Drawing.Size(88, 36);
            this.AgregarMarcabtn.TabIndex = 1;
            this.AgregarMarcabtn.Text = "Agregar";
            this.AgregarMarcabtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AgregarMarcabtn.UseAccentColor = false;
            this.AgregarMarcabtn.UseVisualStyleBackColor = true;
            this.AgregarMarcabtn.Click += new System.EventHandler(this.AgregarMarcabtn_Click);
            // 
            // EliminarMarcaBtn
            // 
            this.EliminarMarcaBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EliminarMarcaBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EliminarMarcaBtn.Depth = 0;
            this.EliminarMarcaBtn.HighEmphasis = true;
            this.EliminarMarcaBtn.Icon = null;
            this.EliminarMarcaBtn.Location = new System.Drawing.Point(280, 27);
            this.EliminarMarcaBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.EliminarMarcaBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.EliminarMarcaBtn.Name = "EliminarMarcaBtn";
            this.EliminarMarcaBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EliminarMarcaBtn.Size = new System.Drawing.Size(88, 36);
            this.EliminarMarcaBtn.TabIndex = 3;
            this.EliminarMarcaBtn.Text = "Eliminar";
            this.EliminarMarcaBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EliminarMarcaBtn.UseAccentColor = false;
            this.EliminarMarcaBtn.UseVisualStyleBackColor = true;
            this.EliminarMarcaBtn.Click += new System.EventHandler(this.EliminarMarcaBtn_Click);
            // 
            // ModificarMarcaBtn
            // 
            this.ModificarMarcaBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModificarMarcaBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ModificarMarcaBtn.Depth = 0;
            this.ModificarMarcaBtn.HighEmphasis = true;
            this.ModificarMarcaBtn.Icon = null;
            this.ModificarMarcaBtn.Location = new System.Drawing.Point(137, 27);
            this.ModificarMarcaBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ModificarMarcaBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarMarcaBtn.Name = "ModificarMarcaBtn";
            this.ModificarMarcaBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ModificarMarcaBtn.Size = new System.Drawing.Size(99, 36);
            this.ModificarMarcaBtn.TabIndex = 2;
            this.ModificarMarcaBtn.Text = "Modificar";
            this.ModificarMarcaBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ModificarMarcaBtn.UseAccentColor = false;
            this.ModificarMarcaBtn.UseVisualStyleBackColor = true;
            this.ModificarMarcaBtn.Click += new System.EventHandler(this.ModificarMarcaBtn_Click);
            // 
            // MarcaTxt
            // 
            this.MarcaTxt.AnimateReadOnly = false;
            this.MarcaTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MarcaTxt.Depth = 0;
            this.MarcaTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MarcaTxt.LeadingIcon = null;
            this.MarcaTxt.Location = new System.Drawing.Point(343, 106);
            this.MarcaTxt.Margin = new System.Windows.Forms.Padding(4);
            this.MarcaTxt.MaxLength = 50;
            this.MarcaTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.MarcaTxt.Multiline = false;
            this.MarcaTxt.Name = "MarcaTxt";
            this.MarcaTxt.Size = new System.Drawing.Size(283, 50);
            this.MarcaTxt.TabIndex = 8;
            this.MarcaTxt.Text = "";
            this.MarcaTxt.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(339, 79);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Marca";
            // 
            // DetallesGB
            // 
            this.DetallesGB.Controls.Add(this.CostoTxt);
            this.DetallesGB.Controls.Add(this.TipoProductoDetallesTxt);
            this.DetallesGB.Controls.Add(this.Costo);
            this.DetallesGB.Controls.Add(this.ModeloTxt);
            this.DetallesGB.Controls.Add(this.materialLabel6);
            this.DetallesGB.Controls.Add(this.MarcaSelect);
            this.DetallesGB.Controls.Add(this.materialLabel4);
            this.DetallesGB.Controls.Add(this.ActualizarDetallesBtn);
            this.DetallesGB.Controls.Add(this.AgregarDetallesBtn);
            this.DetallesGB.Controls.Add(this.EliminarDetallesBtn);
            this.DetallesGB.Controls.Add(this.ModificarDetallesBtn);
            this.DetallesGB.Controls.Add(this.materialLabel5);
            this.DetallesGB.Location = new System.Drawing.Point(1268, 422);
            this.DetallesGB.Margin = new System.Windows.Forms.Padding(4);
            this.DetallesGB.Name = "DetallesGB";
            this.DetallesGB.Padding = new System.Windows.Forms.Padding(4);
            this.DetallesGB.Size = new System.Drawing.Size(633, 298);
            this.DetallesGB.TabIndex = 14;
            this.DetallesGB.TabStop = false;
            this.DetallesGB.Text = "Detalles";
            // 
            // CostoTxt
            // 
            this.CostoTxt.Location = new System.Drawing.Point(352, 229);
            this.CostoTxt.Name = "CostoTxt";
            this.CostoTxt.Size = new System.Drawing.Size(274, 22);
            this.CostoTxt.TabIndex = 15;
            // 
            // TipoProductoDetallesTxt
            // 
            this.TipoProductoDetallesTxt.AnimateReadOnly = false;
            this.TipoProductoDetallesTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TipoProductoDetallesTxt.Depth = 0;
            this.TipoProductoDetallesTxt.Enabled = false;
            this.TipoProductoDetallesTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TipoProductoDetallesTxt.LeadingIcon = null;
            this.TipoProductoDetallesTxt.Location = new System.Drawing.Point(12, 107);
            this.TipoProductoDetallesTxt.Margin = new System.Windows.Forms.Padding(4);
            this.TipoProductoDetallesTxt.MaxLength = 50;
            this.TipoProductoDetallesTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.TipoProductoDetallesTxt.Multiline = false;
            this.TipoProductoDetallesTxt.Name = "TipoProductoDetallesTxt";
            this.TipoProductoDetallesTxt.Size = new System.Drawing.Size(323, 50);
            this.TipoProductoDetallesTxt.TabIndex = 18;
            this.TipoProductoDetallesTxt.Text = "";
            this.TipoProductoDetallesTxt.TrailingIcon = null;
            // 
            // Costo
            // 
            this.Costo.AutoSize = true;
            this.Costo.Depth = 0;
            this.Costo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Costo.Location = new System.Drawing.Point(347, 183);
            this.Costo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Costo.MouseState = MaterialSkin.MouseState.HOVER;
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(42, 19);
            this.Costo.TabIndex = 16;
            this.Costo.Text = "Costo";
            // 
            // ModeloTxt
            // 
            this.ModeloTxt.AnimateReadOnly = false;
            this.ModeloTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModeloTxt.Depth = 0;
            this.ModeloTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ModeloTxt.LeadingIcon = null;
            this.ModeloTxt.Location = new System.Drawing.Point(12, 210);
            this.ModeloTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ModeloTxt.MaxLength = 50;
            this.ModeloTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.ModeloTxt.Multiline = false;
            this.ModeloTxt.Name = "ModeloTxt";
            this.ModeloTxt.Size = new System.Drawing.Size(331, 50);
            this.ModeloTxt.TabIndex = 12;
            this.ModeloTxt.Text = "";
            this.ModeloTxt.TrailingIcon = null;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(8, 183);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(54, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Modelo";
            // 
            // MarcaSelect
            // 
            this.MarcaSelect.AutoResize = false;
            this.MarcaSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MarcaSelect.Depth = 0;
            this.MarcaSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MarcaSelect.DropDownHeight = 174;
            this.MarcaSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarcaSelect.DropDownWidth = 121;
            this.MarcaSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.MarcaSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MarcaSelect.FormattingEnabled = true;
            this.MarcaSelect.IntegralHeight = false;
            this.MarcaSelect.ItemHeight = 43;
            this.MarcaSelect.Location = new System.Drawing.Point(343, 106);
            this.MarcaSelect.Margin = new System.Windows.Forms.Padding(4);
            this.MarcaSelect.MaxDropDownItems = 4;
            this.MarcaSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.MarcaSelect.Name = "MarcaSelect";
            this.MarcaSelect.Size = new System.Drawing.Size(281, 49);
            this.MarcaSelect.StartIndex = 0;
            this.MarcaSelect.TabIndex = 15;
            this.MarcaSelect.SelectedIndexChanged += new System.EventHandler(this.MarcaSelect_SelectedIndexChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(8, 80);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(122, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Tipo de Producto";
            // 
            // ActualizarDetallesBtn
            // 
            this.ActualizarDetallesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ActualizarDetallesBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ActualizarDetallesBtn.Depth = 0;
            this.ActualizarDetallesBtn.HighEmphasis = true;
            this.ActualizarDetallesBtn.Icon = null;
            this.ActualizarDetallesBtn.Location = new System.Drawing.Point(408, 27);
            this.ActualizarDetallesBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ActualizarDetallesBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActualizarDetallesBtn.Name = "ActualizarDetallesBtn";
            this.ActualizarDetallesBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ActualizarDetallesBtn.Size = new System.Drawing.Size(109, 36);
            this.ActualizarDetallesBtn.TabIndex = 4;
            this.ActualizarDetallesBtn.Text = "Actualizar";
            this.ActualizarDetallesBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ActualizarDetallesBtn.UseAccentColor = false;
            this.ActualizarDetallesBtn.UseVisualStyleBackColor = true;
            this.ActualizarDetallesBtn.Click += new System.EventHandler(this.ActualizarDetallesBtn_Click);
            // 
            // AgregarDetallesBtn
            // 
            this.AgregarDetallesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgregarDetallesBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AgregarDetallesBtn.Depth = 0;
            this.AgregarDetallesBtn.HighEmphasis = true;
            this.AgregarDetallesBtn.Icon = null;
            this.AgregarDetallesBtn.Location = new System.Drawing.Point(9, 27);
            this.AgregarDetallesBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.AgregarDetallesBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarDetallesBtn.Name = "AgregarDetallesBtn";
            this.AgregarDetallesBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AgregarDetallesBtn.Size = new System.Drawing.Size(88, 36);
            this.AgregarDetallesBtn.TabIndex = 1;
            this.AgregarDetallesBtn.Text = "Agregar";
            this.AgregarDetallesBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AgregarDetallesBtn.UseAccentColor = false;
            this.AgregarDetallesBtn.UseVisualStyleBackColor = true;
            this.AgregarDetallesBtn.Click += new System.EventHandler(this.AgregarDetallesBtn_Click);
            // 
            // EliminarDetallesBtn
            // 
            this.EliminarDetallesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EliminarDetallesBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EliminarDetallesBtn.Depth = 0;
            this.EliminarDetallesBtn.HighEmphasis = true;
            this.EliminarDetallesBtn.Icon = null;
            this.EliminarDetallesBtn.Location = new System.Drawing.Point(276, 27);
            this.EliminarDetallesBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.EliminarDetallesBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.EliminarDetallesBtn.Name = "EliminarDetallesBtn";
            this.EliminarDetallesBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EliminarDetallesBtn.Size = new System.Drawing.Size(88, 36);
            this.EliminarDetallesBtn.TabIndex = 3;
            this.EliminarDetallesBtn.Text = "Eliminar";
            this.EliminarDetallesBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EliminarDetallesBtn.UseAccentColor = false;
            this.EliminarDetallesBtn.UseVisualStyleBackColor = true;
            this.EliminarDetallesBtn.Click += new System.EventHandler(this.EliminarDetallesBtn_Click);
            // 
            // ModificarDetallesBtn
            // 
            this.ModificarDetallesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModificarDetallesBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ModificarDetallesBtn.Depth = 0;
            this.ModificarDetallesBtn.HighEmphasis = true;
            this.ModificarDetallesBtn.Icon = null;
            this.ModificarDetallesBtn.Location = new System.Drawing.Point(137, 27);
            this.ModificarDetallesBtn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ModificarDetallesBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarDetallesBtn.Name = "ModificarDetallesBtn";
            this.ModificarDetallesBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ModificarDetallesBtn.Size = new System.Drawing.Size(99, 36);
            this.ModificarDetallesBtn.TabIndex = 2;
            this.ModificarDetallesBtn.Text = "Modificar";
            this.ModificarDetallesBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ModificarDetallesBtn.UseAccentColor = false;
            this.ModificarDetallesBtn.UseVisualStyleBackColor = true;
            this.ModificarDetallesBtn.Click += new System.EventHandler(this.ModificarDetallesBtn_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(339, 79);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(46, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Marca";
            // 
            // AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1947, 814);
            this.Controls.Add(this.DetallesGB);
            this.Controls.Add(this.MarcaGB);
            this.Controls.Add(this.DetallesDGV);
            this.Controls.Add(this.MarcaDGV);
            this.Controls.Add(this.TipoProductoGB);
            this.Controls.Add(this.TipoProductoDGV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarProductos";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "AgregarProductos";
            this.Load += new System.EventHandler(this.AgregarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TipoProductoDGV)).EndInit();
            this.TipoProductoGB.ResumeLayout(false);
            this.TipoProductoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDGV)).EndInit();
            this.MarcaGB.ResumeLayout(false);
            this.MarcaGB.PerformLayout();
            this.DetallesGB.ResumeLayout(false);
            this.DetallesGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CostoTxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TipoProductoDGV;
        private System.Windows.Forms.GroupBox TipoProductoGB;
        private MaterialSkin.Controls.MaterialButton ActualizarTipoBtn;
        private MaterialSkin.Controls.MaterialButton AgregarTipoBtn;
        private MaterialSkin.Controls.MaterialButton ElimarTipoBtn;
        private MaterialSkin.Controls.MaterialButton ModificarTipoBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox TipoProductoTxt;
        private System.Windows.Forms.DataGridView MarcaDGV;
        private System.Windows.Forms.DataGridView DetallesDGV;
        private System.Windows.Forms.GroupBox MarcaGB;
        private MaterialSkin.Controls.MaterialButton ActualizarMarcaBtn;
        private MaterialSkin.Controls.MaterialButton AgregarMarcabtn;
        private MaterialSkin.Controls.MaterialButton EliminarMarcaBtn;
        private MaterialSkin.Controls.MaterialButton ModificarMarcaBtn;
        private MaterialSkin.Controls.MaterialTextBox MarcaTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox TipoProductoSelect;
        private System.Windows.Forms.GroupBox DetallesGB;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton ActualizarDetallesBtn;
        private MaterialSkin.Controls.MaterialButton AgregarDetallesBtn;
        private MaterialSkin.Controls.MaterialButton EliminarDetallesBtn;
        private MaterialSkin.Controls.MaterialButton ModificarDetallesBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel Costo;
        private MaterialSkin.Controls.MaterialTextBox ModeloTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox MarcaSelect;
        private MaterialSkin.Controls.MaterialTextBox TipoProductoDetallesTxt;
        private System.Windows.Forms.NumericUpDown CostoTxt;
    }
}