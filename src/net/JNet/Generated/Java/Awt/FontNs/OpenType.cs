/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.FontNs
{
    #region IOpenType
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IOpenType
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#getVersion()"/> 
        /// </summary>
        int Version { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#getFontTable(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        byte[] GetFontTable(int arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#getFontTable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        byte[] GetFontTable(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#getFontTable(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        byte[] GetFontTable(Java.Lang.String arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#getFontTable(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        byte[] GetFontTable(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#getFontTableSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        int GetFontTableSize(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#getFontTableSize(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        int GetFontTableSize(Java.Lang.String arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OpenType
    public partial class OpenType : Java.Awt.FontNs.IOpenType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_ACNT"/>
        /// </summary>
        public static int TAG_ACNT { get { if (!_TAG_ACNTReady) { _TAG_ACNTContent = SGetField<int>(LocalBridgeClazz, "TAG_ACNT"); _TAG_ACNTReady = true; } return _TAG_ACNTContent; } }
        private static int _TAG_ACNTContent = default;
        private static bool _TAG_ACNTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_AVAR"/>
        /// </summary>
        public static int TAG_AVAR { get { if (!_TAG_AVARReady) { _TAG_AVARContent = SGetField<int>(LocalBridgeClazz, "TAG_AVAR"); _TAG_AVARReady = true; } return _TAG_AVARContent; } }
        private static int _TAG_AVARContent = default;
        private static bool _TAG_AVARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_BASE"/>
        /// </summary>
        public static int TAG_BASE { get { if (!_TAG_BASEReady) { _TAG_BASEContent = SGetField<int>(LocalBridgeClazz, "TAG_BASE"); _TAG_BASEReady = true; } return _TAG_BASEContent; } }
        private static int _TAG_BASEContent = default;
        private static bool _TAG_BASEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_BDAT"/>
        /// </summary>
        public static int TAG_BDAT { get { if (!_TAG_BDATReady) { _TAG_BDATContent = SGetField<int>(LocalBridgeClazz, "TAG_BDAT"); _TAG_BDATReady = true; } return _TAG_BDATContent; } }
        private static int _TAG_BDATContent = default;
        private static bool _TAG_BDATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_BLOC"/>
        /// </summary>
        public static int TAG_BLOC { get { if (!_TAG_BLOCReady) { _TAG_BLOCContent = SGetField<int>(LocalBridgeClazz, "TAG_BLOC"); _TAG_BLOCReady = true; } return _TAG_BLOCContent; } }
        private static int _TAG_BLOCContent = default;
        private static bool _TAG_BLOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_BSLN"/>
        /// </summary>
        public static int TAG_BSLN { get { if (!_TAG_BSLNReady) { _TAG_BSLNContent = SGetField<int>(LocalBridgeClazz, "TAG_BSLN"); _TAG_BSLNReady = true; } return _TAG_BSLNContent; } }
        private static int _TAG_BSLNContent = default;
        private static bool _TAG_BSLNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_CFF"/>
        /// </summary>
        public static int TAG_CFF { get { if (!_TAG_CFFReady) { _TAG_CFFContent = SGetField<int>(LocalBridgeClazz, "TAG_CFF"); _TAG_CFFReady = true; } return _TAG_CFFContent; } }
        private static int _TAG_CFFContent = default;
        private static bool _TAG_CFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_CMAP"/>
        /// </summary>
        public static int TAG_CMAP { get { if (!_TAG_CMAPReady) { _TAG_CMAPContent = SGetField<int>(LocalBridgeClazz, "TAG_CMAP"); _TAG_CMAPReady = true; } return _TAG_CMAPContent; } }
        private static int _TAG_CMAPContent = default;
        private static bool _TAG_CMAPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_CVAR"/>
        /// </summary>
        public static int TAG_CVAR { get { if (!_TAG_CVARReady) { _TAG_CVARContent = SGetField<int>(LocalBridgeClazz, "TAG_CVAR"); _TAG_CVARReady = true; } return _TAG_CVARContent; } }
        private static int _TAG_CVARContent = default;
        private static bool _TAG_CVARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_CVT"/>
        /// </summary>
        public static int TAG_CVT { get { if (!_TAG_CVTReady) { _TAG_CVTContent = SGetField<int>(LocalBridgeClazz, "TAG_CVT"); _TAG_CVTReady = true; } return _TAG_CVTContent; } }
        private static int _TAG_CVTContent = default;
        private static bool _TAG_CVTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_DSIG"/>
        /// </summary>
        public static int TAG_DSIG { get { if (!_TAG_DSIGReady) { _TAG_DSIGContent = SGetField<int>(LocalBridgeClazz, "TAG_DSIG"); _TAG_DSIGReady = true; } return _TAG_DSIGContent; } }
        private static int _TAG_DSIGContent = default;
        private static bool _TAG_DSIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_EBDT"/>
        /// </summary>
        public static int TAG_EBDT { get { if (!_TAG_EBDTReady) { _TAG_EBDTContent = SGetField<int>(LocalBridgeClazz, "TAG_EBDT"); _TAG_EBDTReady = true; } return _TAG_EBDTContent; } }
        private static int _TAG_EBDTContent = default;
        private static bool _TAG_EBDTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_EBLC"/>
        /// </summary>
        public static int TAG_EBLC { get { if (!_TAG_EBLCReady) { _TAG_EBLCContent = SGetField<int>(LocalBridgeClazz, "TAG_EBLC"); _TAG_EBLCReady = true; } return _TAG_EBLCContent; } }
        private static int _TAG_EBLCContent = default;
        private static bool _TAG_EBLCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_EBSC"/>
        /// </summary>
        public static int TAG_EBSC { get { if (!_TAG_EBSCReady) { _TAG_EBSCContent = SGetField<int>(LocalBridgeClazz, "TAG_EBSC"); _TAG_EBSCReady = true; } return _TAG_EBSCContent; } }
        private static int _TAG_EBSCContent = default;
        private static bool _TAG_EBSCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_FDSC"/>
        /// </summary>
        public static int TAG_FDSC { get { if (!_TAG_FDSCReady) { _TAG_FDSCContent = SGetField<int>(LocalBridgeClazz, "TAG_FDSC"); _TAG_FDSCReady = true; } return _TAG_FDSCContent; } }
        private static int _TAG_FDSCContent = default;
        private static bool _TAG_FDSCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_FEAT"/>
        /// </summary>
        public static int TAG_FEAT { get { if (!_TAG_FEATReady) { _TAG_FEATContent = SGetField<int>(LocalBridgeClazz, "TAG_FEAT"); _TAG_FEATReady = true; } return _TAG_FEATContent; } }
        private static int _TAG_FEATContent = default;
        private static bool _TAG_FEATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_FMTX"/>
        /// </summary>
        public static int TAG_FMTX { get { if (!_TAG_FMTXReady) { _TAG_FMTXContent = SGetField<int>(LocalBridgeClazz, "TAG_FMTX"); _TAG_FMTXReady = true; } return _TAG_FMTXContent; } }
        private static int _TAG_FMTXContent = default;
        private static bool _TAG_FMTXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_FPGM"/>
        /// </summary>
        public static int TAG_FPGM { get { if (!_TAG_FPGMReady) { _TAG_FPGMContent = SGetField<int>(LocalBridgeClazz, "TAG_FPGM"); _TAG_FPGMReady = true; } return _TAG_FPGMContent; } }
        private static int _TAG_FPGMContent = default;
        private static bool _TAG_FPGMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_FVAR"/>
        /// </summary>
        public static int TAG_FVAR { get { if (!_TAG_FVARReady) { _TAG_FVARContent = SGetField<int>(LocalBridgeClazz, "TAG_FVAR"); _TAG_FVARReady = true; } return _TAG_FVARContent; } }
        private static int _TAG_FVARContent = default;
        private static bool _TAG_FVARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_GASP"/>
        /// </summary>
        public static int TAG_GASP { get { if (!_TAG_GASPReady) { _TAG_GASPContent = SGetField<int>(LocalBridgeClazz, "TAG_GASP"); _TAG_GASPReady = true; } return _TAG_GASPContent; } }
        private static int _TAG_GASPContent = default;
        private static bool _TAG_GASPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_GDEF"/>
        /// </summary>
        public static int TAG_GDEF { get { if (!_TAG_GDEFReady) { _TAG_GDEFContent = SGetField<int>(LocalBridgeClazz, "TAG_GDEF"); _TAG_GDEFReady = true; } return _TAG_GDEFContent; } }
        private static int _TAG_GDEFContent = default;
        private static bool _TAG_GDEFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_GLYF"/>
        /// </summary>
        public static int TAG_GLYF { get { if (!_TAG_GLYFReady) { _TAG_GLYFContent = SGetField<int>(LocalBridgeClazz, "TAG_GLYF"); _TAG_GLYFReady = true; } return _TAG_GLYFContent; } }
        private static int _TAG_GLYFContent = default;
        private static bool _TAG_GLYFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_GPOS"/>
        /// </summary>
        public static int TAG_GPOS { get { if (!_TAG_GPOSReady) { _TAG_GPOSContent = SGetField<int>(LocalBridgeClazz, "TAG_GPOS"); _TAG_GPOSReady = true; } return _TAG_GPOSContent; } }
        private static int _TAG_GPOSContent = default;
        private static bool _TAG_GPOSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_GSUB"/>
        /// </summary>
        public static int TAG_GSUB { get { if (!_TAG_GSUBReady) { _TAG_GSUBContent = SGetField<int>(LocalBridgeClazz, "TAG_GSUB"); _TAG_GSUBReady = true; } return _TAG_GSUBContent; } }
        private static int _TAG_GSUBContent = default;
        private static bool _TAG_GSUBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_GVAR"/>
        /// </summary>
        public static int TAG_GVAR { get { if (!_TAG_GVARReady) { _TAG_GVARContent = SGetField<int>(LocalBridgeClazz, "TAG_GVAR"); _TAG_GVARReady = true; } return _TAG_GVARContent; } }
        private static int _TAG_GVARContent = default;
        private static bool _TAG_GVARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_HDMX"/>
        /// </summary>
        public static int TAG_HDMX { get { if (!_TAG_HDMXReady) { _TAG_HDMXContent = SGetField<int>(LocalBridgeClazz, "TAG_HDMX"); _TAG_HDMXReady = true; } return _TAG_HDMXContent; } }
        private static int _TAG_HDMXContent = default;
        private static bool _TAG_HDMXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_HEAD"/>
        /// </summary>
        public static int TAG_HEAD { get { if (!_TAG_HEADReady) { _TAG_HEADContent = SGetField<int>(LocalBridgeClazz, "TAG_HEAD"); _TAG_HEADReady = true; } return _TAG_HEADContent; } }
        private static int _TAG_HEADContent = default;
        private static bool _TAG_HEADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_HHEA"/>
        /// </summary>
        public static int TAG_HHEA { get { if (!_TAG_HHEAReady) { _TAG_HHEAContent = SGetField<int>(LocalBridgeClazz, "TAG_HHEA"); _TAG_HHEAReady = true; } return _TAG_HHEAContent; } }
        private static int _TAG_HHEAContent = default;
        private static bool _TAG_HHEAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_HMTX"/>
        /// </summary>
        public static int TAG_HMTX { get { if (!_TAG_HMTXReady) { _TAG_HMTXContent = SGetField<int>(LocalBridgeClazz, "TAG_HMTX"); _TAG_HMTXReady = true; } return _TAG_HMTXContent; } }
        private static int _TAG_HMTXContent = default;
        private static bool _TAG_HMTXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_JSTF"/>
        /// </summary>
        public static int TAG_JSTF { get { if (!_TAG_JSTFReady) { _TAG_JSTFContent = SGetField<int>(LocalBridgeClazz, "TAG_JSTF"); _TAG_JSTFReady = true; } return _TAG_JSTFContent; } }
        private static int _TAG_JSTFContent = default;
        private static bool _TAG_JSTFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_JUST"/>
        /// </summary>
        public static int TAG_JUST { get { if (!_TAG_JUSTReady) { _TAG_JUSTContent = SGetField<int>(LocalBridgeClazz, "TAG_JUST"); _TAG_JUSTReady = true; } return _TAG_JUSTContent; } }
        private static int _TAG_JUSTContent = default;
        private static bool _TAG_JUSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_KERN"/>
        /// </summary>
        public static int TAG_KERN { get { if (!_TAG_KERNReady) { _TAG_KERNContent = SGetField<int>(LocalBridgeClazz, "TAG_KERN"); _TAG_KERNReady = true; } return _TAG_KERNContent; } }
        private static int _TAG_KERNContent = default;
        private static bool _TAG_KERNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_LCAR"/>
        /// </summary>
        public static int TAG_LCAR { get { if (!_TAG_LCARReady) { _TAG_LCARContent = SGetField<int>(LocalBridgeClazz, "TAG_LCAR"); _TAG_LCARReady = true; } return _TAG_LCARContent; } }
        private static int _TAG_LCARContent = default;
        private static bool _TAG_LCARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_LOCA"/>
        /// </summary>
        public static int TAG_LOCA { get { if (!_TAG_LOCAReady) { _TAG_LOCAContent = SGetField<int>(LocalBridgeClazz, "TAG_LOCA"); _TAG_LOCAReady = true; } return _TAG_LOCAContent; } }
        private static int _TAG_LOCAContent = default;
        private static bool _TAG_LOCAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_LTSH"/>
        /// </summary>
        public static int TAG_LTSH { get { if (!_TAG_LTSHReady) { _TAG_LTSHContent = SGetField<int>(LocalBridgeClazz, "TAG_LTSH"); _TAG_LTSHReady = true; } return _TAG_LTSHContent; } }
        private static int _TAG_LTSHContent = default;
        private static bool _TAG_LTSHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_MAXP"/>
        /// </summary>
        public static int TAG_MAXP { get { if (!_TAG_MAXPReady) { _TAG_MAXPContent = SGetField<int>(LocalBridgeClazz, "TAG_MAXP"); _TAG_MAXPReady = true; } return _TAG_MAXPContent; } }
        private static int _TAG_MAXPContent = default;
        private static bool _TAG_MAXPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_MMFX"/>
        /// </summary>
        public static int TAG_MMFX { get { if (!_TAG_MMFXReady) { _TAG_MMFXContent = SGetField<int>(LocalBridgeClazz, "TAG_MMFX"); _TAG_MMFXReady = true; } return _TAG_MMFXContent; } }
        private static int _TAG_MMFXContent = default;
        private static bool _TAG_MMFXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_MMSD"/>
        /// </summary>
        public static int TAG_MMSD { get { if (!_TAG_MMSDReady) { _TAG_MMSDContent = SGetField<int>(LocalBridgeClazz, "TAG_MMSD"); _TAG_MMSDReady = true; } return _TAG_MMSDContent; } }
        private static int _TAG_MMSDContent = default;
        private static bool _TAG_MMSDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_MORT"/>
        /// </summary>
        public static int TAG_MORT { get { if (!_TAG_MORTReady) { _TAG_MORTContent = SGetField<int>(LocalBridgeClazz, "TAG_MORT"); _TAG_MORTReady = true; } return _TAG_MORTContent; } }
        private static int _TAG_MORTContent = default;
        private static bool _TAG_MORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_NAME"/>
        /// </summary>
        public static int TAG_NAME { get { if (!_TAG_NAMEReady) { _TAG_NAMEContent = SGetField<int>(LocalBridgeClazz, "TAG_NAME"); _TAG_NAMEReady = true; } return _TAG_NAMEContent; } }
        private static int _TAG_NAMEContent = default;
        private static bool _TAG_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_OPBD"/>
        /// </summary>
        public static int TAG_OPBD { get { if (!_TAG_OPBDReady) { _TAG_OPBDContent = SGetField<int>(LocalBridgeClazz, "TAG_OPBD"); _TAG_OPBDReady = true; } return _TAG_OPBDContent; } }
        private static int _TAG_OPBDContent = default;
        private static bool _TAG_OPBDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_OS2"/>
        /// </summary>
        public static int TAG_OS2 { get { if (!_TAG_OS2Ready) { _TAG_OS2Content = SGetField<int>(LocalBridgeClazz, "TAG_OS2"); _TAG_OS2Ready = true; } return _TAG_OS2Content; } }
        private static int _TAG_OS2Content = default;
        private static bool _TAG_OS2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_PCLT"/>
        /// </summary>
        public static int TAG_PCLT { get { if (!_TAG_PCLTReady) { _TAG_PCLTContent = SGetField<int>(LocalBridgeClazz, "TAG_PCLT"); _TAG_PCLTReady = true; } return _TAG_PCLTContent; } }
        private static int _TAG_PCLTContent = default;
        private static bool _TAG_PCLTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_POST"/>
        /// </summary>
        public static int TAG_POST { get { if (!_TAG_POSTReady) { _TAG_POSTContent = SGetField<int>(LocalBridgeClazz, "TAG_POST"); _TAG_POSTReady = true; } return _TAG_POSTContent; } }
        private static int _TAG_POSTContent = default;
        private static bool _TAG_POSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_PREP"/>
        /// </summary>
        public static int TAG_PREP { get { if (!_TAG_PREPReady) { _TAG_PREPContent = SGetField<int>(LocalBridgeClazz, "TAG_PREP"); _TAG_PREPReady = true; } return _TAG_PREPContent; } }
        private static int _TAG_PREPContent = default;
        private static bool _TAG_PREPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_PROP"/>
        /// </summary>
        public static int TAG_PROP { get { if (!_TAG_PROPReady) { _TAG_PROPContent = SGetField<int>(LocalBridgeClazz, "TAG_PROP"); _TAG_PROPReady = true; } return _TAG_PROPContent; } }
        private static int _TAG_PROPContent = default;
        private static bool _TAG_PROPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_TRAK"/>
        /// </summary>
        public static int TAG_TRAK { get { if (!_TAG_TRAKReady) { _TAG_TRAKContent = SGetField<int>(LocalBridgeClazz, "TAG_TRAK"); _TAG_TRAKReady = true; } return _TAG_TRAKContent; } }
        private static int _TAG_TRAKContent = default;
        private static bool _TAG_TRAKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_TYP1"/>
        /// </summary>
        public static int TAG_TYP1 { get { if (!_TAG_TYP1Ready) { _TAG_TYP1Content = SGetField<int>(LocalBridgeClazz, "TAG_TYP1"); _TAG_TYP1Ready = true; } return _TAG_TYP1Content; } }
        private static int _TAG_TYP1Content = default;
        private static bool _TAG_TYP1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_VDMX"/>
        /// </summary>
        public static int TAG_VDMX { get { if (!_TAG_VDMXReady) { _TAG_VDMXContent = SGetField<int>(LocalBridgeClazz, "TAG_VDMX"); _TAG_VDMXReady = true; } return _TAG_VDMXContent; } }
        private static int _TAG_VDMXContent = default;
        private static bool _TAG_VDMXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_VHEA"/>
        /// </summary>
        public static int TAG_VHEA { get { if (!_TAG_VHEAReady) { _TAG_VHEAContent = SGetField<int>(LocalBridgeClazz, "TAG_VHEA"); _TAG_VHEAReady = true; } return _TAG_VHEAContent; } }
        private static int _TAG_VHEAContent = default;
        private static bool _TAG_VHEAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#TAG_VMTX"/>
        /// </summary>
        public static int TAG_VMTX { get { if (!_TAG_VMTXReady) { _TAG_VMTXContent = SGetField<int>(LocalBridgeClazz, "TAG_VMTX"); _TAG_VMTXReady = true; } return _TAG_VMTXContent; } }
        private static int _TAG_VMTXContent = default;
        private static bool _TAG_VMTXReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#getVersion()"/> 
        /// </summary>
        public int Version
        {
            get { return IExecuteWithSignature<int>("getVersion", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#getFontTable(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetFontTable(int arg0, int arg1, int arg2)
        {
            return IExecuteArray<byte>("getFontTable", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#getFontTable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetFontTable(int arg0)
        {
            return IExecuteWithSignatureArray<byte>("getFontTable", "(I)[B", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#getFontTable(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetFontTable(Java.Lang.String arg0, int arg1, int arg2)
        {
            return IExecuteArray<byte>("getFontTable", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#getFontTable(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetFontTable(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<byte>("getFontTable", "(Ljava/lang/String;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#getFontTableSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetFontTableSize(int arg0)
        {
            return IExecuteWithSignature<int>("getFontTableSize", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/OpenType.html#getFontTableSize(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetFontTableSize(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getFontTableSize", "(Ljava/lang/String;)I", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}