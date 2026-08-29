// Decompiled with JetBrains decompiler
// Type: LDChartControlPlus.Function
// Assembly: LDChartControlPlus, Version=1.0.3873.26967, Culture=neutral, PublicKeyToken=null
// MVID: B87EBCC8-B602-40E5-94CA-0C821CC4B7FA
// Assembly location: G:\Projetos\GITEA\LDChartControlPlus\LDChartControlPlus.dll

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

#nullable disable
namespace LDChartControlPlus;

public static class Function
{
  internal static void DrawString(
    ref Graphics grPaint,
    string text,
    Font font,
    Color foreColor,
    PointF pointF)
  {
    try
    {
      Function.DrawString(ref grPaint, text, font, foreColor, 0, pointF, false);
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  internal static void DrawString(
    ref Graphics grPaint,
    string text,
    Font font,
    Color foreColor,
    int rotateTransform,
    PointF pointF)
  {
    try
    {
      Function.DrawString(ref grPaint, text, font, foreColor, rotateTransform, pointF, false);
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  internal static void DrawString(
    ref Graphics grPaint,
    string text,
    Font font,
    Color foreColor,
    PointF pointF,
    bool centerText)
  {
    try
    {
      Function.DrawString(ref grPaint, text, font, foreColor, 0, pointF, centerText);
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  internal static void DrawString(
    ref Graphics grPaint,
    string text,
    Font font,
    Color foreColor,
    int rotateTransform,
    PointF pointF,
    bool centerText)
  {
    try
    {
      SizeF sizeF = grPaint.MeasureString(text, font);
      if (rotateTransform > 0 || rotateTransform < 0)
      {
        Bitmap bitmap = new Bitmap((int) sizeF.Width + 5, (int) sizeF.Width + 5);
        Graphics graphics = Graphics.FromImage((Image) bitmap);
        graphics.TranslateTransform(sizeF.Height * 0.8f, sizeF.Width);
        graphics.RotateTransform((float) rotateTransform);
        graphics.DrawString(text, font, (Brush) new SolidBrush(foreColor), new PointF(0.0f, 0.0f), new StringFormat());
        grPaint.DrawImage((Image) bitmap, pointF);
      }
      else
      {
        if (centerText)
          pointF.X -= sizeF.Width * 0.5f;
        grPaint.DrawString(text, font, (Brush) new SolidBrush(foreColor), pointF);
      }
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  internal static void DrawRoundRect(Graphics grPaint, Pen pen, RectangleF recRound, float radius)
  {
    try
    {
      Function.DrawRoundRect(grPaint, pen, recRound, radius, new Color?());
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  internal static void DrawRoundRect(
    Graphics grPaint,
    Pen pen,
    RectangleF recRound,
    float radius,
    Color? fillColor)
  {
    try
    {
      if ((double) radius <= 0.0)
      {
        grPaint.DrawRectangle(pen, recRound.X, recRound.Y, recRound.Width, recRound.Height);
      }
      else
      {
        GraphicsPath path = new GraphicsPath();
        path.AddLine(recRound.X + radius, recRound.Y, (float) ((double) recRound.X + (double) recRound.Width - (double) radius * 2.0), recRound.Y);
        path.AddArc((float) ((double) recRound.X + (double) recRound.Width - (double) radius * 2.0), recRound.Y, radius * 2f, radius * 2f, 270f, 90f);
        path.AddLine(recRound.X + recRound.Width, recRound.Y + radius, recRound.X + recRound.Width, (float) ((double) recRound.Y + (double) recRound.Height - (double) radius * 2.0));
        path.AddArc((float) ((double) recRound.X + (double) recRound.Width - (double) radius * 2.0), (float) ((double) recRound.Y + (double) recRound.Height - (double) radius * 2.0), radius * 2f, radius * 2f, 0.0f, 90f);
        path.AddLine((float) ((double) recRound.X + (double) recRound.Width - (double) radius * 2.0), recRound.Y + recRound.Height, recRound.X + radius, recRound.Y + recRound.Height);
        path.AddArc(recRound.X, (float) ((double) recRound.Y + (double) recRound.Height - (double) radius * 2.0), radius * 2f, radius * 2f, 90f, 90f);
        path.AddLine(recRound.X, (float) ((double) recRound.Y + (double) recRound.Height - (double) radius * 2.0), recRound.X, recRound.Y + radius);
        path.AddArc(recRound.X, recRound.Y, radius * 2f, radius * 2f, 180f, 90f);
        path.CloseFigure();
        if (fillColor.HasValue)
          grPaint.FillPath((Brush) new SolidBrush(fillColor.Value), path);
        grPaint.DrawPath(pen, path);
        path.Dispose();
      }
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  internal static string GetPercentage(float value, float total, int places)
  {
    try
    {
      string empty = string.Empty;
      string str = new string('0', places);
      if ((double) value < 0.0)
        value = 0.0f;
      if ((double) total < 0.0)
        total = 0.0f;
      Decimal num;
      if ((double) value == 0.0 || (double) total == 0.0)
      {
        num = 0M;
      }
      else
      {
        num = Decimal.Divide((Decimal) value, (Decimal) total) * 100M;
        if (num > 0M && places > 0)
          str = "0." + str;
      }
      return num.ToString("#" + str);
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  internal static List<string> GetStringArray(
    ref Graphics grPaint,
    string text,
    Font font,
    float size)
  {
    List<string> stringArray = new List<string>();
    string[] strArray = text.Trim().Split(' ');
    if ((double) grPaint.MeasureString(text, font).Width > (double) size)
    {
      for (int index = 0; index < strArray.Length; ++index)
        stringArray.Add(strArray[index]);
    }
    else
      stringArray.Add(text.Trim());
    return stringArray;
  }

  internal static List<string> GetStringArray(string text, int maxCountCharLine)
  {
    List<string> stringArray = new List<string>();
    string[] strArray = text.Split(' ');
    for (int index1 = 0; index1 < strArray.Length; ++index1)
    {
      if (stringArray.Count > 0)
      {
        int index2 = stringArray.Count - 1;
        if (strArray[index1].Length + stringArray[index2].Length < maxCountCharLine)
          stringArray[index2] = $"{stringArray[index2]} {strArray[index1]}";
        else
          stringArray.Add(strArray[index1]);
      }
      else
        stringArray.Add(strArray[index1]);
    }
    return stringArray;
  }
}
