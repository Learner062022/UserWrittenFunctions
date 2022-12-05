namespace DylanDeSouzaWk15ExA
{
    partial class frmTilingCostEstimator
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
            this.txt_est_job_cost = new System.Windows.Forms.TextBox();
            this.txt_est_tile_cost = new System.Windows.Forms.TextBox();
            this.txt_room_area = new System.Windows.Forms.TextBox();
            this.txt_cost_per_metre = new System.Windows.Forms.TextBox();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.btn_cost_estimate = new System.Windows.Forms.Button();
            this.lblRoomLength = new System.Windows.Forms.Label();
            this.lblRoomWidth = new System.Windows.Forms.Label();
            this.lblCostPerSquareMetre = new System.Windows.Forms.Label();
            this.lbRoomArea = new System.Windows.Forms.Label();
            this.lblEstimateTileCost = new System.Windows.Forms.Label();
            this.lblEstimatedTotalJobCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_est_job_cost
            // 
            this.txt_est_job_cost.Location = new System.Drawing.Point(372, 279);
            this.txt_est_job_cost.Name = "txt_est_job_cost";
            this.txt_est_job_cost.Size = new System.Drawing.Size(100, 20);
            this.txt_est_job_cost.TabIndex = 0;
            // 
            // txt_est_tile_cost
            // 
            this.txt_est_tile_cost.Location = new System.Drawing.Point(372, 253);
            this.txt_est_tile_cost.Name = "txt_est_tile_cost";
            this.txt_est_tile_cost.Size = new System.Drawing.Size(100, 20);
            this.txt_est_tile_cost.TabIndex = 1;
            this.txt_est_tile_cost.TabStop = false;
            // 
            // txt_room_area
            // 
            this.txt_room_area.Location = new System.Drawing.Point(372, 227);
            this.txt_room_area.Name = "txt_room_area";
            this.txt_room_area.Size = new System.Drawing.Size(100, 20);
            this.txt_room_area.TabIndex = 2;
            this.txt_room_area.TabStop = false;
            // 
            // txt_cost_per_metre
            // 
            this.txt_cost_per_metre.Location = new System.Drawing.Point(372, 166);
            this.txt_cost_per_metre.Name = "txt_cost_per_metre";
            this.txt_cost_per_metre.Size = new System.Drawing.Size(100, 20);
            this.txt_cost_per_metre.TabIndex = 3;
            // 
            // txt_width
            // 
            this.txt_width.Location = new System.Drawing.Point(372, 140);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(100, 20);
            this.txt_width.TabIndex = 4;
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(258, 140);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(100, 20);
            this.txt_length.TabIndex = 5;
            // 
            // btn_cost_estimate
            // 
            this.btn_cost_estimate.Location = new System.Drawing.Point(329, 198);
            this.btn_cost_estimate.Name = "btn_cost_estimate";
            this.btn_cost_estimate.Size = new System.Drawing.Size(87, 23);
            this.btn_cost_estimate.TabIndex = 6;
            this.btn_cost_estimate.Text = "Estimate Costs";
            this.btn_cost_estimate.UseVisualStyleBackColor = true;
            this.btn_cost_estimate.Click += new System.EventHandler(this.btnEstimateCosts_Click);
            // 
            // lblRoomLength
            // 
            this.lblRoomLength.AutoSize = true;
            this.lblRoomLength.Location = new System.Drawing.Point(255, 124);
            this.lblRoomLength.Name = "lblRoomLength";
            this.lblRoomLength.Size = new System.Drawing.Size(67, 13);
            this.lblRoomLength.TabIndex = 7;
            this.lblRoomLength.Text = "Room length";
            // 
            // lblRoomWidth
            // 
            this.lblRoomWidth.AutoSize = true;
            this.lblRoomWidth.Location = new System.Drawing.Point(369, 124);
            this.lblRoomWidth.Name = "lblRoomWidth";
            this.lblRoomWidth.Size = new System.Drawing.Size(66, 13);
            this.lblRoomWidth.TabIndex = 8;
            this.lblRoomWidth.Text = "Room Width";
            // 
            // lblCostPerSquareMetre
            // 
            this.lblCostPerSquareMetre.AutoSize = true;
            this.lblCostPerSquareMetre.Location = new System.Drawing.Point(231, 173);
            this.lblCostPerSquareMetre.Name = "lblCostPerSquareMetre";
            this.lblCostPerSquareMetre.Size = new System.Drawing.Size(135, 13);
            this.lblCostPerSquareMetre.TabIndex = 9;
            this.lblCostPerSquareMetre.Text = "The Cost per Square Metre";
            // 
            // lbRoomArea
            // 
            this.lbRoomArea.AutoSize = true;
            this.lbRoomArea.Location = new System.Drawing.Point(242, 234);
            this.lbRoomArea.Name = "lbRoomArea";
            this.lbRoomArea.Size = new System.Drawing.Size(60, 13);
            this.lbRoomArea.TabIndex = 10;
            this.lbRoomArea.Text = "Room Area";
            // 
            // lblEstimateTileCost
            // 
            this.lblEstimateTileCost.AutoSize = true;
            this.lblEstimateTileCost.Location = new System.Drawing.Point(242, 260);
            this.lblEstimateTileCost.Name = "lblEstimateTileCost";
            this.lblEstimateTileCost.Size = new System.Drawing.Size(91, 13);
            this.lblEstimateTileCost.TabIndex = 11;
            this.lblEstimateTileCost.Text = "Estimate Tile Cost";
            // 
            // lblEstimatedTotalJobCost
            // 
            this.lblEstimatedTotalJobCost.AutoSize = true;
            this.lblEstimatedTotalJobCost.Location = new System.Drawing.Point(242, 286);
            this.lblEstimatedTotalJobCost.Name = "lblEstimatedTotalJobCost";
            this.lblEstimatedTotalJobCost.Size = new System.Drawing.Size(124, 13);
            this.lblEstimatedTotalJobCost.TabIndex = 12;
            this.lblEstimatedTotalJobCost.Text = "Estimated Total Job Cost\r\n";
            // 
            // frmTilingCostEstimator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEstimatedTotalJobCost);
            this.Controls.Add(this.lblEstimateTileCost);
            this.Controls.Add(this.lbRoomArea);
            this.Controls.Add(this.lblCostPerSquareMetre);
            this.Controls.Add(this.lblRoomWidth);
            this.Controls.Add(this.lblRoomLength);
            this.Controls.Add(this.btn_cost_estimate);
            this.Controls.Add(this.txt_length);
            this.Controls.Add(this.txt_width);
            this.Controls.Add(this.txt_cost_per_metre);
            this.Controls.Add(this.txt_room_area);
            this.Controls.Add(this.txt_est_tile_cost);
            this.Controls.Add(this.txt_est_job_cost);
            this.Name = "frmTilingCostEstimator";
            this.Text = "Tiling Cost Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_est_job_cost;
        private System.Windows.Forms.TextBox txt_est_tile_cost;
        private System.Windows.Forms.TextBox txt_room_area;
        private System.Windows.Forms.TextBox txt_cost_per_metre;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.Button btn_cost_estimate;
        private System.Windows.Forms.Label lblRoomLength;
        private System.Windows.Forms.Label lblRoomWidth;
        private System.Windows.Forms.Label lblCostPerSquareMetre;
        private System.Windows.Forms.Label lbRoomArea;
        private System.Windows.Forms.Label lblEstimateTileCost;
        private System.Windows.Forms.Label lblEstimatedTotalJobCost;
    }
}

