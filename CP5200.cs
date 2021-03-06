﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CPower_CSharp
{
    public class CP5200
    {
        private const string m_strPath = "CP5200.dll";

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern string CP5200_RS232_GetFileName();

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_RS232_SplitScreen(int nCardID, int nScrWidth, int nScrHeight, int nWndCnt, int[] pWndRects);
 
        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_Net_SplitScreen(int nCardID, int nScrWidth, int nScrHeight, int nWndCnt,  int[] pWndRects);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_RS232_InitEx(IntPtr fName, int nBaudrate, int dwTimeout);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_Net_Init(uint dwIP, int nIPPort, uint dwIDCode, int nTimeOut);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_RS232_Open();

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_RS232_SendText(int nCardID, int nWndNo, IntPtr pText, int crColor, int nFontSize, int nSpeed, int nEffect, int nStayTime, int nAlignment);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_Net_SendText(int nCardID, int nWndNo, IntPtr pText, int crColor, int nFontSize, int nSpeed, int nEffect, int nStayTime, int nAlignment);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_RS232_SendTagText(int nCardID, int nWndNo, IntPtr pText, int crColor, int nFontSize, int nSpeed, int nEffect, int nStayTime, int nAlignment);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_Net_SendTagText(int nCardID, int nWndNo, IntPtr pText, int crColor, int nFontSize, int nSpeed, int nEffect, int nStayTime, int nAlignment);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_RS232_SendPicture(int nCardID, int nWndNo, int nPosX, int nPosY, int nCx, int nCy, IntPtr pPictureFile, int nSpeed, int nEffect, int nStayTime, int nPictRef);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_Net_SendPicture(int nCardID, int nWndNo, int nPosX, int nPosY, int nCx, int nCy, IntPtr pPictureFile, int nSpeed, int nEffect, int nStayTime, int nPictRef);
    
        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_RS232_SendStatic(int nCardID, int nWndNo, IntPtr pText, int crColor, int nFontSize, int nAlignment, int x, int y, int cx, int cy);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_Net_SendStatic(int nCardID, int nWndNo, IntPtr pText, int crColor, int nFontSize, int nAlignment, int x, int y, int cx, int cy);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_RS232_SendClock(int nCardID, int nWinNo, int nStayTime, int nCalendar, int nFormat, int nContent, int nFont, int nRed, int nGreen, int nBlue, IntPtr pTxt);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_Net_SendClock(int nCardID, int nWinNo, int nStayTime, int nCalendar, int nFormat, int nContent, int nFont, int nRed, int nGreen, int nBlue, IntPtr pTxt);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_RS232_SetTime(byte nCardID, byte[] pInfo);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_Net_SetTime(byte nCardID, byte[] pInfo);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_RS232_PlaySelectedPrg(int nCardID, int[] pSelected, int nSelCnt, int nOption);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern int CP5200_Net_PlaySelectedPrg(int nCardID, int[] pSelected, int nSelCnt, int nOption);

        // ================================ //
        // == Adicionados posteriormente == //
        // ================================ //

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern object CP5200_Program_Create(int width, int height, byte color);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern object CP5200_Add_Text(object hObj, int nWinNo, string pText, int nFontSize, int crColor, int nEffect, int nSpeed, int nStay);

        [DllImport(m_strPath, CharSet = CharSet.Auto)]
        public static extern object CP5200_RunPRG(object hObj, string pSelected, int nSelCnt, int nOption);

    }
}
