// Decompiled with JetBrains decompiler
// Type: LDChartControlPlus.ChartBarSerie
// Assembly: LDChartControlPlus, Version=1.0.3873.26967, Culture=neutral, PublicKeyToken=null
// MVID: B87EBCC8-B602-40E5-94CA-0C821CC4B7FA
// Assembly location: G:\Projetos\GITEA\LDChartControlPlus\LDChartControlPlus.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Windows.Forms;

#nullable disable
namespace LDChartControlPlus;

[ToolboxBitmap("D:\\Visual Studio 2005\\Projects\\LDChartControlPlus\\Resources\\ChartBar.bmp")]
public class ChartBarSerie : UserControl
{
  private List<ChartBarSerie.ItemsChartSerie> m_itemsChartSerie;
  private List<Color> m_colorsLegends;
  private List<string> m_legends;
  private Font m_legendsLabelFont;
  private float m_maxValue;
  private int m_barCount;
  private float m_itemsTotalValue;
  private string m_titleTop;
  private bool m_showTitleTop;
  private Font m_titleFontTop;
  private Color m_titleColorTop;
  private Color m_BGColor1;
  private Color m_BGColor2;
  private Image m_BGImage;
  private int m_colorMatrix;
  private ChartStyle m_ChartStyle;
  private ImageAttributes m_BGImageAttributes;
  private LinearGradientMode m_BGLinearGradientMode;
  private Color m_gridLineColor;
  private Pen m_gridLinePen;
  private Color m_gridColor;
  private DashStyle m_gridDashStyle;
  private Pen m_gridPen;
  private Color m_gridBGColor;
  private bool m_barGradientColor;
  private LinearGradientMode m_barLinearGradientMode;
  private bool m_showHighlightValue;
  private bool m_showPercentValue;
  private int m_rotateLabelValue;
  private Font m_barLabelFont;
  private Font m_barValueFont;
  private Color m_barLabelColor;
  private string m_legendY;
  private bool m_showLegendY;
  private Font m_legendYFont;
  private Color m_legendYColor;
  private int m_maxStepValueY;
  private int m_stepValueY;
  private Color m_stepColorValueY;
  private Font m_stepValueYFont;
  private bool m_ShowGridY;
  private bool m_ShowGridX;
  private int m_maxCountCharLineLabelX;
  private DirectionLabel m_labelXDirection;
  private RotateFlipType m_rotateFlipType;
  private IContainer components;
  private ToolTip toolTip1;

  [Description("Define a cor do grid.")]
  [Category("Grid")]
  public Color GridColor
  {
    get => this.m_gridColor;
    set
    {
      this.m_gridColor = value;
      this.m_gridPen = new Pen(this.m_gridColor);
      this.m_gridPen.DashStyle = this.m_gridDashStyle;
      this.Invalidate();
    }
  }

  [Description("Define a cor da linha do retângulo do grid.")]
  [Category("Grid")]
  public Color GridLineColor
  {
    get => this.m_gridLineColor;
    set
    {
      this.m_gridLineColor = value;
      this.m_gridLinePen = new Pen(this.m_gridLineColor);
      this.Invalidate();
    }
  }

  [Category("Grid")]
  [Description("Define se dever mostrar o grid do eixo Y..")]
  public bool ShowGridY
  {
    get => this.m_ShowGridY;
    set
    {
      this.m_ShowGridY = value;
      this.Invalidate();
    }
  }

  [Description("Define se dever mostrar o grid do eixo X.")]
  [Category("Grid")]
  public bool ShowGridX
  {
    get => this.m_ShowGridX;
    set
    {
      this.m_ShowGridX = value;
      this.Invalidate();
    }
  }

  [Category("Grid")]
  [Description("Define o estilo da linha do grid.")]
  public DashStyle GridDashStyle
  {
    get => this.m_gridDashStyle;
    set
    {
      this.m_gridDashStyle = value;
      this.m_gridPen = new Pen(this.m_gridColor);
      this.m_gridPen.DashStyle = this.m_gridDashStyle;
      this.Invalidate();
    }
  }

  [Category("Grid")]
  [Description("Define a cor do grid.")]
  public Color GridBGColor
  {
    get => this.m_gridBGColor;
    set
    {
      this.m_gridBGColor = value;
      this.Invalidate();
    }
  }

  [Description("Fonte do Label da barra.")]
  [Category("Bar")]
  public Font LegendsLabelFont
  {
    get => this.m_legendsLabelFont;
    set
    {
      this.m_legendsLabelFont = value;
      this.Invalidate();
    }
  }

  [Description("Direção da Cor de fundo gradiente.")]
  [Category("Bar")]
  public LinearGradientMode BarLinearGradientMode
  {
    get => this.m_barLinearGradientMode;
    set
    {
      this.m_barLinearGradientMode = value;
      this.Invalidate();
    }
  }

  [Category("Bar")]
  [Description("Se deseja a Cor de fundo gradiente ou não.")]
  public bool BarGradientColor
  {
    get => this.m_barGradientColor;
    set
    {
      this.m_barGradientColor = value;
      this.Invalidate();
    }
  }

  [Description("Destaca o valor no topo da barra ou não.")]
  [Category("Bar")]
  public bool ShowHighlightValue
  {
    get => this.m_showHighlightValue;
    set
    {
      this.m_showHighlightValue = value;
      this.Invalidate();
    }
  }

  [Description("Fonte do Label da barra.")]
  [Category("Bar")]
  public Font BarLabelFont
  {
    get => this.m_barLabelFont;
    set
    {
      this.m_barLabelFont = value;
      this.Invalidate();
    }
  }

  [Description("Fonte do valor da barra.")]
  [Category("Bar")]
  public Font BarValueFont
  {
    get => this.m_barValueFont;
    set
    {
      this.m_barValueFont = value;
      this.Invalidate();
    }
  }

  [Description("Cor da Fonte do Label da barra.")]
  [Category("Bar")]
  public Color BarLabelColor
  {
    get => this.m_barLabelColor;
    set
    {
      this.m_barLabelColor = value;
      this.Invalidate();
    }
  }

  [Category("Bar")]
  [Description("Mostra o valor em porcentagem no topo da barra.")]
  public bool ShowPercentValue
  {
    get => this.m_showPercentValue;
    set
    {
      this.m_showPercentValue = value;
      this.Invalidate();
    }
  }

  [Category("Bar")]
  [Description("Define o valor que o texto do valor da barra deve rotacionar.")]
  public int RotateLabelValue
  {
    get => this.m_rotateLabelValue;
    set
    {
      this.m_rotateLabelValue = value;
      this.Invalidate();
    }
  }

  [Description("Cor de fundo 1")]
  [Category("Chart")]
  public Color BGColor1
  {
    get => this.m_BGColor1;
    set
    {
      this.m_BGColor1 = value;
      this.Invalidate();
    }
  }

  [Category("Chart")]
  [Description("Cor de fundo 2")]
  public Color BGColor2
  {
    get => this.m_BGColor2;
    set
    {
      this.m_BGColor2 = value;
      this.Invalidate();
    }
  }

  [Description("Direção da Cor de fundo gradiente.")]
  [Category("Chart")]
  public LinearGradientMode BGLinearGradientMode
  {
    get => this.m_BGLinearGradientMode;
    set
    {
      this.m_BGLinearGradientMode = value;
      this.Invalidate();
    }
  }

  [Category("Chart")]
  [Description("Define/resgata o texto do título.")]
  public string Title
  {
    get => this.m_titleTop;
    set
    {
      this.m_titleTop = value;
      this.Invalidate();
    }
  }

  [Description("Define se dever mostrar o título.")]
  [Category("Chart")]
  public bool ShowTitle
  {
    get => this.m_showTitleTop;
    set
    {
      this.m_showTitleTop = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata a fonte do texto do título.")]
  [Category("Chart")]
  public Font TitleFont
  {
    get => this.m_titleFontTop;
    set
    {
      this.m_titleFontTop = value;
      this.Invalidate();
    }
  }

  [Category("Chart")]
  [Description("Define/resgata a Cor do texto do título.")]
  public Color TitleColor
  {
    get => this.m_titleColorTop;
    set
    {
      this.m_titleColorTop = value;
      this.Invalidate();
    }
  }

  [Category("Chart")]
  [Description("Image de fundo")]
  public Image BGImage
  {
    get => this.m_BGImage;
    set
    {
      this.m_BGImage = value;
      this.Invalidate();
    }
  }

  [Category("Chart")]
  [Description("Valor da tranparência da imagem de fundo.")]
  public int BGImageTransparentValue
  {
    get => this.m_colorMatrix;
    set
    {
      this.m_colorMatrix = value;
      this.m_BGImageAttributes.SetColorMatrix(new ColorMatrix()
      {
        Matrix33 = (float) this.m_colorMatrix
      });
      this.Invalidate();
    }
  }

  [Description("Valor da tranparência da imagem de fundo.")]
  [Category("Chart")]
  public ChartStyle ChartStyle
  {
    get => this.m_ChartStyle;
    set
    {
      this.m_ChartStyle = value;
      this.Invalidate();
    }
  }

  [Category("Eixo Y")]
  [Description("Define/resgata o legenda do eixo Y.")]
  public string LegendY
  {
    get => this.m_legendY;
    set
    {
      this.m_legendY = value;
      this.Invalidate();
    }
  }

  [Category("Eixo Y")]
  [Description("Define se dever mostrar a legenda do eixo Y.")]
  public bool ShowLegendY
  {
    get => this.m_showLegendY;
    set
    {
      this.m_showLegendY = value;
      this.Invalidate();
    }
  }

  [Category("Eixo Y")]
  [Description("Define/resgata a fonte da legenda do eixo Y.")]
  public Font LegendYFont
  {
    get => this.m_legendYFont;
    set
    {
      this.m_legendYFont = value;
      this.Invalidate();
    }
  }

  [Category("Eixo Y")]
  [Description("Define/resgata a Cor da legenda do eixo Y.")]
  public Color LegendYColor
  {
    get => this.m_legendYColor;
    set
    {
      this.m_legendYColor = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata o valor máximo do eixo Y.")]
  [Category("Eixo Y")]
  public int MaxValueY
  {
    get => this.m_maxStepValueY;
    set
    {
      this.m_maxStepValueY = value;
      this.Invalidate();
    }
  }

  [Category("Eixo Y")]
  [Description("Define/resgata o step value do eixo Y.")]
  public int StepValueY
  {
    get => this.m_stepValueY;
    set
    {
      this.m_stepValueY = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata a Cor do step value do eixo Y.")]
  [Category("Eixo Y")]
  public Color StepColorValueY
  {
    get => this.m_stepColorValueY;
    set
    {
      this.m_stepColorValueY = value;
      this.Invalidate();
    }
  }

  [Category("Eixo X")]
  [Description("Quantidade máxima de caracteres do label do eixo X.")]
  public int MaxCountCharLineLabelX
  {
    get => this.m_maxCountCharLineLabelX;
    set
    {
      this.m_maxCountCharLineLabelX = value;
      this.Invalidate();
    }
  }

  [Description("Direção do label do eixo X.")]
  [Category("Eixo X")]
  [DefaultValue(DirectionLabel.Horizontal)]
  public DirectionLabel LabelXDirection
  {
    get => this.m_labelXDirection;
    set
    {
      this.m_labelXDirection = value;
      this.Invalidate();
    }
  }

  [Category("Eixo X")]
  [DefaultValue(RotateFlipType.RotateNoneFlipNone)]
  [Description("Direção do label do eixo X.")]
  public RotateFlipType RotacaoLegenda
  {
    get => this.m_rotateFlipType;
    set
    {
      this.m_rotateFlipType = value;
      this.Invalidate();
    }
  }

  public ChartBarSerie()
  {
    this.InitializeComponent();
    this.SetStyle(ControlStyles.UserPaint, true);
    this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
    this.SetStyle(ControlStyles.DoubleBuffer, true);
    this.SetStyle(ControlStyles.ResizeRedraw, true);
    this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
    this.BackColor = Color.White;
    this.m_titleTop = "Título";
    this.m_showTitleTop = false;
    this.m_titleFontTop = new Font("Tahoma", 10f, FontStyle.Bold);
    this.m_titleColorTop = Color.SteelBlue;
    this.m_legendY = "Legenda Y";
    this.m_showLegendY = false;
    this.m_legendYFont = new Font("Tahoma", 8f, FontStyle.Bold);
    this.m_legendYColor = Color.CadetBlue;
    this.m_stepValueY = 10;
    this.m_maxStepValueY = 100;
    this.m_stepValueYFont = new Font("Tahoma", 8f, FontStyle.Bold);
    this.m_ShowGridY = true;
    this.m_stepColorValueY = Color.Maroon;
    this.m_ShowGridX = true;
    this.m_maxCountCharLineLabelX = 20;
    this.m_labelXDirection = DirectionLabel.Horizontal;
    this.m_rotateLabelValue = 0;
    this.m_maxValue = 0.0f;
    this.m_barCount = 0;
    this.m_ChartStyle = ChartStyle.StyleNormal;
    this.m_gridColor = Color.DarkGray;
    this.m_gridDashStyle = DashStyle.Dot;
    this.m_gridPen = new Pen(this.m_gridColor);
    this.m_gridPen.DashStyle = this.m_gridDashStyle;
    this.m_gridBGColor = Color.WhiteSmoke;
    this.m_gridLineColor = Color.Black;
    this.m_gridLinePen = new Pen(this.m_gridLineColor);
    this.m_BGColor1 = Color.White;
    this.m_BGColor2 = Color.White;
    this.m_BGLinearGradientMode = LinearGradientMode.Horizontal;
    this.m_BGImage = (Image) null;
    this.m_BGImageAttributes = new ImageAttributes();
    this.m_colorMatrix = 200;
    this.m_itemsTotalValue = 0.0f;
    this.m_showPercentValue = true;
    this.m_showHighlightValue = true;
    this.m_barGradientColor = true;
    this.m_barLinearGradientMode = LinearGradientMode.Horizontal;
    this.m_barLabelFont = new Font("Tahoma", 8f, FontStyle.Regular);
    this.m_barLabelColor = Color.Navy;
    this.m_barValueFont = new Font("Tahoma", 8f, FontStyle.Bold);
    this.m_itemsChartSerie = new List<ChartBarSerie.ItemsChartSerie>();
    this.m_colorsLegends = new List<Color>();
    this.m_legends = new List<string>();
    this.m_legendsLabelFont = new Font("Tahoma", 8f, FontStyle.Regular);
    List<string> legends = new List<string>();
    List<Color> colorsLegends = new List<Color>();
    colorsLegends.Add(Color.Blue);
    colorsLegends.Add(Color.Red);
    colorsLegends.Add(Color.Green);
    colorsLegends.Add(Color.Blue);
    colorsLegends.Add(Color.Red);
    colorsLegends.Add(Color.Green);
    colorsLegends.Add(Color.Blue);
    colorsLegends.Add(Color.Red);
    colorsLegends.Add(Color.Green);
    colorsLegends.Add(Color.Blue);
    colorsLegends.Add(Color.Red);
    colorsLegends.Add(Color.Green);
    colorsLegends.Add(Color.Blue);
    colorsLegends.Add(Color.Red);
    colorsLegends.Add(Color.Green);
    legends.Add("Controle criado");
    legends.Add("Por Luciano Dória");
    List<ChartBarSerie.ItemsChartSerie> lstItemsChartSerie = new List<ChartBarSerie.ItemsChartSerie>();
    ChartBarSerie.ItemsChartSerie itemsChartSerie = new ChartBarSerie.ItemsChartSerie();
    List<float> floatList1 = new List<float>();
    itemsChartSerie.Label = "Quantidade";
    floatList1.Add(60f);
    floatList1.Add(40f);
    floatList1.Add(10f);
    itemsChartSerie.Value = floatList1;
    lstItemsChartSerie.Add(itemsChartSerie);
    List<float> floatList2 = new List<float>();
    itemsChartSerie.Label = "Pesquisas Feitas";
    floatList2.Add(80f);
    floatList2.Add(120f);
    floatList2.Add(190f);
    itemsChartSerie.Value = floatList2;
    lstItemsChartSerie.Add(itemsChartSerie);
    this.AddItems(lstItemsChartSerie, colorsLegends, legends);
  }

  public void AddItems(
    List<ChartBarSerie.ItemsChartSerie> lstItemsChartSerie,
    List<Color> colorsLegends,
    List<string> legends)
  {
    this.ClearItems();
    if (lstItemsChartSerie == null)
      return;
    this.m_legends = legends;
    this.m_colorsLegends = colorsLegends;
    this.m_itemsChartSerie = lstItemsChartSerie;
    for (int index1 = this.m_itemsChartSerie.Count - 1; index1 >= 0; --index1)
    {
      for (int index2 = 0; index2 < this.m_itemsChartSerie[index1].Value.Count; ++index2)
      {
        if ((double) this.m_itemsChartSerie[index1].Value[index2] > (double) this.m_maxValue)
          this.m_maxValue = this.m_itemsChartSerie[index1].Value[index2];
        this.m_itemsTotalValue += this.m_itemsChartSerie[index1].Value[index2];
      }
    }
    this.m_barCount = this.m_itemsChartSerie.Count * this.m_legends.Count + this.m_itemsChartSerie.Count;
    if ((double) this.m_maxValue < 1000.0)
    {
      long num1 = (long) ((int) this.m_maxValue % 100);
      long num2 = (long) ((int) this.m_maxValue / 100);
      if (num1 > 0L)
        ++num2;
      this.m_maxStepValueY = (int) num2 * 100;
    }
    else
    {
      long num3 = (long) ((int) this.m_maxValue % 1000);
      long num4 = (long) ((int) this.m_maxValue / 1000);
      if (num3 > 0L)
        ++num4;
      this.m_maxStepValueY = (int) num4 * 1000;
    }
    this.m_stepValueY = this.m_maxStepValueY / 10;
    if ((double) this.m_maxValue > (double) (this.m_maxStepValueY - this.m_stepValueY))
      this.m_maxStepValueY += this.m_stepValueY * 2;
    this.Invalidate();
  }

  public void ClearItems()
  {
    this.m_itemsChartSerie.Clear();
    this.m_maxValue = 0.0f;
    this.m_itemsTotalValue = 0.0f;
    this.Invalidate();
  }

  public Bitmap GetBitmapFromGraphic(bool setClipBoard)
  {
    try
    {
      Application.DoEvents();
      Bitmap image = Utilitarios.GetImage(this.Handle, this.Width, this.Height);
      if (setClipBoard)
        Clipboard.SetImage((Image) image);
      return image;
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    float num1 = 10f;
    float num2 = 10f;
    float num3 = 10f;
    float num4 = 20f;
    int num5 = this.Width - 20;
    RectangleF rect1 = new RectangleF();
    SizeF sizeF1 = new SizeF(0.0f, 0.0f);
    SizeF sizeF2 = new SizeF(0.0f, 0.0f);
    SizeF sizeF3 = new SizeF(0.0f, 0.0f);
    Graphics graphics = e.Graphics;
    try
    {
      if (this.m_maxStepValueY <= 0)
      {
        this.m_maxStepValueY = 100;
        this.m_stepValueY = 10;
      }
      if ((double) this.m_maxValue > (double) (this.m_maxStepValueY - this.m_stepValueY))
        this.m_maxStepValueY += this.m_stepValueY * 2;
      graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
      graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
      if (this.m_showTitleTop)
        sizeF1 = graphics.MeasureString(this.m_titleTop, this.m_titleFontTop);
      if (this.m_showLegendY)
        sizeF2 = graphics.MeasureString(this.m_legendY, this.m_legendYFont);
      SizeF sizeF4 = graphics.MeasureString("TESTE", this.m_barLabelFont);
      SizeF sizeF5 = graphics.MeasureString("TESTE", this.m_legendsLabelFont);
      RectangleF rectangleF1 = new RectangleF();
      rectangleF1.Width = (float) (this.m_legends.Count * 5 + 10);
      for (int index = 0; index < this.m_legends.Count; ++index)
      {
        SizeF sizeF6 = graphics.MeasureString(this.m_legends[index], this.m_legendsLabelFont);
        rectangleF1.Width += (float) ((double) sizeF6.Height + 3.0 + (double) sizeF6.Width + 10.0);
      }
      int num6 = (int) ((double) rectangleF1.Width / (double) num5);
      int num7 = (int) ((double) rectangleF1.Width % (double) num5);
      int num8;
      if (num6 <= 0)
      {
        num8 = 2;
      }
      else
      {
        if (num7 > 0)
          ++num6;
        num8 = num6 * 3;
      }
      SizeF sizeF7 = graphics.MeasureString(this.m_maxStepValueY.ToString(), this.m_stepValueYFont);
      float num9 = num3 + sizeF1.Height;
      float num10 = num1 + (float) ((double) sizeF2.Height + (double) sizeF7.Width + 5.0);
      float num11 = num4 + (sizeF5.Height * (float) num8 + sizeF5.Height + sizeF4.Height);
      int num12 = this.m_maxStepValueY / this.m_stepValueY;
      float num13 = ((float) this.Height - (num9 + num11)) / (float) num12;
      rect1.X = num10;
      rect1.Y = num9;
      rect1.Width = (float) this.Width - (num10 + num2);
      rect1.Height = num13 * (float) num12;
      Rectangle rect2 = new Rectangle(0, 0, this.Width, this.Height);
      graphics.FillRectangle((Brush) new LinearGradientBrush(rect2, this.m_BGColor1, this.m_BGColor2, this.m_BGLinearGradientMode), rect2);
      graphics.FillRectangle((Brush) new SolidBrush(this.m_gridBGColor), rect1);
      if (this.m_showTitleTop)
      {
        PointF pointF = new PointF((float) ((double) rect1.Left + (double) rect1.Width * 0.5 - (double) sizeF1.Width * 0.5), 5f);
        Function.DrawString(ref graphics, this.m_titleTop, this.m_titleFontTop, this.m_titleColorTop, pointF);
      }
      if (this.m_showLegendY)
      {
        StringFormat format = new StringFormat();
        format.FormatFlags = StringFormatFlags.DirectionVertical;
        PointF point = new PointF(5f, (float) ((double) rect1.Top + (double) rect1.Height * 0.5 - (double) sizeF2.Width * 0.5));
        graphics.DrawString(this.m_legendY, this.m_legendYFont, (Brush) new SolidBrush(this.m_legendYColor), point, format);
      }
      if (this.m_BGImage != null)
      {
        Rectangle destRect = new Rectangle();
        int num14 = (double) this.m_BGImage.Width < (double) rect1.Width ? (int) (double) this.m_BGImage.Width : (int) ((double) rect1.Width - 20.0);
        int num15 = (double) this.m_BGImage.Height < (double) rect1.Height ? (int) (double) this.m_BGImage.Height : (int) ((double) rect1.Height - 20.0);
        destRect.Width = num14;
        destRect.Height = num15;
        destRect.X = (int) ((double) rect1.Left + (double) rect1.Width * 0.5 - (double) (num14 / 2));
        destRect.Y = (int) ((double) rect1.Top + (double) rect1.Height * 0.5 - (double) (num15 / 2));
        graphics.DrawImage(this.m_BGImage, destRect, 0, 0, this.m_BGImage.Width, this.m_BGImage.Height, GraphicsUnit.Pixel, this.m_BGImageAttributes);
      }
      this.m_gridPen.DashStyle = this.m_gridDashStyle;
      PointF pointF1 = new PointF();
      PointF pt2 = new PointF();
      PointF pt1 = new PointF();
      pointF1.Y = rect1.Top;
      pointF1.X = rect1.Left;
      pt2.X = rect1.Right;
      pt1.X = rect1.Left - 5f;
      for (int index = 0; index <= num12; ++index)
      {
        pt2.Y = pointF1.Y;
        pt1.Y = pointF1.Y;
        if (this.m_ShowGridY)
          graphics.DrawLine(this.m_gridPen, pointF1, pt2);
        graphics.DrawLine(this.m_gridLinePen, pt1, pointF1);
        int num16 = this.m_maxStepValueY - index * this.m_stepValueY;
        SizeF sizeF8 = graphics.MeasureString(num16.ToString(), this.m_stepValueYFont);
        PointF pointF2 = new PointF((float) ((double) rect1.Left - (double) sizeF8.Width - 5.0), pointF1.Y - sizeF8.Height * 0.5f);
        Function.DrawString(ref graphics, num16.ToString(), this.m_stepValueYFont, this.m_stepColorValueY, pointF2);
        pointF1.Y += num13;
      }
      float num17 = rect1.Height / (float) this.m_maxStepValueY;
      float num18 = rect1.Width / (float) this.m_barCount;
      float num19 = num18 * 0.5f;
      int index1 = 0;
      int index2 = 0;
      int num20 = 2;
      RectangleF rect3 = new RectangleF();
      rect3.Width = num18;
      rect3.X = rect1.Left + num19;
      float x = rect3.X;
      if (this.m_ShowGridX)
      {
        graphics.DrawLine(this.m_gridPen, new PointF(rect1.Left + num19, rect1.Bottom), new PointF(rect1.Left + num19, rect1.Top));
        graphics.DrawLine(this.m_gridPen, new PointF(rect1.Left + num19 + rect3.Width, rect1.Bottom), new PointF(rect1.Left + num19 + rect3.Width, rect1.Top));
      }
      for (int index3 = 0; index3 < this.m_barCount - 1; ++index3)
      {
        if (this.m_ShowGridX && num20 < this.m_barCount - 1)
        {
          graphics.DrawLine(this.m_gridPen, new PointF((float) ((double) rect1.Left + (double) num19 + (double) rect3.Width * (double) num20), rect1.Bottom), new PointF((float) ((double) rect1.Left + (double) num19 + (double) rect3.Width * (double) num20), rect1.Top));
          graphics.DrawLine(this.m_gridPen, new PointF((float) ((double) rect1.Left + (double) num19 + (double) rect3.Width * (double) (num20 + 1)), rect1.Bottom), new PointF((float) ((double) rect1.Left + (double) num19 + (double) rect3.Width * (double) (num20 + 1)), rect1.Top));
        }
        if (index2 < this.m_itemsChartSerie.Count)
        {
          Color colorsLegend = this.m_colorsLegends[index1];
          float num21 = this.m_itemsChartSerie[index2].Value[index1];
          PointF pointF3;
          if ((double) num21 > 0.0)
          {
            float num22 = rect1.Bottom - num21 * num17;
            rect3.Height = num21 * num17;
            rect3.Y = num22;
            if (this.m_barGradientColor)
            {
              Color baseColor1 = RGBHSL.SetBrightness(colorsLegend, 0.7);
              Color baseColor2 = RGBHSL.SetBrightness(colorsLegend, 0.3);
              GraphicsPath path = new GraphicsPath();
              path.AddRectangle(rect3);
              PathGradientBrush pathGradientBrush = new PathGradientBrush(path);
              pathGradientBrush.CenterColor = Color.FromArgb((int) byte.MaxValue, baseColor1);
              pathGradientBrush.CenterPoint = new PointF(rect3.X + rect3.Width * 0.5f, 0.0f);
              Color[] colorArray = new Color[1]
              {
                Color.FromArgb((int) byte.MaxValue, baseColor2)
              };
              pathGradientBrush.SurroundColors = colorArray;
              pathGradientBrush.FocusScales = new PointF(1f / 1000f, 1f);
              graphics.FillRectangle((Brush) pathGradientBrush, rect3);
            }
            else
              graphics.FillRectangle((Brush) new SolidBrush(colorsLegend), rect3);
            graphics.DrawRectangle(new Pen(Color.Black, 1f), rect3.X, rect3.Y, rect3.Width, rect3.Height);
            SizeF sizeF9 = graphics.MeasureString(num21.ToString("#.##"), this.m_barValueFont);
            pointF3 = new PointF((float) ((double) rect3.X + (double) rect3.Width * 0.5 - (double) sizeF9.Width * 0.5), num22 - sizeF9.Height * 1.2f);
            if (this.m_showHighlightValue)
            {
              RectangleF rectangleF2 = new RectangleF();
              rectangleF2.Width = sizeF9.Width + sizeF9.Width * 0.2f;
              rectangleF2.Height = sizeF9.Height - 2f;
              rectangleF2.X = pointF3.X - sizeF9.Width * 0.1f;
              rectangleF2.Y = pointF3.Y;
              graphics.FillRectangle((Brush) new SolidBrush(Color.Ivory), rectangleF2.X, rectangleF2.Y, rectangleF2.Width, rectangleF2.Height);
              graphics.DrawRectangle(new Pen(Color.Black), rectangleF2.X, rectangleF2.Y, rectangleF2.Width, rectangleF2.Height);
              graphics.DrawLine(new Pen(Color.Black), rect3.X + rect3.Width * 0.5f, rect3.Y, rect3.X + rect3.Width * 0.5f, pointF3.Y + (sizeF9.Height - 2f));
            }
            graphics.DrawString(num21.ToString("#.##"), this.m_barValueFont, (Brush) new SolidBrush(Color.Navy), pointF3);
          }
          else
          {
            SizeF sizeF10 = graphics.MeasureString("0", this.m_barValueFont);
            float bottom = rect1.Bottom;
            pointF3 = new PointF((float) ((double) rect3.X + (double) rect3.Width * 0.5 - (double) sizeF10.Width * 0.5), bottom - sizeF10.Height * 1.2f);
            if (this.m_showHighlightValue)
            {
              RectangleF rectangleF3 = new RectangleF();
              rectangleF3.Width = sizeF10.Width + sizeF10.Width * 0.2f;
              rectangleF3.Height = sizeF10.Height - 2f;
              rectangleF3.X = pointF3.X - sizeF10.Width * 0.1f;
              rectangleF3.Y = pointF3.Y;
              graphics.FillRectangle((Brush) new SolidBrush(Color.Ivory), rectangleF3.X, rectangleF3.Y, rectangleF3.Width, rectangleF3.Height);
              graphics.DrawRectangle(new Pen(Color.Black), rectangleF3.X, rectangleF3.Y, rectangleF3.Width, rectangleF3.Height);
              graphics.DrawLine(new Pen(Color.Black), rect3.X + rect3.Width * 0.5f, rectangleF3.Bottom, rect3.X + rect3.Width * 0.5f, rect1.Bottom);
            }
            graphics.DrawString("0", this.m_barValueFont, (Brush) new SolidBrush(Color.Navy), pointF3);
          }
          if (index1 == this.m_legends.Count - 1)
          {
            float num23 = x + (float) (((double) rect3.X + (double) rect3.Width - (double) x) * 0.5);
            if (this.m_itemsChartSerie[index2].Label.Length > this.m_maxCountCharLineLabelX)
            {
              List<string> stringList = new List<string>();
              string[] strArray = this.m_itemsChartSerie[index2].Label.Split(' ');
              for (int index4 = 0; index4 < strArray.Length; ++index4)
              {
                if (stringList.Count > 0)
                {
                  int index5 = stringList.Count - 1;
                  if (strArray[index4].Length + stringList[index5].Length < this.m_maxCountCharLineLabelX)
                    stringList[index5] = $"{stringList[index5]} {strArray[index4]}";
                  else
                    stringList.Add(strArray[index4]);
                }
                else
                  stringList.Add(strArray[index4]);
              }
              for (int index6 = 0; index6 < stringList.Count; ++index6)
              {
                SizeF sizeF11 = graphics.MeasureString(stringList[index6], this.m_barLabelFont);
                pointF3 = new PointF(num23 - sizeF11.Width * 0.5f, (float) ((double) rect1.Bottom + 5.0 + (double) sizeF11.Height * (double) index6));
                graphics.DrawString(stringList[index6], this.m_barLabelFont, (Brush) new SolidBrush(this.m_barLabelColor), pointF3);
              }
            }
            else if (this.m_labelXDirection == DirectionLabel.Horizontal)
            {
              SizeF sizeF12 = graphics.MeasureString(this.m_itemsChartSerie[index2].Label, this.m_barLabelFont);
              pointF3 = new PointF(num23 - sizeF12.Width * 0.5f, rect1.Bottom + 5f);
              graphics.DrawString(this.m_itemsChartSerie[index2].Label, this.m_barLabelFont, (Brush) new SolidBrush(this.m_barLabelColor), pointF3);
            }
            else
            {
              SizeF sizeF13 = graphics.MeasureString(this.m_itemsChartSerie[index2].Label, this.m_barLabelFont);
              pointF3 = new PointF(num23 - sizeF13.Height / 2f, num11 + sizeF13.Height);
              Function.DrawString(ref graphics, this.m_itemsChartSerie[index2].Label, this.m_barLabelFont, this.m_barLabelColor, pointF3);
            }
            index1 = 0;
            ++index2;
            rect3.X += rect3.Width * 2f;
            x = rect3.X;
          }
          else
          {
            rect3.X += rect3.Width;
            ++index1;
          }
          num20 += 2;
        }
      }
      graphics.DrawLine(this.m_gridPen, new PointF(rect1.Right, rect1.Bottom), new PointF(rect1.Right, rect1.Top - 1f));
      Pen pen = new Pen(this.m_gridLineColor, 1f);
      graphics.DrawLine(pen, new PointF(pointF1.X, rect1.Bottom + 1f), new PointF(pt2.X, rect1.Bottom + 1f));
      graphics.DrawLine(pen, new PointF(pointF1.X, rect1.Bottom), new PointF(pt2.X, rect1.Bottom));
      graphics.DrawLine(pen, new PointF(pointF1.X, rect1.Bottom), new PointF(pointF1.X, rect1.Top));
      graphics.DrawLine(pen, new PointF(pointF1.X + 1f, rect1.Bottom), new PointF(pointF1.X + 1f, rect1.Top));
      if ((double) rectangleF1.Width > (double) this.Width)
        rectangleF1.Width = (float) num5;
      rectangleF1.Height = sizeF5.Height * (float) num8;
      rectangleF1.Y = (float) ((double) rect1.Bottom + (double) sizeF5.Height * 2.0 + 5.0);
      rectangleF1.X = (float) (10.0 + (double) num5 * 0.5 - (double) rectangleF1.Width * 0.5);
      graphics.FillRectangle((Brush) new SolidBrush(Color.Ivory), rectangleF1);
      Function.DrawRoundRect(graphics, new Pen(Color.Black, 1f), rectangleF1, 0.0f);
      int num24 = 1;
      RectangleF rectangleF4 = new RectangleF()
      {
        Width = sizeF5.Height,
        Height = sizeF5.Height
      };
      rectangleF4.Y = (float) ((double) rectangleF1.Y + (double) rectangleF4.Height * (double) num24 - (double) rectangleF4.Height * 0.5);
      rectangleF4.X = rectangleF1.X + 5f;
      for (int index7 = 0; index7 < this.m_legends.Count; ++index7)
      {
        SizeF sizeF14 = graphics.MeasureString(this.m_legends[index7], this.m_legendsLabelFont);
        if ((double) rectangleF4.X + (double) rectangleF4.Width + 3.0 + (double) sizeF14.Width + 5.0 > (double) rectangleF1.Right)
        {
          num24 += 2;
          rectangleF4.Y = (float) ((double) rectangleF1.Y + (double) rectangleF4.Height * (double) num24 - (double) rectangleF4.Height * 0.5);
          rectangleF4.X = rectangleF1.X + 5f;
        }
        if (this.m_barGradientColor)
        {
          Color baseColor3 = RGBHSL.SetBrightness(this.m_colorsLegends[index7], 0.7);
          Color baseColor4 = RGBHSL.SetBrightness(this.m_colorsLegends[index7], 0.3);
          GraphicsPath path = new GraphicsPath();
          path.AddRectangle(rectangleF4);
          PathGradientBrush pathGradientBrush = new PathGradientBrush(path);
          pathGradientBrush.CenterColor = Color.FromArgb((int) byte.MaxValue, baseColor3);
          pathGradientBrush.CenterPoint = new PointF(rectangleF4.X + rectangleF4.Width * 0.5f, 0.0f);
          Color[] colorArray = new Color[1]
          {
            Color.FromArgb((int) byte.MaxValue, baseColor4)
          };
          pathGradientBrush.SurroundColors = colorArray;
          pathGradientBrush.FocusScales = new PointF(1f / 1000f, 1f);
          graphics.FillRectangle((Brush) pathGradientBrush, rectangleF4);
        }
        else
          graphics.FillRectangle((Brush) new SolidBrush(this.m_colorsLegends[index7]), rectangleF4);
        Function.DrawRoundRect(graphics, new Pen(Color.Black, 1f), rectangleF4, 0.0f);
        Function.DrawString(ref graphics, this.m_legends[index7], this.m_legendsLabelFont, Color.Black, new PointF((float) ((double) rectangleF4.X + (double) rectangleF4.Width + 3.0), rectangleF4.Y));
        rectangleF4.X += (float) (5.0 + (double) rectangleF4.Width + 3.0) + sizeF14.Width;
      }
    }
    catch
    {
    }
  }

  protected override void OnMouseMove(MouseEventArgs e) => base.OnMouseMove(e);

  private void ControlPicture_Resize(object sender, EventArgs e)
  {
  }

  protected override void OnMouseClick(MouseEventArgs e) => base.OnMouseClick(e);

  private void ChartBar_DoubleClick(object sender, EventArgs e)
  {
    try
    {
      this.GetBitmapFromGraphic(true);
      int num = (int) MessageBox.Show("Imagem copiada para o clipboard com sucesso!\n\nObs.: para colar aperte as teclas [Ctrl + V] em algum programa que aceita colar imagem.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.toolTip1 = new ToolTip(this.components);
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Name = "ChartBar";
    this.Size = new Size(362, 236);
    this.DoubleClick += new EventHandler(this.ChartBar_DoubleClick);
    this.ResumeLayout(false);
  }

  public struct ItemsChartSerie
  {
    public string Label;
    public List<float> Value;
  }
}
