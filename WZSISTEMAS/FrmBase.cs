using WZSISTEMAS.WinForms.Helpers;

namespace WZSISTEMAS;

public partial class FrmBase : Form
{
    public FrmBase()
        => InitializeComponent();

    private void FormBase_Load(object sender, EventArgs e)
    {
        if (!DesignMode)
            Helpers.WindowsFormsHelper.Forms.Add(this);
    }

    private void FormBase_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (!DesignMode)
            Helpers.WindowsFormsHelper.Forms.Remove(this);
    }
}
