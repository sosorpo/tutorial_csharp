namespace FTP
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.picUpLoad = new System.Windows.Forms.PictureBox();
            this.btnUpLoad = new System.Windows.Forms.Button();
            this.picDownLoad = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUpLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Location = new System.Drawing.Point(326, 46);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(154, 28);
            this.btnDownLoad.TabIndex = 0;
            this.btnDownLoad.Text = "다운로드 이미지파일";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // picUpLoad
            // 
            this.picUpLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUpLoad.Location = new System.Drawing.Point(12, 29);
            this.picUpLoad.Name = "picUpLoad";
            this.picUpLoad.Size = new System.Drawing.Size(281, 176);
            this.picUpLoad.TabIndex = 1;
            this.picUpLoad.TabStop = false;
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.Location = new System.Drawing.Point(326, 12);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(154, 28);
            this.btnUpLoad.TabIndex = 0;
            this.btnUpLoad.Text = "업로드 이미지파일";
            this.btnUpLoad.UseVisualStyleBackColor = true;
            this.btnUpLoad.Click += new System.EventHandler(this.btnUpLoad_Click);
            // 
            // picDownLoad
            // 
            this.picDownLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDownLoad.Location = new System.Drawing.Point(15, 236);
            this.picDownLoad.Name = "picDownLoad";
            this.picDownLoad.Size = new System.Drawing.Size(281, 191);
            this.picDownLoad.TabIndex = 1;
            this.picDownLoad.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "다운로드 이미지파일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "업로드 이미지파일";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDownLoad);
            this.Controls.Add(this.picUpLoad);
            this.Controls.Add(this.btnUpLoad);
            this.Controls.Add(this.btnDownLoad);
            this.Name = "Form1";
            this.Text = "FTP테스트";
            ((System.ComponentModel.ISupportInitialize)(this.picUpLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownLoad;
        private System.Windows.Forms.PictureBox picUpLoad;
        private System.Windows.Forms.Button btnUpLoad;
        private System.Windows.Forms.PictureBox picDownLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

