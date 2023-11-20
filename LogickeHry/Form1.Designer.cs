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
            UvodBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            UvodNazev = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            UvodPopis = new Label();
            UvodButtonPrihlaseni = new Button();
            UvodButtonRegistrace = new Button();
            UvodButtonPreskocit = new Button();
            pictureBox1 = new PictureBox();
            UvodBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UvodBox
            // 
            UvodBox.AccessibleRole = AccessibleRole.None;
            UvodBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UvodBox.AutoSize = true;
            UvodBox.Controls.Add(tableLayoutPanel1);
            UvodBox.Location = new Point(0, -6);
            UvodBox.Name = "UvodBox";
            UvodBox.Size = new Size(786, 456);
            UvodBox.TabIndex = 0;
            UvodBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(UvodNazev, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Size = new Size(762, 412);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // UvodNazev
            // 
            UvodNazev.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UvodNazev.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(UvodNazev, 2);
            UvodNazev.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            UvodNazev.Location = new Point(3, 0);
            UvodNazev.Name = "UvodNazev";
            UvodNazev.Size = new Size(756, 123);
            UvodNazev.TabIndex = 0;
            UvodNazev.Text = "Tělocvična pro mozek";
            UvodNazev.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(UvodPopis, 0, 0);
            tableLayoutPanel2.Controls.Add(UvodButtonPrihlaseni, 0, 1);
            tableLayoutPanel2.Controls.Add(UvodButtonRegistrace, 0, 2);
            tableLayoutPanel2.Controls.Add(UvodButtonPreskocit, 0, 3);
            tableLayoutPanel2.Location = new Point(384, 126);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(375, 283);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // UvodPopis
            // 
            UvodPopis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UvodPopis.AutoSize = true;
            UvodPopis.Location = new Point(3, 0);
            UvodPopis.Name = "UvodPopis";
            UvodPopis.Size = new Size(369, 113);
            UvodPopis.TabIndex = 0;
            UvodPopis.Text = "Pojď si s naší aplikací procvičit mozek!";
            UvodPopis.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UvodButtonPrihlaseni
            // 
            UvodButtonPrihlaseni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UvodButtonPrihlaseni.Location = new Point(3, 116);
            UvodButtonPrihlaseni.Name = "UvodButtonPrihlaseni";
            UvodButtonPrihlaseni.Size = new Size(369, 50);
            UvodButtonPrihlaseni.TabIndex = 1;
            UvodButtonPrihlaseni.Text = "Přihlásit se";
            UvodButtonPrihlaseni.UseVisualStyleBackColor = true;
            // 
            // UvodButtonRegistrace
            // 
            UvodButtonRegistrace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UvodButtonRegistrace.Location = new Point(3, 172);
            UvodButtonRegistrace.Name = "UvodButtonRegistrace";
            UvodButtonRegistrace.Size = new Size(369, 50);
            UvodButtonRegistrace.TabIndex = 2;
            UvodButtonRegistrace.Text = "Zaregistrovat se";
            UvodButtonRegistrace.UseVisualStyleBackColor = true;
            // 
            // UvodButtonPreskocit
            // 
            UvodButtonPreskocit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UvodButtonPreskocit.Location = new Point(3, 228);
            UvodButtonPreskocit.Name = "UvodButtonPreskocit";
            UvodButtonPreskocit.Size = new Size(369, 52);
            UvodButtonPreskocit.TabIndex = 3;
            UvodButtonPreskocit.Text = "Pokračovat bez příhlášení";
            UvodButtonPreskocit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.shutterstock_74158666;
            pictureBox1.Location = new Point(3, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 450);
            Controls.Add(UvodBox);
            Name = "GameForm";
            Text = "Multiherní aplikace";
            UvodBox.ResumeLayout(false);
            UvodBox.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox UvodBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label UvodNazev;
        private TableLayoutPanel tableLayoutPanel2;
        private Label UvodPopis;
        private Button UvodButtonPrihlaseni;
        private Button UvodButtonRegistrace;
        private Button UvodButtonPreskocit;
        private PictureBox pictureBox1;
    }
}