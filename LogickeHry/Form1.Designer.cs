namespace LogickeHry
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PrihlaseniBox = new TableLayoutPanel();
            PrihlaseniUdajeBox = new TableLayoutPanel();
            PrihlaseniLJmeno = new Label();
            PrihlaseniTBJmeno = new TextBox();
            PrihlaseniLChHlaska = new Label();
            PrihlaseniTBHeslo = new TextBox();
            PrihlaseniLHeslo = new Label();
            PrihlaseniBPrihlaseni = new Button();
            UvodBox = new TableLayoutPanel();
            UvodTabulkaMenu = new TableLayoutPanel();
            UvodPopis = new Label();
            UvodButtonPrihlaseni = new Button();
            UvodButtonRegistrace = new Button();
            UvodButtonPreskocit = new Button();
            UvodObrazek = new PictureBox();
            UvodNazev = new Label();
            RegistraceBox = new TableLayoutPanel();
            RegistraceBRegistrovat = new Button();
            RegistraceUdajeBox = new TableLayoutPanel();
            RegistraceLJmeno = new Label();
            RegistraceLPohlavi = new Label();
            RegistraceLVek = new Label();
            RegistraceLHeslo = new Label();
            RegistraceTBJmeno = new TextBox();
            RegistraceTBHeslo = new TextBox();
            RegistraceCBPohlavi = new ComboBox();
            RegistraceCBVek = new ComboBox();
            RegistraceChHlaska = new Label();
            HlavniHlavicka = new TableLayoutPanel();
            HlavniLNazev = new Label();
            HlavniLPodnadpis = new Label();
            HlavniSProfil = new MenuStrip();
            ProfilBProfil = new ToolStripMenuItem();
            ProfilBPrihlaseni = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            ProfilBRegistrace = new ToolStripMenuItem();
            HlavniSMenu = new MenuStrip();
            MenuBMenu = new ToolStripMenuItem();
            MenuBHlavniStranka = new ToolStripMenuItem();
            MenuBStatistiky = new ToolStripMenuItem();
            MenuBNastaveni = new ToolStripMenuItem();
            prihlaseny = new CheckBox();
            ProfilLJmeno = new ToolStripLabel();
            ProfilLPohlavi = new ToolStripLabel();
            ProfilLVek = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            ProfilBNastaveni = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ProfilBOdhlasit = new ToolStripMenuItem();
            NastaveniBox = new TableLayoutPanel();
            NastaveniBUlozit = new Button();
            NastaveniTUdaje = new TableLayoutPanel();
            NastaveniLJmeno = new Label();
            NastaveniLPohlavi = new Label();
            NastaveniLVek = new Label();
            NastaveniLHeslo = new Label();
            NastaveniLChHlaska = new Label();
            NastaveniTBJmeno = new TextBox();
            NastaveniTBHeslo = new TextBox();
            NastaveniCBVek = new ComboBox();
            NastaveniCBPohlavi = new ComboBox();
            HlavniLMenu = new Label();
            PRHlavicka = new TableLayoutPanel();
            PRBZpet = new Button();
            PRLNazev = new Label();
            PRLPodnadpis = new Label();
            HlavniBox = new TableLayoutPanel();
            HlavniBLogik = new Button();
            HlavniBMiny = new Button();
            HlavniBLode = new Button();
            HlavniBSudoku = new Button();
            HraBox = new TableLayoutPanel();
            PrihlaseniBox.SuspendLayout();
            PrihlaseniUdajeBox.SuspendLayout();
            UvodBox.SuspendLayout();
            UvodTabulkaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UvodObrazek).BeginInit();
            RegistraceBox.SuspendLayout();
            RegistraceUdajeBox.SuspendLayout();
            HlavniHlavicka.SuspendLayout();
            HlavniSProfil.SuspendLayout();
            HlavniSMenu.SuspendLayout();
            NastaveniBox.SuspendLayout();
            NastaveniTUdaje.SuspendLayout();
            PRHlavicka.SuspendLayout();
            HlavniBox.SuspendLayout();
            SuspendLayout();
            // 
            // PrihlaseniBox
            // 
            PrihlaseniBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PrihlaseniBox.AutoSize = true;
            PrihlaseniBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PrihlaseniBox.ColumnCount = 5;
            PrihlaseniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            PrihlaseniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            PrihlaseniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.335556F));
            PrihlaseniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            PrihlaseniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            PrihlaseniBox.Controls.Add(PrihlaseniUdajeBox, 2, 0);
            PrihlaseniBox.Controls.Add(PrihlaseniBPrihlaseni, 2, 1);
            PrihlaseniBox.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            PrihlaseniBox.Location = new Point(0, 200);
            PrihlaseniBox.Name = "PrihlaseniBox";
            PrihlaseniBox.RowCount = 2;
            PrihlaseniBox.RowStyles.Add(new RowStyle());
            PrihlaseniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            PrihlaseniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PrihlaseniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PrihlaseniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PrihlaseniBox.Size = new Size(556, 246);
            PrihlaseniBox.TabIndex = 0;
            PrihlaseniBox.Visible = false;
            PrihlaseniBox.VisibleChanged += PrihlaseniBox_VisibleChanged;
            // 
            // PrihlaseniUdajeBox
            // 
            PrihlaseniUdajeBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PrihlaseniUdajeBox.ColumnCount = 1;
            PrihlaseniUdajeBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PrihlaseniUdajeBox.Controls.Add(PrihlaseniLJmeno, 0, 0);
            PrihlaseniUdajeBox.Controls.Add(PrihlaseniTBJmeno, 0, 1);
            PrihlaseniUdajeBox.Controls.Add(PrihlaseniLChHlaska, 0, 4);
            PrihlaseniUdajeBox.Controls.Add(PrihlaseniTBHeslo, 0, 3);
            PrihlaseniUdajeBox.Controls.Add(PrihlaseniLHeslo, 0, 2);
            PrihlaseniUdajeBox.Location = new Point(187, 3);
            PrihlaseniUdajeBox.Name = "PrihlaseniUdajeBox";
            PrihlaseniUdajeBox.RowCount = 5;
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            PrihlaseniUdajeBox.Size = new Size(179, 170);
            PrihlaseniUdajeBox.TabIndex = 8;
            // 
            // PrihlaseniLJmeno
            // 
            PrihlaseniLJmeno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PrihlaseniLJmeno.AutoSize = true;
            PrihlaseniLJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrihlaseniLJmeno.ImageAlign = ContentAlignment.BottomCenter;
            PrihlaseniLJmeno.Location = new Point(21, 0);
            PrihlaseniLJmeno.Name = "PrihlaseniLJmeno";
            PrihlaseniLJmeno.Size = new Size(137, 30);
            PrihlaseniLJmeno.TabIndex = 2;
            PrihlaseniLJmeno.Text = "Uživatelské jméno:";
            PrihlaseniLJmeno.TextAlign = ContentAlignment.BottomCenter;
            // 
            // PrihlaseniTBJmeno
            // 
            PrihlaseniTBJmeno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PrihlaseniTBJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrihlaseniTBJmeno.Location = new Point(3, 33);
            PrihlaseniTBJmeno.Name = "PrihlaseniTBJmeno";
            PrihlaseniTBJmeno.Size = new Size(173, 41);
            PrihlaseniTBJmeno.TabIndex = 4;
            PrihlaseniTBJmeno.TextAlign = HorizontalAlignment.Center;
            // 
            // PrihlaseniLChHlaska
            // 
            PrihlaseniLChHlaska.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PrihlaseniLChHlaska.AutoSize = true;
            PrihlaseniLChHlaska.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PrihlaseniLChHlaska.ForeColor = Color.IndianRed;
            PrihlaseniLChHlaska.Location = new Point(3, 144);
            PrihlaseniLChHlaska.Name = "PrihlaseniLChHlaska";
            PrihlaseniLChHlaska.Size = new Size(173, 26);
            PrihlaseniLChHlaska.TabIndex = 6;
            PrihlaseniLChHlaska.Text = "Chybné přihlašovací údaje.";
            PrihlaseniLChHlaska.TextAlign = ContentAlignment.TopCenter;
            // 
            // PrihlaseniTBHeslo
            // 
            PrihlaseniTBHeslo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PrihlaseniTBHeslo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrihlaseniTBHeslo.Location = new Point(3, 105);
            PrihlaseniTBHeslo.Name = "PrihlaseniTBHeslo";
            PrihlaseniTBHeslo.Size = new Size(173, 41);
            PrihlaseniTBHeslo.TabIndex = 5;
            PrihlaseniTBHeslo.TextAlign = HorizontalAlignment.Center;
            // 
            // PrihlaseniLHeslo
            // 
            PrihlaseniLHeslo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PrihlaseniLHeslo.AutoSize = true;
            PrihlaseniLHeslo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrihlaseniLHeslo.Location = new Point(3, 72);
            PrihlaseniLHeslo.Name = "PrihlaseniLHeslo";
            PrihlaseniLHeslo.Size = new Size(173, 30);
            PrihlaseniLHeslo.TabIndex = 3;
            PrihlaseniLHeslo.Text = "Heslo:";
            PrihlaseniLHeslo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // PrihlaseniBPrihlaseni
            // 
            PrihlaseniBPrihlaseni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PrihlaseniBPrihlaseni.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            PrihlaseniBPrihlaseni.Location = new Point(187, 179);
            PrihlaseniBPrihlaseni.Name = "PrihlaseniBPrihlaseni";
            PrihlaseniBPrihlaseni.Size = new Size(179, 64);
            PrihlaseniBPrihlaseni.TabIndex = 7;
            PrihlaseniBPrihlaseni.Text = "Přihlásit se";
            PrihlaseniBPrihlaseni.Click += PrihlaseniBPrihlaseni_Click;
            // 
            // UvodBox
            // 
            UvodBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UvodBox.AutoSize = true;
            UvodBox.ColumnCount = 2;
            UvodBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            UvodBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            UvodBox.Controls.Add(UvodTabulkaMenu, 1, 1);
            UvodBox.Controls.Add(UvodObrazek, 0, 1);
            UvodBox.Controls.Add(UvodNazev, 0, 0);
            UvodBox.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            UvodBox.Location = new Point(0, 0);
            UvodBox.Name = "UvodBox";
            UvodBox.Padding = new Padding(12);
            UvodBox.RowCount = 2;
            UvodBox.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            UvodBox.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            UvodBox.Size = new Size(1103, 700);
            UvodBox.TabIndex = 0;
            // 
            // UvodTabulkaMenu
            // 
            UvodTabulkaMenu.ColumnCount = 1;
            UvodTabulkaMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            UvodTabulkaMenu.Controls.Add(UvodPopis, 0, 0);
            UvodTabulkaMenu.Controls.Add(UvodButtonPrihlaseni, 0, 1);
            UvodTabulkaMenu.Controls.Add(UvodButtonRegistrace, 0, 2);
            UvodTabulkaMenu.Controls.Add(UvodButtonPreskocit, 0, 3);
            UvodTabulkaMenu.Dock = DockStyle.Fill;
            UvodTabulkaMenu.Location = new Point(554, 217);
            UvodTabulkaMenu.Name = "UvodTabulkaMenu";
            UvodTabulkaMenu.RowCount = 4;
            UvodTabulkaMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            UvodTabulkaMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            UvodTabulkaMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            UvodTabulkaMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            UvodTabulkaMenu.Size = new Size(534, 468);
            UvodTabulkaMenu.TabIndex = 1;
            // 
            // UvodPopis
            // 
            UvodPopis.AutoSize = true;
            UvodPopis.Dock = DockStyle.Fill;
            UvodPopis.Font = new Font("Segoe UI", 20F, FontStyle.Italic, GraphicsUnit.Point);
            UvodPopis.Location = new Point(3, 0);
            UvodPopis.Name = "UvodPopis";
            UvodPopis.Size = new Size(528, 187);
            UvodPopis.TabIndex = 0;
            UvodPopis.Text = "Pojď si s naší aplikací procvičit mozek!";
            UvodPopis.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UvodButtonPrihlaseni
            // 
            UvodButtonPrihlaseni.Dock = DockStyle.Fill;
            UvodButtonPrihlaseni.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            UvodButtonPrihlaseni.Location = new Point(3, 190);
            UvodButtonPrihlaseni.Name = "UvodButtonPrihlaseni";
            UvodButtonPrihlaseni.Size = new Size(528, 87);
            UvodButtonPrihlaseni.TabIndex = 1;
            UvodButtonPrihlaseni.Text = "Přihlásit se";
            UvodButtonPrihlaseni.Click += ButtonPrihlaseni_Click;
            // 
            // UvodButtonRegistrace
            // 
            UvodButtonRegistrace.Dock = DockStyle.Fill;
            UvodButtonRegistrace.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            UvodButtonRegistrace.Location = new Point(3, 283);
            UvodButtonRegistrace.Name = "UvodButtonRegistrace";
            UvodButtonRegistrace.Size = new Size(528, 87);
            UvodButtonRegistrace.TabIndex = 2;
            UvodButtonRegistrace.Text = "Zaregistrovat se";
            UvodButtonRegistrace.Click += ButtonRegistrace_Click;
            // 
            // UvodButtonPreskocit
            // 
            UvodButtonPreskocit.Dock = DockStyle.Fill;
            UvodButtonPreskocit.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            UvodButtonPreskocit.Location = new Point(3, 376);
            UvodButtonPreskocit.Name = "UvodButtonPreskocit";
            UvodButtonPreskocit.Size = new Size(528, 89);
            UvodButtonPreskocit.TabIndex = 3;
            UvodButtonPreskocit.Text = "Pokračovat bez příhlášení";
            UvodButtonPreskocit.Click += UvodButtonPreskocit_Click;
            // 
            // UvodObrazek
            // 
            UvodObrazek.Dock = DockStyle.Fill;
            UvodObrazek.Image = Properties.Resources.UvodObrazek;
            UvodObrazek.Location = new Point(15, 217);
            UvodObrazek.Name = "UvodObrazek";
            UvodObrazek.Size = new Size(533, 468);
            UvodObrazek.SizeMode = PictureBoxSizeMode.StretchImage;
            UvodObrazek.TabIndex = 2;
            UvodObrazek.TabStop = false;
            // 
            // UvodNazev
            // 
            UvodNazev.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UvodNazev.AutoSize = true;
            UvodBox.SetColumnSpan(UvodNazev, 2);
            UvodNazev.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            UvodNazev.Location = new Point(15, 12);
            UvodNazev.Name = "UvodNazev";
            UvodNazev.Size = new Size(1073, 202);
            UvodNazev.TabIndex = 0;
            UvodNazev.Text = "Tělocvična pro mozek \U0001f9e0";
            UvodNazev.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistraceBox
            // 
            RegistraceBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceBox.AutoSize = true;
            RegistraceBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RegistraceBox.ColumnCount = 5;
            RegistraceBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.0009995F));
            RegistraceBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            RegistraceBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3355522F));
            RegistraceBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            RegistraceBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.0010014F));
            RegistraceBox.Controls.Add(RegistraceBRegistrovat, 2, 1);
            RegistraceBox.Controls.Add(RegistraceUdajeBox, 2, 0);
            RegistraceBox.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            RegistraceBox.Location = new Point(0, 200);
            RegistraceBox.Name = "RegistraceBox";
            RegistraceBox.RowCount = 2;
            RegistraceBox.RowStyles.Add(new RowStyle());
            RegistraceBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            RegistraceBox.Size = new Size(556, 799);
            RegistraceBox.TabIndex = 0;
            RegistraceBox.Visible = false;
            RegistraceBox.VisibleChanged += RegistraceBox_VisibleChanged;
            // 
            // RegistraceBRegistrovat
            // 
            RegistraceBRegistrovat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceBRegistrovat.FlatStyle = FlatStyle.System;
            RegistraceBRegistrovat.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceBRegistrovat.Location = new Point(187, 732);
            RegistraceBRegistrovat.Name = "RegistraceBRegistrovat";
            RegistraceBRegistrovat.Size = new Size(179, 64);
            RegistraceBRegistrovat.TabIndex = 13;
            RegistraceBRegistrovat.Text = "Registrovat";
            RegistraceBRegistrovat.Click += RegistraceBRegistrovat_Click;
            // 
            // RegistraceUdajeBox
            // 
            RegistraceUdajeBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceUdajeBox.AutoSize = true;
            RegistraceUdajeBox.ColumnCount = 1;
            RegistraceUdajeBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            RegistraceUdajeBox.Controls.Add(RegistraceLJmeno, 0, 0);
            RegistraceUdajeBox.Controls.Add(RegistraceLPohlavi, 0, 2);
            RegistraceUdajeBox.Controls.Add(RegistraceLVek, 0, 4);
            RegistraceUdajeBox.Controls.Add(RegistraceLHeslo, 0, 6);
            RegistraceUdajeBox.Controls.Add(RegistraceTBJmeno, 0, 1);
            RegistraceUdajeBox.Controls.Add(RegistraceTBHeslo, 0, 7);
            RegistraceUdajeBox.Controls.Add(RegistraceCBPohlavi, 0, 3);
            RegistraceUdajeBox.Controls.Add(RegistraceCBVek, 0, 5);
            RegistraceUdajeBox.Controls.Add(RegistraceChHlaska, 0, 8);
            RegistraceUdajeBox.ForeColor = SystemColors.ActiveCaptionText;
            RegistraceUdajeBox.Location = new Point(187, 3);
            RegistraceUdajeBox.Name = "RegistraceUdajeBox";
            RegistraceUdajeBox.RowCount = 9;
            RegistraceUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 9.677421F));
            RegistraceUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4408607F));
            RegistraceUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 9.677421F));
            RegistraceUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4408607F));
            RegistraceUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 9.677421F));
            RegistraceUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4408607F));
            RegistraceUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 9.677421F));
            RegistraceUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4408607F));
            RegistraceUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 7.526882F));
            RegistraceUdajeBox.Size = new Size(179, 723);
            RegistraceUdajeBox.TabIndex = 14;
            // 
            // RegistraceLJmeno
            // 
            RegistraceLJmeno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceLJmeno.AutoSize = true;
            RegistraceLJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceLJmeno.Location = new Point(3, 0);
            RegistraceLJmeno.Name = "RegistraceLJmeno";
            RegistraceLJmeno.Size = new Size(173, 69);
            RegistraceLJmeno.TabIndex = 0;
            RegistraceLJmeno.Text = "Uživatelské jméno:";
            RegistraceLJmeno.TextAlign = ContentAlignment.BottomCenter;
            // 
            // RegistraceLPohlavi
            // 
            RegistraceLPohlavi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceLPohlavi.AutoSize = true;
            RegistraceLPohlavi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceLPohlavi.Location = new Point(3, 166);
            RegistraceLPohlavi.Name = "RegistraceLPohlavi";
            RegistraceLPohlavi.Size = new Size(173, 69);
            RegistraceLPohlavi.TabIndex = 1;
            RegistraceLPohlavi.Text = "Pohlaví:";
            RegistraceLPohlavi.TextAlign = ContentAlignment.BottomCenter;
            // 
            // RegistraceLVek
            // 
            RegistraceLVek.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceLVek.AutoSize = true;
            RegistraceLVek.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceLVek.Location = new Point(3, 332);
            RegistraceLVek.Name = "RegistraceLVek";
            RegistraceLVek.Size = new Size(173, 69);
            RegistraceLVek.TabIndex = 2;
            RegistraceLVek.Text = "Věk:";
            RegistraceLVek.TextAlign = ContentAlignment.BottomCenter;
            // 
            // RegistraceLHeslo
            // 
            RegistraceLHeslo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceLHeslo.AutoSize = true;
            RegistraceLHeslo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceLHeslo.Location = new Point(3, 498);
            RegistraceLHeslo.Name = "RegistraceLHeslo";
            RegistraceLHeslo.Size = new Size(173, 69);
            RegistraceLHeslo.TabIndex = 3;
            RegistraceLHeslo.Text = "Heslo:";
            RegistraceLHeslo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // RegistraceTBJmeno
            // 
            RegistraceTBJmeno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceTBJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceTBJmeno.Location = new Point(3, 72);
            RegistraceTBJmeno.Name = "RegistraceTBJmeno";
            RegistraceTBJmeno.Size = new Size(173, 41);
            RegistraceTBJmeno.TabIndex = 4;
            // 
            // RegistraceTBHeslo
            // 
            RegistraceTBHeslo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceTBHeslo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceTBHeslo.Location = new Point(3, 570);
            RegistraceTBHeslo.Name = "RegistraceTBHeslo";
            RegistraceTBHeslo.Size = new Size(173, 41);
            RegistraceTBHeslo.TabIndex = 5;
            // 
            // RegistraceCBPohlavi
            // 
            RegistraceCBPohlavi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceCBPohlavi.DropDownStyle = ComboBoxStyle.DropDownList;
            RegistraceCBPohlavi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceCBPohlavi.FormattingEnabled = true;
            RegistraceCBPohlavi.Items.AddRange(new object[] { "Muž", "Žena", "Jiné" });
            RegistraceCBPohlavi.Location = new Point(3, 238);
            RegistraceCBPohlavi.Name = "RegistraceCBPohlavi";
            RegistraceCBPohlavi.Size = new Size(173, 43);
            RegistraceCBPohlavi.TabIndex = 6;
            // 
            // RegistraceCBVek
            // 
            RegistraceCBVek.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceCBVek.DropDownStyle = ComboBoxStyle.DropDownList;
            RegistraceCBVek.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceCBVek.FormattingEnabled = true;
            RegistraceCBVek.Items.AddRange(new object[] { "0-10", "11-20", "21-30", "31-40", "41-50", "51-60", "61-70", "70+" });
            RegistraceCBVek.Location = new Point(3, 404);
            RegistraceCBVek.Name = "RegistraceCBVek";
            RegistraceCBVek.Size = new Size(173, 43);
            RegistraceCBVek.TabIndex = 7;
            // 
            // RegistraceChHlaska
            // 
            RegistraceChHlaska.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceChHlaska.AutoSize = true;
            RegistraceChHlaska.ForeColor = Color.IndianRed;
            RegistraceChHlaska.Location = new Point(3, 664);
            RegistraceChHlaska.Name = "RegistraceChHlaska";
            RegistraceChHlaska.Size = new Size(173, 59);
            RegistraceChHlaska.TabIndex = 8;
            RegistraceChHlaska.Text = "Uživatelské jméno již existuje.";
            RegistraceChHlaska.TextAlign = ContentAlignment.TopCenter;
            // 
            // HlavniHlavicka
            // 
            HlavniHlavicka.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            HlavniHlavicka.AutoSize = true;
            HlavniHlavicka.ColumnCount = 5;
            HlavniHlavicka.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.04838F));
            HlavniHlavicka.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2446327F));
            HlavniHlavicka.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3534927F));
            HlavniHlavicka.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.34292F));
            HlavniHlavicka.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.0105715F));
            HlavniHlavicka.Controls.Add(HlavniLNazev, 0, 0);
            HlavniHlavicka.Controls.Add(HlavniLPodnadpis, 2, 1);
            HlavniHlavicka.Controls.Add(HlavniSProfil, 4, 0);
            HlavniHlavicka.Controls.Add(HlavniSMenu, 0, 1);
            HlavniHlavicka.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            HlavniHlavicka.Location = new Point(0, 0);
            HlavniHlavicka.Name = "HlavniHlavicka";
            HlavniHlavicka.RowCount = 3;
            HlavniHlavicka.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            HlavniHlavicka.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            HlavniHlavicka.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            HlavniHlavicka.Size = new Size(1101, 200);
            HlavniHlavicka.TabIndex = 1;
            HlavniHlavicka.Tag = "";
            HlavniHlavicka.Visible = false;
            // 
            // HlavniLNazev
            // 
            HlavniLNazev.AutoSize = true;
            HlavniHlavicka.SetColumnSpan(HlavniLNazev, 4);
            HlavniLNazev.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            HlavniLNazev.Location = new Point(3, 0);
            HlavniLNazev.Name = "HlavniLNazev";
            HlavniLNazev.Size = new Size(745, 81);
            HlavniLNazev.TabIndex = 0;
            HlavniLNazev.Text = "Tělocvična pro mozek \U0001f9e0";
            // 
            // HlavniLPodnadpis
            // 
            HlavniLPodnadpis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HlavniLPodnadpis.AutoSize = true;
            HlavniLPodnadpis.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            HlavniLPodnadpis.Location = new Point(368, 90);
            HlavniLPodnadpis.Name = "HlavniLPodnadpis";
            HlavniLPodnadpis.Size = new Size(361, 70);
            HlavniLPodnadpis.TabIndex = 1;
            HlavniLPodnadpis.Text = "Hlavní stránka";
            HlavniLPodnadpis.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HlavniSProfil
            // 
            HlavniSProfil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HlavniSProfil.Dock = DockStyle.None;
            HlavniSProfil.ImageScalingSize = new Size(20, 20);
            HlavniSProfil.Items.AddRange(new ToolStripItem[] { ProfilBProfil });
            HlavniSProfil.Location = new Point(933, 0);
            HlavniSProfil.Name = "HlavniSProfil";
            HlavniHlavicka.SetRowSpan(HlavniSProfil, 2);
            HlavniSProfil.Size = new Size(168, 160);
            HlavniSProfil.TabIndex = 15;
            HlavniSProfil.Text = "HlavniSProfil";
            // 
            // ProfilBProfil
            // 
            ProfilBProfil.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ProfilBProfil.DropDownItems.AddRange(new ToolStripItem[] { ProfilBPrihlaseni, toolStripSeparator3, ProfilBRegistrace });
            ProfilBProfil.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ProfilBProfil.Name = "ProfilBProfil";
            ProfilBProfil.Overflow = ToolStripItemOverflow.AsNeeded;
            ProfilBProfil.Size = new Size(153, 156);
            ProfilBProfil.Text = "👤 \n Jméno Uživatele";
            // 
            // ProfilBPrihlaseni
            // 
            ProfilBPrihlaseni.Alignment = ToolStripItemAlignment.Right;
            ProfilBPrihlaseni.Name = "ProfilBPrihlaseni";
            ProfilBPrihlaseni.Size = new Size(175, 28);
            ProfilBPrihlaseni.Text = "Přihlásit se";
            ProfilBPrihlaseni.Click += ButtonPrihlaseni_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(172, 6);
            // 
            // ProfilBRegistrace
            // 
            ProfilBRegistrace.Alignment = ToolStripItemAlignment.Right;
            ProfilBRegistrace.Name = "ProfilBRegistrace";
            ProfilBRegistrace.Size = new Size(175, 28);
            ProfilBRegistrace.Text = "Registrace";
            ProfilBRegistrace.Click += ButtonRegistrace_Click;
            // 
            // HlavniSMenu
            // 
            HlavniSMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HlavniSMenu.Dock = DockStyle.None;
            HlavniSMenu.ImageScalingSize = new Size(20, 20);
            HlavniSMenu.Items.AddRange(new ToolStripItem[] { MenuBMenu });
            HlavniSMenu.Location = new Point(0, 90);
            HlavniSMenu.Name = "HlavniSMenu";
            HlavniSMenu.Size = new Size(220, 70);
            HlavniSMenu.TabIndex = 14;
            HlavniSMenu.Text = "menuStrip1";
            // 
            // MenuBMenu
            // 
            MenuBMenu.DropDownItems.AddRange(new ToolStripItem[] { MenuBHlavniStranka, MenuBStatistiky, MenuBNastaveni });
            MenuBMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MenuBMenu.Name = "MenuBMenu";
            MenuBMenu.Size = new Size(161, 66);
            MenuBMenu.Text = "☰ Menu";
            // 
            // MenuBHlavniStranka
            // 
            MenuBHlavniStranka.Name = "MenuBHlavniStranka";
            MenuBHlavniStranka.Size = new Size(323, 50);
            MenuBHlavniStranka.Text = "Hlavní stránka";
            MenuBHlavniStranka.Click += ButtonHlavniStranka_Click;
            // 
            // MenuBStatistiky
            // 
            MenuBStatistiky.Name = "MenuBStatistiky";
            MenuBStatistiky.Size = new Size(323, 50);
            MenuBStatistiky.Text = "Statistiky";
            // 
            // MenuBNastaveni
            // 
            MenuBNastaveni.Name = "MenuBNastaveni";
            MenuBNastaveni.Size = new Size(323, 50);
            MenuBNastaveni.Text = "⚙ Nastavení";
            MenuBNastaveni.Click += ButtonNastaveni_Click;
            // 
            // prihlaseny
            // 
            prihlaseny.AutoSize = true;
            prihlaseny.Location = new Point(370, 163);
            prihlaseny.Name = "prihlaseny";
            prihlaseny.Size = new Size(140, 24);
            prihlaseny.TabIndex = 16;
            prihlaseny.Text = "jsem prihlaseny?";
            prihlaseny.UseVisualStyleBackColor = true;
            prihlaseny.CheckedChanged += prihlaseny_CheckedChanged;
            // 
            // ProfilLJmeno
            // 
            ProfilLJmeno.Name = "ProfilLJmeno";
            ProfilLJmeno.Size = new Size(115, 20);
            ProfilLJmeno.Text = "Jméno uživatele";
            // 
            // ProfilLPohlavi
            // 
            ProfilLPohlavi.Name = "ProfilLPohlavi";
            ProfilLPohlavi.Size = new Size(42, 20);
            ProfilLPohlavi.Text = "Žena";
            // 
            // ProfilLVek
            // 
            ProfilLVek.Name = "ProfilLVek";
            ProfilLVek.Size = new Size(32, 20);
            ProfilLVek.Text = "Vek";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(186, 6);
            // 
            // ProfilBNastaveni
            // 
            ProfilBNastaveni.Name = "ProfilBNastaveni";
            ProfilBNastaveni.Size = new Size(189, 26);
            ProfilBNastaveni.Text = "⚙ Nastavení";
            ProfilBNastaveni.Click += ButtonNastaveni_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(186, 6);
            // 
            // ProfilBOdhlasit
            // 
            ProfilBOdhlasit.Name = "ProfilBOdhlasit";
            ProfilBOdhlasit.Size = new Size(189, 26);
            ProfilBOdhlasit.Text = "⇥𝨔 Odhlásit se";
            ProfilBOdhlasit.Click += ButtonOdhlaseni_Click;
            // 
            // NastaveniBox
            // 
            NastaveniBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniBox.AutoSize = true;
            NastaveniBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NastaveniBox.ColumnCount = 5;
            NastaveniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            NastaveniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            NastaveniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.335556F));
            NastaveniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.33122F));
            NastaveniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            NastaveniBox.Controls.Add(NastaveniBUlozit, 2, 1);
            NastaveniBox.Controls.Add(NastaveniTUdaje, 2, 0);
            NastaveniBox.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            NastaveniBox.Location = new Point(0, 200);
            NastaveniBox.Name = "NastaveniBox";
            NastaveniBox.RowCount = 2;
            NastaveniBox.RowStyles.Add(new RowStyle());
            NastaveniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            NastaveniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            NastaveniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            NastaveniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            NastaveniBox.Size = new Size(556, 463);
            NastaveniBox.TabIndex = 0;
            NastaveniBox.Visible = false;
            NastaveniBox.VisibleChanged += NastaveniBox_VisibleChanged;
            // 
            // NastaveniBUlozit
            // 
            NastaveniBUlozit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniBUlozit.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniBUlozit.Location = new Point(187, 396);
            NastaveniBUlozit.Name = "NastaveniBUlozit";
            NastaveniBUlozit.Size = new Size(179, 64);
            NastaveniBUlozit.TabIndex = 2;
            NastaveniBUlozit.Text = "Uložit";
            NastaveniBUlozit.UseVisualStyleBackColor = true;
            // 
            // NastaveniTUdaje
            // 
            NastaveniTUdaje.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniTUdaje.AutoSize = true;
            NastaveniTUdaje.ColumnCount = 1;
            NastaveniTUdaje.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            NastaveniTUdaje.Controls.Add(NastaveniLJmeno, 0, 0);
            NastaveniTUdaje.Controls.Add(NastaveniLPohlavi, 0, 2);
            NastaveniTUdaje.Controls.Add(NastaveniLVek, 0, 4);
            NastaveniTUdaje.Controls.Add(NastaveniLHeslo, 0, 6);
            NastaveniTUdaje.Controls.Add(NastaveniLChHlaska, 0, 8);
            NastaveniTUdaje.Controls.Add(NastaveniTBJmeno, 0, 1);
            NastaveniTUdaje.Controls.Add(NastaveniTBHeslo, 0, 7);
            NastaveniTUdaje.Controls.Add(NastaveniCBVek, 0, 5);
            NastaveniTUdaje.Controls.Add(NastaveniCBPohlavi, 0, 3);
            NastaveniTUdaje.Location = new Point(187, 3);
            NastaveniTUdaje.Name = "NastaveniTUdaje";
            NastaveniTUdaje.RowCount = 9;
            NastaveniTUdaje.RowStyles.Add(new RowStyle());
            NastaveniTUdaje.RowStyles.Add(new RowStyle());
            NastaveniTUdaje.RowStyles.Add(new RowStyle());
            NastaveniTUdaje.RowStyles.Add(new RowStyle());
            NastaveniTUdaje.RowStyles.Add(new RowStyle());
            NastaveniTUdaje.RowStyles.Add(new RowStyle());
            NastaveniTUdaje.RowStyles.Add(new RowStyle());
            NastaveniTUdaje.RowStyles.Add(new RowStyle());
            NastaveniTUdaje.RowStyles.Add(new RowStyle());
            NastaveniTUdaje.Size = new Size(179, 387);
            NastaveniTUdaje.TabIndex = 3;
            // 
            // NastaveniLJmeno
            // 
            NastaveniLJmeno.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniLJmeno.AutoSize = true;
            NastaveniLJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniLJmeno.Location = new Point(3, 0);
            NastaveniLJmeno.Name = "NastaveniLJmeno";
            NastaveniLJmeno.Size = new Size(173, 70);
            NastaveniLJmeno.TabIndex = 0;
            NastaveniLJmeno.Text = "Uživatelské jméno:";
            NastaveniLJmeno.TextAlign = ContentAlignment.BottomCenter;
            // 
            // NastaveniLPohlavi
            // 
            NastaveniLPohlavi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniLPohlavi.AutoSize = true;
            NastaveniLPohlavi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniLPohlavi.Location = new Point(3, 117);
            NastaveniLPohlavi.Name = "NastaveniLPohlavi";
            NastaveniLPohlavi.Size = new Size(173, 35);
            NastaveniLPohlavi.TabIndex = 5;
            NastaveniLPohlavi.Text = "Pohlaví:";
            NastaveniLPohlavi.TextAlign = ContentAlignment.BottomCenter;
            // 
            // NastaveniLVek
            // 
            NastaveniLVek.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniLVek.AutoSize = true;
            NastaveniLVek.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniLVek.Location = new Point(3, 201);
            NastaveniLVek.Name = "NastaveniLVek";
            NastaveniLVek.Size = new Size(173, 35);
            NastaveniLVek.TabIndex = 6;
            NastaveniLVek.Text = "Věk:";
            NastaveniLVek.TextAlign = ContentAlignment.BottomCenter;
            // 
            // NastaveniLHeslo
            // 
            NastaveniLHeslo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniLHeslo.AutoSize = true;
            NastaveniLHeslo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniLHeslo.Location = new Point(3, 285);
            NastaveniLHeslo.Name = "NastaveniLHeslo";
            NastaveniLHeslo.Size = new Size(173, 35);
            NastaveniLHeslo.TabIndex = 7;
            NastaveniLHeslo.Text = "Heslo:";
            NastaveniLHeslo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // NastaveniLChHlaska
            // 
            NastaveniLChHlaska.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniLChHlaska.AutoSize = true;
            NastaveniLChHlaska.Location = new Point(3, 367);
            NastaveniLChHlaska.Name = "NastaveniLChHlaska";
            NastaveniLChHlaska.Size = new Size(173, 20);
            NastaveniLChHlaska.TabIndex = 8;
            NastaveniLChHlaska.Text = "Chybová hláška.";
            NastaveniLChHlaska.TextAlign = ContentAlignment.TopCenter;
            // 
            // NastaveniTBJmeno
            // 
            NastaveniTBJmeno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniTBJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniTBJmeno.Location = new Point(3, 73);
            NastaveniTBJmeno.Name = "NastaveniTBJmeno";
            NastaveniTBJmeno.Size = new Size(173, 41);
            NastaveniTBJmeno.TabIndex = 9;
            // 
            // NastaveniTBHeslo
            // 
            NastaveniTBHeslo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniTBHeslo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniTBHeslo.Location = new Point(3, 323);
            NastaveniTBHeslo.Name = "NastaveniTBHeslo";
            NastaveniTBHeslo.Size = new Size(173, 41);
            NastaveniTBHeslo.TabIndex = 10;
            // 
            // NastaveniCBVek
            // 
            NastaveniCBVek.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniCBVek.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniCBVek.FormattingEnabled = true;
            NastaveniCBVek.Items.AddRange(new object[] { "0-10", "11-20", "21-30", "31-40", "41-50", "51-60", "61-70", "70+" });
            NastaveniCBVek.Location = new Point(3, 239);
            NastaveniCBVek.Name = "NastaveniCBVek";
            NastaveniCBVek.Size = new Size(173, 43);
            NastaveniCBVek.Sorted = true;
            NastaveniCBVek.TabIndex = 11;
            // 
            // NastaveniCBPohlavi
            // 
            NastaveniCBPohlavi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniCBPohlavi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniCBPohlavi.FormattingEnabled = true;
            NastaveniCBPohlavi.Items.AddRange(new object[] { "Muž", "Žena", "Jiné" });
            NastaveniCBPohlavi.Location = new Point(3, 155);
            NastaveniCBPohlavi.Name = "NastaveniCBPohlavi";
            NastaveniCBPohlavi.Size = new Size(173, 43);
            NastaveniCBPohlavi.TabIndex = 12;
            // 
            // HlavniLMenu
            // 
            HlavniLMenu.Location = new Point(0, 0);
            HlavniLMenu.Name = "HlavniLMenu";
            HlavniLMenu.Size = new Size(100, 23);
            HlavniLMenu.TabIndex = 0;
            // 
            // PRHlavicka
            // 
            PRHlavicka.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PRHlavicka.AutoSize = true;
            PRHlavicka.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PRHlavicka.ColumnCount = 5;
            PRHlavicka.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.0010023F));
            PRHlavicka.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312244F));
            PRHlavicka.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.335556F));
            PRHlavicka.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312244F));
            PRHlavicka.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.0010023F));
            PRHlavicka.Controls.Add(PRBZpet, 0, 1);
            PRHlavicka.Controls.Add(PRLNazev, 0, 0);
            PRHlavicka.Controls.Add(PRLPodnadpis, 1, 1);
            PRHlavicka.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            PRHlavicka.Location = new Point(0, 0);
            PRHlavicka.Name = "PRHlavicka";
            PRHlavicka.RowCount = 3;
            PRHlavicka.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            PRHlavicka.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            PRHlavicka.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            PRHlavicka.Size = new Size(559, 200);
            PRHlavicka.TabIndex = 2;
            PRHlavicka.Visible = false;
            // 
            // PRBZpet
            // 
            PRBZpet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PRBZpet.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            PRBZpet.Location = new Point(3, 93);
            PRBZpet.Name = "PRBZpet";
            PRBZpet.Size = new Size(77, 64);
            PRBZpet.TabIndex = 9;
            PRBZpet.Text = "🢠";
            PRBZpet.Click += PRBZpet_Click;
            // 
            // PRLNazev
            // 
            PRLNazev.AutoSize = true;
            PRHlavicka.SetColumnSpan(PRLNazev, 5);
            PRLNazev.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            PRLNazev.Location = new Point(3, 0);
            PRLNazev.Name = "PRLNazev";
            PRLNazev.Size = new Size(459, 90);
            PRLNazev.TabIndex = 11;
            PRLNazev.Text = "Tělocvična pro mozek \U0001f9e0";
            // 
            // PRLPodnadpis
            // 
            PRLPodnadpis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PRLPodnadpis.AutoSize = true;
            PRHlavicka.SetColumnSpan(PRLPodnadpis, 3);
            PRLPodnadpis.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            PRLPodnadpis.Location = new Point(86, 90);
            PRLPodnadpis.Name = "PRLPodnadpis";
            PRLPodnadpis.Size = new Size(384, 67);
            PRLPodnadpis.TabIndex = 12;
            PRLPodnadpis.Text = "Registrace";
            PRLPodnadpis.TextAlign = ContentAlignment.TopCenter;
            // 
            // HlavniBox
            // 
            HlavniBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            HlavniBox.AutoSize = true;
            HlavniBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            HlavniBox.ColumnCount = 5;
            HlavniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            HlavniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            HlavniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.335556F));
            HlavniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            HlavniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            HlavniBox.Controls.Add(HlavniBLogik, 0, 1);
            HlavniBox.Controls.Add(HlavniBMiny, 1, 1);
            HlavniBox.Controls.Add(HlavniBLode, 2, 1);
            HlavniBox.Controls.Add(HlavniBSudoku, 3, 1);
            HlavniBox.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            HlavniBox.Location = new Point(0, 200);
            HlavniBox.Name = "HlavniBox";
            HlavniBox.RowCount = 2;
            HlavniBox.RowStyles.Add(new RowStyle());
            HlavniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            HlavniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            HlavniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            HlavniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            HlavniBox.Size = new Size(556, 70);
            HlavniBox.TabIndex = 3;
            HlavniBox.Visible = false;
            HlavniBox.VisibleChanged += HlavniBox_VisibleChanged;
            // 
            // HlavniBLogik
            // 
            HlavniBLogik.Location = new Point(3, 3);
            HlavniBLogik.Name = "HlavniBLogik";
            HlavniBLogik.Size = new Size(77, 29);
            HlavniBLogik.TabIndex = 0;
            HlavniBLogik.Text = "Logik";
            HlavniBLogik.UseVisualStyleBackColor = true;
            HlavniBLogik.Click += HlavniBLogik_Click;
            // 
            // HlavniBMiny
            // 
            HlavniBMiny.Location = new Point(86, 3);
            HlavniBMiny.Name = "HlavniBMiny";
            HlavniBMiny.Size = new Size(94, 29);
            HlavniBMiny.TabIndex = 1;
            HlavniBMiny.Text = "Miny";
            HlavniBMiny.UseVisualStyleBackColor = true;
            HlavniBMiny.Click += HlavniBMiny_Click;
            // 
            // HlavniBLode
            // 
            HlavniBLode.Location = new Point(187, 3);
            HlavniBLode.Name = "HlavniBLode";
            HlavniBLode.Size = new Size(94, 29);
            HlavniBLode.TabIndex = 2;
            HlavniBLode.Text = "Lode";
            HlavniBLode.UseVisualStyleBackColor = true;
            // 
            // HlavniBSudoku
            // 
            HlavniBSudoku.Location = new Point(372, 3);
            HlavniBSudoku.Name = "HlavniBSudoku";
            HlavniBSudoku.Size = new Size(94, 29);
            HlavniBSudoku.TabIndex = 3;
            HlavniBSudoku.Text = "Sudoku";
            HlavniBSudoku.UseVisualStyleBackColor = true;
            HlavniBSudoku.Click += HlavniBSudoku_Click;
            // 
            // HraBox
            // 
            HraBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HraBox.AutoSize = true;
            HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            HraBox.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            HraBox.Location = new Point(0, 200);
            HraBox.Name = "HraBox";
            HraBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            HraBox.Size = new Size(1101, 500);
            HraBox.TabIndex = 10;
            HraBox.Visible = false;
            HraBox.VisibleChanged += HraBox_VisibleChanged;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1103, 700);
            Controls.Add(UvodBox);
            Controls.Add(HlavniBox);
            Controls.Add(HraBox);
            Controls.Add(HlavniHlavicka);
            Controls.Add(PRHlavicka);
            Controls.Add(NastaveniBox);
            Controls.Add(RegistraceBox);
            Controls.Add(PrihlaseniBox);
            MainMenuStrip = HlavniSMenu;
            Name = "GameForm";
            Text = "Multiherní aplikace";
            PrihlaseniBox.ResumeLayout(false);
            PrihlaseniUdajeBox.ResumeLayout(false);
            PrihlaseniUdajeBox.PerformLayout();
            UvodBox.ResumeLayout(false);
            UvodBox.PerformLayout();
            UvodTabulkaMenu.ResumeLayout(false);
            UvodTabulkaMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UvodObrazek).EndInit();
            RegistraceBox.ResumeLayout(false);
            RegistraceBox.PerformLayout();
            RegistraceUdajeBox.ResumeLayout(false);
            RegistraceUdajeBox.PerformLayout();
            HlavniHlavicka.ResumeLayout(false);
            HlavniHlavicka.PerformLayout();
            HlavniSProfil.ResumeLayout(false);
            HlavniSProfil.PerformLayout();
            HlavniSMenu.ResumeLayout(false);
            HlavniSMenu.PerformLayout();
            NastaveniBox.ResumeLayout(false);
            NastaveniBox.PerformLayout();
            NastaveniTUdaje.ResumeLayout(false);
            NastaveniTUdaje.PerformLayout();
            PRHlavicka.ResumeLayout(false);
            PRHlavicka.PerformLayout();
            HlavniBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel UvodBox;
        private Label UvodNazev;
        private TableLayoutPanel UvodTabulkaMenu;
        private Label UvodPopis;
        private Button UvodButtonPrihlaseni;
        private Button UvodButtonRegistrace;
        private Button UvodButtonPreskocit;
        private PictureBox UvodObrazek;
        private TableLayoutPanel PrihlaseniBox;
        private Button PrihlaseniBPrihlaseni;
        private TableLayoutPanel PrihlaseniUdajeBox;
        private Label PrihlaseniLJmeno;
        private TextBox PrihlaseniTBJmeno;
        private Label PrihlaseniLChHlaska;
        private TextBox PrihlaseniTBHeslo;
        private Label PrihlaseniLHeslo;
        private TableLayoutPanel RegistraceBox;
        private Button RegistraceBRegistrovat;
        private TableLayoutPanel RegistraceUdajeBox;
        private Label RegistraceLJmeno;
        private Label RegistraceLPohlavi;
        private Label RegistraceLVek;
        private Label RegistraceLHeslo;
        private TextBox RegistraceTBJmeno;
        private TextBox RegistraceTBHeslo;
        private ComboBox RegistraceCBPohlavi;
        private ComboBox RegistraceCBVek;
        private TableLayoutPanel HlavniHlavicka;
        private Label RegistraceChHlaska;
        private Label HlavniLNazev;
        private Label HlavniLPodnadpis;
        private TableLayoutPanel NastaveniBox;
        private Button NastaveniBUlozit;
        private TableLayoutPanel NastaveniTUdaje;
        private Label NastaveniLJmeno;
        private Label NastaveniLPohlavi;
        private Label NastaveniLVek;
        private Label NastaveniLHeslo;
        private Label NastaveniLChHlaska;
        private TextBox NastaveniTBJmeno;
        private TextBox NastaveniTBHeslo;
        private ComboBox NastaveniCBVek;
        private ComboBox NastaveniCBPohlavi;
        private MenuStrip HlavniSMenu;
        private ToolStripMenuItem MenuBMenu;
        private ToolStripMenuItem MenuBHlavniStranka;
        private ToolStripMenuItem MenuBStatistiky;
        private ToolStripMenuItem MenuBNastaveni;
        private Label HlavniLMenu;
        private MenuStrip HlavniSProfil;
        private ToolStripMenuItem ProfilBProfil;
        private ToolStripLabel ProfilLJmeno;
        private ToolStripMenuItem ProfilBNastaveni;
        private ToolStripMenuItem ProfilBPrihlaseni;
        private ToolStripMenuItem ProfilBRegistrace;
        private TableLayoutPanel PRHlavicka;
        private Button PRBZpet;
        private Label PRLNazev;
        private Label PRLPodnadpis;
        private ToolStripLabel ProfilLPohlavi;
        private ToolStripLabel ProfilLVek;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem ProfilBOdhlasit;
        private CheckBox prihlaseny;
        private Button HlavniBLogik;
        private Button HlavniBMiny;
        private Button HlavniBLode;
        private Button HlavniBSudoku;
        internal TableLayoutPanel HraBox;
        internal TableLayoutPanel HlavniBox;
    }
}