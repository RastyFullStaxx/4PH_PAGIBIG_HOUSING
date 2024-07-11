namespace _4PH_PAGIBIG_HOUSING
{
    partial class OverlayForm
    {
        public OverlayForm(Form owner)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.Opacity = 0.60;
            this.StartPosition = FormStartPosition.Manual;
            this.ShowInTaskbar = false;
            this.Owner = owner;
            this.Size = owner.ClientSize;
            this.Location = owner.PointToScreen(Point.Empty);
            owner.Move += (s, e) => this.Location = owner.PointToScreen(Point.Empty);
            owner.SizeChanged += (s, e) => this.Size = owner.ClientSize;
        }
    }}