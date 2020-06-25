namespace MapT
{
    partial class MapTForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapTForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MapTTest = new System.Windows.Forms.Button();
            this.MapTAxMap = new AxMapWinGIS.AxMap();
            this.MaptTreeView = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapTAxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.48466F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.51534F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MapTAxMap, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MaptTreeView, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.57895F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.421053F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 436);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.MapTTest, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(168, 402);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(773, 31);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // MapTTest
            // 
            this.MapTTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MapTTest.Location = new System.Drawing.Point(695, 3);
            this.MapTTest.Name = "MapTTest";
            this.MapTTest.Size = new System.Drawing.Size(75, 23);
            this.MapTTest.TabIndex = 1;
            this.MapTTest.Text = "View";
            this.MapTTest.UseVisualStyleBackColor = true;
            this.MapTTest.Click += new System.EventHandler(this.MapTTest_Click);
            // 
            // MapTAxMap
            // 
            this.MapTAxMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapTAxMap.Enabled = true;
            this.MapTAxMap.Location = new System.Drawing.Point(168, 3);
            this.MapTAxMap.Name = "MapTAxMap";
            this.MapTAxMap.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MapTAxMap.OcxState")));
            this.MapTAxMap.Size = new System.Drawing.Size(773, 393);
            this.MapTAxMap.TabIndex = 1;
            // 
            // MaptTreeView
            // 
            this.MaptTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaptTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaptTreeView.CheckBoxes = true;
            this.MaptTreeView.Location = new System.Drawing.Point(3, 3);
            this.MaptTreeView.Name = "MaptTreeView";
            this.MaptTreeView.Size = new System.Drawing.Size(159, 393);
            this.MaptTreeView.TabIndex = 2;
            this.MaptTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.MaptTreeView_AfterCheck);
            this.MaptTreeView.Click += new System.EventHandler(this.MaptTreeView_Click);
            // 
            // MapTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 447);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MapTForm";
            this.Text = "MapT";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapTAxMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button MapTTest;
        private AxMapWinGIS.AxMap MapTAxMap;
        private System.Windows.Forms.TreeView MaptTreeView;
    }
}

