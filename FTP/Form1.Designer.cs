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
            this.picDownImage = new System.Windows.Forms.PictureBox();
            this.btnUpLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDownImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Location = new System.Drawing.Point(425, 27);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(72, 28);
            this.btnDownLoad.TabIndex = 0;
            this.btnDownLoad.Text = "다운로드";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // picDownImage
            // 
            this.picDownImage.Location = new System.Drawing.Point(28, 27);
            this.picDownImage.Name = "picDownImage";
            this.picDownImage.Size = new System.Drawing.Size(361, 211);
            this.picDownImage.TabIndex = 1;
            this.picDownImage.TabStop = false;
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.Location = new System.Drawing.Point(425, 61);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(72, 28);
            this.btnUpLoad.TabIndex = 0;
            this.btnUpLoad.Text = "업로드";
            this.btnUpLoad.UseVisualStyleBackColor = true;
            this.btnUpLoad.Click += new System.EventHandler(this.btnUpLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 276);
            this.Controls.Add(this.picDownImage);
            this.Controls.Add(this.btnUpLoad);
            this.Controls.Add(this.btnDownLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDownImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDownLoad;
        private System.Windows.Forms.PictureBox picDownImage;
        private System.Windows.Forms.Button btnUpLoad;
    }
}

