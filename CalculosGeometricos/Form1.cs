namespace CalculosGeometricos;

public partial class Form1 : Form
{
    private Label? lblFigura;
    private ComboBox? cmbFiguras;
    private Label? lblCalculo;
    private ComboBox? cmbCalculos;
    private Label? lblA;
    private TextBox? txtA;
    private Label? lblB;
    private TextBox? txtB;
    private Label? lblC;
    private TextBox? txtC;
    private Label? lblH;
    private TextBox? txtH;
    private Label? lblResultado;
    private TextBox? txtResultado;
    private Button? btnCalcular;
    private int? value;
    public Form1()
    {
        InitializeComponent();
        InicializarComponenetes();
    }
    private void InicializarComponenetes()
    {
        // Tamaño de la ventana
        this.Size = new Size(300, 350);

        //Etiqueta Figura
        lblFigura = new Label();
        lblFigura.Text = "Figura";
        lblFigura.AutoSize = true;
        lblFigura.Location = new Point(10, 10);

        //ComboBox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Selecciona figura");
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Rectangulo");
        cmbFiguras.Items.Add("Triangulo");
        cmbFiguras.SelectedIndex = 0;
        cmbFiguras.Location = new Point(10, 40);
        cmbFiguras.SelectedValueChanged += new EventHandler(cmb_ValueChanged);

        //Etiqueta Calculo
        lblCalculo = new Label();
        lblCalculo.Text = "Cálculo";
        lblCalculo.AutoSize = true;
        lblCalculo.Location = new Point(150, 10);

        //ComboBox Calculos
        cmbCalculos = new ComboBox();
        cmbCalculos.Items.Add("Selecciona calculo");
        cmbCalculos.Items.Add("Périmetro");
        cmbCalculos.Items.Add("Área");
        cmbCalculos.SelectedIndex = 0;
        cmbCalculos.Location = new Point(150, 40);
        cmbCalculos.SelectedValueChanged += new EventHandler(cmb_ValueChanged);

        //Etiqueta para (a)
        lblA = new Label();
        lblA.Text = "a = ";
        lblA.AutoSize = true;
        lblA.Location = new Point(10, 80);
        lblA.Visible = false;

        //TextBox para (a)
        txtA = new TextBox();
        txtA.Size = new Size(100, 20);
        txtA.Location = new Point(40, 75);
        txtA.Visible = false;

        //Etiqueta para (b)
        lblB = new Label();
        lblB.Text = "b = ";
        lblB.AutoSize = true;
        lblB.Location = new Point(10, 110);
        lblB.Visible = false;

        //TextBox para (b)
        txtB = new TextBox();
        txtB.Size = new Size(100, 20);
        txtB.Location = new Point(40, 105);
        txtB.Visible = false;

        //Etiqueta para (c)
        lblC = new Label();
        lblC.Text = "c = ";
        lblC.AutoSize = true;
        lblC.Location = new Point(10, 140);
        lblC.Visible = false;

        //TextBox para (c)
        txtC = new TextBox();
        txtC.Size = new Size(100, 20);
        txtC.Location = new Point(40, 135);
        txtC.Visible = false;

        //Etiqueta para (h)
        lblH = new Label();
        lblH.Text = "h = ";
        lblH.AutoSize = true;
        lblH.Location = new Point(10, 80);
        lblH.Visible = false;

        //TextBox para (h)
        txtH = new TextBox();
        txtH.Size = new Size(100, 20);
        txtH.Location = new Point(40, 75);
        txtH.Visible = false;

        //Etiqueta Altura
        lblResultado = new Label();
        lblResultado.Text = "Resultado";
        lblResultado.AutoSize = true;
        lblResultado.Location = new Point(10, 280);

        //TextBox Prueba
        txtResultado = new TextBox();
        txtResultado.Size = new Size(100, 20);
        txtResultado.Location = new Point(70, 275);
        txtResultado.Enabled = false;

        //Boton Calcular
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(200, 200);
        btnCalcular.Click += new EventHandler(btnCalcular_Click);

        //Agregar controles a la ventana
        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculos);
        this.Controls.Add(lblA);
        this.Controls.Add(txtA);
        this.Controls.Add(lblB);
        this.Controls.Add(txtB);
        this.Controls.Add(lblC);
        this.Controls.Add(txtC);
        this.Controls.Add(lblH);
        this.Controls.Add(txtH);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);
        this.Controls.Add(btnCalcular);
    }
    private void cmb_ValueChanged(object sender, EventArgs e)
    {
        if (cmbCalculos.SelectedIndex != 0 && cmbFiguras.SelectedIndex != 0)
        {
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado")
            {
                value = 1;
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
                txtH.Text = "";
                txtResultado.Text = "";
                if (cmbCalculos.SelectedItem.ToString() == "Périmetro")
                {
                    txtA.Visible = false;
                    lblA.Visible = false;
                    txtB.Visible = false;
                    lblB.Visible = false;
                    txtC.Visible = false;
                    lblC.Visible = false;
                    txtH.Visible = false;
                    lblH.Visible = false;
                    txtA.Visible = true;
                    lblA.Visible = true;
                }
                if (cmbCalculos.SelectedItem.ToString() == "Área")
                {
                    txtA.Visible = false;
                    lblA.Visible = false;
                    txtB.Visible = false;
                    lblB.Visible = false;
                    txtC.Visible = false;
                    lblC.Visible = false;
                    txtH.Visible = false;
                    lblH.Visible = false;
                    txtA.Visible = true;
                    lblA.Visible = true;
                }
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo")
            {
                value = 2;
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
                txtH.Text = "";
                txtResultado.Text = "";
                if (cmbCalculos.SelectedItem.ToString() == "Périmetro")
                {
                    txtA.Visible = false;
                    lblA.Visible = false;
                    txtB.Visible = false;
                    lblB.Visible = false;
                    txtC.Visible = false;
                    lblC.Visible = false;
                    txtH.Visible = false;
                    lblH.Visible = false;
                    txtA.Visible = true;
                    lblA.Visible = true;
                    txtB.Visible = true;
                    lblB.Visible = true;
                }
                if (cmbCalculos.SelectedItem.ToString() == "Área")
                {
                    txtA.Visible = false;
                    lblA.Visible = false;
                    txtB.Visible = false;
                    lblB.Visible = false;
                    txtC.Visible = false;
                    lblC.Visible = false;
                    txtH.Visible = false;
                    lblH.Visible = false;
                    txtA.Visible = true;
                    lblA.Visible = true;
                    txtB.Visible = true;
                    lblB.Visible = true;
                }
            }
            if (cmbFiguras.SelectedItem.ToString() == "Triangulo")
            {
                value = 3;
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
                txtH.Text = "";
                txtResultado.Text = "";
                if (cmbCalculos.SelectedItem.ToString() == "Périmetro")
                {
                    txtA.Visible = false;
                    lblA.Visible = false;
                    txtB.Visible = false;
                    lblB.Visible = false;
                    txtC.Visible = false;
                    lblC.Visible = false;
                    txtH.Visible = false;
                    lblH.Visible = false;
                    txtA.Visible = true;
                    lblA.Visible = true;
                    txtB.Visible = true;
                    lblB.Visible = true;
                    txtC.Visible = true;
                    lblC.Visible = true;
                }
                if (cmbCalculos.SelectedItem.ToString() == "Área")
                {
                    txtA.Visible = false;
                    lblA.Visible = false;
                    txtB.Visible = false;
                    lblB.Visible = false;
                    txtC.Visible = false;
                    lblC.Visible = false;
                    txtH.Visible = false;
                    lblH.Visible = false;
                    txtH.Visible = true;
                    lblH.Visible = true;
                    txtB.Visible = true;
                    lblB.Visible = true;
                }
            }
        }
        else
        {
            txtA.Visible = false;
            lblA.Visible = false;
            txtB.Visible = false;
            lblB.Visible = false;
            txtC.Visible = false;
            lblC.Visible = false;
            txtH.Visible = false;
            lblH.Visible = false;
        }
    }
    private async void btnCalcular_Click(object sender, EventArgs e)
    {
        string? calculo = cmbCalculos.SelectedItem.ToString();
        string mensaje = "Llena todos los espacios requeridos correctamente : )";
        if (value == 1)
        {
            if (calculo == "Périmetro")
            {
                if (txtA.Text != "" && int.TryParse(txtA.Text, out int num))
                {
                    int a = Convert.ToInt32(txtA.Text);
                    txtResultado.Text = (a * 4).ToString();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            if (calculo == "Área")
            {
                if (txtA.Text != "" && int.TryParse(txtA.Text, out int num))
                {
                    int a = Convert.ToInt32(txtA.Text);
                    txtResultado.Text = (a * a).ToString();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }
        if (value == 2)
        {
            if (calculo == "Périmetro")
            {
                if (txtA.Text != "" && txtB.Text != "" && int.TryParse(txtA.Text, out int num) && int.TryParse(txtB.Text, out int num2))
                {
                    int a = Convert.ToInt32(txtA.Text);
                    int b = Convert.ToInt32(txtB.Text);
                    int resultado = 2 * (a + b);
                    txtResultado.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            if (calculo == "Área")
            {
                if (txtA.Text != "" && txtB.Text != "" && int.TryParse(txtA.Text, out int num) && int.TryParse(txtB.Text, out int num2))
                {
                    int a = Convert.ToInt32(txtA.Text);
                    int b = Convert.ToInt32(txtB.Text);
                    int resultado = b * a;
                    txtResultado.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }
        if (value == 3)
        {
            if (calculo == "Périmetro")
            {
                if (txtA.Text != "" && txtB.Text != "" && txtC.Text != "" && int.TryParse(txtA.Text, out int num) && int.TryParse(txtB.Text, out int num2) && int.TryParse(txtC.Text, out int num3))
                {
                    int a = Convert.ToInt32(txtA.Text);
                    int b = Convert.ToInt32(txtB.Text);
                    int c = Convert.ToInt32(txtC.Text);
                    int resultado = a + b + c;
                    txtResultado.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            if (calculo == "Área")
            {
                if (txtH.Text != "" && txtB.Text != "" && int.TryParse(txtH.Text, out int num) && int.TryParse(txtB.Text, out int num2))
                {
                    int h = Convert.ToInt32(txtH.Text);
                    int b = Convert.ToInt32(txtB.Text);
                    int resultado = (b * h) / 2;
                    txtResultado.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }
    }
}