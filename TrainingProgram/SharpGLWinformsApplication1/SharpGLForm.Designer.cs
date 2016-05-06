namespace SharpGLWinformsApplication1
{
    partial class SharpGLForm
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
            this.openGLControl = new SharpGL.OpenGLControl();
            this.BTN_LOADMG = new System.Windows.Forms.Button();
            this.LBL_BETA = new System.Windows.Forms.Label();
            this.LBL_GAMMA = new System.Windows.Forms.Label();
            this.LBL_TAU = new System.Windows.Forms.Label();
            this.LBL_POW = new System.Windows.Forms.Label();
            this.TXT_BETA = new System.Windows.Forms.TextBox();
            this.TXT_GAMMA = new System.Windows.Forms.TextBox();
            this.TXT_POW = new System.Windows.Forms.TextBox();
            this.TXT_TAU = new System.Windows.Forms.TextBox();
            this.TXT_N = new System.Windows.Forms.TextBox();
            this.LBL_N = new System.Windows.Forms.Label();
            this.PNL_MACKEY = new System.Windows.Forms.Panel();
            this.CHK_MACKEY_DOTS = new System.Windows.Forms.CheckBox();
            this.CHK_MACKEY = new System.Windows.Forms.CheckBox();
            this.TXT_CLUSTERS = new System.Windows.Forms.TextBox();
            this.LBL_CEN = new System.Windows.Forms.Label();
            this.BTN_LOADFUZZY = new System.Windows.Forms.Button();
            this.PNL_CLUSTERS = new System.Windows.Forms.Panel();
            this.CHK_CLUSTER = new System.Windows.Forms.CheckBox();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_LOAD = new System.Windows.Forms.Button();
            this.BTN_POINTS = new System.Windows.Forms.Button();
            this.CHK_ROTATE_Y = new System.Windows.Forms.CheckBox();
            this.CHK_ROTATE_X = new System.Windows.Forms.CheckBox();
            this.CHK_ROTATE_Z = new System.Windows.Forms.CheckBox();
            this.BTN_FUZZY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.PNL_MACKEY.SuspendLayout();
            this.PNL_CLUSTERS.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl.BackColor = System.Drawing.Color.Red;
            this.openGLControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.openGLControl.DrawFPS = false;
            this.openGLControl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.openGLControl.FrameRate = 30;
            this.openGLControl.Location = new System.Drawing.Point(170, 12);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(941, 672);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            // 
            // BTN_LOADMG
            // 
            this.BTN_LOADMG.BackColor = System.Drawing.Color.Maroon;
            this.BTN_LOADMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LOADMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LOADMG.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BTN_LOADMG.Location = new System.Drawing.Point(12, 12);
            this.BTN_LOADMG.Name = "BTN_LOADMG";
            this.BTN_LOADMG.Size = new System.Drawing.Size(152, 58);
            this.BTN_LOADMG.TabIndex = 1;
            this.BTN_LOADMG.Text = "LOAD MACKEY G";
            this.BTN_LOADMG.UseVisualStyleBackColor = false;
            this.BTN_LOADMG.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBL_BETA
            // 
            this.LBL_BETA.AutoSize = true;
            this.LBL_BETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_BETA.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LBL_BETA.Location = new System.Drawing.Point(9, 4);
            this.LBL_BETA.Name = "LBL_BETA";
            this.LBL_BETA.Size = new System.Drawing.Size(29, 31);
            this.LBL_BETA.TabIndex = 2;
            this.LBL_BETA.Text = "β";
            // 
            // LBL_GAMMA
            // 
            this.LBL_GAMMA.AutoSize = true;
            this.LBL_GAMMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_GAMMA.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LBL_GAMMA.Location = new System.Drawing.Point(9, 44);
            this.LBL_GAMMA.Name = "LBL_GAMMA";
            this.LBL_GAMMA.Size = new System.Drawing.Size(28, 31);
            this.LBL_GAMMA.TabIndex = 3;
            this.LBL_GAMMA.Text = "ɣ";
            // 
            // LBL_TAU
            // 
            this.LBL_TAU.AutoSize = true;
            this.LBL_TAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TAU.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LBL_TAU.Location = new System.Drawing.Point(10, 86);
            this.LBL_TAU.Name = "LBL_TAU";
            this.LBL_TAU.Size = new System.Drawing.Size(28, 31);
            this.LBL_TAU.TabIndex = 4;
            this.LBL_TAU.Text = "τ";
            // 
            // LBL_POW
            // 
            this.LBL_POW.AutoSize = true;
            this.LBL_POW.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_POW.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LBL_POW.Location = new System.Drawing.Point(6, 124);
            this.LBL_POW.Name = "LBL_POW";
            this.LBL_POW.Size = new System.Drawing.Size(67, 31);
            this.LBL_POW.TabIndex = 5;
            this.LBL_POW.Text = "Pow";
            // 
            // TXT_BETA
            // 
            this.TXT_BETA.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TXT_BETA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_BETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_BETA.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_BETA.Location = new System.Drawing.Point(74, 14);
            this.TXT_BETA.Name = "TXT_BETA";
            this.TXT_BETA.Size = new System.Drawing.Size(66, 19);
            this.TXT_BETA.TabIndex = 6;
            this.TXT_BETA.Text = "0.25";
            this.TXT_BETA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_GAMMA
            // 
            this.TXT_GAMMA.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TXT_GAMMA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_GAMMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_GAMMA.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_GAMMA.Location = new System.Drawing.Point(74, 54);
            this.TXT_GAMMA.Name = "TXT_GAMMA";
            this.TXT_GAMMA.Size = new System.Drawing.Size(66, 19);
            this.TXT_GAMMA.TabIndex = 7;
            this.TXT_GAMMA.Text = "0.1";
            this.TXT_GAMMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_POW
            // 
            this.TXT_POW.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TXT_POW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_POW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_POW.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_POW.Location = new System.Drawing.Point(74, 134);
            this.TXT_POW.Name = "TXT_POW";
            this.TXT_POW.Size = new System.Drawing.Size(66, 19);
            this.TXT_POW.TabIndex = 9;
            this.TXT_POW.Text = "10";
            this.TXT_POW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_TAU
            // 
            this.TXT_TAU.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TXT_TAU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_TAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TAU.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_TAU.Location = new System.Drawing.Point(74, 96);
            this.TXT_TAU.Name = "TXT_TAU";
            this.TXT_TAU.Size = new System.Drawing.Size(66, 19);
            this.TXT_TAU.TabIndex = 8;
            this.TXT_TAU.Text = "17";
            this.TXT_TAU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_N
            // 
            this.TXT_N.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TXT_N.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_N.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_N.Location = new System.Drawing.Point(74, 174);
            this.TXT_N.Name = "TXT_N";
            this.TXT_N.Size = new System.Drawing.Size(66, 19);
            this.TXT_N.TabIndex = 11;
            this.TXT_N.Text = "10000";
            this.TXT_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBL_N
            // 
            this.LBL_N.AutoSize = true;
            this.LBL_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_N.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LBL_N.Location = new System.Drawing.Point(10, 164);
            this.LBL_N.Name = "LBL_N";
            this.LBL_N.Size = new System.Drawing.Size(34, 31);
            this.LBL_N.TabIndex = 10;
            this.LBL_N.Text = "N";
            // 
            // PNL_MACKEY
            // 
            this.PNL_MACKEY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PNL_MACKEY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_MACKEY.Controls.Add(this.CHK_MACKEY_DOTS);
            this.PNL_MACKEY.Controls.Add(this.CHK_MACKEY);
            this.PNL_MACKEY.Controls.Add(this.LBL_BETA);
            this.PNL_MACKEY.Controls.Add(this.TXT_N);
            this.PNL_MACKEY.Controls.Add(this.LBL_GAMMA);
            this.PNL_MACKEY.Controls.Add(this.LBL_N);
            this.PNL_MACKEY.Controls.Add(this.LBL_TAU);
            this.PNL_MACKEY.Controls.Add(this.TXT_POW);
            this.PNL_MACKEY.Controls.Add(this.LBL_POW);
            this.PNL_MACKEY.Controls.Add(this.TXT_TAU);
            this.PNL_MACKEY.Controls.Add(this.TXT_BETA);
            this.PNL_MACKEY.Controls.Add(this.TXT_GAMMA);
            this.PNL_MACKEY.Location = new System.Drawing.Point(12, 76);
            this.PNL_MACKEY.Name = "PNL_MACKEY";
            this.PNL_MACKEY.Size = new System.Drawing.Size(152, 267);
            this.PNL_MACKEY.TabIndex = 12;
            // 
            // CHK_MACKEY_DOTS
            // 
            this.CHK_MACKEY_DOTS.AutoSize = true;
            this.CHK_MACKEY_DOTS.Checked = true;
            this.CHK_MACKEY_DOTS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_MACKEY_DOTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_MACKEY_DOTS.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CHK_MACKEY_DOTS.Location = new System.Drawing.Point(15, 233);
            this.CHK_MACKEY_DOTS.Name = "CHK_MACKEY_DOTS";
            this.CHK_MACKEY_DOTS.Size = new System.Drawing.Size(89, 29);
            this.CHK_MACKEY_DOTS.TabIndex = 13;
            this.CHK_MACKEY_DOTS.Text = "DOTS";
            this.CHK_MACKEY_DOTS.UseVisualStyleBackColor = true;
            // 
            // CHK_MACKEY
            // 
            this.CHK_MACKEY.AutoSize = true;
            this.CHK_MACKEY.Checked = true;
            this.CHK_MACKEY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_MACKEY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_MACKEY.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CHK_MACKEY.Location = new System.Drawing.Point(16, 204);
            this.CHK_MACKEY.Name = "CHK_MACKEY";
            this.CHK_MACKEY.Size = new System.Drawing.Size(91, 29);
            this.CHK_MACKEY.TabIndex = 12;
            this.CHK_MACKEY.Text = "LINES";
            this.CHK_MACKEY.UseVisualStyleBackColor = true;
            // 
            // TXT_CLUSTERS
            // 
            this.TXT_CLUSTERS.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TXT_CLUSTERS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_CLUSTERS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CLUSTERS.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_CLUSTERS.Location = new System.Drawing.Point(74, 13);
            this.TXT_CLUSTERS.Name = "TXT_CLUSTERS";
            this.TXT_CLUSTERS.Size = new System.Drawing.Size(66, 19);
            this.TXT_CLUSTERS.TabIndex = 13;
            this.TXT_CLUSTERS.Text = "100";
            this.TXT_CLUSTERS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBL_CEN
            // 
            this.LBL_CEN.AutoSize = true;
            this.LBL_CEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CEN.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LBL_CEN.Location = new System.Drawing.Point(10, 6);
            this.LBL_CEN.Name = "LBL_CEN";
            this.LBL_CEN.Size = new System.Drawing.Size(34, 31);
            this.LBL_CEN.TabIndex = 12;
            this.LBL_CEN.Text = "C";
            // 
            // BTN_LOADFUZZY
            // 
            this.BTN_LOADFUZZY.BackColor = System.Drawing.Color.Maroon;
            this.BTN_LOADFUZZY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LOADFUZZY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LOADFUZZY.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BTN_LOADFUZZY.Location = new System.Drawing.Point(12, 495);
            this.BTN_LOADFUZZY.Name = "BTN_LOADFUZZY";
            this.BTN_LOADFUZZY.Size = new System.Drawing.Size(152, 34);
            this.BTN_LOADFUZZY.TabIndex = 14;
            this.BTN_LOADFUZZY.Text = "LOAD FUZZY";
            this.BTN_LOADFUZZY.UseVisualStyleBackColor = false;
            this.BTN_LOADFUZZY.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PNL_CLUSTERS
            // 
            this.PNL_CLUSTERS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PNL_CLUSTERS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_CLUSTERS.Controls.Add(this.CHK_CLUSTER);
            this.PNL_CLUSTERS.Controls.Add(this.TXT_CLUSTERS);
            this.PNL_CLUSTERS.Controls.Add(this.LBL_CEN);
            this.PNL_CLUSTERS.Location = new System.Drawing.Point(12, 413);
            this.PNL_CLUSTERS.Name = "PNL_CLUSTERS";
            this.PNL_CLUSTERS.Size = new System.Drawing.Size(152, 76);
            this.PNL_CLUSTERS.TabIndex = 15;
            // 
            // CHK_CLUSTER
            // 
            this.CHK_CLUSTER.AutoSize = true;
            this.CHK_CLUSTER.Checked = true;
            this.CHK_CLUSTER.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_CLUSTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_CLUSTER.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CHK_CLUSTER.Location = new System.Drawing.Point(15, 40);
            this.CHK_CLUSTER.Name = "CHK_CLUSTER";
            this.CHK_CLUSTER.Size = new System.Drawing.Size(118, 29);
            this.CHK_CLUSTER.TabIndex = 14;
            this.CHK_CLUSTER.Text = "Visualize";
            this.CHK_CLUSTER.UseVisualStyleBackColor = true;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.BackColor = System.Drawing.Color.Maroon;
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SAVE.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BTN_SAVE.Location = new System.Drawing.Point(12, 652);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(152, 32);
            this.BTN_SAVE.TabIndex = 16;
            this.BTN_SAVE.Text = "SAVE  DATA";
            this.BTN_SAVE.UseVisualStyleBackColor = false;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // BTN_LOAD
            // 
            this.BTN_LOAD.BackColor = System.Drawing.Color.Maroon;
            this.BTN_LOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LOAD.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BTN_LOAD.Location = new System.Drawing.Point(12, 349);
            this.BTN_LOAD.Name = "BTN_LOAD";
            this.BTN_LOAD.Size = new System.Drawing.Size(152, 58);
            this.BTN_LOAD.TabIndex = 17;
            this.BTN_LOAD.Text = "LOAD CLUSTERS";
            this.BTN_LOAD.UseVisualStyleBackColor = false;
            this.BTN_LOAD.Click += new System.EventHandler(this.BTN_LOAD_Click);
            // 
            // BTN_POINTS
            // 
            this.BTN_POINTS.BackColor = System.Drawing.Color.Maroon;
            this.BTN_POINTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_POINTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_POINTS.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BTN_POINTS.Location = new System.Drawing.Point(12, 588);
            this.BTN_POINTS.Name = "BTN_POINTS";
            this.BTN_POINTS.Size = new System.Drawing.Size(152, 58);
            this.BTN_POINTS.TabIndex = 18;
            this.BTN_POINTS.Text = "SAVE  MACKEY";
            this.BTN_POINTS.UseVisualStyleBackColor = false;
            this.BTN_POINTS.Click += new System.EventHandler(this.BTN_POINTS_Click);
            // 
            // CHK_ROTATE_Y
            // 
            this.CHK_ROTATE_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CHK_ROTATE_Y.AutoSize = true;
            this.CHK_ROTATE_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CHK_ROTATE_Y.Checked = true;
            this.CHK_ROTATE_Y.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_ROTATE_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_ROTATE_Y.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CHK_ROTATE_Y.Location = new System.Drawing.Point(251, 662);
            this.CHK_ROTATE_Y.Name = "CHK_ROTATE_Y";
            this.CHK_ROTATE_Y.Size = new System.Drawing.Size(68, 16);
            this.CHK_ROTATE_Y.TabIndex = 14;
            this.CHK_ROTATE_Y.Text = "ROTATE Y";
            this.CHK_ROTATE_Y.UseVisualStyleBackColor = false;
            // 
            // CHK_ROTATE_X
            // 
            this.CHK_ROTATE_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CHK_ROTATE_X.AutoSize = true;
            this.CHK_ROTATE_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CHK_ROTATE_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_ROTATE_X.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CHK_ROTATE_X.Location = new System.Drawing.Point(176, 662);
            this.CHK_ROTATE_X.Name = "CHK_ROTATE_X";
            this.CHK_ROTATE_X.Size = new System.Drawing.Size(69, 16);
            this.CHK_ROTATE_X.TabIndex = 19;
            this.CHK_ROTATE_X.Text = "ROTATE X";
            this.CHK_ROTATE_X.UseVisualStyleBackColor = false;
            // 
            // CHK_ROTATE_Z
            // 
            this.CHK_ROTATE_Z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CHK_ROTATE_Z.AutoSize = true;
            this.CHK_ROTATE_Z.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CHK_ROTATE_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_ROTATE_Z.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CHK_ROTATE_Z.Location = new System.Drawing.Point(325, 662);
            this.CHK_ROTATE_Z.Name = "CHK_ROTATE_Z";
            this.CHK_ROTATE_Z.Size = new System.Drawing.Size(69, 16);
            this.CHK_ROTATE_Z.TabIndex = 20;
            this.CHK_ROTATE_Z.Text = "ROTATE Z";
            this.CHK_ROTATE_Z.UseVisualStyleBackColor = false;
            // 
            // BTN_FUZZY
            // 
            this.BTN_FUZZY.BackColor = System.Drawing.Color.Maroon;
            this.BTN_FUZZY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_FUZZY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FUZZY.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BTN_FUZZY.Location = new System.Drawing.Point(12, 535);
            this.BTN_FUZZY.Name = "BTN_FUZZY";
            this.BTN_FUZZY.Size = new System.Drawing.Size(152, 47);
            this.BTN_FUZZY.TabIndex = 21;
            this.BTN_FUZZY.Text = "SAVE  FUZZY";
            this.BTN_FUZZY.UseVisualStyleBackColor = false;
            this.BTN_FUZZY.Click += new System.EventHandler(this.BTN_FUZZY_Click);
            // 
            // SharpGLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1123, 696);
            this.Controls.Add(this.BTN_FUZZY);
            this.Controls.Add(this.CHK_ROTATE_Z);
            this.Controls.Add(this.CHK_ROTATE_X);
            this.Controls.Add(this.CHK_ROTATE_Y);
            this.Controls.Add(this.BTN_POINTS);
            this.Controls.Add(this.BTN_LOAD);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.PNL_CLUSTERS);
            this.Controls.Add(this.BTN_LOADFUZZY);
            this.Controls.Add(this.PNL_MACKEY);
            this.Controls.Add(this.BTN_LOADMG);
            this.Controls.Add(this.openGLControl);
            this.DoubleBuffered = true;
            this.Name = "SharpGLForm";
            this.Text = "Mackey Glass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SharpGLForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.PNL_MACKEY.ResumeLayout(false);
            this.PNL_MACKEY.PerformLayout();
            this.PNL_CLUSTERS.ResumeLayout(false);
            this.PNL_CLUSTERS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.Button BTN_LOADMG;
        private System.Windows.Forms.Label LBL_BETA;
        private System.Windows.Forms.Label LBL_GAMMA;
        private System.Windows.Forms.Label LBL_TAU;
        private System.Windows.Forms.Label LBL_POW;
        private System.Windows.Forms.TextBox TXT_GAMMA;
        private System.Windows.Forms.TextBox TXT_POW;
        private System.Windows.Forms.TextBox TXT_TAU;
        private System.Windows.Forms.TextBox TXT_N;
        private System.Windows.Forms.Label LBL_N;
        public System.Windows.Forms.TextBox TXT_BETA;
        private System.Windows.Forms.Panel PNL_MACKEY;
        private System.Windows.Forms.TextBox TXT_CLUSTERS;
        private System.Windows.Forms.Label LBL_CEN;
        private System.Windows.Forms.Button BTN_LOADFUZZY;
        private System.Windows.Forms.Panel PNL_CLUSTERS;
        private System.Windows.Forms.CheckBox CHK_MACKEY;
        private System.Windows.Forms.CheckBox CHK_CLUSTER;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_LOAD;
        private System.Windows.Forms.Button BTN_POINTS;
        private System.Windows.Forms.CheckBox CHK_MACKEY_DOTS;
        private System.Windows.Forms.CheckBox CHK_ROTATE_Y;
        private System.Windows.Forms.CheckBox CHK_ROTATE_X;
        private System.Windows.Forms.CheckBox CHK_ROTATE_Z;
        private System.Windows.Forms.Button BTN_FUZZY;
    }
}

