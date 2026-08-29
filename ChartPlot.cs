// Decompiled with JetBrains decompiler
// Type: LDChartControlPlus.ChartPlot
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

[ToolboxBitmap("D:\\Visual Studio 2005\\Projects\\LDChartControlPlus\\Resources\\ChartPlot.bmp")]
public class ChartPlot : UserControl
{
  private const int MARK_SIZE = 3;
  private IContainer components;
  private List<ItemsChartPlot> m_ItemsChartPlot;
  private List<Color> m_colorsBar;
  private float m_maxValue;
  private float m_totalValue;
  private List<string> m_monthDesc = new List<string>();
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
  private PlotStepXType m_plotStepXType;
  private int m_month;
  private int m_year;
  private Color m_gridLineColor;
  private Pen m_gridLinePen;
  private Color m_gridColor;
  private DashStyle m_gridDashStyle;
  private Pen m_gridPen;
  private Color m_gridBGColor;
  private bool m_showTotalValue;
  private bool m_showHighlightValue;
  private Font m_plotValueFont;
  private Color m_plotValueColor;
  private string m_legendY;
  private bool m_showLegendY;
  private Font m_legendYFont;
  private Color m_legendYColor;
  private int m_maxStepValueY;
  private int m_stepValueY;
  private Color m_stepColorValueY;
  private Font m_stepValueYFont;
  private bool m_ShowGridY;
  private string m_legendX;
  private bool m_showLegendX;
  private Font m_legendXFont;
  private Color m_legendXColor;
  private bool m_showGridX;
  private int m_maxCountCharLineLabelX;
  private DirectionLabel m_labelXDirection;
  private int m_stepValueX;
  private int m_minStepValueX;
  private int m_maxStepValueX;
  private DateTime m_startDateStepValueX;
  private DateTime m_endDateStepValueX;
  private List<ChartPlot.PlotDateValue> m_listPlotDateValue;
  private bool m_showLabelStepValueX;
  private string[] m_labelStepValueX;
  private int m_rotateLabelStepValueX;
  private Color m_stepColorValueX;
  private Font m_stepValueXFont;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Name = nameof (ChartPlot);
    this.Size = new Size(362, 236);
    this.DoubleClick += new EventHandler(this.ChartPlot_DoubleClick);
    this.ResumeLayout(false);
  }

  public ChartPlot()
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
    this.m_legendYFont = new Font("Tahoma", 14f, FontStyle.Bold);
    this.m_legendYColor = Color.Black;
    this.m_stepValueY = 10;
    this.m_maxStepValueY = 100;
    this.m_stepValueYFont = new Font("Tahoma", 8f, FontStyle.Bold);
    this.m_ShowGridY = true;
    this.m_stepColorValueY = Color.Maroon;
    this.m_legendX = "Legenda X";
    this.m_showLegendX = false;
    this.m_legendXFont = new Font("Tahoma", 14f, FontStyle.Bold);
    this.m_legendXColor = Color.SteelBlue;
    this.m_showGridX = true;
    this.m_maxCountCharLineLabelX = 20;
    this.m_stepValueX = 1;
    this.m_minStepValueX = 1;
    this.m_maxStepValueX = 30;
    this.m_listPlotDateValue = new List<ChartPlot.PlotDateValue>();
    this.m_startDateStepValueX = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy 00:00:00"));
    this.m_endDateStepValueX = DateTime.Parse(DateTime.Now.AddDays(30.0).ToString("dd/MM/yyyy 23:59:59"));
    this.m_showLabelStepValueX = false;
    this.m_rotateLabelStepValueX = 0;
    this.m_labelXDirection = DirectionLabel.Horizontal;
    this.m_stepColorValueX = Color.SteelBlue;
    this.m_stepValueXFont = new Font("Tahoma", 8f, FontStyle.Bold);
    this.m_maxValue = 0.0f;
    this.m_totalValue = 0.0f;
    this.m_ChartStyle = ChartStyle.StyleNormal;
    this.m_gridColor = Color.DarkGray;
    this.m_gridDashStyle = DashStyle.Dot;
    this.m_gridPen = new Pen(this.m_gridColor);
    this.m_gridPen.DashStyle = this.m_gridDashStyle;
    this.m_gridBGColor = Color.GhostWhite;
    this.m_gridLineColor = Color.Black;
    this.m_gridLinePen = new Pen(this.m_gridLineColor);
    this.m_BGColor1 = Color.White;
    this.m_BGColor2 = Color.White;
    this.m_BGLinearGradientMode = LinearGradientMode.Horizontal;
    this.m_BGImage = (Image) null;
    this.m_BGImageAttributes = new ImageAttributes();
    this.m_colorMatrix = 128 /*0x80*/;
    this.SetPlotStepXType(PlotStepXType.Number);
    this.m_month = 1;
    this.m_year = 2008;
    this.m_showHighlightValue = true;
    this.m_showTotalValue = false;
    this.m_plotValueFont = new Font("Tahoma", 8f, FontStyle.Bold);
    this.m_plotValueColor = Color.Navy;
    this.m_ItemsChartPlot = new List<ItemsChartPlot>();
    this.m_colorsBar = new List<Color>();
    this.m_colorsBar.Add(Color.DimGray);
    this.m_colorsBar.Add(Color.Teal);
    this.m_colorsBar.Add(Color.Maroon);
    this.m_colorsBar.Add(Color.SkyBlue);
    this.m_colorsBar.Add(Color.Red);
    this.m_colorsBar.Add(Color.SteelBlue);
    this.m_colorsBar.Add(Color.LightCoral);
    this.m_colorsBar.Add(Color.SlateGray);
    this.m_colorsBar.Add(Color.MistyRose);
    this.m_colorsBar.Add(Color.RoyalBlue);
    this.m_colorsBar.Add(Color.Chocolate);
    this.m_colorsBar.Add(Color.Tan);
    this.m_colorsBar.Add(Color.Navy);
    this.m_colorsBar.Add(Color.Orange);
    this.m_colorsBar.Add(Color.SlateBlue);
    this.m_colorsBar.Add(Color.Olive);
    this.m_colorsBar.Add(Color.Indigo);
    this.m_colorsBar.Add(Color.OliveDrab);
    this.m_colorsBar.Add(Color.Purple);
    this.m_colorsBar.Add(Color.ForestGreen);
    this.m_colorsBar.Add(Color.Crimson);
    this.m_colorsBar.Add(Color.Green);
    this.m_monthDesc.Add("JAN");
    this.m_monthDesc.Add("FEV");
    this.m_monthDesc.Add("MAR");
    this.m_monthDesc.Add("ABR");
    this.m_monthDesc.Add("MAI");
    this.m_monthDesc.Add("JUN");
    this.m_monthDesc.Add("JUL");
    this.m_monthDesc.Add("AGO");
    this.m_monthDesc.Add("SET");
    this.m_monthDesc.Add("OUT");
    this.m_monthDesc.Add("NOV");
    this.m_monthDesc.Add("DEZ");
    this.FillDateValues();
    List<ItemsChartPlot> lstItemsChartPlot = new List<ItemsChartPlot>();
    ItemsChartPlot itemsChartPlot = new ItemsChartPlot();
    itemsChartPlot.Number = 1;
    itemsChartPlot.Value = 10.1f;
    lstItemsChartPlot.Add(itemsChartPlot);
    itemsChartPlot.Number = 2;
    itemsChartPlot.Value = 15f;
    lstItemsChartPlot.Add(itemsChartPlot);
    itemsChartPlot.Number = 3;
    itemsChartPlot.Value = 60.9f;
    lstItemsChartPlot.Add(itemsChartPlot);
    itemsChartPlot.Number = 5;
    itemsChartPlot.Value = 41.2f;
    lstItemsChartPlot.Add(itemsChartPlot);
    itemsChartPlot.Number = 7;
    itemsChartPlot.Value = 8f;
    lstItemsChartPlot.Add(itemsChartPlot);
    itemsChartPlot.Number = 11;
    itemsChartPlot.Value = 88.08f;
    lstItemsChartPlot.Add(itemsChartPlot);
    itemsChartPlot.Number = 12;
    itemsChartPlot.Value = 45.4f;
    lstItemsChartPlot.Add(itemsChartPlot);
    this.AddItems(lstItemsChartPlot);
    this.Invalidate();
  }

  [Category("Grid")]
  [Description("Define a cor do grid.")]
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

  [Category("Grid")]
  [Description("Define se dever mostrar o grid do eixo X.")]
  public bool ShowGridX
  {
    get => this.m_showGridX;
    set
    {
      this.m_showGridX = value;
      this.Invalidate();
    }
  }

  [Description("Define o estilo da linha do grid.")]
  [Category("Grid")]
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

  [Description("Define a cor do grid.")]
  [Category("Grid")]
  public Color GridBGColor
  {
    get => this.m_gridBGColor;
    set
    {
      this.m_gridBGColor = value;
      this.Invalidate();
    }
  }

  [Category("Plot")]
  [Description("Se deseja destacar o valor no topo da barra ou não.")]
  public bool ShowHighlightValue
  {
    get => this.m_showHighlightValue;
    set
    {
      this.m_showHighlightValue = value;
      this.Invalidate();
    }
  }

  [Description("Se deseja visualizar o valor Total e a Média ou não.")]
  [Category("Plot")]
  public bool ShowTotalValue
  {
    get => this.m_showTotalValue;
    set
    {
      this.m_showTotalValue = value;
      this.Invalidate();
    }
  }

  [Category("Plot")]
  [Description("Fonte do Label da barra.")]
  public Font BarLabelFont
  {
    get => this.m_plotValueFont;
    set
    {
      this.m_plotValueFont = value;
      this.Invalidate();
    }
  }

  [Description("Cor da Fonte do Label da barra.")]
  [Category("Plot")]
  public Color BarLabelColor
  {
    get => this.m_plotValueColor;
    set
    {
      this.m_plotValueColor = value;
      this.Invalidate();
    }
  }

  [Category("Chart")]
  [Description("Cor de fundo 1")]
  public Color BGColor1
  {
    get => this.m_BGColor1;
    set
    {
      this.m_BGColor1 = value;
      this.Invalidate();
    }
  }

  [Description("Cor de fundo 2")]
  [Category("Chart")]
  public Color BGColor2
  {
    get => this.m_BGColor2;
    set
    {
      this.m_BGColor2 = value;
      this.Invalidate();
    }
  }

  [Category("Chart")]
  [Description("Direção da Cor de fundo gradiente.")]
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

  [Category("Chart")]
  [Description("Define se dever mostrar o título.")]
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

  [Description("Tipo do Step do Eixo X.")]
  [Category("Chart")]
  public PlotStepXType PlotStepXType
  {
    get => this.m_plotStepXType;
    set => this.SetPlotStepXType(value);
  }

  [Description("Mês.")]
  [Category("Chart")]
  public int Month
  {
    get => this.m_month;
    set
    {
      this.m_month = value;
      this.Invalidate();
    }
  }

  [Category("Chart")]
  [Description("Ano")]
  public int Year
  {
    get => this.m_year;
    set
    {
      this.m_year = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata o legenda do eixo Y.")]
  [Category("Eixo Y")]
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

  [Description("Define/resgata a fonte da legenda do eixo Y.")]
  [Category("Eixo Y")]
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

  [Category("Eixo Y")]
  [Description("Define/resgata o valor máximo do eixo Y.")]
  public int MaxValueY
  {
    get => this.m_maxStepValueY;
    set
    {
      this.m_maxStepValueY = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata o step value do eixo Y.")]
  [Category("Eixo Y")]
  public int StepValueY
  {
    get => this.m_stepValueY;
    set
    {
      this.m_stepValueY = value;
      this.Invalidate();
    }
  }

  [Category("Eixo Y")]
  [Description("Define/resgata a Cor do step value do eixo Y.")]
  public Color StepColorValueY
  {
    get => this.m_stepColorValueY;
    set
    {
      this.m_stepColorValueY = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata o legenda do eixo X.")]
  [Category("Eixo X")]
  public string LegendX
  {
    get => this.m_legendX;
    set
    {
      this.m_legendX = value;
      this.Invalidate();
    }
  }

  [Category("Eixo X")]
  [Description("Define se deve mostrar a legenda do eixo X.")]
  public bool ShowLegendX
  {
    get => this.m_showLegendX;
    set
    {
      this.m_showLegendX = value;
      this.Invalidate();
    }
  }

  [Category("Eixo X")]
  [Description("Define/resgata a fonte da legenda do eixo X.")]
  public Font LegendXFont
  {
    get => this.m_legendXFont;
    set
    {
      this.m_legendXFont = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata a Cor da legenda do eixo X.")]
  [Category("Eixo X")]
  public Color LegendXColor
  {
    get => this.m_legendXColor;
    set
    {
      this.m_legendXColor = value;
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
  [Description("Define/resgata o step value do eixo X.")]
  public int StepValueX
  {
    get => this.m_stepValueX;
    set
    {
      this.m_stepValueX = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata o valor mínimo do eixo X.")]
  [Category("Eixo X")]
  public int MinStepValueX
  {
    get => this.m_minStepValueX;
    set
    {
      this.m_minStepValueX = value;
      this.Invalidate();
    }
  }

  [Category("Eixo X")]
  [Description("Define/resgata o valor máximo do eixo X.")]
  public int MaxStepValueX
  {
    get => this.m_maxStepValueX;
    set
    {
      this.m_maxStepValueX = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata a data inicial do eixo X.")]
  [Category("Eixo X")]
  public DateTime StartDateStepValueX
  {
    get => this.m_startDateStepValueX;
    set
    {
      this.m_startDateStepValueX = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata a data final do eixo X.")]
  [Category("Eixo X")]
  public DateTime EndDateStepValueX
  {
    get => this.m_endDateStepValueX;
    set
    {
      this.m_endDateStepValueX = value;
      this.Invalidate();
    }
  }

  [Category("Eixo X")]
  [Description("Define se deve mostrar o texto em vez de números no steps do eixo X.")]
  public bool ShowLabelStepValueX
  {
    get => this.m_showLabelStepValueX;
    set
    {
      this.m_showLabelStepValueX = value;
      this.Invalidate();
    }
  }

  [Category("Eixo X")]
  [Description("Define o valor que o texto do steps do eixo X deve rotacionar.")]
  public int RotateLabelStepValueX
  {
    get => this.m_rotateLabelStepValueX;
    set
    {
      this.m_rotateLabelStepValueX = value;
      this.Invalidate();
    }
  }

  [Category("Eixo X")]
  [Description("Define o texto a visualizar no steps do eixo X.")]
  public string[] LabelStepValueX
  {
    get => this.m_labelStepValueX;
    set
    {
      this.m_labelStepValueX = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata a Cor do step value do eixo X.")]
  [Category("Eixo X")]
  public Color StepColorValueX
  {
    get => this.m_stepColorValueX;
    set
    {
      this.m_stepColorValueX = value;
      this.Invalidate();
    }
  }

  [Category("Eixo X")]
  [Description("Define/resgata a fonte do step value do eixo X.")]
  public Font StepValueXFont
  {
    get => this.m_stepValueXFont;
    set
    {
      this.m_stepValueXFont = value;
      this.Invalidate();
    }
  }

  public void AddItems(List<ItemsChartPlot> lstItemsChartPlot)
  {
    this.ClearItems();
    if (lstItemsChartPlot == null)
      return;
    this.m_ItemsChartPlot = lstItemsChartPlot;
    for (int index = this.m_ItemsChartPlot.Count - 1; index >= 0; --index)
    {
      if ((double) this.m_ItemsChartPlot[index].Value <= 0.0)
      {
        this.m_ItemsChartPlot.RemoveAt(index);
      }
      else
      {
        if ((double) this.m_ItemsChartPlot[index].Value > (double) this.m_maxValue)
          this.m_maxValue = this.m_ItemsChartPlot[index].Value;
        this.m_totalValue += this.m_ItemsChartPlot[index].Value;
      }
    }
    if (this.m_plotStepXType == PlotStepXType.DayMonth)
      this.FillDateValues();
    if ((double) this.m_maxValue >= 100.0)
    {
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
    }
    this.Invalidate();
  }

  private void FillDateValues()
  {
    try
    {
      this.m_listPlotDateValue.Clear();
      this.m_startDateStepValueX = DateTime.Parse(this.m_startDateStepValueX.ToString("dd/MM/yyyy") + " 00:00:00");
      this.m_endDateStepValueX = DateTime.Parse(this.m_endDateStepValueX.ToString("dd/MM/yyyy") + " 23:59:59");
      this.m_maxStepValueX = (int) (this.m_endDateStepValueX - this.m_startDateStepValueX).TotalDays;
      DateTime dateTime = this.m_startDateStepValueX;
      for (int index = 1; index <= this.m_maxStepValueX; ++index)
      {
        this.m_listPlotDateValue.Add(new ChartPlot.PlotDateValue()
        {
          Day = dateTime.Day,
          Month = dateTime.Month,
          Year = dateTime.Year
        });
        dateTime = dateTime.AddDays(1.0);
      }
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  public void ClearItems()
  {
    this.m_ItemsChartPlot.Clear();
    this.m_listPlotDateValue.Clear();
    this.m_totalValue = 0.0f;
    this.m_maxValue = 0.0f;
  }

  public Bitmap GetBitmapFromGraphic(bool setClipBoard)
  {
    try
    {
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
    float num3 = 20f;
    float num4 = 20f;
    RectangleF rectangleF1 = new RectangleF();
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
        sizeF3 = graphics.MeasureString(this.m_legendY, this.m_legendYFont);
      if (this.m_showLegendX)
        sizeF2 = graphics.MeasureString(this.m_legendX, this.m_legendXFont);
      SizeF sizeF4 = graphics.MeasureString("99/00", this.m_stepValueXFont);
      float num5 = this.m_rotateLabelStepValueX <= 0 ? num4 + (sizeF4.Height + 2f) : num4 + (sizeF4.Width + 2f);
      SizeF sizeF5 = graphics.MeasureString(this.m_maxStepValueY.ToString(), this.m_stepValueYFont);
      float num6 = num3 + sizeF1.Height;
      float num7 = num1 + (float) ((double) sizeF3.Height + (double) sizeF5.Width + 5.0);
      float num8 = num5 + (sizeF2.Height + 10f);
      int num9 = this.m_maxStepValueY / this.m_stepValueY;
      float num10 = ((float) this.Height - (num6 + num8)) / (float) num9;
      rectangleF1.X = num7;
      rectangleF1.Y = num6;
      rectangleF1.Width = (float) this.Width - (num7 + num2);
      rectangleF1.Height = num10 * (float) num9;
      Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
      graphics.FillRectangle((Brush) new LinearGradientBrush(rect, this.m_BGColor1, this.m_BGColor2, this.m_BGLinearGradientMode), rect);
      graphics.FillRectangle((Brush) new SolidBrush(this.m_gridBGColor), rectangleF1);
      if (this.m_showTitleTop)
      {
        PointF pointF = new PointF((float) ((double) rectangleF1.Left + (double) rectangleF1.Width * 0.5 - (double) sizeF1.Width * 0.5), 5f);
        Function.DrawString(ref graphics, this.m_titleTop, this.m_titleFontTop, this.m_titleColorTop, pointF);
      }
      if (this.m_showLegendY)
      {
        StringFormat format = new StringFormat();
        format.FormatFlags = StringFormatFlags.DirectionVertical;
        PointF point = new PointF(5f, (float) ((double) rectangleF1.Top + (double) rectangleF1.Height * 0.5 - (double) sizeF3.Width * 0.5));
        graphics.DrawString(this.m_legendY, this.m_legendYFont, (Brush) new SolidBrush(this.m_legendYColor), point, format);
      }
      if (this.m_showLegendX)
      {
        PointF pointF = new PointF((float) ((double) rectangleF1.Left + (double) rectangleF1.Width * 0.5 - (double) sizeF2.Width * 0.5), (float) this.Height - sizeF2.Height);
        Function.DrawString(ref graphics, this.m_legendX, this.m_legendXFont, this.m_legendXColor, pointF);
      }
      if (this.m_BGImage != null)
      {
        Rectangle destRect = new Rectangle();
        int num11 = (double) this.m_BGImage.Width < (double) rectangleF1.Width ? (int) (double) this.m_BGImage.Width : (int) ((double) rectangleF1.Width - 20.0);
        int num12 = (double) this.m_BGImage.Height < (double) rectangleF1.Height ? (int) (double) this.m_BGImage.Height : (int) ((double) rectangleF1.Height - 20.0);
        destRect.Width = num11;
        destRect.Height = num12;
        destRect.X = (int) ((double) rectangleF1.Left + (double) rectangleF1.Width * 0.5 - (double) (num11 / 2));
        destRect.Y = (int) ((double) rectangleF1.Top + (double) rectangleF1.Height * 0.5 - (double) (num12 / 2));
        graphics.DrawImage(this.m_BGImage, destRect, 0, 0, this.m_BGImage.Width, this.m_BGImage.Height, GraphicsUnit.Pixel, this.m_BGImageAttributes);
      }
      this.m_gridPen.DashStyle = this.m_gridDashStyle;
      PointF pointF1 = new PointF();
      PointF pt2_1 = new PointF();
      PointF pt1_1 = new PointF();
      pointF1.Y = rectangleF1.Top;
      pointF1.X = rectangleF1.Left;
      pt2_1.X = rectangleF1.Right;
      pt1_1.X = rectangleF1.Left - 5f;
      for (int index = 0; index <= num9; ++index)
      {
        pt2_1.Y = pointF1.Y;
        pt1_1.Y = pointF1.Y;
        if (this.m_ShowGridY)
          graphics.DrawLine(this.m_gridPen, pointF1, pt2_1);
        graphics.DrawLine(this.m_gridLinePen, pt1_1, pointF1);
        int num13 = this.m_maxStepValueY - index * this.m_stepValueY;
        SizeF sizeF6 = graphics.MeasureString(num13.ToString(), this.m_stepValueYFont);
        PointF pointF2 = new PointF((float) ((double) rectangleF1.Left - (double) sizeF6.Width - 5.0), pointF1.Y - sizeF6.Height * 0.5f);
        Function.DrawString(ref graphics, num13.ToString(), this.m_stepValueYFont, this.m_stepColorValueY, pointF2);
        pointF1.Y += num10;
      }
      if (this.m_plotStepXType == PlotStepXType.Number || this.m_plotStepXType == PlotStepXType.Month || this.m_plotStepXType == PlotStepXType.Hour || this.m_plotStepXType == PlotStepXType.Day)
        this.DrawStepsEixoXNumber(ref graphics, rectangleF1);
      else if (this.m_plotStepXType == PlotStepXType.DayMonth)
        this.DrawStepsEixoXDayMonth(ref graphics, rectangleF1);
      float num14 = rectangleF1.Width / (float) this.m_maxStepValueX;
      float num15 = rectangleF1.Height / (float) this.m_maxStepValueY;
      for (int index = 0; index < this.m_ItemsChartPlot.Count; ++index)
      {
        float y1 = rectangleF1.Bottom - this.m_ItemsChartPlot[index].Value * num15;
        int num16 = this.m_ItemsChartPlot[index].Number;
        if (this.m_plotStepXType == PlotStepXType.DayMonth)
          num16 = (int) (DateTime.Parse($"{this.m_ItemsChartPlot[index].Number.ToString()}/{this.m_ItemsChartPlot[index].Month.ToString()}/{this.m_ItemsChartPlot[index].Year.ToString()} 00:00:00") - this.m_startDateStepValueX).TotalDays + 1;
        PointF pt1_2 = new PointF((float) ((double) rectangleF1.Left + (double) num16 * (double) num14 - (double) num14 * 0.5), y1);
        if (index < this.m_ItemsChartPlot.Count - 1)
        {
          int num17 = this.m_ItemsChartPlot[index + 1].Number;
          if (this.m_plotStepXType == PlotStepXType.DayMonth)
            num17 = (int) (DateTime.Parse($"{this.m_ItemsChartPlot[index + 1].Number.ToString()}/{this.m_ItemsChartPlot[index + 1].Month.ToString()}/{this.m_ItemsChartPlot[index + 1].Year.ToString()} 00:00:00") - this.m_startDateStepValueX).TotalDays + 1;
          float y2 = rectangleF1.Bottom - this.m_ItemsChartPlot[index + 1].Value * num15;
          PointF pt2_2 = new PointF((float) ((double) rectangleF1.Left + (double) num17 * (double) num14 - (double) num14 * 0.5), y2);
          graphics.DrawLine(new Pen(Color.Blue), pt1_2, pt2_2);
        }
        Point point1 = new Point((int) pt1_2.X, (int) pt1_2.Y);
        Point[] points = new Point[4];
        points[0] = point1;
        points[0].Offset(0, 3);
        points[1] = point1;
        points[1].Offset(3, 0);
        points[2] = point1;
        points[2].Offset(0, -3);
        points[3] = point1;
        points[3].Offset(-3, 0);
        graphics.FillPolygon((Brush) new SolidBrush(Color.DeepSkyBlue), points);
        graphics.DrawPolygon(new Pen(Color.Navy), points);
        SizeF sizeF7 = graphics.MeasureString(this.m_ItemsChartPlot[index].Value.ToString(), this.m_plotValueFont);
        PointF point2 = new PointF(pt1_2.X - sizeF7.Width * 0.5f, pt1_2.Y - (sizeF7.Height + 3f));
        if (this.m_showHighlightValue)
        {
          RectangleF rectangleF2 = new RectangleF();
          rectangleF2.Width = sizeF7.Width + sizeF7.Width * 0.2f;
          rectangleF2.Height = sizeF7.Height - 2f;
          rectangleF2.X = point2.X - sizeF7.Width * 0.1f;
          rectangleF2.Y = point2.Y;
          graphics.FillRectangle((Brush) new SolidBrush(Color.Ivory), rectangleF2.X, rectangleF2.Y, rectangleF2.Width, rectangleF2.Height);
          graphics.DrawRectangle(new Pen(Color.Black), rectangleF2.X, rectangleF2.Y, rectangleF2.Width, rectangleF2.Height);
        }
        graphics.DrawString(this.m_ItemsChartPlot[index].Value.ToString(), this.m_plotValueFont, (Brush) new SolidBrush(this.m_plotValueColor), point2);
      }
      graphics.DrawLine(this.m_gridPen, new PointF(rectangleF1.Right, rectangleF1.Bottom), new PointF(rectangleF1.Right, rectangleF1.Top - 1f));
      Pen pen = new Pen(this.m_gridLineColor, 1f);
      graphics.DrawLine(pen, new PointF(pointF1.X, rectangleF1.Bottom + 1f), new PointF(pt2_1.X, rectangleF1.Bottom + 1f));
      graphics.DrawLine(pen, new PointF(pointF1.X, rectangleF1.Bottom), new PointF(pt2_1.X, rectangleF1.Bottom));
      graphics.DrawLine(pen, new PointF(pointF1.X, rectangleF1.Bottom), new PointF(pointF1.X, rectangleF1.Top));
      graphics.DrawLine(pen, new PointF(pointF1.X + 1f, rectangleF1.Bottom), new PointF(pointF1.X + 1f, rectangleF1.Top));
      if (!this.m_showTotalValue)
        return;
      SizeF sizeF8 = graphics.MeasureString("Total\t=  " + this.m_totalValue.ToString("n0"), this.m_stepValueYFont);
      PointF pointF3 = new PointF(num7 - 3f, (float) this.Height - sizeF8.Height * 2.3f);
      Function.DrawString(ref graphics, "Total\t=  " + this.m_totalValue.ToString("n0"), this.m_stepValueYFont, Color.CadetBlue, pointF3);
      if (this.m_ItemsChartPlot.Count <= 0)
        return;
      float num18 = this.m_totalValue / (float) this.m_ItemsChartPlot.Count;
      SizeF sizeF9 = graphics.MeasureString("Média\t=  " + num18.ToString(), this.m_stepValueYFont);
      pointF3 = new PointF(pointF3.X, pointF3.Y + sizeF9.Height * 1.1f);
      Function.DrawString(ref graphics, "Média\t=  " + num18.ToString(), this.m_stepValueYFont, Color.CadetBlue, pointF3);
    }
    catch (Exception ex)
    {
      int num19 = (int) MessageBox.Show($"Erro Message: {ex.Message}\n\n Erro StackTrace: {ex.StackTrace}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void DrawStepsEixoXNumber(ref Graphics grPaint, RectangleF recGrid)
  {
    try
    {
      this.m_gridPen.DashStyle = this.m_gridDashStyle;
      float num = recGrid.Width / (float) this.m_maxStepValueX;
      for (int day = 1; day <= this.m_maxStepValueX; ++day)
      {
        PointF pt1 = new PointF();
        PointF pt2_1 = new PointF();
        PointF pt2_2 = new PointF();
        pt1.X = (float) ((double) recGrid.Left + (double) num * (double) day - (double) num * 0.5);
        pt1.Y = recGrid.Bottom;
        pt2_1.X = pt1.X;
        pt2_1.Y = recGrid.Top;
        if (this.m_plotStepXType == PlotStepXType.Day)
        {
          try
          {
            DateTime dateTime = new DateTime(this.m_year, this.m_month, day);
            Pen pen = (Pen) this.m_gridPen.Clone();
            if (dateTime.DayOfWeek == DayOfWeek.Saturday)
            {
              pen.Color = Color.Maroon;
              pen.DashStyle = DashStyle.Dash;
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
              pen.Color = Color.Blue;
              pen.DashStyle = DashStyle.Dash;
            }
            grPaint.DrawLine(pen, pt1, pt2_1);
          }
          catch
          {
            grPaint.DrawLine(this.m_gridPen, pt1, pt2_1);
          }
        }
        else
          grPaint.DrawLine(this.m_gridPen, pt1, pt2_1);
        pt2_2.X = pt1.X;
        pt2_2.Y = recGrid.Bottom + 5f;
        grPaint.DrawLine(this.m_gridLinePen, pt1, pt2_2);
        string text = day.ToString("00");
        if (this.m_showLabelStepValueX)
          text = this.m_labelStepValueX[day - 1].ToString();
        switch (this.m_plotStepXType)
        {
          case PlotStepXType.Month:
            text = this.m_monthDesc[day - 1];
            break;
          case PlotStepXType.Hour:
            text = (day - 1).ToString();
            break;
        }
        SizeF sizeF1 = grPaint.MeasureString(text, this.m_stepValueXFont);
        PointF pointF = new PointF(pt2_2.X - sizeF1.Width * 0.5f, pt2_2.Y + 1f);
        Function.DrawString(ref grPaint, text, this.m_stepValueXFont, this.m_stepColorValueX, this.m_rotateLabelStepValueX, pointF);
        if (this.m_plotStepXType == PlotStepXType.Day)
        {
          try
          {
            SizeF sizeF2 = grPaint.MeasureString("S", this.m_stepValueXFont);
            pointF = new PointF(pt2_2.X - sizeF2.Width * 0.5f, (float) ((double) pointF.Y + (double) sizeF2.Height + 1.0));
            DateTime dateTime = new DateTime(this.m_year, this.m_month, day);
            Pen pen = (Pen) this.m_gridPen.Clone();
            if (dateTime.DayOfWeek == DayOfWeek.Saturday)
              grPaint.DrawString("S", this.m_stepValueXFont, (Brush) new SolidBrush(Color.Maroon), pointF);
            else if (dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
              grPaint.DrawString("D", this.m_stepValueXFont, (Brush) new SolidBrush(Color.Blue), pointF);
            }
            else
            {
              string s = "";
              switch (dateTime.DayOfWeek)
              {
                case DayOfWeek.Monday:
                  s = "S";
                  break;
                case DayOfWeek.Tuesday:
                  s = "T";
                  break;
                case DayOfWeek.Wednesday:
                  s = "Q";
                  break;
                case DayOfWeek.Thursday:
                  s = "Q";
                  break;
                case DayOfWeek.Friday:
                  s = "S";
                  break;
              }
              pointF.Y = recGrid.Top - (sizeF2.Height + 1f);
              grPaint.DrawString(s, this.m_stepValueXFont, (Brush) new SolidBrush(this.m_stepColorValueX), pointF);
            }
          }
          catch
          {
            grPaint.DrawLine(this.m_gridPen, pt1, pt2_1);
          }
        }
      }
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  private void DrawStepsEixoXDayMonth(ref Graphics grPaint, RectangleF recGrid)
  {
    try
    {
      this.m_gridPen.DashStyle = this.m_gridDashStyle;
      float num = recGrid.Width / (float) this.m_listPlotDateValue.Count;
      for (int index = 1; index <= this.m_listPlotDateValue.Count; ++index)
      {
        PointF pt1 = new PointF();
        PointF pt2_1 = new PointF();
        PointF pt2_2 = new PointF();
        int day = this.m_listPlotDateValue[index - 1].Day;
        int month = this.m_listPlotDateValue[index - 1].Month;
        int year = this.m_listPlotDateValue[index - 1].Year;
        pt1.X = (float) ((double) recGrid.Left + (double) num * (double) index - (double) num * 0.5);
        pt1.Y = recGrid.Bottom;
        pt2_1.X = pt1.X;
        pt2_1.Y = recGrid.Top;
        if (this.m_plotStepXType != PlotStepXType.Day)
        {
          if (this.m_plotStepXType != PlotStepXType.DayMonth)
          {
            grPaint.DrawLine(this.m_gridPen, pt1, pt2_1);
            goto label_10;
          }
        }
        try
        {
          DateTime dateTime = new DateTime(year, month, day);
          Pen pen = (Pen) this.m_gridPen.Clone();
          if (dateTime.DayOfWeek == DayOfWeek.Saturday)
          {
            pen.Color = Color.Maroon;
            pen.DashStyle = DashStyle.Dash;
          }
          else if (dateTime.DayOfWeek == DayOfWeek.Sunday)
          {
            pen.Color = Color.Blue;
            pen.DashStyle = DashStyle.Dash;
          }
          grPaint.DrawLine(pen, pt1, pt2_1);
        }
        catch
        {
          grPaint.DrawLine(this.m_gridPen, pt1, pt2_1);
        }
label_10:
        pt2_2.X = pt1.X;
        pt2_2.Y = recGrid.Bottom + 5f;
        grPaint.DrawLine(this.m_gridLinePen, pt1, pt2_2);
        string text = $"{day.ToString("00")}/{month.ToString("00")}";
        SizeF sizeF1 = grPaint.MeasureString(text, this.m_stepValueXFont);
        PointF pointF = new PointF(pt2_2.X - sizeF1.Width * 0.5f, pt2_2.Y + 1f);
        Function.DrawString(ref grPaint, text, this.m_stepValueXFont, this.m_stepColorValueX, this.m_rotateLabelStepValueX, pointF);
        try
        {
          SizeF sizeF2 = grPaint.MeasureString("S", this.m_stepValueXFont);
          pointF = new PointF(pt2_2.X - sizeF2.Width * 0.5f, (float) ((double) pointF.Y + (double) sizeF2.Height + 1.0));
          DateTime dateTime = new DateTime(year, month, day);
          Pen pen = (Pen) this.m_gridPen.Clone();
          Color color = this.m_stepColorValueX;
          string s = "";
          switch (dateTime.DayOfWeek)
          {
            case DayOfWeek.Sunday:
              s = "D";
              color = Color.Blue;
              break;
            case DayOfWeek.Monday:
              s = "S";
              break;
            case DayOfWeek.Tuesday:
              s = "T";
              break;
            case DayOfWeek.Wednesday:
              s = "Q";
              break;
            case DayOfWeek.Thursday:
              s = "Q";
              break;
            case DayOfWeek.Friday:
              s = "S";
              break;
            case DayOfWeek.Saturday:
              s = "S";
              color = Color.Maroon;
              break;
          }
          pointF.Y = recGrid.Top - (sizeF2.Height + 1f);
          grPaint.DrawString(s, this.m_stepValueXFont, (Brush) new SolidBrush(color), pointF);
        }
        catch
        {
          grPaint.DrawLine(this.m_gridPen, pt1, pt2_1);
        }
      }
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  protected override void OnMouseMove(MouseEventArgs e) => base.OnMouseMove(e);

  protected override void OnMouseClick(MouseEventArgs e) => base.OnMouseClick(e);

  private void ChartPlot_DoubleClick(object sender, EventArgs e)
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

  private void SetPlotStepXType(PlotStepXType plotStepXType)
  {
    try
    {
      this.m_plotStepXType = plotStepXType;
      switch (this.m_plotStepXType)
      {
        case PlotStepXType.Month:
          this.m_maxStepValueX = 12;
          break;
        case PlotStepXType.Hour:
          this.m_maxStepValueX = 24;
          break;
      }
    }
    catch (Exception ex)
    {
      throw ex;
    }
    finally
    {
      this.Invalidate();
    }
  }

  private struct PlotDateValue
  {
    public int Day;
    public int Month;
    public int Year;
  }
}
