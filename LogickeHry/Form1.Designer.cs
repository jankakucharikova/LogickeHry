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
            button3 = new Button();
            label8 = new Label();
            label9 = new Label();
            button4 = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label14 = new Label();
            button5 = new Button();
            label15 = new Label();
            label16 = new Label();
            button6 = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            label17 = new Label();
            label18 = new Label();
            PRHlavicka = new TableLayoutPanel();
            PRBZpet = new Button();
            PRLNazev = new Label();
            PRLPodnadpis = new Label();
            HlavniBox = new TableLayoutPanel();
            StatistikaBox = new TableLayoutPanel();
            LogikBox = new TableLayoutPanel();
            SudokuBox = new TableLayoutPanel();
            LodeBox = new TableLayoutPanel();
            MinyBox = new TableLayoutPanel();
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
            SuspendLayout();
            // 
            // PrihlaseniBox
            // 
            PrihlaseniBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            PrihlaseniBox.Size = new Size(1060, 246);
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
            PrihlaseniUdajeBox.Location = new Point(356, 3);
            PrihlaseniUdajeBox.Name = "PrihlaseniUdajeBox";
            PrihlaseniUdajeBox.RowCount = 5;
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PrihlaseniUdajeBox.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            PrihlaseniUdajeBox.Size = new Size(347, 170);
            PrihlaseniUdajeBox.TabIndex = 8;
            // 
            // PrihlaseniLJmeno
            // 
            PrihlaseniLJmeno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PrihlaseniLJmeno.AutoSize = true;
            PrihlaseniLJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrihlaseniLJmeno.ImageAlign = ContentAlignment.BottomCenter;
            PrihlaseniLJmeno.Location = new Point(64, 0);
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
            PrihlaseniTBJmeno.Size = new Size(341, 41);
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
            PrihlaseniLChHlaska.Size = new Size(341, 20);
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
            PrihlaseniTBHeslo.Size = new Size(341, 41);
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
            PrihlaseniLHeslo.Size = new Size(341, 30);
            PrihlaseniLHeslo.TabIndex = 3;
            PrihlaseniLHeslo.Text = "Heslo:";
            PrihlaseniLHeslo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // PrihlaseniBPrihlaseni
            // 
            PrihlaseniBPrihlaseni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PrihlaseniBPrihlaseni.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            PrihlaseniBPrihlaseni.Location = new Point(356, 179);
            PrihlaseniBPrihlaseni.Name = "PrihlaseniBPrihlaseni";
            PrihlaseniBPrihlaseni.Size = new Size(347, 64);
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
            UvodBox.Size = new Size(1103, 755);
            UvodBox.TabIndex = 0;
            // 
            // UvodTabulkaMenu
            // 
            UvodTabulkaMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UvodTabulkaMenu.ColumnCount = 1;
            UvodTabulkaMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            UvodTabulkaMenu.Controls.Add(UvodPopis, 0, 0);
            UvodTabulkaMenu.Controls.Add(UvodButtonPrihlaseni, 0, 1);
            UvodTabulkaMenu.Controls.Add(UvodButtonRegistrace, 0, 2);
            UvodTabulkaMenu.Controls.Add(UvodButtonPreskocit, 0, 3);
            UvodTabulkaMenu.Location = new Point(554, 234);
            UvodTabulkaMenu.Name = "UvodTabulkaMenu";
            UvodTabulkaMenu.RowCount = 4;
            UvodTabulkaMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            UvodTabulkaMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            UvodTabulkaMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            UvodTabulkaMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            UvodTabulkaMenu.Size = new Size(534, 506);
            UvodTabulkaMenu.TabIndex = 1;
            // 
            // UvodPopis
            // 
            UvodPopis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UvodPopis.AutoSize = true;
            UvodPopis.Font = new Font("Segoe UI", 20F, FontStyle.Italic, GraphicsUnit.Point);
            UvodPopis.Location = new Point(3, 0);
            UvodPopis.Name = "UvodPopis";
            UvodPopis.Size = new Size(528, 202);
            UvodPopis.TabIndex = 0;
            UvodPopis.Text = "Pojď si s naší aplikací procvičit mozek!";
            UvodPopis.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UvodButtonPrihlaseni
            // 
            UvodButtonPrihlaseni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UvodButtonPrihlaseni.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            UvodButtonPrihlaseni.Location = new Point(3, 205);
            UvodButtonPrihlaseni.Name = "UvodButtonPrihlaseni";
            UvodButtonPrihlaseni.Size = new Size(528, 95);
            UvodButtonPrihlaseni.TabIndex = 1;
            UvodButtonPrihlaseni.Text = "Přihlásit se";
            UvodButtonPrihlaseni.Click += ButtonPrihlaseni_Click;
            // 
            // UvodButtonRegistrace
            // 
            UvodButtonRegistrace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UvodButtonRegistrace.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            UvodButtonRegistrace.Location = new Point(3, 306);
            UvodButtonRegistrace.Name = "UvodButtonRegistrace";
            UvodButtonRegistrace.Size = new Size(528, 95);
            UvodButtonRegistrace.TabIndex = 2;
            UvodButtonRegistrace.Text = "Zaregistrovat se";
            UvodButtonRegistrace.Click += ButtonRegistrace_Click;
            // 
            // UvodButtonPreskocit
            // 
            UvodButtonPreskocit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UvodButtonPreskocit.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            UvodButtonPreskocit.Location = new Point(3, 407);
            UvodButtonPreskocit.Name = "UvodButtonPreskocit";
            UvodButtonPreskocit.Size = new Size(528, 96);
            UvodButtonPreskocit.TabIndex = 3;
            UvodButtonPreskocit.Text = "Pokračovat bez příhlášení";
            UvodButtonPreskocit.Click += UvodButtonPreskocit_Click;
            // 
            // UvodObrazek
            // 
            UvodObrazek.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UvodObrazek.Image = Properties.Resources.shutterstock_74158666;
            UvodObrazek.Location = new Point(15, 234);
            UvodObrazek.Name = "UvodObrazek";
            UvodObrazek.Size = new Size(533, 506);
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
            UvodNazev.Size = new Size(1073, 219);
            UvodNazev.TabIndex = 0;
            UvodNazev.Text = "Tělocvična pro mozek \U0001f9e0";
            UvodNazev.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistraceBox
            // 
            RegistraceBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            RegistraceBox.Size = new Size(1060, 441);
            RegistraceBox.TabIndex = 0;
            RegistraceBox.Visible = false;
            RegistraceBox.VisibleChanged += RegistraceBox_VisibleChanged;
            // 
            // RegistraceBRegistrovat
            // 
            RegistraceBRegistrovat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceBRegistrovat.FlatStyle = FlatStyle.System;
            RegistraceBRegistrovat.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceBRegistrovat.Location = new Point(356, 374);
            RegistraceBRegistrovat.Name = "RegistraceBRegistrovat";
            RegistraceBRegistrovat.Size = new Size(347, 64);
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
            RegistraceUdajeBox.Location = new Point(356, 3);
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
            RegistraceUdajeBox.Size = new Size(347, 365);
            RegistraceUdajeBox.TabIndex = 14;
            // 
            // RegistraceLJmeno
            // 
            RegistraceLJmeno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceLJmeno.AutoSize = true;
            RegistraceLJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceLJmeno.Location = new Point(3, 0);
            RegistraceLJmeno.Name = "RegistraceLJmeno";
            RegistraceLJmeno.Size = new Size(341, 35);
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
            RegistraceLPohlavi.Size = new Size(341, 35);
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
            RegistraceLVek.Size = new Size(341, 35);
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
            RegistraceLHeslo.Size = new Size(341, 35);
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
            RegistraceTBJmeno.Size = new Size(341, 41);
            RegistraceTBJmeno.TabIndex = 4;
            // 
            // RegistraceTBHeslo
            // 
            RegistraceTBHeslo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceTBHeslo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistraceTBHeslo.Location = new Point(3, 290);
            RegistraceTBHeslo.Name = "RegistraceTBHeslo";
            RegistraceTBHeslo.Size = new Size(341, 41);
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
            RegistraceCBPohlavi.Size = new Size(341, 43);
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
            RegistraceCBVek.Size = new Size(341, 43);
            RegistraceCBVek.TabIndex = 7;
            // 
            // RegistraceChHlaska
            // 
            RegistraceChHlaska.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RegistraceChHlaska.AutoSize = true;
            RegistraceChHlaska.ForeColor = Color.IndianRed;
            RegistraceChHlaska.Location = new Point(3, 336);
            RegistraceChHlaska.Name = "RegistraceChHlaska";
            RegistraceChHlaska.Size = new Size(341, 29);
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
            ProfilBPrihlaseni.Size = new Size(224, 28);
            ProfilBPrihlaseni.Text = "Přihlásit se";
            ProfilBPrihlaseni.Click += ButtonPrihlaseni_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(221, 6);
            // 
            // ProfilBRegistrace
            // 
            ProfilBRegistrace.Alignment = ToolStripItemAlignment.Right;
            ProfilBRegistrace.Name = "ProfilBRegistrace";
            ProfilBRegistrace.Size = new Size(224, 28);
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
            NastaveniBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            NastaveniBox.Size = new Size(1060, 428);
            NastaveniBox.TabIndex = 0;
            NastaveniBox.Visible = false;
            NastaveniBox.VisibleChanged += NastaveniBox_VisibleChanged;
            // 
            // NastaveniBUlozit
            // 
            NastaveniBUlozit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniBUlozit.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniBUlozit.Location = new Point(356, 361);
            NastaveniBUlozit.Name = "NastaveniBUlozit";
            NastaveniBUlozit.Size = new Size(347, 64);
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
            NastaveniTUdaje.Location = new Point(356, 3);
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
            NastaveniTUdaje.Size = new Size(347, 352);
            NastaveniTUdaje.TabIndex = 3;
            // 
            // NastaveniLJmeno
            // 
            NastaveniLJmeno.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniLJmeno.AutoSize = true;
            NastaveniLJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniLJmeno.Location = new Point(3, 0);
            NastaveniLJmeno.Name = "NastaveniLJmeno";
            NastaveniLJmeno.Size = new Size(341, 35);
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
            NastaveniLPohlavi.Size = new Size(341, 35);
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
            NastaveniLVek.Size = new Size(341, 35);
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
            NastaveniLHeslo.Size = new Size(341, 35);
            NastaveniLHeslo.TabIndex = 7;
            NastaveniLHeslo.Text = "Heslo:";
            NastaveniLHeslo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // NastaveniLChHlaska
            // 
            NastaveniLChHlaska.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniLChHlaska.AutoSize = true;
            NastaveniLChHlaska.Location = new Point(3, 332);
            NastaveniLChHlaska.Name = "NastaveniLChHlaska";
            NastaveniLChHlaska.Size = new Size(341, 20);
            NastaveniLChHlaska.TabIndex = 8;
            NastaveniLChHlaska.Text = "Chybová hláška.";
            NastaveniLChHlaska.TextAlign = ContentAlignment.TopCenter;
            // 
            // NastaveniTBJmeno
            // 
            NastaveniTBJmeno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniTBJmeno.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniTBJmeno.Location = new Point(3, 38);
            NastaveniTBJmeno.Name = "NastaveniTBJmeno";
            NastaveniTBJmeno.Size = new Size(341, 41);
            NastaveniTBJmeno.TabIndex = 9;
            // 
            // NastaveniTBHeslo
            // 
            NastaveniTBHeslo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniTBHeslo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniTBHeslo.Location = new Point(3, 288);
            NastaveniTBHeslo.Name = "NastaveniTBHeslo";
            NastaveniTBHeslo.Size = new Size(341, 41);
            NastaveniTBHeslo.TabIndex = 10;
            // 
            // NastaveniCBVek
            // 
            NastaveniCBVek.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniCBVek.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniCBVek.FormattingEnabled = true;
            NastaveniCBVek.Items.AddRange(new object[] { "0-10", "11-20", "21-30", "31-40", "41-50", "51-60", "61-70", "70+" });
            NastaveniCBVek.Location = new Point(3, 204);
            NastaveniCBVek.Name = "NastaveniCBVek";
            NastaveniCBVek.Size = new Size(341, 43);
            NastaveniCBVek.Sorted = true;
            NastaveniCBVek.TabIndex = 11;
            // 
            // NastaveniCBPohlavi
            // 
            NastaveniCBPohlavi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NastaveniCBPohlavi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NastaveniCBPohlavi.FormattingEnabled = true;
            NastaveniCBPohlavi.Items.AddRange(new object[] { "Muž", "Žena", "Jiné" });
            NastaveniCBPohlavi.Location = new Point(3, 120);
            NastaveniCBPohlavi.Name = "NastaveniCBPohlavi";
            NastaveniCBPohlavi.Size = new Size(341, 43);
            NastaveniCBPohlavi.TabIndex = 12;
            // 
            // HlavniLMenu
            // 
            HlavniLMenu.Location = new Point(0, 0);
            HlavniLMenu.Name = "HlavniLMenu";
            HlavniLMenu.Size = new Size(100, 23);
            HlavniLMenu.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            // 
            // label8
            // 
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 0;
            // 
            // label9
            // 
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label10
            // 
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 0;
            // 
            // label11
            // 
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 0;
            // 
            // label12
            // 
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(100, 23);
            label12.TabIndex = 0;
            // 
            // label13
            // 
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(100, 23);
            label13.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 27);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(0, 0);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 27);
            textBox4.TabIndex = 0;
            // 
            // comboBox3
            // 
            comboBox3.Location = new Point(0, 0);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 28);
            comboBox3.TabIndex = 0;
            // 
            // comboBox4
            // 
            comboBox4.Location = new Point(0, 0);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 28);
            comboBox4.TabIndex = 0;
            // 
            // label14
            // 
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(100, 23);
            label14.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 0;
            // 
            // label15
            // 
            label15.Location = new Point(0, 0);
            label15.Name = "label15";
            label15.Size = new Size(100, 23);
            label15.TabIndex = 0;
            // 
            // label16
            // 
            label16.Location = new Point(0, 0);
            label16.Name = "label16";
            label16.Size = new Size(100, 23);
            label16.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label17
            // 
            label17.Location = new Point(0, 0);
            label17.Name = "label17";
            label17.Size = new Size(100, 23);
            label17.TabIndex = 0;
            // 
            // label18
            // 
            label18.Location = new Point(0, 0);
            label18.Name = "label18";
            label18.Size = new Size(100, 23);
            label18.TabIndex = 0;
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
            PRHlavicka.Size = new Size(1060, 200);
            PRHlavicka.TabIndex = 2;
            PRHlavicka.Visible = false;
            // 
            // PRBZpet
            // 
            PRBZpet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PRBZpet.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            PRBZpet.Location = new Point(3, 93);
            PRBZpet.Name = "PRBZpet";
            PRBZpet.Size = new Size(153, 64);
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
            PRLNazev.Size = new Size(745, 81);
            PRLNazev.TabIndex = 11;
            PRLNazev.Text = "Tělocvična pro mozek \U0001f9e0";
            // 
            // PRLPodnadpis
            // 
            PRLPodnadpis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PRLPodnadpis.AutoSize = true;
            PRHlavicka.SetColumnSpan(PRLPodnadpis, 3);
            PRLPodnadpis.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            PRLPodnadpis.Location = new Point(162, 90);
            PRLPodnadpis.Name = "PRLPodnadpis";
            PRLPodnadpis.Size = new Size(735, 67);
            PRLPodnadpis.TabIndex = 12;
            PRLPodnadpis.Text = "Registrace";
            PRLPodnadpis.TextAlign = ContentAlignment.TopCenter;
            // 
            // HlavniBox
            // 
            HlavniBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HlavniBox.AutoSize = true;
            HlavniBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            HlavniBox.ColumnCount = 5;
            HlavniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            HlavniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            HlavniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.335556F));
            HlavniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            HlavniBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            HlavniBox.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            HlavniBox.Location = new Point(0, 200);
            HlavniBox.Name = "HlavniBox";
            HlavniBox.RowCount = 2;
            HlavniBox.RowStyles.Add(new RowStyle());
            HlavniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            HlavniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            HlavniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            HlavniBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            HlavniBox.Size = new Size(1060, 70);
            HlavniBox.TabIndex = 3;
            HlavniBox.Visible = false;
            HlavniBox.VisibleChanged += HlavniBox_VisibleChanged;
            // 
            // StatistikaBox
            // 
            StatistikaBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatistikaBox.AutoSize = true;
            StatistikaBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StatistikaBox.ColumnCount = 5;
            StatistikaBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            StatistikaBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            StatistikaBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.335556F));
            StatistikaBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            StatistikaBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            StatistikaBox.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            StatistikaBox.Location = new Point(15, 342);
            StatistikaBox.Name = "StatistikaBox";
            StatistikaBox.RowCount = 2;
            StatistikaBox.RowStyles.Add(new RowStyle());
            StatistikaBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            StatistikaBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            StatistikaBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            StatistikaBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            StatistikaBox.Size = new Size(1059, 70);
            StatistikaBox.TabIndex = 4;
            StatistikaBox.Visible = false;
            // 
            // LogikBox
            // 
            LogikBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LogikBox.AutoSize = true;
            LogikBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LogikBox.ColumnCount = 5;
            LogikBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            LogikBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            LogikBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.335556F));
            LogikBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            LogikBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            LogikBox.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            LogikBox.Location = new Point(15, 342);
            LogikBox.Name = "LogikBox";
            LogikBox.RowCount = 2;
            LogikBox.RowStyles.Add(new RowStyle());
            LogikBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            LogikBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LogikBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LogikBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LogikBox.Size = new Size(1060, 70);
            LogikBox.TabIndex = 5;
            LogikBox.Visible = false;
            // 
            // SudokuBox
            // 
            SudokuBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SudokuBox.AutoSize = true;
            SudokuBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SudokuBox.ColumnCount = 5;
            SudokuBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            SudokuBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            SudokuBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.335556F));
            SudokuBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            SudokuBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            SudokuBox.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            SudokuBox.Location = new Point(15, 342);
            SudokuBox.Name = "SudokuBox";
            SudokuBox.RowCount = 2;
            SudokuBox.RowStyles.Add(new RowStyle());
            SudokuBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            SudokuBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SudokuBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SudokuBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SudokuBox.Size = new Size(1063, 70);
            SudokuBox.TabIndex = 6;
            SudokuBox.Visible = false;
            // 
            // LodeBox
            // 
            LodeBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LodeBox.AutoSize = true;
            LodeBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LodeBox.ColumnCount = 5;
            LodeBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            LodeBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            LodeBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.335556F));
            LodeBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            LodeBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            LodeBox.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            LodeBox.Location = new Point(15, 342);
            LodeBox.Name = "LodeBox";
            LodeBox.RowCount = 2;
            LodeBox.RowStyles.Add(new RowStyle());
            LodeBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            LodeBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LodeBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LodeBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LodeBox.Size = new Size(1066, 70);
            LodeBox.TabIndex = 7;
            LodeBox.Visible = false;
            // 
            // MinyBox
            // 
            MinyBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MinyBox.AutoSize = true;
            MinyBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MinyBox.ColumnCount = 5;
            MinyBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            MinyBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            MinyBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.335556F));
            MinyBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3312225F));
            MinyBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.001F));
            MinyBox.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            MinyBox.Location = new Point(15, 342);
            MinyBox.Name = "MinyBox";
            MinyBox.RowCount = 2;
            MinyBox.RowStyles.Add(new RowStyle());
            MinyBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            MinyBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MinyBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MinyBox.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MinyBox.Size = new Size(1069, 70);
            MinyBox.TabIndex = 8;
            MinyBox.Visible = false;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1103, 755);
            Controls.Add(MinyBox);
            Controls.Add(LodeBox);
            Controls.Add(SudokuBox);
            Controls.Add(LogikBox);
            Controls.Add(StatistikaBox);
            Controls.Add(HlavniHlavicka);
            Controls.Add(PRHlavicka);
            Controls.Add(HlavniBox);
            Controls.Add(NastaveniBox);
            Controls.Add(RegistraceBox);
            Controls.Add(PrihlaseniBox);
            Controls.Add(UvodBox);
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
        private Button button3;
        private Label label8;
        private Label label9;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label14;
        private Button button5;
        private Label label15;
        private Label label16;
        private Button button6;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label17;
        private Label label18;
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
        private TableLayoutPanel HlavniBox;
        private TableLayoutPanel StatistikaBox;
        private TableLayoutPanel LogikBox;
        private TableLayoutPanel SudokuBox;
        private TableLayoutPanel LodeBox;
        private TableLayoutPanel MinyBox;
    }
}