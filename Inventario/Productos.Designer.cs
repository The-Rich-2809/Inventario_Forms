namespace Inventario
{
    partial class Productos
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
            this.ActivoDGV = new System.Windows.Forms.DataGridView();
            this.AgregarBtn = new MaterialSkin.Controls.MaterialButton();
            this.ModificarBtn = new MaterialSkin.Controls.MaterialButton();
            this.ElimarBtn = new MaterialSkin.Controls.MaterialButton();
            this.ActualizarBtn = new MaterialSkin.Controls.MaterialButton();
            this.ControlesGB = new System.Windows.Forms.GroupBox();
            this.TipoProductoCB = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.MarcaCB = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.ModeloCB = new MaterialSkin.Controls.MaterialComboBox();
            this.IMEITXT = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.NumSerieTxt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.EstadoCB = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.ColorCB = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.SiteCB = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.CostoTxt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ActivoDGV)).BeginInit();
            this.ControlesGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActivoDGV
            // 
            this.ActivoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActivoDGV.Location = new System.Drawing.Point(6, 67);
            this.ActivoDGV.Name = "ActivoDGV";
            this.ActivoDGV.RowHeadersWidth = 51;
            this.ActivoDGV.Size = new System.Drawing.Size(1177, 272);
            this.ActivoDGV.TabIndex = 0;
            this.ActivoDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActivoDGV_CellClick);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgregarBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AgregarBtn.Depth = 0;
            this.AgregarBtn.HighEmphasis = true;
            this.AgregarBtn.Icon = null;
            this.AgregarBtn.Location = new System.Drawing.Point(7, 22);
            this.AgregarBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AgregarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AgregarBtn.Size = new System.Drawing.Size(88, 36);
            this.AgregarBtn.TabIndex = 1;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AgregarBtn.UseAccentColor = false;
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModificarBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ModificarBtn.Depth = 0;
            this.ModificarBtn.HighEmphasis = true;
            this.ModificarBtn.Icon = null;
            this.ModificarBtn.Location = new System.Drawing.Point(103, 22);
            this.ModificarBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ModificarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ModificarBtn.Size = new System.Drawing.Size(99, 36);
            this.ModificarBtn.TabIndex = 2;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ModificarBtn.UseAccentColor = false;
            this.ModificarBtn.UseVisualStyleBackColor = true;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // ElimarBtn
            // 
            this.ElimarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ElimarBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ElimarBtn.Depth = 0;
            this.ElimarBtn.HighEmphasis = true;
            this.ElimarBtn.Icon = null;
            this.ElimarBtn.Location = new System.Drawing.Point(210, 22);
            this.ElimarBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ElimarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ElimarBtn.Name = "ElimarBtn";
            this.ElimarBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ElimarBtn.Size = new System.Drawing.Size(88, 36);
            this.ElimarBtn.TabIndex = 3;
            this.ElimarBtn.Text = "Eliminar";
            this.ElimarBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ElimarBtn.UseAccentColor = false;
            this.ElimarBtn.UseVisualStyleBackColor = true;
            this.ElimarBtn.Click += new System.EventHandler(this.ElimarBtn_Click);
            // 
            // ActualizarBtn
            // 
            this.ActualizarBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ActualizarBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ActualizarBtn.Depth = 0;
            this.ActualizarBtn.HighEmphasis = true;
            this.ActualizarBtn.Icon = null;
            this.ActualizarBtn.Location = new System.Drawing.Point(306, 22);
            this.ActualizarBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ActualizarBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActualizarBtn.Name = "ActualizarBtn";
            this.ActualizarBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ActualizarBtn.Size = new System.Drawing.Size(109, 36);
            this.ActualizarBtn.TabIndex = 4;
            this.ActualizarBtn.Text = "Actualizar";
            this.ActualizarBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ActualizarBtn.UseAccentColor = false;
            this.ActualizarBtn.UseVisualStyleBackColor = true;
            this.ActualizarBtn.Click += new System.EventHandler(this.ActualizarBtn_Click);
            // 
            // ControlesGB
            // 
            this.ControlesGB.Controls.Add(this.ActualizarBtn);
            this.ControlesGB.Controls.Add(this.AgregarBtn);
            this.ControlesGB.Controls.Add(this.ElimarBtn);
            this.ControlesGB.Controls.Add(this.ModificarBtn);
            this.ControlesGB.Location = new System.Drawing.Point(223, 345);
            this.ControlesGB.Name = "ControlesGB";
            this.ControlesGB.Size = new System.Drawing.Size(423, 69);
            this.ControlesGB.TabIndex = 5;
            this.ControlesGB.TabStop = false;
            // 
            // TipoProductoCB
            // 
            this.TipoProductoCB.AutoResize = false;
            this.TipoProductoCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TipoProductoCB.Depth = 0;
            this.TipoProductoCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TipoProductoCB.DropDownHeight = 174;
            this.TipoProductoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoProductoCB.DropDownWidth = 121;
            this.TipoProductoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TipoProductoCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TipoProductoCB.FormattingEnabled = true;
            this.TipoProductoCB.IntegralHeight = false;
            this.TipoProductoCB.ItemHeight = 43;
            this.TipoProductoCB.Location = new System.Drawing.Point(35, 456);
            this.TipoProductoCB.MaxDropDownItems = 4;
            this.TipoProductoCB.MouseState = MaterialSkin.MouseState.OUT;
            this.TipoProductoCB.Name = "TipoProductoCB";
            this.TipoProductoCB.Size = new System.Drawing.Size(182, 49);
            this.TipoProductoCB.StartIndex = 0;
            this.TipoProductoCB.TabIndex = 6;
            this.TipoProductoCB.SelectedIndexChanged += new System.EventHandler(this.TipoProductoCB_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(35, 431);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(122, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Tipo de Producto";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(223, 430);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Marca";
            // 
            // MarcaCB
            // 
            this.MarcaCB.AutoResize = false;
            this.MarcaCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MarcaCB.Depth = 0;
            this.MarcaCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MarcaCB.DropDownHeight = 174;
            this.MarcaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarcaCB.DropDownWidth = 121;
            this.MarcaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.MarcaCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MarcaCB.FormattingEnabled = true;
            this.MarcaCB.IntegralHeight = false;
            this.MarcaCB.ItemHeight = 43;
            this.MarcaCB.Location = new System.Drawing.Point(223, 455);
            this.MarcaCB.MaxDropDownItems = 4;
            this.MarcaCB.MouseState = MaterialSkin.MouseState.OUT;
            this.MarcaCB.Name = "MarcaCB";
            this.MarcaCB.Size = new System.Drawing.Size(221, 49);
            this.MarcaCB.StartIndex = 0;
            this.MarcaCB.TabIndex = 8;
            this.MarcaCB.SelectedIndexChanged += new System.EventHandler(this.MarcaCB_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(447, 434);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Modelo";
            // 
            // ModeloCB
            // 
            this.ModeloCB.AutoResize = false;
            this.ModeloCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ModeloCB.Depth = 0;
            this.ModeloCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ModeloCB.DropDownHeight = 174;
            this.ModeloCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeloCB.DropDownWidth = 121;
            this.ModeloCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ModeloCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ModeloCB.FormattingEnabled = true;
            this.ModeloCB.IntegralHeight = false;
            this.ModeloCB.ItemHeight = 43;
            this.ModeloCB.Location = new System.Drawing.Point(450, 456);
            this.ModeloCB.MaxDropDownItems = 4;
            this.ModeloCB.MouseState = MaterialSkin.MouseState.OUT;
            this.ModeloCB.Name = "ModeloCB";
            this.ModeloCB.Size = new System.Drawing.Size(227, 49);
            this.ModeloCB.StartIndex = 0;
            this.ModeloCB.TabIndex = 10;
            this.ModeloCB.SelectedIndexChanged += new System.EventHandler(this.ModeloCB_SelectedIndexChanged);
            // 
            // IMEITXT
            // 
            this.IMEITXT.AllowPromptAsInput = true;
            this.IMEITXT.AnimateReadOnly = false;
            this.IMEITXT.AsciiOnly = false;
            this.IMEITXT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IMEITXT.BeepOnError = false;
            this.IMEITXT.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.IMEITXT.Depth = 0;
            this.IMEITXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.IMEITXT.HidePromptOnLeave = false;
            this.IMEITXT.HideSelection = true;
            this.IMEITXT.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.IMEITXT.LeadingIcon = null;
            this.IMEITXT.Location = new System.Drawing.Point(35, 551);
            this.IMEITXT.Mask = "";
            this.IMEITXT.MaxLength = 32767;
            this.IMEITXT.MouseState = MaterialSkin.MouseState.OUT;
            this.IMEITXT.Name = "IMEITXT";
            this.IMEITXT.PasswordChar = '\0';
            this.IMEITXT.PrefixSuffixText = null;
            this.IMEITXT.PromptChar = '_';
            this.IMEITXT.ReadOnly = false;
            this.IMEITXT.RejectInputOnFirstFailure = false;
            this.IMEITXT.ResetOnPrompt = true;
            this.IMEITXT.ResetOnSpace = true;
            this.IMEITXT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IMEITXT.SelectedText = "";
            this.IMEITXT.SelectionLength = 0;
            this.IMEITXT.SelectionStart = 0;
            this.IMEITXT.ShortcutsEnabled = true;
            this.IMEITXT.Size = new System.Drawing.Size(314, 48);
            this.IMEITXT.SkipLiterals = true;
            this.IMEITXT.TabIndex = 12;
            this.IMEITXT.TabStop = false;
            this.IMEITXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IMEITXT.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.IMEITXT.TrailingIcon = null;
            this.IMEITXT.UseSystemPasswordChar = false;
            this.IMEITXT.ValidatingType = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(35, 529);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(32, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "IMEI";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(363, 529);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(117, 19);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Numero de Serie";
            // 
            // NumSerieTxt
            // 
            this.NumSerieTxt.AllowPromptAsInput = true;
            this.NumSerieTxt.AnimateReadOnly = false;
            this.NumSerieTxt.AsciiOnly = false;
            this.NumSerieTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NumSerieTxt.BeepOnError = false;
            this.NumSerieTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NumSerieTxt.Depth = 0;
            this.NumSerieTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NumSerieTxt.HidePromptOnLeave = false;
            this.NumSerieTxt.HideSelection = true;
            this.NumSerieTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.NumSerieTxt.LeadingIcon = null;
            this.NumSerieTxt.Location = new System.Drawing.Point(363, 551);
            this.NumSerieTxt.Mask = "";
            this.NumSerieTxt.MaxLength = 32767;
            this.NumSerieTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.NumSerieTxt.Name = "NumSerieTxt";
            this.NumSerieTxt.PasswordChar = '\0';
            this.NumSerieTxt.PrefixSuffixText = null;
            this.NumSerieTxt.PromptChar = '_';
            this.NumSerieTxt.ReadOnly = false;
            this.NumSerieTxt.RejectInputOnFirstFailure = false;
            this.NumSerieTxt.ResetOnPrompt = true;
            this.NumSerieTxt.ResetOnSpace = true;
            this.NumSerieTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumSerieTxt.SelectedText = "";
            this.NumSerieTxt.SelectionLength = 0;
            this.NumSerieTxt.SelectionStart = 0;
            this.NumSerieTxt.ShortcutsEnabled = true;
            this.NumSerieTxt.Size = new System.Drawing.Size(314, 48);
            this.NumSerieTxt.SkipLiterals = true;
            this.NumSerieTxt.TabIndex = 14;
            this.NumSerieTxt.TabStop = false;
            this.NumSerieTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumSerieTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.NumSerieTxt.TrailingIcon = null;
            this.NumSerieTxt.UseSystemPasswordChar = false;
            this.NumSerieTxt.ValidatingType = null;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(680, 529);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(50, 19);
            this.materialLabel6.TabIndex = 17;
            this.materialLabel6.Text = "Estado";
            // 
            // EstadoCB
            // 
            this.EstadoCB.AutoResize = false;
            this.EstadoCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EstadoCB.Depth = 0;
            this.EstadoCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.EstadoCB.DropDownHeight = 174;
            this.EstadoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoCB.DropDownWidth = 121;
            this.EstadoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.EstadoCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EstadoCB.FormattingEnabled = true;
            this.EstadoCB.IntegralHeight = false;
            this.EstadoCB.ItemHeight = 43;
            this.EstadoCB.Items.AddRange(new object[] {
            "Usado",
            "Nuevo"});
            this.EstadoCB.Location = new System.Drawing.Point(683, 551);
            this.EstadoCB.MaxDropDownItems = 4;
            this.EstadoCB.MouseState = MaterialSkin.MouseState.OUT;
            this.EstadoCB.Name = "EstadoCB";
            this.EstadoCB.Size = new System.Drawing.Size(199, 49);
            this.EstadoCB.StartIndex = 0;
            this.EstadoCB.TabIndex = 16;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(888, 530);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(38, 19);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "Color";
            // 
            // ColorCB
            // 
            this.ColorCB.AutoResize = false;
            this.ColorCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ColorCB.Depth = 0;
            this.ColorCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ColorCB.DropDownHeight = 174;
            this.ColorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorCB.DropDownWidth = 121;
            this.ColorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ColorCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColorCB.FormattingEnabled = true;
            this.ColorCB.IntegralHeight = false;
            this.ColorCB.ItemHeight = 43;
            this.ColorCB.Items.AddRange(new object[] {
            "Blanco",
            "Negro",
            "Azul",
            "Rojo",
            "Verde",
            "Cafe"});
            this.ColorCB.Location = new System.Drawing.Point(891, 552);
            this.ColorCB.MaxDropDownItems = 4;
            this.ColorCB.MouseState = MaterialSkin.MouseState.OUT;
            this.ColorCB.Name = "ColorCB";
            this.ColorCB.Size = new System.Drawing.Size(199, 49);
            this.ColorCB.StartIndex = 0;
            this.ColorCB.TabIndex = 20;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(680, 434);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(28, 19);
            this.materialLabel8.TabIndex = 22;
            this.materialLabel8.Text = "Site";
            // 
            // SiteCB
            // 
            this.SiteCB.AutoResize = false;
            this.SiteCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SiteCB.Depth = 0;
            this.SiteCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SiteCB.DropDownHeight = 174;
            this.SiteCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SiteCB.DropDownWidth = 121;
            this.SiteCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SiteCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SiteCB.FormattingEnabled = true;
            this.SiteCB.IntegralHeight = false;
            this.SiteCB.ItemHeight = 43;
            this.SiteCB.Location = new System.Drawing.Point(683, 456);
            this.SiteCB.MaxDropDownItems = 4;
            this.SiteCB.MouseState = MaterialSkin.MouseState.OUT;
            this.SiteCB.Name = "SiteCB";
            this.SiteCB.Size = new System.Drawing.Size(227, 49);
            this.SiteCB.StartIndex = 0;
            this.SiteCB.TabIndex = 21;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(913, 431);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(42, 19);
            this.materialLabel9.TabIndex = 24;
            this.materialLabel9.Text = "Costo";
            // 
            // CostoTxt
            // 
            this.CostoTxt.AllowPromptAsInput = true;
            this.CostoTxt.AnimateReadOnly = false;
            this.CostoTxt.AsciiOnly = false;
            this.CostoTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CostoTxt.BeepOnError = false;
            this.CostoTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CostoTxt.Depth = 0;
            this.CostoTxt.Enabled = false;
            this.CostoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CostoTxt.HidePromptOnLeave = false;
            this.CostoTxt.HideSelection = true;
            this.CostoTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.CostoTxt.LeadingIcon = null;
            this.CostoTxt.Location = new System.Drawing.Point(916, 456);
            this.CostoTxt.Mask = "";
            this.CostoTxt.MaxLength = 32767;
            this.CostoTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.CostoTxt.Name = "CostoTxt";
            this.CostoTxt.PasswordChar = '\0';
            this.CostoTxt.PrefixSuffixText = null;
            this.CostoTxt.PromptChar = '_';
            this.CostoTxt.ReadOnly = false;
            this.CostoTxt.RejectInputOnFirstFailure = false;
            this.CostoTxt.ResetOnPrompt = true;
            this.CostoTxt.ResetOnSpace = true;
            this.CostoTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CostoTxt.SelectedText = "";
            this.CostoTxt.SelectionLength = 0;
            this.CostoTxt.SelectionStart = 0;
            this.CostoTxt.ShortcutsEnabled = true;
            this.CostoTxt.Size = new System.Drawing.Size(246, 48);
            this.CostoTxt.SkipLiterals = true;
            this.CostoTxt.TabIndex = 23;
            this.CostoTxt.TabStop = false;
            this.CostoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CostoTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CostoTxt.TrailingIcon = null;
            this.CostoTxt.UseSystemPasswordChar = false;
            this.CostoTxt.ValidatingType = null;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 640);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.CostoTxt);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.SiteCB);
            this.Controls.Add(this.ColorCB);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.EstadoCB);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.NumSerieTxt);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.IMEITXT);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.ModeloCB);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.MarcaCB);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TipoProductoCB);
            this.Controls.Add(this.ControlesGB);
            this.Controls.Add(this.ActivoDGV);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActivoDGV)).EndInit();
            this.ControlesGB.ResumeLayout(false);
            this.ControlesGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ActivoDGV;
        private MaterialSkin.Controls.MaterialButton AgregarBtn;
        private MaterialSkin.Controls.MaterialButton ModificarBtn;
        private MaterialSkin.Controls.MaterialButton ElimarBtn;
        private MaterialSkin.Controls.MaterialButton ActualizarBtn;
        private System.Windows.Forms.GroupBox ControlesGB;
        private MaterialSkin.Controls.MaterialComboBox TipoProductoCB;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox MarcaCB;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox ModeloCB;
        private MaterialSkin.Controls.MaterialMaskedTextBox IMEITXT;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialMaskedTextBox NumSerieTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox EstadoCB;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox ColorCB;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox SiteCB;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialMaskedTextBox CostoTxt;
    }
}