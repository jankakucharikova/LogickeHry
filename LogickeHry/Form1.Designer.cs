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
            HlavniBSudoku = new Button();
            BSudokuZvirata = new Button();
            BSudokuPlanety = new Button();
            BSudokuOvoce = new Button();
            BSudokuPismenka = new Button();
            BSudokuTvary = new Button();
            BSudokuKostka = new Button();
            HraBox = new TableLayoutPanel();
            StatistikaBox = new TableLayoutPanel();
            StatistikyCBMoje = new CheckBox();
            StatistikyCBHra = new ComboBox();
            StatistikaCBObtiznost = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            StatistikaBox.SuspendLayout();
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
            PrihlaseniBox.Size = new Size(859, 246);
            PrihlaseniBox.TabIndex = 0;
            PrihlaseniBox.Visible = false;
            PrihlaseniBox.VisibleChanged += PRBox_VisibleChanged;
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
            PrihlaseniUdajeBox.Location = new Point(288, 3);
            PrihlaseniUdajeBox.Name = "PrihlaseniUdajeBox";
            PrihlaseniUdajeBox.RowCount = 5;
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            PrihlaseniUdajeBox.Size = new Size(280, 170);
            PrihlaseniUdajeBox.TabIndex = 8;
            // 
            // PrihlaseniLJmeno
            // 
            PrihlaseniLJmeno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PrihlaseniLJmeno.AutoSize = true;
            PrihlaseniLJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrihlaseniLJmeno.ImageAlign = ContentAlignment.BottomCenter;
            PrihlaseniLJmeno.Location = new Point(30, 0);
            PrihlaseniLJmeno.Name = "PrihlaseniLJmeno";
            PrihlaseniLJmeno.Size = new Size(219, 30);
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
            PrihlaseniTBJmeno.Size = new Size(274, 41);
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
            PrihlaseniLChHlaska.Size = new Size(274, 20);
            PrihlaseniLChHlaska.TabIndex = 6;
            PrihlaseniLChHlaska.Text = "Chybné přihlašovací údaje.";
            PrihlaseniLChHlaska.TextAlign = ContentAlignment.TopCenter;
            PrihlaseniLChHlaska.Visible = false;
            // 
            // PrihlaseniTBHeslo
            // 
            PrihlaseniTBHeslo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PrihlaseniTBHeslo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrihlaseniTBHeslo.Location = new Point(3, 105);
            PrihlaseniTBHeslo.Name = "PrihlaseniTBHeslo";
            PrihlaseniTBHeslo.PasswordChar = '*';
            PrihlaseniTBHeslo.Size = new Size(274, 41);
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
            PrihlaseniLHeslo.Size = new Size(274, 30);
            PrihlaseniLHeslo.TabIndex = 3;
            PrihlaseniLHeslo.Text = "Heslo:";
            PrihlaseniLHeslo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // PrihlaseniBPrihlaseni
            // 
            PrihlaseniBPrihlaseni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PrihlaseniBPrihlaseni.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            PrihlaseniBPrihlaseni.Location = new Point(288, 179);
            PrihlaseniBPrihlaseni.Name = "PrihlaseniBPrihlaseni";
            PrihlaseniBPrihlaseni.Size = new Size(280, 64);
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
            UvodButtonPrihlaseni.Click += BPrihlaseni_Click;
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
            UvodButtonRegistrace.Click += BRegistrace_Click;
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
            UvodButtonPreskocit.Click += BUvodPreskocit_Click;
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
            RegistraceBox.Size = new Size(859, 441);
            RegistraceBox.TabIndex = 0;
            RegistraceBox.Visible = false;
            RegistraceBox.VisibleChanged += PRBox_VisibleChanged;
            // 
            // RegistraceBRegistrovat
            // 
            RegistraceBRegistrovat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceBRegistrovat.FlatStyle = FlatStyle.System;
            RegistraceBRegistrovat.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceBRegistrovat.Location = new Point(288, 374);
            RegistraceBRegistrovat.Name = "RegistraceBRegistrovat";
            RegistraceBRegistrovat.Size = new Size(280, 64);
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
            RegistraceUdajeBox.Location = new Point(288, 3);
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
            RegistraceUdajeBox.Size = new Size(280, 365);
            RegistraceUdajeBox.TabIndex = 14;
            // 
            // RegistraceLJmeno
            // 
            RegistraceLJmeno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceLJmeno.AutoSize = true;
            RegistraceLJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceLJmeno.Location = new Point(3, 0);
            RegistraceLJmeno.Name = "RegistraceLJmeno";
            RegistraceLJmeno.Size = new Size(274, 35);
            RegistraceLJmeno.TabIndex = 0;
            RegistraceLJmeno.Text = "Uživatelské jméno:";
            RegistraceLJmeno.TextAlign = ContentAlignment.BottomCenter;
            // 
            // RegistraceLPohlavi
            // 
            RegistraceLPohlavi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceLPohlavi.AutoSize = true;
            RegistraceLPohlavi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceLPohlavi.Location = new Point(3, 84);
            RegistraceLPohlavi.Name = "RegistraceLPohlavi";
            RegistraceLPohlavi.Size = new Size(274, 35);
            RegistraceLPohlavi.TabIndex = 1;
            RegistraceLPohlavi.Text = "Pohlaví:";
            RegistraceLPohlavi.TextAlign = ContentAlignment.BottomCenter;
            // 
            // RegistraceLVek
            // 
            RegistraceLVek.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceLVek.AutoSize = true;
            RegistraceLVek.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceLVek.Location = new Point(3, 168);
            RegistraceLVek.Name = "RegistraceLVek";
            RegistraceLVek.Size = new Size(274, 35);
            RegistraceLVek.TabIndex = 2;
            RegistraceLVek.Text = "Věk:";
            RegistraceLVek.TextAlign = ContentAlignment.BottomCenter;
            // 
            // RegistraceLHeslo
            // 
            RegistraceLHeslo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceLHeslo.AutoSize = true;
            RegistraceLHeslo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceLHeslo.Location = new Point(3, 252);
            RegistraceLHeslo.Name = "RegistraceLHeslo";
            RegistraceLHeslo.Size = new Size(274, 35);
            RegistraceLHeslo.TabIndex = 3;
            RegistraceLHeslo.Text = "Heslo:";
            RegistraceLHeslo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // RegistraceTBJmeno
            // 
            RegistraceTBJmeno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceTBJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceTBJmeno.Location = new Point(3, 38);
            RegistraceTBJmeno.Name = "RegistraceTBJmeno";
            RegistraceTBJmeno.Size = new Size(274, 41);
            RegistraceTBJmeno.TabIndex = 4;
            // 
            // RegistraceTBHeslo
            // 
            RegistraceTBHeslo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceTBHeslo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceTBHeslo.Location = new Point(3, 290);
            RegistraceTBHeslo.Name = "RegistraceTBHeslo";
            RegistraceTBHeslo.PasswordChar = '*';
            RegistraceTBHeslo.Size = new Size(274, 41);
            RegistraceTBHeslo.TabIndex = 5;
            // 
            // RegistraceCBPohlavi
            // 
            RegistraceCBPohlavi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceCBPohlavi.DropDownStyle = ComboBoxStyle.DropDownList;
            RegistraceCBPohlavi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceCBPohlavi.FormattingEnabled = true;
            RegistraceCBPohlavi.Items.AddRange(new object[] { "Muž", "Žena", "Jiné" });
            RegistraceCBPohlavi.Location = new Point(3, 122);
            RegistraceCBPohlavi.Name = "RegistraceCBPohlavi";
            RegistraceCBPohlavi.Size = new Size(274, 43);
            RegistraceCBPohlavi.TabIndex = 6;
            // 
            // RegistraceCBVek
            // 
            RegistraceCBVek.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceCBVek.DropDownStyle = ComboBoxStyle.DropDownList;
            RegistraceCBVek.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceCBVek.FormattingEnabled = true;
            RegistraceCBVek.Items.AddRange(new object[] { "0-10", "11-20", "21-30", "31-40", "41-50", "51-60", "61-70", "70+" });
            RegistraceCBVek.Location = new Point(3, 206);
            RegistraceCBVek.Name = "RegistraceCBVek";
            RegistraceCBVek.Size = new Size(274, 43);
            RegistraceCBVek.TabIndex = 7;
            // 
            // RegistraceChHlaska
            // 
            RegistraceChHlaska.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceChHlaska.AutoSize = true;
            RegistraceChHlaska.ForeColor = Color.IndianRed;
            RegistraceChHlaska.Location = new Point(3, 336);
            RegistraceChHlaska.Name = "RegistraceChHlaska";
            RegistraceChHlaska.Size = new Size(274, 29);
            RegistraceChHlaska.TabIndex = 8;
            RegistraceChHlaska.Text = "Uživatelské jméno již existuje.";
            RegistraceChHlaska.TextAlign = ContentAlignment.TopCenter;
            RegistraceChHlaska.Visible = false;
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
            HlavniHlavicka.Controls.Add(HlavniSProfil, 4, 1);
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
            HlavniHlavicka.SetColumnSpan(HlavniLNazev, 5);
            HlavniLNazev.Dock = DockStyle.Fill;
            HlavniLNazev.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            HlavniLNazev.ImageAlign = ContentAlignment.MiddleRight;
            HlavniLNazev.Location = new Point(3, 0);
            HlavniLNazev.Name = "HlavniLNazev";
            HlavniLNazev.Size = new Size(1095, 90);
            HlavniLNazev.TabIndex = 0;
            HlavniLNazev.Text = "Tělocvična pro mozek \U0001f9e0";
            HlavniLNazev.TextAlign = ContentAlignment.MiddleCenter;
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
            HlavniSProfil.Location = new Point(933, 90);
            HlavniSProfil.Name = "HlavniSProfil";
            HlavniSProfil.Size = new Size(168, 70);
            HlavniSProfil.TabIndex = 15;
            HlavniSProfil.Text = "HlavniSProfil";
            // 
            // ProfilBProfil
            // 
            ProfilBProfil.DropDownItems.AddRange(new ToolStripItem[] { ProfilBPrihlaseni, toolStripSeparator3, ProfilBRegistrace });
            ProfilBProfil.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ProfilBProfil.Name = "ProfilBProfil";
            ProfilBProfil.Overflow = ToolStripItemOverflow.AsNeeded;
            ProfilBProfil.Size = new Size(153, 66);
            ProfilBProfil.Text = "👤 \n Jméno Uživatele";
            // 
            // ProfilBPrihlaseni
            // 
            ProfilBPrihlaseni.Alignment = ToolStripItemAlignment.Right;
            ProfilBPrihlaseni.Name = "ProfilBPrihlaseni";
            ProfilBPrihlaseni.Size = new Size(175, 28);
            ProfilBPrihlaseni.Text = "Přihlásit se";
            ProfilBPrihlaseni.Click += BPrihlaseni_Click;
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
            ProfilBRegistrace.Click += BRegistrace_Click;
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
            MenuBMenu.DropDownItems.AddRange(new ToolStripItem[] { MenuBHlavniStranka, MenuBStatistiky });
            MenuBMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MenuBMenu.Name = "MenuBMenu";
            MenuBMenu.Size = new Size(161, 66);
            MenuBMenu.Text = "☰ Menu";
            // 
            // MenuBHlavniStranka
            // 
            MenuBHlavniStranka.Name = "MenuBHlavniStranka";
            MenuBHlavniStranka.Size = new Size(379, 50);
            MenuBHlavniStranka.Text = "🏠 Hlavní stránka";
            MenuBHlavniStranka.Click += BHlavniStranka_Click;
            // 
            // MenuBStatistiky
            // 
            MenuBStatistiky.Name = "MenuBStatistiky";
            MenuBStatistiky.Size = new Size(379, 50);
            MenuBStatistiky.Text = "\U0001f947 Statistiky";
            MenuBStatistiky.Click += BStatistiky_Click;
            // 
            // MenuBNastaveni
            // 
            MenuBNastaveni.Name = "MenuBNastaveni";
            MenuBNastaveni.Size = new Size(323, 50);
            MenuBNastaveni.Text = "⚙ Nastavení";
            MenuBNastaveni.Click += BNastaveni_Click;
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
            ProfilBNastaveni.Click += BNastaveni_Click;
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
            ProfilBOdhlasit.Click += BOdhlaseni_Click;
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
            NastaveniBox.Size = new Size(859, 428);
            NastaveniBox.TabIndex = 0;
            NastaveniBox.Visible = false;
            NastaveniBox.VisibleChanged += NastaveniBox_VisibleChanged;
            // 
            // NastaveniBUlozit
            // 
            NastaveniBUlozit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniBUlozit.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniBUlozit.Location = new Point(288, 361);
            NastaveniBUlozit.Name = "NastaveniBUlozit";
            NastaveniBUlozit.Size = new Size(280, 64);
            NastaveniBUlozit.TabIndex = 2;
            NastaveniBUlozit.Text = "Uložit";
            NastaveniBUlozit.UseVisualStyleBackColor = true;
            NastaveniBUlozit.Click += NastaveniBUlozit_Click;
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
            NastaveniTUdaje.Location = new Point(288, 3);
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
            NastaveniTUdaje.Size = new Size(280, 352);
            NastaveniTUdaje.TabIndex = 3;
            // 
            // NastaveniLJmeno
            // 
            NastaveniLJmeno.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniLJmeno.AutoSize = true;
            NastaveniLJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniLJmeno.Location = new Point(3, 0);
            NastaveniLJmeno.Name = "NastaveniLJmeno";
            NastaveniLJmeno.Size = new Size(274, 35);
            NastaveniLJmeno.TabIndex = 0;
            NastaveniLJmeno.Text = "Uživatelské jméno:";
            NastaveniLJmeno.TextAlign = ContentAlignment.BottomCenter;
            // 
            // NastaveniLPohlavi
            // 
            NastaveniLPohlavi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniLPohlavi.AutoSize = true;
            NastaveniLPohlavi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniLPohlavi.Location = new Point(3, 82);
            NastaveniLPohlavi.Name = "NastaveniLPohlavi";
            NastaveniLPohlavi.Size = new Size(274, 35);
            NastaveniLPohlavi.TabIndex = 5;
            NastaveniLPohlavi.Text = "Pohlaví:";
            NastaveniLPohlavi.TextAlign = ContentAlignment.BottomCenter;
            // 
            // NastaveniLVek
            // 
            NastaveniLVek.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniLVek.AutoSize = true;
            NastaveniLVek.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniLVek.Location = new Point(3, 166);
            NastaveniLVek.Name = "NastaveniLVek";
            NastaveniLVek.Size = new Size(274, 35);
            NastaveniLVek.TabIndex = 6;
            NastaveniLVek.Text = "Věk:";
            NastaveniLVek.TextAlign = ContentAlignment.BottomCenter;
            // 
            // NastaveniLHeslo
            // 
            NastaveniLHeslo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniLHeslo.AutoSize = true;
            NastaveniLHeslo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniLHeslo.Location = new Point(3, 250);
            NastaveniLHeslo.Name = "NastaveniLHeslo";
            NastaveniLHeslo.Size = new Size(274, 35);
            NastaveniLHeslo.TabIndex = 7;
            NastaveniLHeslo.Text = "Heslo:";
            NastaveniLHeslo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // NastaveniLChHlaska
            // 
            NastaveniLChHlaska.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniLChHlaska.AutoSize = true;
            NastaveniLChHlaska.ForeColor = Color.IndianRed;
            NastaveniLChHlaska.Location = new Point(3, 332);
            NastaveniLChHlaska.Name = "NastaveniLChHlaska";
            NastaveniLChHlaska.Size = new Size(274, 20);
            NastaveniLChHlaska.TabIndex = 8;
            NastaveniLChHlaska.Text = "Chybová hláška.";
            NastaveniLChHlaska.TextAlign = ContentAlignment.TopCenter;
            NastaveniLChHlaska.Visible = false;
            // 
            // NastaveniTBJmeno
            // 
            NastaveniTBJmeno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniTBJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniTBJmeno.Location = new Point(3, 38);
            NastaveniTBJmeno.Name = "NastaveniTBJmeno";
            NastaveniTBJmeno.Size = new Size(274, 41);
            NastaveniTBJmeno.TabIndex = 9;
            // 
            // NastaveniTBHeslo
            // 
            NastaveniTBHeslo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniTBHeslo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniTBHeslo.Location = new Point(3, 288);
            NastaveniTBHeslo.Name = "NastaveniTBHeslo";
            NastaveniTBHeslo.PasswordChar = '*';
            NastaveniTBHeslo.Size = new Size(274, 41);
            NastaveniTBHeslo.TabIndex = 10;
            // 
            // NastaveniCBVek
            // 
            NastaveniCBVek.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniCBVek.DropDownStyle = ComboBoxStyle.DropDownList;
            NastaveniCBVek.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniCBVek.FormattingEnabled = true;
            NastaveniCBVek.Items.AddRange(new object[] { "0-10", "11-20", "21-30", "31-40", "41-50", "51-60", "61-70", "70+" });
            NastaveniCBVek.Location = new Point(3, 204);
            NastaveniCBVek.Name = "NastaveniCBVek";
            NastaveniCBVek.Size = new Size(274, 43);
            NastaveniCBVek.Sorted = true;
            NastaveniCBVek.TabIndex = 11;
            // 
            // NastaveniCBPohlavi
            // 
            NastaveniCBPohlavi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniCBPohlavi.DropDownStyle = ComboBoxStyle.DropDownList;
            NastaveniCBPohlavi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniCBPohlavi.FormattingEnabled = true;
            NastaveniCBPohlavi.Items.AddRange(new object[] { "Muž", "Žena", "Jiné" });
            NastaveniCBPohlavi.Location = new Point(3, 120);
            NastaveniCBPohlavi.Name = "NastaveniCBPohlavi";
            NastaveniCBPohlavi.Size = new Size(274, 43);
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
            PRHlavicka.Size = new Size(301, 200);
            PRHlavicka.TabIndex = 2;
            PRHlavicka.Visible = false;
            // 
            // PRBZpet
            // 
            PRBZpet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PRBZpet.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            PRBZpet.Location = new Point(3, 93);
            PRBZpet.Name = "PRBZpet";
            PRBZpet.Size = new Size(39, 64);
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
            PRLNazev.Size = new Size(295, 90);
            PRLNazev.TabIndex = 11;
            PRLNazev.Text = "Tělocvična pro mozek \U0001f9e0";
            // 
            // PRLPodnadpis
            // 
            PRLPodnadpis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PRLPodnadpis.AutoSize = true;
            PRHlavicka.SetColumnSpan(PRLPodnadpis, 3);
            PRLPodnadpis.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            PRLPodnadpis.Location = new Point(48, 90);
            PRLPodnadpis.Name = "PRLPodnadpis";
            PRLPodnadpis.Size = new Size(204, 70);
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
            HlavniBox.Controls.Add(HlavniBSudoku, 3, 1);
            HlavniBox.Controls.Add(BSudokuZvirata, 2, 1);
            HlavniBox.Controls.Add(BSudokuPlanety, 3, 0);
            HlavniBox.Controls.Add(BSudokuOvoce, 2, 0);
            HlavniBox.Controls.Add(BSudokuPismenka, 1, 0);
            HlavniBox.Controls.Add(BSudokuTvary, 0, 0);
            HlavniBox.Controls.Add(BSudokuKostka, 4, 0);
            HlavniBox.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            HlavniBox.Location = new Point(0, 200);
            HlavniBox.Name = "HlavniBox";
            HlavniBox.RowCount = 2;
            HlavniBox.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            HlavniBox.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            HlavniBox.Size = new Size(859, 140);
            HlavniBox.TabIndex = 3;
            HlavniBox.Visible = false;
            HlavniBox.VisibleChanged += HlavniBox_VisibleChanged;
            // 
            // HlavniBLogik
            // 
            HlavniBLogik.Dock = DockStyle.Fill;
            HlavniBLogik.Location = new Point(3, 73);
            HlavniBLogik.Name = "HlavniBLogik";
            HlavniBLogik.Size = new Size(122, 64);
            HlavniBLogik.TabIndex = 0;
            HlavniBLogik.Text = "Logik";
            HlavniBLogik.UseVisualStyleBackColor = true;
            HlavniBLogik.Click += BLogik_Click;
            // 
            // HlavniBMiny
            // 
            HlavniBMiny.Dock = DockStyle.Fill;
            HlavniBMiny.Location = new Point(131, 73);
            HlavniBMiny.Name = "HlavniBMiny";
            HlavniBMiny.Size = new Size(151, 64);
            HlavniBMiny.TabIndex = 1;
            HlavniBMiny.Text = "Miny";
            HlavniBMiny.UseVisualStyleBackColor = true;
            HlavniBMiny.Click += BMiny_Click;
            // 
            // HlavniBSudoku
            // 
            HlavniBSudoku.Dock = DockStyle.Fill;
            HlavniBSudoku.Location = new Point(574, 73);
            HlavniBSudoku.Name = "HlavniBSudoku";
            HlavniBSudoku.Size = new Size(151, 64);
            HlavniBSudoku.TabIndex = 3;
            HlavniBSudoku.Text = "Sudoku";
            HlavniBSudoku.UseVisualStyleBackColor = true;
            HlavniBSudoku.Click += BSudoku_Click;
            // 
            // BSudokuZvirata
            // 
            BSudokuZvirata.Dock = DockStyle.Fill;
            BSudokuZvirata.Location = new Point(288, 73);
            BSudokuZvirata.Name = "BSudokuZvirata";
            BSudokuZvirata.Size = new Size(280, 64);
            BSudokuZvirata.TabIndex = 4;
            BSudokuZvirata.Text = "Sudoku Zvirata";
            BSudokuZvirata.UseVisualStyleBackColor = true;
            BSudokuZvirata.Click += BSudokuZvirata_Click;
            // 
            // BSudokuPlanety
            // 
            BSudokuPlanety.Dock = DockStyle.Fill;
            BSudokuPlanety.Location = new Point(574, 3);
            BSudokuPlanety.Name = "BSudokuPlanety";
            BSudokuPlanety.Size = new Size(151, 64);
            BSudokuPlanety.TabIndex = 5;
            BSudokuPlanety.Text = "Sudoku Planety";
            BSudokuPlanety.UseVisualStyleBackColor = true;
            BSudokuPlanety.Click += BSudokuPlanety_Click;
            // 
            // BSudokuOvoce
            // 
            BSudokuOvoce.Dock = DockStyle.Fill;
            BSudokuOvoce.Location = new Point(288, 3);
            BSudokuOvoce.Name = "BSudokuOvoce";
            BSudokuOvoce.Size = new Size(280, 64);
            BSudokuOvoce.TabIndex = 6;
            BSudokuOvoce.Text = "Sudoku Ovoce";
            BSudokuOvoce.UseVisualStyleBackColor = true;
            BSudokuOvoce.Click += BSudokuOvoce_Click;
            // 
            // BSudokuPismenka
            // 
            BSudokuPismenka.Dock = DockStyle.Fill;
            BSudokuPismenka.Location = new Point(131, 3);
            BSudokuPismenka.Name = "BSudokuPismenka";
            BSudokuPismenka.Size = new Size(151, 64);
            BSudokuPismenka.TabIndex = 7;
            BSudokuPismenka.Text = "Sudoku Pismenka";
            BSudokuPismenka.UseVisualStyleBackColor = true;
            BSudokuPismenka.Click += BSudokuPismenka_Click;
            // 
            // BSudokuTvary
            // 
            BSudokuTvary.Dock = DockStyle.Fill;
            BSudokuTvary.Location = new Point(3, 3);
            BSudokuTvary.Name = "BSudokuTvary";
            BSudokuTvary.Size = new Size(122, 64);
            BSudokuTvary.TabIndex = 8;
            BSudokuTvary.Text = "Sudoku Tvary";
            BSudokuTvary.UseVisualStyleBackColor = true;
            BSudokuTvary.Click += BSudokuTvary_Click;
            // 
            // BSudokuKostka
            // 
            BSudokuKostka.Dock = DockStyle.Fill;
            BSudokuKostka.Location = new Point(731, 3);
            BSudokuKostka.Name = "BSudokuKostka";
            BSudokuKostka.Size = new Size(125, 64);
            BSudokuKostka.TabIndex = 9;
            BSudokuKostka.Text = "Sudoku Kostka";
            BSudokuKostka.UseVisualStyleBackColor = true;
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
            // StatistikaBox
            // 
            StatistikaBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatistikaBox.AutoSize = true;
            StatistikaBox.ColumnCount = 6;
            StatistikaBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            StatistikaBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            StatistikaBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            StatistikaBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            StatistikaBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            StatistikaBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            StatistikaBox.Controls.Add(StatistikyCBMoje, 1, 0);
            StatistikaBox.Controls.Add(StatistikyCBHra, 3, 0);
            StatistikaBox.Controls.Add(StatistikaCBObtiznost, 5, 0);
            StatistikaBox.Controls.Add(label1, 2, 0);
            StatistikaBox.Controls.Add(label2, 4, 0);
            StatistikaBox.Controls.Add(label3, 0, 0);
            StatistikaBox.Location = new Point(1, 200);
            StatistikaBox.Name = "StatistikaBox";
            StatistikaBox.RowCount = 2;
            StatistikaBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            StatistikaBox.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            StatistikaBox.Size = new Size(1101, 500);
            StatistikaBox.TabIndex = 11;
            StatistikaBox.Visible = false;
            StatistikaBox.VisibleChanged += HlavniBox_VisibleChanged;
            // 
            // StatistikyCBMoje
            // 
            StatistikyCBMoje.AutoSize = true;
            StatistikyCBMoje.Dock = DockStyle.Fill;
            StatistikyCBMoje.Location = new Point(186, 3);
            StatistikyCBMoje.Name = "StatistikyCBMoje";
            StatistikyCBMoje.Size = new Size(177, 24);
            StatistikyCBMoje.TabIndex = 0;
            StatistikyCBMoje.UseVisualStyleBackColor = true;
            StatistikyCBMoje.CheckedChanged += StatistikaCBObtiznost_SelectedIndexChanged;
            // 
            // StatistikyCBHra
            // 
            StatistikyCBHra.Dock = DockStyle.Fill;
            StatistikyCBHra.DropDownStyle = ComboBoxStyle.DropDownList;
            StatistikyCBHra.FormattingEnabled = true;
            StatistikyCBHra.Items.AddRange(new object[] { "Sudoku", "Miny", "Logik" });
            StatistikyCBHra.Location = new Point(552, 3);
            StatistikyCBHra.Name = "StatistikyCBHra";
            StatistikyCBHra.Size = new Size(177, 28);
            StatistikyCBHra.TabIndex = 1;
            StatistikyCBHra.SelectedIndexChanged += StatistikaCBObtiznost_SelectedIndexChanged;
            // 
            // StatistikaCBObtiznost
            // 
            StatistikaCBObtiznost.Dock = DockStyle.Fill;
            StatistikaCBObtiznost.DropDownStyle = ComboBoxStyle.DropDownList;
            StatistikaCBObtiznost.FormattingEnabled = true;
            StatistikaCBObtiznost.Items.AddRange(new object[] { "Lehké", "Střední", "Těžké" });
            StatistikaCBObtiznost.Location = new Point(918, 3);
            StatistikaCBObtiznost.Name = "StatistikaCBObtiznost";
            StatistikaCBObtiznost.Size = new Size(180, 28);
            StatistikaCBObtiznost.TabIndex = 2;
            StatistikaCBObtiznost.SelectedIndexChanged += StatistikaCBObtiznost_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(510, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 30);
            label1.TabIndex = 3;
            label1.Text = "Hra:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(836, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 30);
            label2.TabIndex = 4;
            label2.Text = "Obtížnost:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 30);
            label3.TabIndex = 5;
            label3.Text = "Jen moje:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1103, 700);
            Controls.Add(HlavniBox);
            Controls.Add(HlavniHlavicka);
            Controls.Add(StatistikaBox);
            Controls.Add(UvodBox);
            Controls.Add(HraBox);
            Controls.Add(PRHlavicka);
            Controls.Add(NastaveniBox);
            Controls.Add(RegistraceBox);
            Controls.Add(PrihlaseniBox);
            MainMenuStrip = HlavniSMenu;
            Name = "GameForm";
            Text = "Tělocvična pro mozek";
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
            StatistikaBox.ResumeLayout(false);
            StatistikaBox.PerformLayout();
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
        private Button HlavniBLogik;
        private Button HlavniBMiny;
        private Button HlavniBSudoku;
        internal TableLayoutPanel HraBox;
        internal TableLayoutPanel HlavniBox;
        internal TableLayoutPanel StatistikaBox;
        private Label label1;
        private Label label2;
        private Label label3;
        internal ComboBox StatistikaCBObtiznost;
        internal ComboBox StatistikyCBHra;
        internal CheckBox StatistikyCBMoje;
        private Button BSudokuZvirata;
        private Button BSudokuPlanety;
        private Button BSudokuOvoce;
        private Button BSudokuPismenka;
        private Button BSudokuTvary;
        private Button BSudokuKostka;
    }
}