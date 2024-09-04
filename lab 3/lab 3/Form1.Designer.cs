namespace lab_3
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            tBPalabra = new TextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            listBoxVocales = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // tBPalabra
            // 
            tBPalabra.Location = new Point(341, 183);
            tBPalabra.Name = "tBPalabra";
            tBPalabra.Size = new Size(100, 23);
            tBPalabra.TabIndex = 0;
            tBPalabra.Tag = "tBPalabra";
            tBPalabra.TextChanged += tBPalabra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 165);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Tag = "lbpalabra";
            label1.Text = "Ingrese una palabra";
            // 
            // listBoxVocales
            // 
            listBoxVocales.FormattingEnabled = true;
            listBoxVocales.ItemHeight = 15;
            listBoxVocales.Location = new Point(341, 306);
            listBoxVocales.Name = "listBoxVocales";
            listBoxVocales.Size = new Size(120, 94);
            listBoxVocales.TabIndex = 2;
            listBoxVocales.Tag = "listBoxVocales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(352, 278);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 3;
            label2.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(listBoxVocales);
            Controls.Add(label1);
            Controls.Add(tBPalabra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBPalabra;
        private Label label1;
        private ToolTip toolTip1;
        private ListBox listBoxVocales;
        private Label label2;
    }
}
