// Decompiled with JetBrains decompiler
// Type: LDChartControlPlus.Properties.Resources
// Assembly: LDChartControlPlus, Version=1.0.3873.26967, Culture=neutral, PublicKeyToken=null
// MVID: B87EBCC8-B602-40E5-94CA-0C821CC4B7FA
// Assembly location: G:\Projetos\GITEA\LDChartControlPlus\LDChartControlPlus.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace LDChartControlPlus.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
  private static ResourceManager resourceMan;
  private static CultureInfo resourceCulture;

  internal Resources()
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static ResourceManager ResourceManager
  {
    get
    {
      if (object.ReferenceEquals((object) LDChartControlPlus.Properties.Resources.resourceMan, (object) null))
        LDChartControlPlus.Properties.Resources.resourceMan = new ResourceManager("LDChartControlPlus.Properties.Resources", typeof (LDChartControlPlus.Properties.Resources).Assembly);
      return LDChartControlPlus.Properties.Resources.resourceMan;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal static CultureInfo Culture
  {
    get => LDChartControlPlus.Properties.Resources.resourceCulture;
    set => LDChartControlPlus.Properties.Resources.resourceCulture = value;
  }

  internal static Bitmap ChartBar
  {
    get
    {
      return (Bitmap) LDChartControlPlus.Properties.Resources.ResourceManager.GetObject(nameof (ChartBar), LDChartControlPlus.Properties.Resources.resourceCulture);
    }
  }

  internal static Bitmap ChartPlot
  {
    get
    {
      return (Bitmap) LDChartControlPlus.Properties.Resources.ResourceManager.GetObject(nameof (ChartPlot), LDChartControlPlus.Properties.Resources.resourceCulture);
    }
  }

  internal static Bitmap copy
  {
    get => (Bitmap) LDChartControlPlus.Properties.Resources.ResourceManager.GetObject(nameof (copy), LDChartControlPlus.Properties.Resources.resourceCulture);
  }

  internal static Bitmap grafico_Acertividade
  {
    get
    {
      return (Bitmap) LDChartControlPlus.Properties.Resources.ResourceManager.GetObject(nameof (grafico_Acertividade), LDChartControlPlus.Properties.Resources.resourceCulture);
    }
  }
}
