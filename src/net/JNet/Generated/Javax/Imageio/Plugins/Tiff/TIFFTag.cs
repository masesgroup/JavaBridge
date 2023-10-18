/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Plugins.Tiff
{
    #region TIFFTag
    public partial class TIFFTag
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#%3Cinit%3E(java.lang.String,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public TIFFTag(string arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#%3Cinit%3E(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public TIFFTag(string arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#%3Cinit%3E(java.lang.String,int,javax.imageio.plugins.tiff.TIFFTagSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.Plugins.Tiff.TIFFTagSet"/></param>
        public TIFFTag(string arg0, int arg1, Javax.Imageio.Plugins.Tiff.TIFFTagSet arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#MAX_DATATYPE"/>
        /// </summary>
        public static int MAX_DATATYPE { get { return SGetField<int>(LocalBridgeClazz, "MAX_DATATYPE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#MIN_DATATYPE"/>
        /// </summary>
        public static int MIN_DATATYPE { get { return SGetField<int>(LocalBridgeClazz, "MIN_DATATYPE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_ASCII"/>
        /// </summary>
        public static int TIFF_ASCII { get { return SGetField<int>(LocalBridgeClazz, "TIFF_ASCII"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_BYTE"/>
        /// </summary>
        public static int TIFF_BYTE { get { return SGetField<int>(LocalBridgeClazz, "TIFF_BYTE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_DOUBLE"/>
        /// </summary>
        public static int TIFF_DOUBLE { get { return SGetField<int>(LocalBridgeClazz, "TIFF_DOUBLE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_FLOAT"/>
        /// </summary>
        public static int TIFF_FLOAT { get { return SGetField<int>(LocalBridgeClazz, "TIFF_FLOAT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_IFD_POINTER"/>
        /// </summary>
        public static int TIFF_IFD_POINTER { get { return SGetField<int>(LocalBridgeClazz, "TIFF_IFD_POINTER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_LONG"/>
        /// </summary>
        public static int TIFF_LONG { get { return SGetField<int>(LocalBridgeClazz, "TIFF_LONG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_RATIONAL"/>
        /// </summary>
        public static int TIFF_RATIONAL { get { return SGetField<int>(LocalBridgeClazz, "TIFF_RATIONAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_SBYTE"/>
        /// </summary>
        public static int TIFF_SBYTE { get { return SGetField<int>(LocalBridgeClazz, "TIFF_SBYTE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_SHORT"/>
        /// </summary>
        public static int TIFF_SHORT { get { return SGetField<int>(LocalBridgeClazz, "TIFF_SHORT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_SLONG"/>
        /// </summary>
        public static int TIFF_SLONG { get { return SGetField<int>(LocalBridgeClazz, "TIFF_SLONG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_SRATIONAL"/>
        /// </summary>
        public static int TIFF_SRATIONAL { get { return SGetField<int>(LocalBridgeClazz, "TIFF_SRATIONAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_SSHORT"/>
        /// </summary>
        public static int TIFF_SSHORT { get { return SGetField<int>(LocalBridgeClazz, "TIFF_SSHORT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_UNDEFINED"/>
        /// </summary>
        public static int TIFF_UNDEFINED { get { return SGetField<int>(LocalBridgeClazz, "TIFF_UNDEFINED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#UNKNOWN_TAG_NAME"/>
        /// </summary>
        public static string UNKNOWN_TAG_NAME { get { return SGetField<string>(LocalBridgeClazz, "UNKNOWN_TAG_NAME"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getSizeOfType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetSizeOfType(int arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "getSizeOfType", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getCount()"/> 
        /// </summary>
        public int Count
        {
            get { return IExecute<int>("getCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getDataTypes()"/> 
        /// </summary>
        public int DataTypes
        {
            get { return IExecute<int>("getDataTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getNamedValues()"/> 
        /// </summary>
        public int[] NamedValues
        {
            get { return IExecuteArray<int>("getNamedValues"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getNumber()"/> 
        /// </summary>
        public int Number
        {
            get { return IExecute<int>("getNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getTagSet()"/> 
        /// </summary>
        public Javax.Imageio.Plugins.Tiff.TIFFTagSet TagSet
        {
            get { return IExecute<Javax.Imageio.Plugins.Tiff.TIFFTagSet>("getTagSet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#hasValueNames()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasValueNames()
        {
            return IExecute<bool>("hasValueNames");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#isDataTypeOK(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDataTypeOK(int arg0)
        {
            return IExecute<bool>("isDataTypeOK", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#isIFDPointer()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsIFDPointer()
        {
            return IExecute<bool>("isIFDPointer");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getValueName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetValueName(int arg0)
        {
            return IExecute<string>("getValueName", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}